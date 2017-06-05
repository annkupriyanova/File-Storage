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
            this.components = new System.ComponentModel.Container();
            this.tcFiles = new System.Windows.Forms.TabControl();
            this.tpUserFiles = new System.Windows.Forms.TabPage();
            this.dgvUserFiles = new System.Windows.Forms.DataGridView();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpAllowedFiles = new System.Windows.Forms.TabPage();
            this.dgvAllowedFiles = new System.Windows.Forms.DataGridView();
            this.OwnerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.btnShareFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.btnCreateComment = new System.Windows.Forms.Button();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.AuthorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.commentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fileIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCreationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tcFiles.SuspendLayout();
            this.tpUserFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserFiles)).BeginInit();
            this.tpAllowedFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllowedFiles)).BeginInit();
            this.gbFile.SuspendLayout();
            this.gbComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcFiles
            // 
            this.tcFiles.Controls.Add(this.tpUserFiles);
            this.tcFiles.Controls.Add(this.tpAllowedFiles);
            this.tcFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcFiles.Location = new System.Drawing.Point(8, 65);
            this.tcFiles.Margin = new System.Windows.Forms.Padding(4);
            this.tcFiles.Name = "tcFiles";
            this.tcFiles.SelectedIndex = 0;
            this.tcFiles.Size = new System.Drawing.Size(587, 289);
            this.tcFiles.TabIndex = 1;
            this.tcFiles.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcFiles_Selected);
            // 
            // tpUserFiles
            // 
            this.tpUserFiles.Controls.Add(this.dgvUserFiles);
            this.tpUserFiles.Location = new System.Drawing.Point(4, 25);
            this.tpUserFiles.Margin = new System.Windows.Forms.Padding(4);
            this.tpUserFiles.Name = "tpUserFiles";
            this.tpUserFiles.Padding = new System.Windows.Forms.Padding(4);
            this.tpUserFiles.Size = new System.Drawing.Size(579, 260);
            this.tpUserFiles.TabIndex = 0;
            this.tpUserFiles.Text = "Your files";
            this.tpUserFiles.UseVisualStyleBackColor = true;
            // 
            // dgvUserFiles
            // 
            this.dgvUserFiles.AllowUserToAddRows = false;
            this.dgvUserFiles.AllowUserToDeleteRows = false;
            this.dgvUserFiles.AutoGenerateColumns = false;
            this.dgvUserFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserFiles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUserFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfCreationDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.Size});
            this.dgvUserFiles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvUserFiles.DataSource = this.fileBindingSource1;
            this.dgvUserFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserFiles.GridColor = System.Drawing.SystemColors.Window;
            this.dgvUserFiles.Location = new System.Drawing.Point(4, 4);
            this.dgvUserFiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserFiles.MultiSelect = false;
            this.dgvUserFiles.Name = "dgvUserFiles";
            this.dgvUserFiles.ReadOnly = true;
            this.dgvUserFiles.RowHeadersVisible = false;
            this.dgvUserFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserFiles.Size = new System.Drawing.Size(571, 252);
            this.dgvUserFiles.TabIndex = 4;
            this.dgvUserFiles.SelectionChanged += new System.EventHandler(this.dgvUserFiles_SelectionChanged);
            // 
            // Size
            // 
            this.Size.DataPropertyName = "strSize";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // tpAllowedFiles
            // 
            this.tpAllowedFiles.Controls.Add(this.dgvAllowedFiles);
            this.tpAllowedFiles.Location = new System.Drawing.Point(4, 25);
            this.tpAllowedFiles.Margin = new System.Windows.Forms.Padding(4);
            this.tpAllowedFiles.Name = "tpAllowedFiles";
            this.tpAllowedFiles.Padding = new System.Windows.Forms.Padding(4);
            this.tpAllowedFiles.Size = new System.Drawing.Size(579, 260);
            this.tpAllowedFiles.TabIndex = 1;
            this.tpAllowedFiles.Text = "Allowed files";
            this.tpAllowedFiles.UseVisualStyleBackColor = true;
            // 
            // dgvAllowedFiles
            // 
            this.dgvAllowedFiles.AllowUserToAddRows = false;
            this.dgvAllowedFiles.AllowUserToDeleteRows = false;
            this.dgvAllowedFiles.AutoGenerateColumns = false;
            this.dgvAllowedFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllowedFiles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAllowedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllowedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.dateOfCreationDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.ownerDataGridViewTextBoxColumn1,
            this.OwnerEmail});
            this.dgvAllowedFiles.DataSource = this.fileBindingSource1;
            this.dgvAllowedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllowedFiles.GridColor = System.Drawing.SystemColors.Window;
            this.dgvAllowedFiles.Location = new System.Drawing.Point(4, 4);
            this.dgvAllowedFiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllowedFiles.Name = "dgvAllowedFiles";
            this.dgvAllowedFiles.ReadOnly = true;
            this.dgvAllowedFiles.RowHeadersVisible = false;
            this.dgvAllowedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllowedFiles.Size = new System.Drawing.Size(571, 252);
            this.dgvAllowedFiles.TabIndex = 0;
            this.dgvAllowedFiles.SelectionChanged += new System.EventHandler(this.dgvAllowedFiles_SelectionChanged);
            // 
            // OwnerEmail
            // 
            this.OwnerEmail.DataPropertyName = "OwnerName";
            this.OwnerEmail.HeaderText = "Owner";
            this.OwnerEmail.Name = "OwnerEmail";
            this.OwnerEmail.ReadOnly = true;
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.btnShareFile);
            this.gbFile.Controls.Add(this.btnAddFile);
            this.gbFile.Controls.Add(this.btnDeleteFile);
            this.gbFile.Controls.Add(this.btnDownloadFile);
            this.gbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFile.Location = new System.Drawing.Point(601, 96);
            this.gbFile.Margin = new System.Windows.Forms.Padding(4);
            this.gbFile.Name = "gbFile";
            this.gbFile.Padding = new System.Windows.Forms.Padding(4);
            this.gbFile.Size = new System.Drawing.Size(124, 254);
            this.gbFile.TabIndex = 9;
            this.gbFile.TabStop = false;
            this.gbFile.Text = "File";
            // 
            // btnShareFile
            // 
            this.btnShareFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShareFile.Location = new System.Drawing.Point(11, 199);
            this.btnShareFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareFile.Name = "btnShareFile";
            this.btnShareFile.Size = new System.Drawing.Size(105, 47);
            this.btnShareFile.TabIndex = 4;
            this.btnShareFile.Text = "Share";
            this.btnShareFile.UseVisualStyleBackColor = false;
            this.btnShareFile.Click += new System.EventHandler(this.btnShareFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddFile.Location = new System.Drawing.Point(11, 37);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(105, 47);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteFile.Location = new System.Drawing.Point(11, 145);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(105, 47);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDownloadFile.Location = new System.Drawing.Point(11, 91);
            this.btnDownloadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(105, 47);
            this.btnDownloadFile.TabIndex = 2;
            this.btnDownloadFile.Text = "Download";
            this.btnDownloadFile.UseVisualStyleBackColor = false;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // btnCreateComment
            // 
            this.btnCreateComment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateComment.Location = new System.Drawing.Point(604, 145);
            this.btnCreateComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateComment.Name = "btnCreateComment";
            this.btnCreateComment.Size = new System.Drawing.Size(100, 47);
            this.btnCreateComment.TabIndex = 5;
            this.btnCreateComment.Text = "Add";
            this.btnCreateComment.UseVisualStyleBackColor = false;
            this.btnCreateComment.Click += new System.EventHandler(this.btnCreateComment_Click);
            // 
            // gbComments
            // 
            this.gbComments.Controls.Add(this.btnCreateComment);
            this.gbComments.Controls.Add(this.dgvComments);
            this.gbComments.Controls.Add(this.btnDeleteComment);
            this.gbComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbComments.Location = new System.Drawing.Point(8, 362);
            this.gbComments.Margin = new System.Windows.Forms.Padding(4);
            this.gbComments.Name = "gbComments";
            this.gbComments.Padding = new System.Windows.Forms.Padding(4);
            this.gbComments.Size = new System.Drawing.Size(717, 254);
            this.gbComments.TabIndex = 11;
            this.gbComments.TabStop = false;
            this.gbComments.Text = "Comments";
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoGenerateColumns = false;
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.fileDataGridViewTextBoxColumn,
            this.AuthorEmail});
            this.dgvComments.DataSource = this.commentBindingSource;
            this.dgvComments.GridColor = System.Drawing.SystemColors.Window;
            this.dgvComments.Location = new System.Drawing.Point(5, 27);
            this.dgvComments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersVisible = false;
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.Size = new System.Drawing.Size(573, 219);
            this.dgvComments.TabIndex = 6;
            // 
            // AuthorEmail
            // 
            this.AuthorEmail.DataPropertyName = "AuthorName";
            this.AuthorEmail.HeaderText = "Author";
            this.AuthorEmail.Name = "AuthorEmail";
            this.AuthorEmail.ReadOnly = true;
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteComment.Location = new System.Drawing.Point(604, 199);
            this.btnDeleteComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(100, 47);
            this.btnDeleteComment.TabIndex = 7;
            this.btnDeleteComment.Text = "Delete";
            this.btnDeleteComment.UseVisualStyleBackColor = false;
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(8, 19);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(110, 24);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "Welcome, ";
            // 
            // commentIdDataGridViewTextBoxColumn
            // 
            this.commentIdDataGridViewTextBoxColumn.DataPropertyName = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.HeaderText = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.Name = "commentIdDataGridViewTextBoxColumn";
            this.commentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileDataGridViewTextBoxColumn
            // 
            this.fileDataGridViewTextBoxColumn.DataPropertyName = "File";
            this.fileDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileDataGridViewTextBoxColumn.Name = "fileDataGridViewTextBoxColumn";
            this.fileDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(FileStorage.Model.Comment);
            // 
            // fileIdDataGridViewTextBoxColumn
            // 
            this.fileIdDataGridViewTextBoxColumn.DataPropertyName = "FileId";
            this.fileIdDataGridViewTextBoxColumn.HeaderText = "FileId";
            this.fileIdDataGridViewTextBoxColumn.Name = "fileIdDataGridViewTextBoxColumn";
            this.fileIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfCreationDataGridViewTextBoxColumn
            // 
            this.dateOfCreationDataGridViewTextBoxColumn.DataPropertyName = "DateOfCreation";
            this.dateOfCreationDataGridViewTextBoxColumn.HeaderText = "Date Of Creation";
            this.dateOfCreationDataGridViewTextBoxColumn.Name = "dateOfCreationDataGridViewTextBoxColumn";
            this.dateOfCreationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileBindingSource1
            // 
            this.fileBindingSource1.DataSource = typeof(FileStorage.Model.File);
            // 
            // fileIdDataGridViewTextBoxColumn1
            // 
            this.fileIdDataGridViewTextBoxColumn1.DataPropertyName = "FileId";
            this.fileIdDataGridViewTextBoxColumn1.HeaderText = "FileId";
            this.fileIdDataGridViewTextBoxColumn1.Name = "fileIdDataGridViewTextBoxColumn1";
            this.fileIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fileIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOfCreationDataGridViewTextBoxColumn1
            // 
            this.dateOfCreationDataGridViewTextBoxColumn1.DataPropertyName = "DateOfCreation";
            this.dateOfCreationDataGridViewTextBoxColumn1.HeaderText = "Date Of Creation";
            this.dateOfCreationDataGridViewTextBoxColumn1.Name = "dateOfCreationDataGridViewTextBoxColumn1";
            this.dateOfCreationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "strSize";
            this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn1
            // 
            this.ownerDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ownerDataGridViewTextBoxColumn1.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn1.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn1.Name = "ownerDataGridViewTextBoxColumn1";
            this.ownerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn1.Visible = false;
            this.ownerDataGridViewTextBoxColumn1.Width = 63;
            // 
            // fileBindingSource
            // 
            this.fileBindingSource.DataSource = typeof(FileStorage.Model.File);
            // 
            // fileBindingSource2
            // 
            this.fileBindingSource2.DataSource = typeof(FileStorage.Model.File);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAddFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 634);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.tcFiles);
            this.Controls.Add(this.gbFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your File Storage";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcFiles.ResumeLayout(false);
            this.tpUserFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserFiles)).EndInit();
            this.tpAllowedFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllowedFiles)).EndInit();
            this.gbFile.ResumeLayout(false);
            this.gbComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcFiles;
        private System.Windows.Forms.TabPage tpUserFiles;
        private System.Windows.Forms.TabPage tpAllowedFiles;
        private System.Windows.Forms.GroupBox gbFile;
        private System.Windows.Forms.Button btnShareFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.BindingSource fileBindingSource1;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private System.Windows.Forms.DataGridView dgvUserFiles;
        private System.Windows.Forms.DataGridView dgvAllowedFiles;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.Button btnCreateComment;
        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.BindingSource fileBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorEmail;
    }
}

