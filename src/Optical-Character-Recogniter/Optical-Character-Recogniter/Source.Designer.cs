namespace Optical_Character_Recogniter
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.DecAreaButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ImageHeightLabel = new System.Windows.Forms.Label();
            this.ImageWidthLabel = new System.Windows.Forms.Label();
            this.ImageSizeLabel = new System.Windows.Forms.Label();
            this.ImageNameLabel = new System.Windows.Forms.Label();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.LoadImageBox = new System.Windows.Forms.PictureBox();
            this.OCRpictureBox = new System.Windows.Forms.PictureBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AppendTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OCRpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.DecAreaButton);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.ImageHeightLabel);
            this.panel1.Controls.Add(this.ImageWidthLabel);
            this.panel1.Controls.Add(this.ImageSizeLabel);
            this.panel1.Controls.Add(this.ImageNameLabel);
            this.panel1.Controls.Add(this.LoadImageButton);
            this.panel1.Controls.Add(this.LoadImageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 455);
            this.panel1.TabIndex = 0;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(13, 327);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(125, 24);
            this.ExecuteButton.TabIndex = 8;
            this.ExecuteButton.Text = "3　OCRの実行";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click_1);
            // 
            // DecAreaButton
            // 
            this.DecAreaButton.Location = new System.Drawing.Point(13, 304);
            this.DecAreaButton.Name = "DecAreaButton";
            this.DecAreaButton.Size = new System.Drawing.Size(125, 24);
            this.DecAreaButton.TabIndex = 7;
            this.DecAreaButton.Text = "2　領域の指定";
            this.DecAreaButton.UseVisualStyleBackColor = true;
            this.DecAreaButton.Click += new System.EventHandler(this.DecAreaButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(13, 121);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(125, 24);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "画像の削除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ImageHeightLabel
            // 
            this.ImageHeightLabel.AutoSize = true;
            this.ImageHeightLabel.Location = new System.Drawing.Point(37, 263);
            this.ImageHeightLabel.Name = "ImageHeightLabel";
            this.ImageHeightLabel.Size = new System.Drawing.Size(57, 12);
            this.ImageHeightLabel.TabIndex = 5;
            this.ImageHeightLabel.Text = "高さ： 0 px";
            // 
            // ImageWidthLabel
            // 
            this.ImageWidthLabel.AutoSize = true;
            this.ImageWidthLabel.Location = new System.Drawing.Point(45, 230);
            this.ImageWidthLabel.Name = "ImageWidthLabel";
            this.ImageWidthLabel.Size = new System.Drawing.Size(49, 12);
            this.ImageWidthLabel.TabIndex = 4;
            this.ImageWidthLabel.Text = "幅： 0 px";
            // 
            // ImageSizeLabel
            // 
            this.ImageSizeLabel.AutoSize = true;
            this.ImageSizeLabel.Location = new System.Drawing.Point(28, 199);
            this.ImageSizeLabel.Name = "ImageSizeLabel";
            this.ImageSizeLabel.Size = new System.Drawing.Size(81, 12);
            this.ImageSizeLabel.TabIndex = 3;
            this.ImageSizeLabel.Text = "サイズ： 000 KB";
            // 
            // ImageNameLabel
            // 
            this.ImageNameLabel.AutoSize = true;
            this.ImageNameLabel.Location = new System.Drawing.Point(11, 169);
            this.ImageNameLabel.Name = "ImageNameLabel";
            this.ImageNameLabel.Size = new System.Drawing.Size(106, 12);
            this.ImageNameLabel.TabIndex = 2;
            this.ImageNameLabel.Text = "ファイル名： unnamed";
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(13, 98);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(125, 24);
            this.LoadImageButton.TabIndex = 1;
            this.LoadImageButton.Text = "1　画像の読み込み";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // LoadImageBox
            // 
            this.LoadImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadImageBox.Location = new System.Drawing.Point(13, 11);
            this.LoadImageBox.Name = "LoadImageBox";
            this.LoadImageBox.Size = new System.Drawing.Size(125, 80);
            this.LoadImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadImageBox.TabIndex = 0;
            this.LoadImageBox.TabStop = false;
            // 
            // OCRpictureBox
            // 
            this.OCRpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OCRpictureBox.Location = new System.Drawing.Point(171, 12);
            this.OCRpictureBox.Name = "OCRpictureBox";
            this.OCRpictureBox.Size = new System.Drawing.Size(471, 296);
            this.OCRpictureBox.TabIndex = 7;
            this.OCRpictureBox.TabStop = false;
            this.OCRpictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OCRpictureBox_Paint);
            this.OCRpictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OCRpictureBox_MouseDown);
            this.OCRpictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OCRpictureBox_MouseMove);
            this.OCRpictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OCRpictureBox_MouseUp);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultTextBox.Location = new System.Drawing.Point(171, 347);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(471, 93);
            this.ResultTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(169, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "＜ 検出した文字列 ＞";
            // 
            // AppendTimer
            // 
            this.AppendTimer.Tick += new System.EventHandler(this.AppendTimer_Tick);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.OCRpictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optical Character Recogniter   |   Sakamochanq";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OCRpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.PictureBox LoadImageBox;
        private System.Windows.Forms.Label ImageHeightLabel;
        private System.Windows.Forms.Label ImageWidthLabel;
        private System.Windows.Forms.Label ImageSizeLabel;
        private System.Windows.Forms.Label ImageNameLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.PictureBox OCRpictureBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DecAreaButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Timer AppendTimer;
    }
}

