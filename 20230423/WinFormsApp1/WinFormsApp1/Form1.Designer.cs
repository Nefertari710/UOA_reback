namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelShowStatus = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDownload1 = new System.Windows.Forms.Button();
            this.buttonDownload2 = new System.Windows.Forms.Button();
            this.listBoxShowList = new System.Windows.Forms.ListBox();
            this.labelDownloadFIleName = new System.Windows.Forms.Label();
            this.textBoxShowFIle = new System.Windows.Forms.TextBox();
            this.buttonDownLoadImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShowStatus
            // 
            this.labelShowStatus.AutoSize = true;
            this.labelShowStatus.Location = new System.Drawing.Point(12, 9);
            this.labelShowStatus.Name = "labelShowStatus";
            this.labelShowStatus.Size = new System.Drawing.Size(93, 15);
            this.labelShowStatus.TabIndex = 0;
            this.labelShowStatus.Text = "labelShowStatus";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(43, 100);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(144, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show File List";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDownload1
            // 
            this.buttonDownload1.Location = new System.Drawing.Point(43, 216);
            this.buttonDownload1.Name = "buttonDownload1";
            this.buttonDownload1.Size = new System.Drawing.Size(144, 23);
            this.buttonDownload1.TabIndex = 2;
            this.buttonDownload1.Text = "download File";
            this.buttonDownload1.UseVisualStyleBackColor = true;
            this.buttonDownload1.Click += new System.EventHandler(this.buttonDownload1_Click);
            // 
            // buttonDownload2
            // 
            this.buttonDownload2.Location = new System.Drawing.Point(44, 331);
            this.buttonDownload2.Name = "buttonDownload2";
            this.buttonDownload2.Size = new System.Drawing.Size(143, 23);
            this.buttonDownload2.TabIndex = 3;
            this.buttonDownload2.Text = "Download and Show";
            this.buttonDownload2.UseVisualStyleBackColor = true;
            this.buttonDownload2.Click += new System.EventHandler(this.buttonDownload2_Click);
            // 
            // listBoxShowList
            // 
            this.listBoxShowList.FormattingEnabled = true;
            this.listBoxShowList.ItemHeight = 15;
            this.listBoxShowList.Location = new System.Drawing.Point(214, 100);
            this.listBoxShowList.Name = "listBoxShowList";
            this.listBoxShowList.Size = new System.Drawing.Size(270, 94);
            this.listBoxShowList.TabIndex = 5;
            // 
            // labelDownloadFIleName
            // 
            this.labelDownloadFIleName.AutoSize = true;
            this.labelDownloadFIleName.Location = new System.Drawing.Point(214, 220);
            this.labelDownloadFIleName.Name = "labelDownloadFIleName";
            this.labelDownloadFIleName.Size = new System.Drawing.Size(136, 15);
            this.labelDownloadFIleName.TabIndex = 6;
            this.labelDownloadFIleName.Text = "labelDownloadFIleName";
            // 
            // textBoxShowFIle
            // 
            this.textBoxShowFIle.Location = new System.Drawing.Point(214, 238);
            this.textBoxShowFIle.Multiline = true;
            this.textBoxShowFIle.Name = "textBoxShowFIle";
            this.textBoxShowFIle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowFIle.Size = new System.Drawing.Size(270, 100);
            this.textBoxShowFIle.TabIndex = 9;
            // 
            // buttonDownLoadImg
            // 
            this.buttonDownLoadImg.Location = new System.Drawing.Point(44, 376);
            this.buttonDownLoadImg.Name = "buttonDownLoadImg";
            this.buttonDownLoadImg.Size = new System.Drawing.Size(75, 23);
            this.buttonDownLoadImg.TabIndex = 10;
            this.buttonDownLoadImg.Text = "buttonDownLoadImg";
            this.buttonDownLoadImg.UseVisualStyleBackColor = true;
            this.buttonDownLoadImg.Click += new System.EventHandler(this.buttonDownLoadImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(524, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDownLoadImg);
            this.Controls.Add(this.textBoxShowFIle);
            this.Controls.Add(this.labelDownloadFIleName);
            this.Controls.Add(this.listBoxShowList);
            this.Controls.Add(this.buttonDownload2);
            this.Controls.Add(this.buttonDownload1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelShowStatus);
            this.Name = "Form1";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelShowStatus;
        private Button buttonShow;
        private Button buttonDownload1;
        private Button buttonDownload2;
        private Label labelText;
        private ListBox listBoxShowList;
        private Label labelDownloadFIleName;
        private ListBox listBoxFileContext;
        private TextBox textBoxShowFIle;
        private Button buttonDownLoadImg;
        private PictureBox pictureBox1;
    }
}