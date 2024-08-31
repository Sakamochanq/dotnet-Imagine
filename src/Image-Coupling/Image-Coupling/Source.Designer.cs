namespace Image_Coupling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderBrowseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ConvertImageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsTopMostCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHelpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoggerLabel = new System.Windows.Forms.Label();
            this.ImageListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImagePreviewBox = new System.Windows.Forms.PictureBox();
            this.ConvertAsButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.TruePageCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ReStartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(679, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFolderBrowseButton,
            this.toolStripMenuItem1,
            this.ConvertImageButton,
            this.toolStripMenuItem2,
            this.ExitButton});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // OpenFolderBrowseButton
            // 
            this.OpenFolderBrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFolderBrowseButton.Image")));
            this.OpenFolderBrowseButton.Name = "OpenFolderBrowseButton";
            this.OpenFolderBrowseButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFolderBrowseButton.Size = new System.Drawing.Size(197, 22);
            this.OpenFolderBrowseButton.Text = "開く";
            this.OpenFolderBrowseButton.Click += new System.EventHandler(this.OpenFolderBrowseButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // ConvertImageButton
            // 
            this.ConvertImageButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertImageButton.Image")));
            this.ConvertImageButton.Name = "ConvertImageButton";
            this.ConvertImageButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ConvertImageButton.Size = new System.Drawing.Size(197, 22);
            this.ConvertImageButton.Text = "変換保存";
            this.ConvertImageButton.Click += new System.EventHandler(this.ConvertImageButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitButton.Size = new System.Drawing.Size(197, 22);
            this.ExitButton.Text = "終了";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsTopMostCheckBox,
            this.toolStripMenuItem3,
            this.ReStartButton});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.表示VToolStripMenuItem.Text = "表示(V)";
            // 
            // IsTopMostCheckBox
            // 
            this.IsTopMostCheckBox.CheckOnClick = true;
            this.IsTopMostCheckBox.Name = "IsTopMostCheckBox";
            this.IsTopMostCheckBox.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.IsTopMostCheckBox.Size = new System.Drawing.Size(197, 22);
            this.IsTopMostCheckBox.Text = "最前面表示";
            this.IsTopMostCheckBox.CheckedChanged += new System.EventHandler(this.IsTopMostCheckBox_CheckedChanged);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenHelpButton});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
            // 
            // OpenHelpButton
            // 
            this.OpenHelpButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenHelpButton.Image")));
            this.OpenHelpButton.Name = "OpenHelpButton";
            this.OpenHelpButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.OpenHelpButton.Size = new System.Drawing.Size(209, 22);
            this.OpenHelpButton.Text = "ヘルプを表示";
            this.OpenHelpButton.Click += new System.EventHandler(this.OpenHelpButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LoggerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 25);
            this.panel1.TabIndex = 1;
            // 
            // LoggerLabel
            // 
            this.LoggerLabel.AutoSize = true;
            this.LoggerLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoggerLabel.Location = new System.Drawing.Point(7, 7);
            this.LoggerLabel.Name = "LoggerLabel";
            this.LoggerLabel.Size = new System.Drawing.Size(41, 12);
            this.LoggerLabel.TabIndex = 2;
            this.LoggerLabel.Text = "待機中";
            this.LoggerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageListView
            // 
            this.ImageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ImageListView.HideSelection = false;
            this.ImageListView.Location = new System.Drawing.Point(12, 38);
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(348, 245);
            this.ImageListView.TabIndex = 2;
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            this.ImageListView.View = System.Windows.Forms.View.Details;
            this.ImageListView.SelectedIndexChanged += new System.EventHandler(this.ImageListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ファイル名";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "パス";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "サイズ";
            this.columnHeader3.Width = 89;
            // 
            // ImagePreviewBox
            // 
            this.ImagePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreviewBox.Location = new System.Drawing.Point(373, 38);
            this.ImagePreviewBox.Name = "ImagePreviewBox";
            this.ImagePreviewBox.Size = new System.Drawing.Size(296, 245);
            this.ImagePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreviewBox.TabIndex = 3;
            this.ImagePreviewBox.TabStop = false;
            // 
            // ConvertAsButton
            // 
            this.ConvertAsButton.Location = new System.Drawing.Point(541, 294);
            this.ConvertAsButton.Name = "ConvertAsButton";
            this.ConvertAsButton.Size = new System.Drawing.Size(125, 37);
            this.ConvertAsButton.TabIndex = 4;
            this.ConvertAsButton.Text = "PDFの出力";
            this.ConvertAsButton.UseVisualStyleBackColor = true;
            this.ConvertAsButton.Click += new System.EventHandler(this.ConvertAsButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(537, 290);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(132, 45);
            this.progressBar.TabIndex = 5;
            // 
            // TruePageCheckBox
            // 
            this.TruePageCheckBox.AutoSize = true;
            this.TruePageCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.TruePageCheckBox.Location = new System.Drawing.Point(373, 294);
            this.TruePageCheckBox.Name = "TruePageCheckBox";
            this.TruePageCheckBox.Size = new System.Drawing.Size(109, 17);
            this.TruePageCheckBox.TabIndex = 6;
            this.TruePageCheckBox.Text = "ページ数の描画";
            this.TruePageCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(194, 6);
            // 
            // ReStartButton
            // 
            this.ReStartButton.Image = ((System.Drawing.Image)(resources.GetObject("ReStartButton.Image")));
            this.ReStartButton.Name = "ReStartButton";
            this.ReStartButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.ReStartButton.Size = new System.Drawing.Size(197, 22);
            this.ReStartButton.Text = "再起動";
            this.ReStartButton.Click += new System.EventHandler(this.ReStartButton_Click);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 366);
            this.Controls.Add(this.TruePageCheckBox);
            this.Controls.Add(this.ConvertAsButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ImagePreviewBox);
            this.Controls.Add(this.ImageListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Coupling   |   C:\\";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderBrowseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ImageListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox ImagePreviewBox;
        private System.Windows.Forms.Button ConvertAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ConvertImageButton;
        private System.Windows.Forms.Label LoggerLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsTopMostCheckBox;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenHelpButton;
        private System.Windows.Forms.CheckBox TruePageCheckBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ReStartButton;
    }
}

