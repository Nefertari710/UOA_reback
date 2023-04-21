namespace WinFormsApp2
{
    partial class Cache
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
            this.labelShowStatus1 = new System.Windows.Forms.Label();
            this.labelShowStatus2 = new System.Windows.Forms.Label();
            this.labelShowStatus3 = new System.Windows.Forms.Label();
            this.buttonDeleteAllFile = new System.Windows.Forms.Button();
            this.labelDeleteFIleStatus = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelTest = new System.Windows.Forms.Label();
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
            // labelShowStatus1
            // 
            this.labelShowStatus1.AutoSize = true;
            this.labelShowStatus1.Location = new System.Drawing.Point(12, 24);
            this.labelShowStatus1.Name = "labelShowStatus1";
            this.labelShowStatus1.Size = new System.Drawing.Size(99, 15);
            this.labelShowStatus1.TabIndex = 1;
            this.labelShowStatus1.Text = "labelShowStatus1";
            // 
            // labelShowStatus2
            // 
            this.labelShowStatus2.AutoSize = true;
            this.labelShowStatus2.Location = new System.Drawing.Point(12, 39);
            this.labelShowStatus2.Name = "labelShowStatus2";
            this.labelShowStatus2.Size = new System.Drawing.Size(99, 15);
            this.labelShowStatus2.TabIndex = 2;
            this.labelShowStatus2.Text = "labelShowStatus2";
            // 
            // labelShowStatus3
            // 
            this.labelShowStatus3.AutoSize = true;
            this.labelShowStatus3.Location = new System.Drawing.Point(12, 54);
            this.labelShowStatus3.Name = "labelShowStatus3";
            this.labelShowStatus3.Size = new System.Drawing.Size(99, 15);
            this.labelShowStatus3.TabIndex = 3;
            this.labelShowStatus3.Text = "labelShowStatus3";
            // 
            // buttonDeleteAllFile
            // 
            this.buttonDeleteAllFile.Location = new System.Drawing.Point(97, 159);
            this.buttonDeleteAllFile.Name = "buttonDeleteAllFile";
            this.buttonDeleteAllFile.Size = new System.Drawing.Size(135, 23);
            this.buttonDeleteAllFile.TabIndex = 4;
            this.buttonDeleteAllFile.Text = "buttonDeleteAllFile";
            this.buttonDeleteAllFile.UseVisualStyleBackColor = true;
            this.buttonDeleteAllFile.Click += new System.EventHandler(this.buttonDeleteAllFile_Click);
            // 
            // labelDeleteFIleStatus
            // 
            this.labelDeleteFIleStatus.AutoSize = true;
            this.labelDeleteFIleStatus.Location = new System.Drawing.Point(247, 164);
            this.labelDeleteFIleStatus.Name = "labelDeleteFIleStatus";
            this.labelDeleteFIleStatus.Size = new System.Drawing.Size(115, 15);
            this.labelDeleteFIleStatus.TabIndex = 5;
            this.labelDeleteFIleStatus.Text = "labelDeleteFIleStatus";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(97, 198);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(359, 163);
            this.textBoxLog.TabIndex = 6;
            this.textBoxLog.Text = "textBoxLog";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(653, 401);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(52, 15);
            this.labelTest.TabIndex = 7;
            this.labelTest.Text = "labelTest";
            // 
            // Cache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelDeleteFIleStatus);
            this.Controls.Add(this.buttonDeleteAllFile);
            this.Controls.Add(this.labelShowStatus3);
            this.Controls.Add(this.labelShowStatus2);
            this.Controls.Add(this.labelShowStatus1);
            this.Controls.Add(this.labelShowStatus);
            this.Name = "Cache";
            this.Text = "Cache";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelShowStatus;
        private Label labelShowStatus1;
        private Label labelShowStatus2;
        private Label labelShowStatus3;
        private Button buttonDeleteAllFile;
        private Label labelDeleteFIleStatus;
        private TextBox textBoxLog;
        private Label labelTest;
    }
}