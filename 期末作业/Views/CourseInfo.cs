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
        private BindingList<CourseMsg> _CourseList;
        private List<CourseMsg> _AddList;
        private List<CourseMsg> _RemoveList;
        public CourseInfo()
        {
            InitializeComponent();
            _AddList = new List<CourseMsg>();
            _RemoveList = new List<CourseMsg>();
            _ViewModel = new CourseInfoViewModel();
        }
        private void ShowData()
        {
            _CourseList = new BindingList<CourseMsg>(_ViewModel.GetCourses().ToList());
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
            _ViewModel.UpdateData(_AddList, _RemoveList);
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否取消操作", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _CourseList.Clear();
                _ViewModel.Refresh();
                ShowData();
                dgvCourse.Refresh();
            }
        }

        private void dgvCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dgvCourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (dgvCourse.SelectedRows.Count > 0)
                {
                    int index = dgvCourse.SelectedRows[0].Index;
                    _RemoveList.Add(_CourseList[index]);
                    _CourseList.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("请选择要删除的行", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvCourse_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Debug.WriteLine("test");
        }
    }
}
