using PdfiumViewer;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PDF_Extractor
{
    internal class PDF
    {
        private Bitmap Render(PdfDocument document, int page, int dpi)
        {
            return (Bitmap)document.Render(page, dpi, dpi, PdfRenderFlags.Annotations);
        }

        public void Export(string pdfPath, string selectedPath, ImageFormat imageFormat, int dpi, ProgressBar progressbar, ToolStripLabel label)
        {
            progressbar.Value = 0;
            try
            {
                using (var document = PdfDocument.Load(pdfPath))
                {
                    int pageCount = document.PageCount;
                    progressbar.Maximum = pageCount;

                    for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
                    {
                        Bitmap pageImage = Render(document, pageIndex, dpi);
                        string fileName = Path.Combine(selectedPath, pageIndex + 1 + "." + imageFormat.ToString().ToLower());
                        pageImage.Save(fileName, imageFormat);
                        pageImage.Dispose();

                        progressbar.Value = pageIndex + 1;
                        label.Text = $"Page {pageIndex + 1} / {pageCount}";
                        Application.DoEvents();
                    }
                }
                MessageBox.Show("すべての画像抽出が完了しました。", "PDF Extractor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PDF Extractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
