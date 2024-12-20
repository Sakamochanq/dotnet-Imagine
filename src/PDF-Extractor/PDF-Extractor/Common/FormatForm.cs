using System.Windows.Forms;

namespace PDF_Extractor.Common
{
    public partial class FormatForm : Form
    {
        public FormatForm()
        {
            InitializeComponent();
        }

        private void FormatForm_Load(object sender, System.EventArgs e)
        {
            FormatList.Items.Add(".png");
            FormatList.Items.Add(".jpg");
            FormatList.Items.Add(".bmp");
            FormatList.Items.Add(".gif");
            FormatList.Items.Add(".tiff");
            FormatList.Items.Add(".wmf");
            FormatList.Items.Add(".emf");
            this.FormatList.SelectedIndex = 0;
        }

        public int SelectedIndex { get; private set; } = 0;

        private void SelectFormatButton_Click(object sender, System.EventArgs e)
        {
            SelectedIndex = FormatList.SelectedIndex;
            this.Close();
        }
    }
}
