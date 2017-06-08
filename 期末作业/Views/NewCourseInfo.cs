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
    public partial class NewCourseInfo : Form
    {
        private string _CourseName;
        private string _CourseClass;
        private string _Required;
        private int _Credit;
        private int _PrelectionCredit;
        private int _ExperimentCredit;
        public NewCourseInfo()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                if (tbName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    _CourseName = tbName.Text;
                    _CourseClass = cboClass.SelectedItem.ToString();
                    _Required = rdoRequired.Checked ? "必修" : "选修";
                    _Credit = (int)nudCredit.Value;
                    _PrelectionCredit = (int)nudPrelection.Value;
                    _ExperimentCredit = (int)nudExp.Value;
                    string message = $"课程名：{_CourseName}\n课程类别：{_CourseClass}\n课程性质：{_Required}" +
                        $"\n学分：{_Credit}\n理论学时：{_PrelectionCredit}\n实验学时：{_ExperimentCredit}";
                    rtbInfo.Text = message;

                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog()==DialogResult.OK)
            {
                rtbInfo.Font = fontDialog.Font;
            }
        }
    }
}
