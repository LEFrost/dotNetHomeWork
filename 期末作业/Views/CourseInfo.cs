using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期末作业.Models;
using 期末作业.ViewModels;

namespace 期末作业.Views
{
    public partial class CourseInfo : Form
    {
        private CourseInfoViewModel _ViewModel;
        private List<CourseMsg> _CourseList;
        public CourseInfo()
        {
            InitializeComponent();
            _ViewModel = new CourseInfoViewModel();
        }
        private void ShowData()
        {
            _CourseList = _ViewModel.GetCourses().ToList();
            dgvCourse.DataSource = _CourseList;
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            ShowData();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvCourse.Update();
            foreach (var item in _CourseList)
                Debug.WriteLine(item.CourseId);
            _ViewModel.UpdateData(_CourseList);
        }

        private void dgvCourse_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == _CourseList.Count - 1)
            {
                _CourseList.Add(new CourseMsg() {CourseName="sds",Credit=32});
                dgvCourse.Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否取消操作","注意",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                _CourseList.Clear();
                _ViewModel.Refresh();
                ShowData();
                dgvCourse.Refresh();
            }
        }
    }
}
