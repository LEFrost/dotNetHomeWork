using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期末作业.Models;
using 期末作业.ViewModels;

namespace 期末作业.Views
{
    public partial class Login : Form
    {
        private LoginViewModel _ViewModel;
        public Login()
        {
            InitializeComponent();
#if DEBUG
            MySchoolDataContext _DBMySchool = new MySchoolDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString);
            var user = from u in _DBMySchool.User select u;
            tbPassword.Text = user.First().Password;
            tbUserName.Text = user.First().UserName;
#else
#endif
            _ViewModel = new LoginViewModel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (_ViewModel.IsSuccess(new Models.User()
            {
                UserName = tbUserName.Text.Trim(),
                Password = tbPassword.Text.Trim()
            }))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Owner = this;
                this.Hide();
                mainWindow.StartPosition = FormStartPosition.CenterScreen;
                mainWindow.ShowDialog();
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("密码错误或用户不存在！！！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
