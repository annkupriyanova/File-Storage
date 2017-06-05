namespace FileStorage.WinForms
{
    partial class UserForm
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
            this.tcUsers = new System.Windows.Forms.TabControl();
            this.tpSignIn = new System.Windows.Forms.TabPage();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblNameSignIn = new System.Windows.Forms.Label();
            this.tbNameSignIn = new System.Windows.Forms.TextBox();
            this.tpSignUp = new System.Windows.Forms.TabPage();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tcUsers.SuspendLayout();
            this.tpSignIn.SuspendLayout();
            this.tpSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUsers
            // 
            this.tcUsers.Controls.Add(this.tpSignIn);
            this.tcUsers.Controls.Add(this.tpSignUp);
            this.tcUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcUsers.Location = new System.Drawing.Point(2, 1);
            this.tcUsers.Name = "tcUsers";
            this.tcUsers.SelectedIndex = 0;
            this.tcUsers.Size = new System.Drawing.Size(282, 200);
            this.tcUsers.TabIndex = 0;
            // 
            // tpSignIn
            // 
            this.tpSignIn.Controls.Add(this.btnSignIn);
            this.tpSignIn.Controls.Add(this.lblNameSignIn);
            this.tpSignIn.Controls.Add(this.tbNameSignIn);
            this.tpSignIn.Location = new System.Drawing.Point(4, 25);
            this.tpSignIn.Name = "tpSignIn";
            this.tpSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tpSignIn.Size = new System.Drawing.Size(274, 171);
            this.tpSignIn.TabIndex = 1;
            this.tpSignIn.Text = "Sign In";
            this.tpSignIn.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(100, 99);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 38);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblNameSignIn
            // 
            this.lblNameSignIn.AutoSize = true;
            this.lblNameSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameSignIn.Location = new System.Drawing.Point(6, 35);
            this.lblNameSignIn.Name = "lblNameSignIn";
            this.lblNameSignIn.Size = new System.Drawing.Size(54, 17);
            this.lblNameSignIn.TabIndex = 4;
            this.lblNameSignIn.Text = "Name:";
            // 
            // tbNameSignIn
            // 
            this.tbNameSignIn.Location = new System.Drawing.Point(6, 54);
            this.tbNameSignIn.Multiline = true;
            this.tbNameSignIn.Name = "tbNameSignIn";
            this.tbNameSignIn.Size = new System.Drawing.Size(260, 30);
            this.tbNameSignIn.TabIndex = 3;
            // 
            // tpSignUp
            // 
            this.tpSignUp.Controls.Add(this.btnSignUp);
            this.tpSignUp.Controls.Add(this.lblEmail);
            this.tpSignUp.Controls.Add(this.lblName);
            this.tpSignUp.Controls.Add(this.tbEmail);
            this.tpSignUp.Controls.Add(this.tbName);
            this.tpSignUp.Location = new System.Drawing.Point(4, 25);
            this.tpSignUp.Name = "tpSignUp";
            this.tpSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tpSignUp.Size = new System.Drawing.Size(274, 171);
            this.tpSignUp.TabIndex = 0;
            this.tpSignUp.Text = "Sign Up";
            this.tpSignUp.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(100, 127);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 38);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(6, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(6, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(6, 84);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(260, 30);
            this.tbEmail.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 26);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 30);
            this.tbName.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.tcUsers);
            this.Name = "UserForm";
            this.Text = "Users";
            this.tcUsers.ResumeLayout(false);
            this.tpSignIn.ResumeLayout(false);
            this.tpSignIn.PerformLayout();
            this.tpSignUp.ResumeLayout(false);
            this.tpSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUsers;
        private System.Windows.Forms.TabPage tpSignUp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TabPage tpSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblNameSignIn;
        private System.Windows.Forms.TextBox tbNameSignIn;
        private System.Windows.Forms.Button btnSignIn;
    }
}