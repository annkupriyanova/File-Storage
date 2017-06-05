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
    public partial class CommentForm : Form
    {
        public string commentText = "";

        public CommentForm()
        {
            InitializeComponent();
            tbComment.Text = commentText;
        }

        private void btnCreateComment_Click(object sender, EventArgs e)
        {
            commentText = tbComment.Text;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
