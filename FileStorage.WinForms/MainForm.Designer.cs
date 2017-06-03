namespace FileStorage.WinForms
{
    partial class MainForm
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
            this.tabcFiles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbUserFiles = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbAllowedFiles = new System.Windows.Forms.ListBox();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.btnShareFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tabcFiles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbFile.SuspendLayout();
            this.gbComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcFiles
            // 
            this.tabcFiles.Controls.Add(this.tabPage1);
            this.tabcFiles.Controls.Add(this.tabPage2);
            this.tabcFiles.Location = new System.Drawing.Point(6, 121);
            this.tabcFiles.Name = "tabcFiles";
            this.tabcFiles.SelectedIndex = 0;
            this.tabcFiles.Size = new System.Drawing.Size(332, 186);
            this.tabcFiles.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbUserFiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(324, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Your files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbUserFiles
            // 
            this.lbUserFiles.FormattingEnabled = true;
            this.lbUserFiles.Location = new System.Drawing.Point(6, 6);
            this.lbUserFiles.Name = "lbUserFiles";
            this.lbUserFiles.Size = new System.Drawing.Size(312, 147);
            this.lbUserFiles.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbAllowedFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(324, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Allowed files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbAllowedFiles
            // 
            this.lbAllowedFiles.FormattingEnabled = true;
            this.lbAllowedFiles.Location = new System.Drawing.Point(6, 6);
            this.lbAllowedFiles.Name = "lbAllowedFiles";
            this.lbAllowedFiles.Size = new System.Drawing.Size(330, 147);
            this.lbAllowedFiles.TabIndex = 11;
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.btnShareFile);
            this.gbFile.Controls.Add(this.btnAddFile);
            this.gbFile.Controls.Add(this.btnDeleteFile);
            this.gbFile.Controls.Add(this.btnDownloadFile);
            this.gbFile.Location = new System.Drawing.Point(6, 47);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(332, 68);
            this.gbFile.TabIndex = 9;
            this.gbFile.TabStop = false;
            this.gbFile.Text = "File";
            // 
            // btnShareFile
            // 
            this.btnShareFile.Location = new System.Drawing.Point(249, 19);
            this.btnShareFile.Name = "btnShareFile";
            this.btnShareFile.Size = new System.Drawing.Size(75, 38);
            this.btnShareFile.TabIndex = 3;
            this.btnShareFile.Text = "Share";
            this.btnShareFile.UseVisualStyleBackColor = true;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(6, 19);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 38);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(168, 19);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteFile.TabIndex = 1;
            this.btnDeleteFile.Text = "Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Location = new System.Drawing.Point(87, 19);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(75, 38);
            this.btnDownloadFile.TabIndex = 2;
            this.btnDownloadFile.Text = "Download";
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(10, 19);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(312, 150);
            this.tbComments.TabIndex = 10;
            // 
            // gbComments
            // 
            this.gbComments.Controls.Add(this.tbComments);
            this.gbComments.Location = new System.Drawing.Point(6, 325);
            this.gbComments.Name = "gbComments";
            this.gbComments.Size = new System.Drawing.Size(332, 175);
            this.gbComments.TabIndex = 11;
            this.gbComments.TabStop = false;
            this.gbComments.Text = "Comments";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(6, 13);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(83, 17);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "Welcome, ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 506);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.tabcFiles);
            this.Controls.Add(this.gbFile);
            this.Name = "MainForm";
            this.Text = "Your File Storage";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabcFiles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbFile.ResumeLayout(false);
            this.gbComments.ResumeLayout(false);
            this.gbComments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcFiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbUserFiles;
        private System.Windows.Forms.ListBox lbAllowedFiles;
        private System.Windows.Forms.GroupBox gbFile;
        private System.Windows.Forms.Button btnShareFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.Label lbUserName;
    }
}

