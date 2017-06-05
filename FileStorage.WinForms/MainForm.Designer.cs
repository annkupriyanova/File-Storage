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
            this.tpAllowedFiles = new System.Windows.Forms.TabPage();
            this.dgvAllowedFiles = new System.Windows.Forms.DataGridView();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.btnShareFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.btnCreateComment = new System.Windows.Forms.Button();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.dgvComments = new System.Windows.Forms.DataGridView();
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
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fileIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCreationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.SuspendLayout();
            // 
            // tcFiles
            // 
            this.tcFiles.Controls.Add(this.tpUserFiles);
            this.tcFiles.Controls.Add(this.tpAllowedFiles);
            this.tcFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcFiles.Location = new System.Drawing.Point(6, 121);
            this.tcFiles.Name = "tcFiles";
            this.tcFiles.SelectedIndex = 0;
            this.tcFiles.Size = new System.Drawing.Size(332, 186);
            this.tcFiles.TabIndex = 8;
            this.tcFiles.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcFiles_Selected);
            // 
            // tpUserFiles
            // 
            this.tpUserFiles.Controls.Add(this.dgvUserFiles);
            this.tpUserFiles.Location = new System.Drawing.Point(4, 22);
            this.tpUserFiles.Name = "tpUserFiles";
            this.tpUserFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserFiles.Size = new System.Drawing.Size(324, 160);
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
            this.dgvUserFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUserFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfCreationDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn});
            this.dgvUserFiles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvUserFiles.DataSource = this.fileBindingSource1;
            this.dgvUserFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserFiles.GridColor = System.Drawing.SystemColors.Window;
            this.dgvUserFiles.Location = new System.Drawing.Point(3, 3);
            this.dgvUserFiles.MultiSelect = false;
            this.dgvUserFiles.Name = "dgvUserFiles";
            this.dgvUserFiles.ReadOnly = true;
            this.dgvUserFiles.RowHeadersVisible = false;
            this.dgvUserFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserFiles.Size = new System.Drawing.Size(318, 154);
            this.dgvUserFiles.TabIndex = 13;
            this.dgvUserFiles.SelectionChanged += new System.EventHandler(this.dgvUserFiles_SelectionChanged);
            // 
            // tpAllowedFiles
            // 
            this.tpAllowedFiles.Controls.Add(this.dgvAllowedFiles);
            this.tpAllowedFiles.Location = new System.Drawing.Point(4, 22);
            this.tpAllowedFiles.Name = "tpAllowedFiles";
            this.tpAllowedFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tpAllowedFiles.Size = new System.Drawing.Size(324, 160);
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
            this.dgvAllowedFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAllowedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllowedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.dateOfCreationDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.ownerDataGridViewTextBoxColumn1});
            this.dgvAllowedFiles.DataSource = this.fileBindingSource1;
            this.dgvAllowedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllowedFiles.GridColor = System.Drawing.SystemColors.Window;
            this.dgvAllowedFiles.Location = new System.Drawing.Point(3, 3);
            this.dgvAllowedFiles.Name = "dgvAllowedFiles";
            this.dgvAllowedFiles.ReadOnly = true;
            this.dgvAllowedFiles.RowHeadersVisible = false;
            this.dgvAllowedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllowedFiles.Size = new System.Drawing.Size(318, 154);
            this.dgvAllowedFiles.TabIndex = 0;
            this.dgvAllowedFiles.SelectionChanged += new System.EventHandler(this.dgvAllowedFiles_SelectionChanged);
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.btnShareFile);
            this.gbFile.Controls.Add(this.btnAddFile);
            this.gbFile.Controls.Add(this.btnDeleteFile);
            this.gbFile.Controls.Add(this.btnDownloadFile);
            this.gbFile.Location = new System.Drawing.Point(6, 47);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(413, 68);
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
            this.btnShareFile.Click += new System.EventHandler(this.btnShareFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(6, 19);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 38);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(168, 19);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteFile.TabIndex = 1;
            this.btnDeleteFile.Text = "Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Location = new System.Drawing.Point(87, 19);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(75, 38);
            this.btnDownloadFile.TabIndex = 2;
            this.btnDownloadFile.Text = "Download";
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // btnCreateComment
            // 
            this.btnCreateComment.Location = new System.Drawing.Point(338, 16);
            this.btnCreateComment.Name = "btnCreateComment";
            this.btnCreateComment.Size = new System.Drawing.Size(75, 38);
            this.btnCreateComment.TabIndex = 13;
            this.btnCreateComment.Text = "Add";
            this.btnCreateComment.UseVisualStyleBackColor = true;
            this.btnCreateComment.Click += new System.EventHandler(this.btnCreateComment_Click);
            // 
            // gbComments
            // 
            this.gbComments.Controls.Add(this.btnCreateComment);
            this.gbComments.Controls.Add(this.dgvComments);
            this.gbComments.Controls.Add(this.btnDeleteComment);
            this.gbComments.Location = new System.Drawing.Point(6, 325);
            this.gbComments.Name = "gbComments";
            this.gbComments.Size = new System.Drawing.Size(422, 175);
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
            this.dgvComments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.fileDataGridViewTextBoxColumn});
            this.dgvComments.DataSource = this.commentBindingSource;
            this.dgvComments.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvComments.GridColor = System.Drawing.SystemColors.Window;
            this.dgvComments.Location = new System.Drawing.Point(3, 16);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersVisible = false;
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.Size = new System.Drawing.Size(326, 156);
            this.dgvComments.TabIndex = 0;
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.Location = new System.Drawing.Point(338, 60);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteComment.TabIndex = 13;
            this.btnDeleteComment.Text = "Delete";
            this.btnDeleteComment.UseVisualStyleBackColor = true;
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
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
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
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
            this.ownerDataGridViewTextBoxColumn1.Width = 63;
            // 
            // fileBindingSource
            // 
            this.fileBindingSource.DataSource = typeof(FileStorage.Model.File);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAddFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(458, 506);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.tcFiles);
            this.Controls.Add(this.gbFile);
            this.Name = "MainForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAllowedFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.Button btnCreateComment;
        private System.Windows.Forms.Button btnDeleteComment;
    }
}

