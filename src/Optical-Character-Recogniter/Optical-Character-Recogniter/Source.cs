using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;
using System.Drawing.Imaging;
using Tesseract;

namespace Optical_Character_Recogniter
{
    public partial class Source : Form
    {
        private Area selectedArea;
        private bool isSelecting;
        private Rectangle selectedRectangle;

        private string loadImage;
        private string imageName;
        private double imageSize;
        private int imageWidth;
        private int imageHeight;

        private string ocrResult;
        private int currentCharIndex;

        private string title = "Optical Character Recogniter";

        public Source()
        {
            InitializeComponent();
            RemoveButton.Enabled = false;
            LoadImageButton.Enabled = true;
            DecAreaButton.Enabled = false;
            ExecuteButton.Enabled = false;

            selectedArea = new Area();

            // 実行タイマー
            AppendTimer.Interval = 100;
            AppendTimer.Tick += AppendTimer_Tick;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            // 画像の読み込み
            using (var ofd = new OpenFileDialog() { Filter = "Windows画像形式 (*.png; *.jpg; *.jpeg; *.bmp;) | *.png; *.jpg; *.jpeg; *.bmp;" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    RemoveButton.Enabled = true;
                    LoadImageButton.Enabled = false;
                    DecAreaButton.Enabled = true;
                    ExecuteButton.Enabled = true;

                    loadImage = ofd.FileName;
                    LoadImageBox.ImageLocation = loadImage;

                    // 画像をリサイズしてOCRpictureBoxに表示
                    Image originalImage = Image.FromFile(loadImage);
                    Image resizedImage = ResizeImage(originalImage, OCRpictureBox.Width - 20, OCRpictureBox.Height - 20); // 20pxのマージンを追加
                    OCRpictureBox.Image = resizedImage;

                    // 画像の情報取得
                    var fileInfo = new FileInfo(loadImage);

                    imageName = fileInfo.Name;
                    imageSize = fileInfo.Length / 1024;

                    imageWidth = resizedImage.Width;
                    imageHeight = resizedImage.Height;

                    // 画像の情報の描画
                    ImageNameLabel.Text = "ファイル名： " + imageName;
                    ImageSizeLabel.Text = "サイズ： " + imageSize.ToString() + " KB";
                    ImageWidthLabel.Text = "幅：" + imageWidth.ToString() + " px";
                    ImageHeightLabel.Text = "高さ： " + imageHeight.ToString() + " px";
                }
            }
        }

        // 画像を指定されたサイズにリサイズするメソッド
        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int width = image.Width;
            int height = image.Height;

            // アスペクト比を保持してリサイズ
            if (width > maxWidth || height > maxHeight)
            {
                float aspectRatio = (float)width / height;
                if (width > height)
                {
                    width = maxWidth;
                    height = (int)(maxWidth / aspectRatio);
                }
                else
                {
                    height = maxHeight;
                    width = (int)(maxHeight * aspectRatio);
                }
            }

            // 新しいサイズで画像をリサイズ
            Bitmap resizedBitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedBitmap;
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            LoadImageBox.Image = null;
            OCRpictureBox.Image = null;
            ResultTextBox.Text = null;

            RemoveButton.Enabled = false;
            LoadImageButton.Enabled = true;
            DecAreaButton.Enabled = false;
            ExecuteButton.Enabled = false;

            // 画像情報の更新
            ImageNameLabel.Text = "ファイル名： unnamed";
            ImageSizeLabel.Text = "サイズ： 000 KB";
            ImageWidthLabel.Text = "幅： 0 px";
            ImageHeightLabel.Text = "高さ： 0 px";
        }

        private void DecAreaButton_Click(object sender, EventArgs e)
        {
            if (selectedArea != null)
            {
                isSelecting = true;
                Cursor = Cursors.Cross;
            }
            else
            {
                MessageBox.Show("選択領域を初期化してください。", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OCRpictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isSelecting && selectedArea != null)
            {
                // 範囲選択の開始
                selectedArea.StartSelection(e.Location);
            }
        }

        private void OCRpictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting && selectedArea != null)
            {
                // 描画の更新
                selectedArea.UpdateSelection(e.Location);
                OCRpictureBox.Invalidate();
            }
        }

        private void OCRpictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting && selectedArea != null)
            {
                // 選択範囲の確定
                selectedRectangle = selectedArea.EndSelection();
                // 範囲選択モードの終了
                isSelecting = false;
                Cursor = Cursors.Default;
                // 再描画
                OCRpictureBox.Invalidate();
            }
        }

        private void OCRpictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (selectedArea != null)
            {
                // 選択範囲の描画
                selectedArea.DrawSelection(e.Graphics);
            }
        }

        // OCR
        void ExecuteOCR(Rectangle rect)
        {
            if (OCRpictureBox.Image != null)
            {
                using (Bitmap bmp = new Bitmap(OCRpictureBox.Image))
                {
                    using (Bitmap selectedBmp = bmp.Clone(rect, bmp.PixelFormat))
                    {
                        string tessdataPath = "./tessdata";
                        using (var engine = new TesseractEngine(tessdataPath, "jpn+eng", EngineMode.Default)) // 日本語と英語
                        {
                            using (var page = engine.Process(selectedBmp))
                            {
                                ocrResult = page.GetText();
                                currentCharIndex = 0;

                                ResultTextBox.Clear();
                                AppendTimer.Start();
                            }
                        }
                    }
                }
            }
        }

        private void AppendTimer_Tick(object sender, EventArgs e)
        {
            if (currentCharIndex < ocrResult.Length)
            {
                ResultTextBox.AppendText(ocrResult[currentCharIndex].ToString());
                currentCharIndex++;
            }
            else
            {
                AppendTimer.Stop();
            }
        }

        private void ExecuteButton_Click_1(object sender, EventArgs e)
        {
            if (selectedRectangle == Rectangle.Empty)
            {
                MessageBox.Show("OCRを実行する範囲を指定してください。", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                try
                {
                    ExecuteOCR(selectedRectangle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}