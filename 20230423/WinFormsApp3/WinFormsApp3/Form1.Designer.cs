namespace WinFormsApp3
{
    partial class Server
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
            this.listBoxAllData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxServerData = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.labelShowStatus4 = new System.Windows.Forms.Label();
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
            // listBoxAllData
            // 
            this.listBoxAllData.FormattingEnabled = true;
            this.listBoxAllData.ItemHeight = 15;
            this.listBoxAllData.Location = new System.Drawing.Point(147, 86);
            this.listBoxAllData.Name = "listBoxAllData";
            this.listBoxAllData.Size = new System.Drawing.Size(167, 109);
            this.listBoxAllData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "All File List";
            // 
            // listBoxServerData
            // 
            this.listBoxServerData.FormattingEnabled = true;
            this.listBoxServerData.ItemHeight = 15;
            this.listBoxServerData.Location = new System.Drawing.Point(147, 250);
            this.listBoxServerData.Name = "listBoxServerData";
            this.listBoxServerData.Size = new System.Drawing.Size(167, 109);
            this.listBoxServerData.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Available File List";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(239, 201);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(75, 23);
            this.buttonAuth.TabIndex = 8;
            this.buttonAuth.Text = "Authorized";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // labelShowStatus4
            // 
            this.labelShowStatus4.AutoSize = true;
            this.labelShowStatus4.Location = new System.Drawing.Point(12, 68);
            this.labelShowStatus4.Name = "labelShowStatus4";
            this.labelShowStatus4.Size = new System.Drawing.Size(99, 15);
            this.labelShowStatus4.TabIndex = 9;
            this.labelShowStatus4.Text = "labelShowStatus4";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelShowStatus4);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxServerData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAllData);
            this.Controls.Add(this.labelShowStatus3);
            this.Controls.Add(this.labelShowStatus2);
            this.Controls.Add(this.labelShowStatus1);
            this.Controls.Add(this.labelShowStatus);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelShowStatus;
        private Label labelShowStatus1;
        private Label labelShowStatus2;
        private Label labelShowStatus3;
        private ListBox listBoxAllData;
        private Label label1;
        private ListBox listBoxServerData;
        private Label label2;
        private Button buttonAuth;
        private Label labelShowStatus4;
    }
}