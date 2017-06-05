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
    public partial class UserForm : Form
    {
        private readonly ServiceClient _client;

        public UserForm()
        {
            InitializeComponent();
            //_client = new ServiceClient("http://localhost:49957/api/");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
