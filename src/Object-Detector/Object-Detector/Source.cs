using Size = OpenCvSharp.Size;
using OpenCvSharp.Extensions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using OpenCvSharp;
using System;

namespace Object_Detector
{
    public partial class Source : Form
    {
        string title = "Object Detector";
        private VideoCapture capture;
        private Timer timer;

        //フレーム保持
        private Mat previousFrame;

        //FPSの計測
        private Stopwatch fpswatch = new Stopwatch();
        private int frameCount = 0;
        double fps = 0;

        //API
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Source()
        {
            InitializeComponent();
            AllocConsole();

            //FPSnumBox.Enabled = false;
            ObjectRemoveButton.Enabled = false;
        }

        private void Motion_Tracking(Mat current_frame)
        {
            // 動きを検知する閾値
            const double motionThreshold = 3000;  // 以前より高めに設定

            // 検出する輪郭の最小面積
            const int minArea = 1500;

            if (previousFrame != null)
            {
                var gray_current_frame = new Mat();
                var gray_previous_frame = new Mat();

                // グレースケールに変換
                Cv2.CvtColor(current_frame, gray_current_frame, ColorConversionCodes.BGR2GRAY);
                Cv2.CvtColor(previousFrame, gray_previous_frame, ColorConversionCodes.BGR2GRAY);

                // フレーム間の差分
                var dif = new Mat();
                Cv2.Absdiff(gray_previous_frame, gray_current_frame, dif);

                // 差分画像の平滑化（ブラー処理）
                Cv2.GaussianBlur(dif, dif, new Size(5, 5), 0);

                // 差分画像の二値化
                var threshold = new Mat();
                Cv2.Threshold(dif, threshold, 30, 255, ThresholdTypes.Binary);

                // モルフォロジー処理でノイズ除去
                var kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new Size(5, 5));
                Cv2.Dilate(threshold, threshold, kernel);

                // 輪郭の検出
                Cv2.FindContours(threshold, out var contours, out var _, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

                foreach (var contour in contours)
                {
                    var area = Cv2.ContourArea(contour);

                    // 閾値以上の面積を持つ輪郭のみ
                    if (area > minArea)
                    {
                        // 枠線のトラッキングと描画
                        var boundingRect = Cv2.BoundingRect(contour);

                        if (area > motionThreshold)
                        {
                            Cv2.Rectangle(current_frame, boundingRect, Scalar.LimeGreen, 2);

                            // "Detected"の文字のトラッキングと描画
                            var textPos = new OpenCvSharp.Point(boundingRect.Left, boundingRect.Top - 10);
                            Cv2.PutText(current_frame, "Detected", textPos, HersheyFonts.Italic, 1, Scalar.LimeGreen, 2);

                            //コンソールに出力
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Motion Detected");
                        }
                    }
                }

                // フレームを更新
                previousFrame?.Dispose();
                previousFrame = current_frame.Clone();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            using (var current_frame = new Mat())
            {
                //フレームの読み込み
                capture.Read(current_frame);

                //空の場合は処理中断
                if (current_frame.Empty())
                {
                    return;
                }
                else if (previousFrame == null)
                {
                    previousFrame = current_frame.Clone();
                }

                //フレーム数のカウント
                frameCount++;

                //FPS計測
                if (fpswatch.IsRunning)
                {
                    double elapsedSeconds = fpswatch.Elapsed.TotalSeconds;
                    if (elapsedSeconds >= 1.0)
                    {
                        fps = frameCount / elapsedSeconds;
                        fpswatch.Restart();
                        frameCount = 0;
                    }
                }
                else
                {
                    fpswatch.Start();
                }
                //FPSを画面上に描画
                Cv2.PutText(current_frame, $"FPS: {fps:F1}", new OpenCvSharp.Point(10, 30), HersheyFonts.Italic, 1, Scalar.Lime, 2);

                //コンソールに出力
                Console.WriteLine("\n");

                Motion_Tracking(current_frame);

                Bitmap bitmap = BitmapConverter.ToBitmap(current_frame);

                //画像クリア
                ObjectWindow.Image?.Dispose();
                ObjectWindow.Image = bitmap;

            }
        }

        private void LoadObjectButton_Click(object sender, System.EventArgs e)
        {
            ObjectRemoveButton.Enabled = true;
            LoadObjectButton.Enabled = false;

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tracking Start");
                //デフォルトカメラを使用
                capture = new VideoCapture(0);
                capture.Open(0);
                if (!capture.IsOpened())
                {
                    MessageBox.Show("使用可能なカメラが見つかりません。", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                //timerの初期化
                timer = new Timer();
                timer.Interval = 30;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObjectRemoveButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            fpswatch.Stop();
            fpswatch.Reset();
            
            Console.Clear();

            //コンソールに出力
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Remove");

            //画像のクリア
            ObjectWindow.Image = null;

            //キャプチャのクリア
            capture.Release();
            capture.Dispose();

            ObjectRemoveButton.Enabled = false;
            LoadObjectButton.Enabled = true;
        }
    }
}