namespace Object_Detector
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
            this.ObjectWindow = new System.Windows.Forms.PictureBox();
            this.LoadObjectButton = new System.Windows.Forms.Button();
            this.ObjectRemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectWindow
            // 
            this.ObjectWindow.BackColor = System.Drawing.SystemColors.ControlText;
            this.ObjectWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ObjectWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectWindow.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ObjectWindow.Location = new System.Drawing.Point(3, 4);
            this.ObjectWindow.Name = "ObjectWindow";
            this.ObjectWindow.Size = new System.Drawing.Size(622, 440);
            this.ObjectWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObjectWindow.TabIndex = 0;
            this.ObjectWindow.TabStop = false;
            // 
            // LoadObjectButton
            // 
            this.LoadObjectButton.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoadObjectButton.Location = new System.Drawing.Point(7, 450);
            this.LoadObjectButton.Name = "LoadObjectButton";
            this.LoadObjectButton.Size = new System.Drawing.Size(117, 29);
            this.LoadObjectButton.TabIndex = 1;
            this.LoadObjectButton.Text = "起動";
            this.LoadObjectButton.UseVisualStyleBackColor = true;
            this.LoadObjectButton.Click += new System.EventHandler(this.LoadObjectButton_Click);
            // 
            // ObjectRemoveButton
            // 
            this.ObjectRemoveButton.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.ObjectRemoveButton.Location = new System.Drawing.Point(130, 450);
            this.ObjectRemoveButton.Name = "ObjectRemoveButton";
            this.ObjectRemoveButton.Size = new System.Drawing.Size(106, 29);
            this.ObjectRemoveButton.TabIndex = 4;
            this.ObjectRemoveButton.Text = "終了";
            this.ObjectRemoveButton.UseVisualStyleBackColor = true;
            this.ObjectRemoveButton.Click += new System.EventHandler(this.ObjectRemoveButton_Click);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 486);
            this.Controls.Add(this.LoadObjectButton);
            this.Controls.Add(this.ObjectRemoveButton);
            this.Controls.Add(this.ObjectWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Detector   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ObjectWindow;
        private System.Windows.Forms.Button LoadObjectButton;
        private System.Windows.Forms.Button ObjectRemoveButton;
    }
}

