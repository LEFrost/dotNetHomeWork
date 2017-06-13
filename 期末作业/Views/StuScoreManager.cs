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
using 期末作业.Models;
using 期末作业.Util;
using 期末作业.ViewModels;

namespace 期末作业.Views
{
    public partial class StuScoreManager : Form
    {
        private int _Current;
        private List<ScoreMsg> _ScoreList;
        private StuScoreManagerViewModel _ViewModel;
        public StuScoreManager()
        {
            InitializeComponent();
            _ViewModel = new StuScoreManagerViewModel();
            GetList();
            _Current = 0;
        }

        private void GetList()
        {
            _ScoreList = _ViewModel.LoadScores().ToList();
        }

        private void ShowData()
        {
            if (_Current >= 0 && _Current < _ScoreList.Count())
            {
                tbScore.Text = _ScoreList[_Current].Score.ToString();
                tbStuNo.Text = _ScoreList[_Current].StudentNo.ToString();
                tbCourseNo.Text = _ScoreList[_Current].CourseId.ToString();

            }
        }

        private void StuScoreManager_Load(object sender, EventArgs e)
        {
            ShowData();
        }



        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_Current > 0)
            {
                _Current--;
                ShowData();
            }
            else
            {
                MessageBox.Show("前面已经没有了", "注意", MessageBoxButtons.OK);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Current < _ScoreList.Count - 1)
            {
                _Current++;
                ShowData();
            }
            else
            {
                MessageBox.Show("后面已经没有了", "注意", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ScoreMsg score = GetScore();
            if (score != null)
            {
                if (_ViewModel.AddScore(score))
                {
                    MessageBox.Show("添加成功", "消息", MessageBoxButtons.OK);
                    _ScoreList = _ViewModel.LoadScores().ToList();
                    _Current = _ScoreList.Count;
                    ShowData();
                }
                else
                {
                    MessageBox.Show("添加失败", "消息", MessageBoxButtons.OK);
                }
            }
        }

        private ScoreMsg GetScore()
        {
            ScoreMsg score = new ScoreMsg();
            Debug.WriteLine(RegularExpressions.IsNumeric(tbScore.Text));
            if (tbStuName.Text.Equals("") || tbCourseName.Text.Equals("") || tbScore.Text.Equals(""))
            {
                MessageBox.Show("请确保输入数据正确", "错误", MessageBoxButtons.OK);
                return null;
            }
            else
            {
                score.CourseId = Convert.ToInt32(tbCourseNo.Text);
                score.StudentNo = Convert.ToInt32(tbStuNo.Text);
                score.Score = Convert.ToInt32(tbScore.Text);
            }
            return score;
        }

        private void tbCourseNo_TextChanged(object sender, EventArgs e)
        {
            if (!tbCourseNo.Text.Equals(""))
                tbCourseName.Text = _ViewModel.QueryCourseName(Convert.ToInt32(tbCourseNo.Text));
            else
                tbCourseName.Text = string.Empty;
        }

        private void tbStuNo_TextChanged(object sender, EventArgs e)
        {
            if (!tbStuNo.Text.Equals(""))
                tbStuName.Text = _ViewModel.QueryStudentName(Convert.ToInt32(tbStuNo.Text));
            else
                tbStuName.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ScoreMsg score = GetScore();
            if (score != null)
            {
                if (_ViewModel.UpdateScore(score))
                    MessageBox.Show("更新成功", "消息", MessageBoxButtons.OK);
                else
                {
                    MessageBox.Show("更新失败，请选择添加", "消息", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ScoreMsg score = GetScore();
            if (score != null)
            {
                if (_ViewModel.DeleteScore(score))
                {
                    MessageBox.Show("删除成功", "消息", MessageBoxButtons.OK);
                    _ScoreList = _ViewModel.LoadScores().ToList();
                    _Current = _Current > 0 ? _Current - 1 : 0;
                    ShowData();
                }
                else
                    MessageBox.Show("删除失败", "消息", MessageBoxButtons.OK);
            }
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
