using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PDF_Extractor.Common;
using PdfiumViewer;

namespace PDF_Extractor
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string title = "PDF Extractor";
        private string pdfPath;
        private string SelectedPath;

        PDF PDF = new PDF();

        private void Source_Load(object sender, EventArgs e)
        {
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog() { Filter = "PDF (*.pdf) | *.pdf; | すべてのファイル (*.) | *.*;"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pdfPath = ofd.FileName;
                    InputBox.Text = pdfPath;
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    SelectedPath = fbd.SelectedPath;
                    OutputBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void OpenFormatForm_Click(object sender, EventArgs e)
        {
            using (var formatForm = new FormatForm())
            {
                formatForm.ShowDialog();

                switch (formatForm.SelectedIndex)
                {
                    case 0:
                        string PNG = ".png";
                        ImageFormatLabel.Text = $"*{PNG}";
                        break;
                    case 1:
                        string JPG = ".jpg";
                        ImageFormatLabel.Text = $"*{JPG}";
                        break;
                    case 2:
                        string BMP = ".bmp";
                        ImageFormatLabel.Text = $"*{BMP}";
                        break;
                    case 3:
                        string GIF = ".gif";
                        ImageFormatLabel.Text = $"*{GIF}";
                        break;
                    case 4:
                        string TIFF = ".tiff";
                        ImageFormatLabel.Text = $"*{TIFF}";
                        break;
                    case 5:
                        string WMF = ".wmf";
                        ImageFormatLabel.Text = $"*{WMF}";
                        break;
                    case 6:
                        string EMF = ".emf";
                        ImageFormatLabel.Text = $"*{EMF}";
                        break;
                }
            }
        }

        private void OpenDpiForm_Click(object sender, EventArgs e)
        {
            using(var dpiForm = new DpiForm())
            {
                dpiForm.ShowDialog();
                DPILabel.Text = dpiForm.SelectedDPI.ToString();
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            int dpi = int.Parse(DPILabel.Text);
            switch (ImageFormatLabel.Text)
            {
                case "*.png":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Png, dpi, progressBar, StatusLabel);
                    break;
                case "*.jpg":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Jpeg, dpi, progressBar, StatusLabel);
                    break;
                case "*.bmp":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Bmp, dpi, progressBar, StatusLabel);
                    break;
                case "*.gif":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Gif, dpi, progressBar, StatusLabel);
                    break;
                case "*.tiff":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Tiff, dpi, progressBar, StatusLabel);
                    break;
                case "*.wmf":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Wmf, dpi, progressBar, StatusLabel);
                    break;
                case "*.emf":
                    PDF.Export(pdfPath, SelectedPath, ImageFormat.Emf, dpi, progressBar, StatusLabel);
                    break;
            }
        }
    }
}
