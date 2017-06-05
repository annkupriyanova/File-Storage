using FileStorage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace FileStorage.WinForms
{
    public partial class MainForm : Form
    {
        private readonly Guid _userId = new Guid("705537E6-C136-4C62-A34E-7871961D6D30");
        private readonly ServiceClient _client;

        public MainForm()
        {
            InitializeComponent();
            _client = new ServiceClient("http://localhost:49957/api/", _userId);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshFileList();
            lbUserName.Text += _client.GetUser().Name + "!";
        }

        private void RefreshFileList()
        {
            dgvUserFiles.DataSource = _client.GetUserFiles();
            dgvAllowedFiles.DataSource = _client.GetUserAllowedFiles();
        }

        private void RefreshComments()
        {
            Guid fileId = new Guid();
            var name = tcFiles.SelectedTab.Name;
            switch (name)
            {
                case "tpUserFiles":
                    {
                        if (dgvUserFiles.SelectedRows.Count != 0)
                        {
                            fileId = (Guid)dgvUserFiles.SelectedRows[0].Cells[0].Value;
                        }
                        break;
                    }
                case "tpAllowedFiles":
                    {
                        if (dgvAllowedFiles.SelectedRows.Count != 0)
                        {
                            fileId = (Guid)dgvAllowedFiles.SelectedRows[0].Cells[0].Value;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            dgvComments.DataSource = _client.GetFileComments(fileId);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileContent = File.ReadAllBytes(dialog.FileName);
                        var file = new Model.File
                        {
                            Name = Path.GetFileName(dialog.FileName),
                            Owner = _client.GetUser()
                        };
                        var fileId = _client.CreateFile(file);
                        _client.UploadFileContent(fileId, fileContent);
                        RefreshFileList();
                        MessageBox.Show($"File {file.Name} was added successfully", "File Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"File was not added. Error message: {Environment.NewLine}{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            Guid fileId=new Guid();
            try
            {
                if (tcFiles.SelectedTab.Name == "tpUserFiles")
                {
                    fileId = (Guid)dgvUserFiles.SelectedRows[0].Cells[0].Value;
                }
                else if (tcFiles.SelectedTab.Name == "tpAllowedFiles")
                {
                    fileId = (Guid)dgvAllowedFiles.SelectedRows[0].Cells[0].Value;
                }
                if (fileId != null)
                {
                    _client.DeleteFile(fileId);
                    RefreshFileList();
                    RefreshComments();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"File was not deleted. Error message: {Environment.NewLine}{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            Guid fileId = new Guid();
            string fileName = "";

            try
            {
                if (tcFiles.SelectedTab.Name == "tpUserFiles")
                {
                    fileId = (Guid)dgvUserFiles.SelectedRows[0].Cells[0].Value;
                    fileName = dgvUserFiles.SelectedRows[0].Cells[1].Value.ToString();
                }
                else if (tcFiles.SelectedTab.Name == "tpAllowedFiles")
                {
                    fileId = (Guid)dgvAllowedFiles.SelectedRows[0].Cells[0].Value;
                    fileName = dgvAllowedFiles.SelectedRows[0].Cells[1].Value.ToString();
                }
                if (fileId != null)
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.FileName = fileName.ToString();
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            var content = _client.DownloadFile((Guid)fileId);
                            File.WriteAllBytes(dialog.FileName, content);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"File was not downloaded. Error message: {Environment.NewLine}{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUserFiles_SelectionChanged(object sender, EventArgs e)
        {
            RefreshComments();
        }

        private void dgvAllowedFiles_SelectionChanged(object sender, EventArgs e)
        {
            RefreshComments();
        }

        private void btnCreateComment_Click(object sender, EventArgs e)
        {
            Guid fileId = new Guid();

            try
            {
                using (CommentForm commentForm = new CommentForm())
                {
                    if (commentForm.ShowDialog() == DialogResult.OK)
                    {
                        var text = commentForm.commentText;
                        if (tcFiles.SelectedTab.Name == "tpUserFiles")
                        {
                            fileId = (Guid)dgvUserFiles.SelectedRows[0].Cells[0].Value;
                        }
                        else if (tcFiles.SelectedTab.Name == "tpAllowedFiles")
                        {
                            fileId = (Guid)dgvAllowedFiles.SelectedRows[0].Cells[0].Value;
                        }
                        var comment = new Comment
                        {
                            Text = text,
                            File = _client.GetFile(fileId),
                            Author = _client.GetUser()
                        };
                        _client.CreateComment(comment);
                        RefreshComments();
                        MessageBox.Show($"Comment was added successfully", "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Comment was not added. Error message: {Environment.NewLine}{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            try
            {
                var commentId = (Guid)dgvComments.SelectedRows[0].Cells[0].Value;
                var author = (User)dgvComments.SelectedRows[0].Cells[3].Value;
                var file = (Model.File)dgvComments.SelectedRows[0].Cells[4].Value;

                if (_client.GetUser().UserId == author.UserId)
                {
                    _client.DeleteComment(commentId);
                    RefreshComments();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Comment was not deleted. Error message: {Environment.NewLine}{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShareFile_Click(object sender, EventArgs e)
        {
            Guid fileId = new Guid();

            try
            {
                if (tcFiles.SelectedTab.Name == "tpUserFiles")
                {
                    fileId = (Guid)dgvUserFiles.SelectedRows[0].Cells[0].Value;
                }
                else if (tcFiles.SelectedTab.Name == "tpAllowedFiles")
                {
                    fileId = (Guid)dgvAllowedFiles.SelectedRows[0].Cells[0].Value;
                }

                var allowedUsers = _client.GetAllowedUsers(fileId);

                using (ShareForm shareForm = new ShareForm(allowedUsers))
                {
                    var result = shareForm.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                var userName = shareForm.userName;
                                _client.GiveAccessToFile(fileId, userName);
                                MessageBox.Show($"User {userName} got access to your file", "File Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        case DialogResult.No:
                            {
                                var selectedUserId = shareForm.selectedUserId;
                                _client.DeleteAccessToFile(fileId, selectedUserId);
                                MessageBox.Show($"Access to file is deleted", "File Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка при обработке доступа к файлу, текст ошибки: {Environment.NewLine}{exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcFiles_Selected(object sender, TabControlEventArgs e)
        {
            RefreshComments();

            if(tcFiles.SelectedTab.Name == "tpAllowedFiles")
            {
                btnShareFile.Enabled = false;
                btnDeleteFile.Enabled = false;
                btnDeleteComment.Enabled = false;
            }
            else if (tcFiles.SelectedTab.Name == "tpUserFiles")
            {
                btnShareFile.Enabled = true;
                btnDeleteFile.Enabled = true;
                btnDeleteComment.Enabled = true;
            }
        }
    }
}