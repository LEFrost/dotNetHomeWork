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
    public partial class ModifyWindow : Form
    {
        private ModifyWindowViewModel _ViewModel;
        public StudentMsg NewStudent { get; set; }
        public ModifyWindow()
        {
            InitializeComponent();
            _ViewModel = new ModifyWindowViewModel();
        }
        public ModifyWindow(StudentMsg student) : this()
        {
            StuInfoControl.SetStudent(student);
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (!_ViewModel.Modify(NewStudent= StuInfoControl.GetStudent()))
                MessageBox.Show("修改失败！！！");
            else
            {
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
