using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期末作业.ViewModels;

namespace 期末作业.Views
{
    public partial class StuInfoManager : Form
    {
        private StuInfoManagerViewModel _ViewModel;
        public StuInfoManager()
        {
            InitializeComponent();
            _ViewModel = new StuInfoManagerViewModel();
        }

        private void StuInfoManager_Load(object sender, EventArgs e)
        {
            LoadStu();
        }

        public void LoadStu()
        {
            Debug.WriteLine("使用来一次");
            lvStudents.Items.Clear();
            var StuList = _ViewModel.GetStudents();
            foreach (var item in StuList)
            {
                ListViewItem lvi = new ListViewItem(item.StudentNo.ToString());

                //lvi.SubItems.Add();
                lvi.SubItems.Add(item.StudentName);
                lvi.SubItems.Add(item.Sex.ToString());
                lvi.SubItems.Add(item.Birthday.Value.ToString());
                lvi.SubItems.Add(item.Department);
                lvi.SubItems.Add(item.Speciality);
                lvi.SubItems.Add(item.Hobby);
                lvStudents.Items.Add(lvi);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvStudents.SelectedItems[0].Text);
            if (lvStudents.SelectedItems.Count > 0)
            {
                int index = lvStudents.SelectedItems[0].Index;
                var student = _ViewModel.GetStudent(Convert.ToInt32(lvStudents.SelectedItems[0].Text));
                ModifyWindow modify = new ModifyWindow(student);
                if (modify.ShowDialog() == DialogResult.OK)
                {
                    lvStudents.Items.RemoveAt(index);
                    ListViewItem lvi = new ListViewItem(modify.NewStudent.StudentNo.ToString());
                    lvi.SubItems.Add(modify.NewStudent.StudentName);
                    lvi.SubItems.Add(modify.NewStudent.Sex.ToString());
                    lvi.SubItems.Add(modify.NewStudent.Birthday.Value.ToString());
                    lvi.SubItems.Add(modify.NewStudent.Department);
                    lvi.SubItems.Add(modify.NewStudent.Speciality);
                    lvi.SubItems.Add(modify.NewStudent.Hobby);
                    lvStudents.Items.Insert(index, lvi);
                }

            }
            else
            {
                MessageBox.Show("请选择一个学生", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0)
            {
                int index = lvStudents.SelectedItems[0].Index;
                if (_ViewModel.Delete(Convert.ToInt32(lvStudents.SelectedItems[0].Text)))
                {
                    lvStudents.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                }
            }
            else
            {
                MessageBox.Show("请选择一个学生", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
