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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnShareFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAllowedUsers = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteAccess = new System.Windows.Forms.Button();
            this.lblAllowedUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(16, 182);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(345, 48);
            this.tbUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(16, 158);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(130, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Type user name:";
            // 
            // btnShareFile
            // 
            this.btnShareFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShareFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShareFile.Location = new System.Drawing.Point(16, 239);
            this.btnShareFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareFile.Name = "btnShareFile";
            this.btnShareFile.Size = new System.Drawing.Size(109, 49);
            this.btnShareFile.TabIndex = 1;
            this.btnShareFile.Text = "Share";
            this.btnShareFile.UseVisualStyleBackColor = false;
            this.btnShareFile.Click += new System.EventHandler(this.btnShareFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(253, 239);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbAllowedUsers
            // 
            this.lbAllowedUsers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "UserId", true));
            this.lbAllowedUsers.DataSource = this.userBindingSource;
            this.lbAllowedUsers.DisplayMember = "Name";
            this.lbAllowedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllowedUsers.FormattingEnabled = true;
            this.lbAllowedUsers.ItemHeight = 16;
            this.lbAllowedUsers.Location = new System.Drawing.Point(16, 37);
            this.lbAllowedUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lbAllowedUsers.Name = "lbAllowedUsers";
            this.lbAllowedUsers.Size = new System.Drawing.Size(341, 116);
            this.lbAllowedUsers.TabIndex = 2;
            this.lbAllowedUsers.ValueMember = "UserId";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FileStorage.Model.User);
            // 
            // btnDeleteAccess
            // 
            this.btnDeleteAccess.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteAccess.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAccess.Location = new System.Drawing.Point(136, 239);
            this.btnDeleteAccess.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccess.Name = "btnDeleteAccess";
            this.btnDeleteAccess.Size = new System.Drawing.Size(109, 49);
            this.btnDeleteAccess.TabIndex = 3;
            this.btnDeleteAccess.Text = "Delete access";
            this.btnDeleteAccess.UseVisualStyleBackColor = false;
            this.btnDeleteAccess.Click += new System.EventHandler(this.btnDeleteAccess_Click);
            // 
            // lblAllowedUsers
            // 
            this.lblAllowedUsers.AutoSize = true;
            this.lblAllowedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllowedUsers.Location = new System.Drawing.Point(16, 11);
            this.lblAllowedUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllowedUsers.Name = "lblAllowedUsers";
            this.lblAllowedUsers.Size = new System.Drawing.Size(113, 17);
            this.lblAllowedUsers.TabIndex = 6;
            this.lblAllowedUsers.Text = "Allowed users:";
            // 
            // ShareForm
            // 
            this.AcceptButton = this.btnShareFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(379, 303);
            this.Controls.Add(this.lblAllowedUsers);
            this.Controls.Add(this.btnDeleteAccess);
            this.Controls.Add(this.lbAllowedUsers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShareFile);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share File";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnShareFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbAllowedUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnDeleteAccess;
        private System.Windows.Forms.Label lblAllowedUsers;
    }
}