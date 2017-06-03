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
    public partial class MainForm : Form
    {
        private readonly Guid _userId = new Guid("E5277DA8-89F7-4A5F-A7A3-2937FAE9AC17");
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
            lbUserFiles.DataSource = _client.GetUserFiles();
            lbAllowedFiles.DataSource = _client.GetUserAllowedFiles();
        }
    }
}
