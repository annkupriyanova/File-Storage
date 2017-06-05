namespace FileStorage.WinForms
{
    partial class CommentForm
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
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnCreateComment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbComment
            // 
            this.tbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbComment.Location = new System.Drawing.Point(12, 29);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(260, 71);
            this.tbComment.TabIndex = 0;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComment.Location = new System.Drawing.Point(12, 9);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(155, 17);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = "Type your comment:";
            // 
            // btnCreateComment
            // 
            this.btnCreateComment.Location = new System.Drawing.Point(12, 106);
            this.btnCreateComment.Name = "btnCreateComment";
            this.btnCreateComment.Size = new System.Drawing.Size(75, 38);
            this.btnCreateComment.TabIndex = 2;
            this.btnCreateComment.Text = "Save comment";
            this.btnCreateComment.UseVisualStyleBackColor = true;
            this.btnCreateComment.Click += new System.EventHandler(this.btnCreateComment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CommentForm
            // 
            this.AcceptButton = this.btnCreateComment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.tbComment);
            this.Name = "CommentForm";
            this.Text = "Create Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnCreateComment;
        private System.Windows.Forms.Button btnCancel;
    }
}