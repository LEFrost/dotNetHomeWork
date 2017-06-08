using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末作业.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Owner = this;
            this.Hide();
            mainWindow.StartPosition = FormStartPosition.CenterScreen;
            mainWindow.ShowDialog();
            Application.ExitThread();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
