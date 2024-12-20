namespace PDF_Extractor.Common
{
    partial class DpiForm
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
            this.SelectDPIButton = new System.Windows.Forms.Button();
            this.DPInumBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DPInumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDPIButton
            // 
            this.SelectDPIButton.Location = new System.Drawing.Point(173, 34);
            this.SelectDPIButton.Name = "SelectDPIButton";
            this.SelectDPIButton.Size = new System.Drawing.Size(100, 26);
            this.SelectDPIButton.TabIndex = 3;
            this.SelectDPIButton.Text = "保存（&S）";
            this.SelectDPIButton.UseVisualStyleBackColor = true;
            this.SelectDPIButton.Click += new System.EventHandler(this.SelectDPIButton_Click);
            // 
            // DPInumBox
            // 
            this.DPInumBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DPInumBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DPInumBox.Location = new System.Drawing.Point(36, 38);
            this.DPInumBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DPInumBox.Name = "DPInumBox";
            this.DPInumBox.Size = new System.Drawing.Size(120, 20);
            this.DPInumBox.TabIndex = 5;
            this.DPInumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DPInumBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // DpiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 91);
            this.ControlBox = false;
            this.Controls.Add(this.DPInumBox);
            this.Controls.Add(this.SelectDPIButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DpiForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPI（解像度）の設定";
            ((System.ComponentModel.ISupportInitialize)(this.DPInumBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectDPIButton;
        private System.Windows.Forms.NumericUpDown DPInumBox;
    }
}