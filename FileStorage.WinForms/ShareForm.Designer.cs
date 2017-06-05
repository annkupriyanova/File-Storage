namespace FileStorage.WinForms
{
    partial class ShareForm
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
            this.components = new System.ComponentModel.Container();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnShareFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAllowedUsers = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteAccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(12, 148);
            this.tbUserEmail.Multiline = true;
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(260, 40);
            this.tbUserEmail.TabIndex = 0;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserEmail.Location = new System.Drawing.Point(12, 128);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(135, 17);
            this.lblUserEmail.TabIndex = 1;
            this.lblUserEmail.Text = "Type user e-mail:";
            // 
            // btnShareFile
            // 
            this.btnShareFile.Location = new System.Drawing.Point(12, 194);
            this.btnShareFile.Name = "btnShareFile";
            this.btnShareFile.Size = new System.Drawing.Size(75, 38);
            this.btnShareFile.TabIndex = 2;
            this.btnShareFile.Text = "Share";
            this.btnShareFile.UseVisualStyleBackColor = true;
            this.btnShareFile.Click += new System.EventHandler(this.btnShareFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbAllowedUsers
            // 
            this.lbAllowedUsers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "UserId", true));
            this.lbAllowedUsers.DataSource = this.userBindingSource;
            this.lbAllowedUsers.DisplayMember = "Email";
            this.lbAllowedUsers.FormattingEnabled = true;
            this.lbAllowedUsers.Location = new System.Drawing.Point(15, 22);
            this.lbAllowedUsers.Name = "lbAllowedUsers";
            this.lbAllowedUsers.Size = new System.Drawing.Size(257, 95);
            this.lbAllowedUsers.TabIndex = 4;
            this.lbAllowedUsers.ValueMember = "UserId";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FileStorage.Model.User);
            // 
            // btnDeleteAccess
            // 
            this.btnDeleteAccess.Location = new System.Drawing.Point(94, 194);
            this.btnDeleteAccess.Name = "btnDeleteAccess";
            this.btnDeleteAccess.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteAccess.TabIndex = 5;
            this.btnDeleteAccess.Text = "Delete access";
            this.btnDeleteAccess.UseVisualStyleBackColor = true;
            this.btnDeleteAccess.Click += new System.EventHandler(this.btnDeleteAccess_Click);
            // 
            // ShareForm
            // 
            this.AcceptButton = this.btnShareFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.btnDeleteAccess);
            this.Controls.Add(this.lbAllowedUsers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShareFile);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.tbUserEmail);
            this.Name = "ShareForm";
            this.Text = "Share File";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnShareFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbAllowedUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnDeleteAccess;
    }
}