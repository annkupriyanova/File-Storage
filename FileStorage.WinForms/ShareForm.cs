using FileStorage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStorage.WinForms
{
    public partial class ShareForm : Form
    {
        public string email = "";
        public Guid selectedUserId = new Guid();

        public ShareForm(User[] allowedUsers)
        {
            InitializeComponent();
            lbAllowedUsers.DataSource = allowedUsers;
        }

        private void btnShareFile_Click(object sender, EventArgs e)
        {
            email = tbUserEmail.Text;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnDeleteAccess_Click(object sender, EventArgs e)
        {
            selectedUserId = (Guid)lbAllowedUsers.SelectedValue;
            DialogResult = DialogResult.No;
            Dispose();
        }
    }
}
