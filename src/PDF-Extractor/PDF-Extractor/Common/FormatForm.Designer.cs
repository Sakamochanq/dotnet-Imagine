namespace PDF_Extractor.Common
{
    partial class FormatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormatList = new System.Windows.Forms.ComboBox();
            this.SelectFormatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormatList
            // 
            this.FormatList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatList.FormattingEnabled = true;
            this.FormatList.Location = new System.Drawing.Point(28, 29);
            this.FormatList.Name = "FormatList";
            this.FormatList.Size = new System.Drawing.Size(165, 20);
            this.FormatList.TabIndex = 0;
            // 
            // SelectFormatButton
            // 
            this.SelectFormatButton.Location = new System.Drawing.Point(209, 26);
            this.SelectFormatButton.Name = "SelectFormatButton";
            this.SelectFormatButton.Size = new System.Drawing.Size(100, 26);
            this.SelectFormatButton.TabIndex = 1;
            this.SelectFormatButton.Text = "保存（&S）";
            this.SelectFormatButton.UseVisualStyleBackColor = true;
            this.SelectFormatButton.Click += new System.EventHandler(this.SelectFormatButton_Click);
            // 
            // FormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 78);
            this.ControlBox = false;
            this.Controls.Add(this.SelectFormatButton);
            this.Controls.Add(this.FormatList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出力する画像フォーマットの選択";
            this.Load += new System.EventHandler(this.FormatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FormatList;
        private System.Windows.Forms.Button SelectFormatButton;
    }
}