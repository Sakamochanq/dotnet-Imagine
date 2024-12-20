using System;
using System.Windows.Forms;

namespace PDF_Extractor.Common
{
    public partial class DpiForm : Form
    {
        public DpiForm()
        {
            InitializeComponent();
        }

        public int SelectedDPI { get; private set; } = 0;

        private void SelectDPIButton_Click(object sender, EventArgs e)
        {
            SelectedDPI = (int)DPInumBox.Value;
            this.Close();
        }
    }
}
