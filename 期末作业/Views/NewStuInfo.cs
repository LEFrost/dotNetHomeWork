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

namespace 期末作业.Views
{
    public partial class NewStuInfo : Form
    {
        private ViewModels.NewStuInfoViewModel _ViewModel;
        public NewStuInfo()
        {
            InitializeComponent();
            _ViewModel = new ViewModels.NewStuInfoViewModel();
        }

        private void NewStuInfo_Load(object sender, EventArgs e)
        {
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            StudentMsg student = StuInfoControl.GetStudent();
            if (student == null)
                //MessageBox.Show("添加失败！！！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            else
                _ViewModel.AddStudent(student);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
