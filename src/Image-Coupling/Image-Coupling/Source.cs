using System.Drawing.Imaging;
using System.Windows.Forms;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.Drawing;
using System.Linq;
using System.IO;
using System;
using SixLabors.Fonts;

//The "PDFSharpCore" package must be installed.
//dotnet add package PdfSharpCore --version 1.3.65

namespace Image_Coupling
{
    public partial class Source : Form
    {
        private Timer waitTimer;
        private string[] ImageList;
        private object file;

        public Source()
        {
            InitializeComponent();

            //Timerの初期化
            waitTimer = new Timer();
            //8秒間のインターバル
            waitTimer.Interval = 8000;
            waitTimer.Tick += waitTimer_Tick;
        }

        private void OpenFolderBrowseButton_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    //Progressbarのクリア
                    progressBar.Value = 0;

                    //ListViewのクリア
                    ImageListView.Items.Clear();
                    ImagePreviewBox.Image = null;


                    this.Text = "Image Coupling   |   " + fbd.SelectedPath;
                    try
                    {
                        string SelectedFolder = fbd.SelectedPath;

                        //画像ファイルのみ取得
                        string[] validExtensions = { ".png", ".jpg", ".jpeg", ".bmp", ".dds", ".emf", ".gif", ".svg", ".webp" };
                        //ソート
                        ImageList = Directory.GetFiles(SelectedFolder, "*.*").Where(file => validExtensions.Contains(Path.GetExtension(file).ToLower())).ToArray();
                        foreach(string file in ImageList)
                        {
                            //ファイル名の取得
                            string FileName = Path.GetFileName(file);

                            //ファイルパスの取得
                            string FilePath = file;

                            //ファイルサイズの取得
                            long filebyte = new FileInfo(file).Length;
                            //KB単位で表示
                            string FileSize = (filebyte / 1024) + " KB";


                            //ListViewに追加
                            ListViewItem item = new ListViewItem(FileName);
                            item.SubItems.Add(FilePath);
                            item.SubItems.Add(FileSize);
                            ImageListView.Items.Add(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void ImageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ImageListView.SelectedItems.Count > 0)
            {
                //選択中のアイテムを取得
                ListViewItem selectedItem = ImageListView.SelectedItems[0];
                string filePath = selectedItem.SubItems[1].Text;

                try
                {
                    //選択中の画像のプレビュー
                    ImagePreviewBox.Image = Image.FromFile(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ConvertAsButton_Click(object sender, EventArgs e)
        {
            if (ImageListView.Items.Count == 0)
            {
                MessageBox.Show("結合する画像が見つかりません。", "Image Coupling", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // SaveFileDialogよりPDFの保存先を指定
            using (var sfd = new SaveFileDialog() { Filter = "PDFファイル (*.pdf) | *.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Progressbarの初期化
                    progressBar.Maximum = ImageListView.Items.Count;
                    progressBar.Step = 1;

                    //操作不可
                    ConvertAsButton.Enabled = false;
                    TruePageCheckBox.Enabled = false;

                    try
                    {
                        // PDFの作成開始
                        using (var document = new PdfDocument())
                        {
                            int total_images = ImageListView.Items.Count;
                            int processed_images = 0;

                            foreach (ListViewItem item in ImageListView.Items)
                            {
                                string filePath = item.SubItems[1].Text;

                                // 進捗をLoggerLabelに表示
                                processed_images++;
                                progressBar.PerformStep();
                                LoggerLabel.Text = processed_images + "/" + total_images + " ｜ " + "画像を処理中..." + Path.GetFileName(filePath);
                                
                                // UIを更新
                                Application.DoEvents(); 

                                // 画像の読み込み
                                using (XImage image = XImage.FromFile(filePath))
                                {
                                    LoggerLabel.Text = processed_images + "/" + total_images + " ｜ " + "新規ページを作成中... " + Path.GetFileName(filePath);
                                    Application.DoEvents();

                                    // 新規ページの追加
                                    PdfPage page = document.AddPage();

                                    LoggerLabel.Text = processed_images + "/" + total_images + " ｜ " + "画像を描画中... " + Path.GetFileName(filePath);
                                    Application.DoEvents();

                                    // 画像サイズを指定
                                    page.Width = image.PointWidth;
                                    page.Height = image.PointHeight;

                                    // 画像の描画
                                    using (XGraphics xg = XGraphics.FromPdfPage(page))
                                    {
                                        xg.DrawImage(image, 0, 0);

                                        if (TruePageCheckBox.Checked)
                                        {
                                            LoggerLabel.Text = processed_images + "/" + total_images + " ｜ " + "ページ数を描画中... " + Path.GetFileName(filePath);
                                            Application.DoEvents();

                                            //ページ数の描画
                                            string pageNumber = processed_images.ToString();
                                            XFont font = new XFont("Arial", 20, XFontStyle.Bold);
                                            XBrush brushBlack = XBrushes.Black;
                                            XBrush brushWhite = XBrushes.White;

                                            // 黒い縁取り（少し大きめ）
                                            xg.DrawString(pageNumber, font, brushBlack, new XPoint(9, 29));
                                            xg.DrawString(pageNumber, font, brushBlack, new XPoint(11, 29));
                                            xg.DrawString(pageNumber, font, brushBlack, new XPoint(9, 31));
                                            xg.DrawString(pageNumber, font, brushBlack, new XPoint(11, 31));

                                            // 白い文字（少し小さめ）
                                            xg.DrawString(pageNumber, font, brushWhite, new XPoint(10, 30));
                                        }
                                    }
                                }
                            }

                            LoggerLabel.Text = "PDFの保存中...";
                            Application.DoEvents();

                            // PDFの保存
                            document.Save(sfd.FileName);
                            progressBar.Value = 0;
                            progressBar.Value = progressBar.Maximum;

                            LoggerLabel.Text = "PDFの作成が完了しました。";

                            //操作可能
                            ConvertAsButton.Enabled = true;
                            TruePageCheckBox.Enabled = true;

                            //Timerを開始
                            waitTimer.Start();
                        }
                    }
                    catch (Exception ex)
                    {
                        LoggerLabel.Text = "例外エラーの発生 | Image cannot be loaded, Available decoders.";

                        //Timerを開始
                        waitTimer.Start();

                        MessageBox.Show(ex.Message, "Image Coupling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ConvertImageButton_Click(object sender, EventArgs e)
        {
            if(ImagePreviewBox.Image != null)
            {
                using (var sfd = new SaveFileDialog() { Filter = "BitMap形式(*.bmp) | *.bmp; | PNG形式(*.png) | *.png; | JPEG形式(*.jpg *.jpeg) | *.jpg; *.jpeg; | Windowsメタ形式(*.wmf) | *.wmf;" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string FileName = sfd.FileName;

                            switch (Path.GetExtension(FileName).ToLower())
                            {
                                case ".bmp":
                                    ImagePreviewBox.Image.Save(FileName, ImageFormat.Bmp);
                                    break;

                                case ".png":
                                    ImagePreviewBox.Image.Save(FileName, ImageFormat.Png);
                                    break;

                                case ".jpg":
                                case ".jpeg":
                                    ImagePreviewBox.Image.Save(FileName, ImageFormat.Jpeg);
                                    break;
                                case ".wmf":
                                    ImagePreviewBox.Image.Save(FileName, ImageFormat.Wmf);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("変換する画像が見つかりません。", "Image Coupling", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            LoggerLabel.Text = "待機中";
            this.progressBar.Value = 0;

        }

        private void IsTopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsTopMostCheckBox.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void OpenHelpButton_Click(object sender, EventArgs e)
        {
            //Translation English.
            //You can create a PDF document from multiple images. Simply select the directory with the image files from File (F) and click Output PDF.
            MessageBox.Show("複数枚の画像からPDFドキュメントを作成することが出来ます。\nファイル(F)から画像ファイルのあるディレクトリを選択し、\nPDFの出力をクリックするだけです。","Image Coupling",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ReStartButton_Click(object sender, EventArgs e)
        {
            //アプリの再起動
            Application.Restart();
        }
    }
}
