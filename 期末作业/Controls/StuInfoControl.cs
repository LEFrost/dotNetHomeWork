using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期末作业.Models;

namespace 期末作业.Controls
{
    public partial class StuInfoControl : UserControl
    {
        private StudentMsg _Student;

        //public StudentMsg Student { get; set ; }

        public StuInfoControl()
        {
            InitializeComponent();
        }
        public StudentMsg GetStudent()
        {
            string sex, birthday, hobby, dept, spec;
            sex = rbMan.Checked ? "男" : "女";
            birthday = dtpBirthday.Value.ToString();
            dept = cboDept.SelectedItem.ToString();
            if (lbSpec.SelectedIndex == -1)
            {
                MessageBox.Show("请选择专业!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            spec = lbSpec.SelectedItem.ToString();
            hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += hobby == string.Empty ? checkBox2.Text : "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += hobby == string.Empty ? checkBox3.Text : "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += hobby == string.Empty ? checkBox4.Text : "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += hobby == string.Empty ? checkBox5.Text : "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += hobby == string.Empty ? checkBox6.Text : "、" + checkBox6.Text;

            string info = "您姓名是：" + tbStuName.Text + "\n性别：" + sex + "\n出生年月为：" + birthday +
                "\n您是" + dept + "系" + spec + "专业的学生" + "\n你的兴趣有：" + hobby;
            MessageBox.Show(info, "学生信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
          StudentMsg  student = new StudentMsg()
            {
                StudentName = tbStuName.Text,
                Sex = Convert.ToChar(sex),
                Birthday = dtpBirthday.Value,
                Department = dept,
                Speciality = spec,
                Hobby = hobby
            };
            if (_Student != null)
                student.StudentNo = _Student.StudentNo;
            return student;
        }
        public void SetStudent(StudentMsg student)
        {
            _Student = student;
        }
        private void StuInfoControl_Load(object sender, EventArgs e)
        {
            lblTip.Location = new Point(-lblTip.Width, lblTip.Location.Y);
            timeGo.Start();
            if (_Student == null)
            {

                rbMan.Checked = true;
                dtpBirthday.MaxDate = DateTime.Now;
                dtpBirthday.Value = dtpBirthday.MinDate;
                cboDept.SelectedIndex = 0;
            }
            else
            {
                if (_Student.Sex == '男') rbMan.Checked = true;
                else rbWoman.Checked = true;
                tbStuName.Text = _Student.StudentName;
                dtpBirthday.Value = _Student.Birthday.Value;
                var list1 = cboDept.Items;
                foreach (var item in list1)
                {
                    if (item.ToString().Equals(_Student.Department))
                    {
                        cboDept.SelectedItem = item;
                        break;
                    }
                }

                var list2 = lbSpec.Items;
                foreach (var item in list2)
                {
                    if (item.ToString().Equals(_Student.Speciality))
                    {
                        lbSpec.SelectedItem = item;
                        break;
                    }
                }
                var list3 = _Student.Hobby.Split('、');
                foreach (var item in list3)
                {
                    switch(item)
                    {
                        case "阅读":
                            checkBox1.Checked = true;
                            break;
                        case "体育":
                            checkBox2.Checked = true;
                            break;
                        case "音乐":
                            checkBox3.Checked = true;
                            break;
                        case "上网":
                            checkBox4.Checked = true;
                            break;
                        case "旅游":
                            checkBox5.Checked = true;
                            break;
                        case "其它":
                            checkBox6.Checked = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void timeGo_Tick(object sender, EventArgs e)
        {
            if (lblTip.Left < this.Width)
                lblTip.Left++;
            else
                lblTip.Left = -lblTip.Width;
        }
        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //}



        //private void btnFinish_Click(object sender, EventArgs e)
        //{
        //    string sex, birthday, hobby, dept, spec;
        //    sex = rbMan.Checked ? "男" : "女";
        //    birthday = dtpBirthday.Value.ToString();
        //    dept = cboDept.SelectedItem.ToString();
        //    if (lbSpec.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("请选择专业!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    spec = lbSpec.SelectedItem.ToString();
        //    hobby = "";
        //    if (checkBox1.Checked) hobby += checkBox1.Text;
        //    if (checkBox2.Checked) hobby += hobby == string.Empty ? checkBox2.Text : "、" + checkBox2.Text;
        //    if (checkBox3.Checked) hobby += hobby == string.Empty ? checkBox3.Text : "、" + checkBox3.Text;
        //    if (checkBox4.Checked) hobby += hobby == string.Empty ? checkBox4.Text : "、" + checkBox4.Text;
        //    if (checkBox5.Checked) hobby += hobby == string.Empty ? checkBox5.Text : "、" + checkBox5.Text;
        //    if (checkBox6.Checked) hobby += hobby == string.Empty ? checkBox6.Text : "、" + checkBox6.Text;

        //    string info = "您姓名是：" + tbStuName.Text + "\n性别：" + sex + "\n出生年月为：" + birthday +
        //        "\n您是" + dept + "系" + spec + "专业的学生" + "\n你的兴趣有：" + hobby;
        //    MessageBox.Show(info, "学生信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    StudentMsg student = new StudentMsg()
        //    {
        //        StudentName = tbStuName.Text,
        //        Sex = Convert.ToChar(sex),
        //        Birthday = dtpBirthday.Value,
        //        Department = dept,
        //        Speciality = spec,
        //        Hobby = hobby
        //    };

        //}

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDept.SelectedIndex)
            {
                case 0:
                    AddList(new string[]
                    {
                        "计算机科学与技术",
                        "信息与技术科学"
                    });
                    break;
                case 1:
                    AddList(new string[]
                    {
                        "集成电路与集成系统",
                       "集成电路设计与集成系统"
                    });
                    break;
                case 2:
                    AddList(new string[]
                    {
                        "通信工程",
                        "电子信息工程",
                        "电磁场与无线技术",
                        "机械设计制造及其自动化"
                    });
                    break;
                case 3:
                    AddList(new string[]
                    {
                        "国际经济与商贸",
                        "电子商务",
                        "信息管理与信息系统",
                        "财务管理"
                    });
                    break;
                case 4:
                    AddList(new string[]
                    {
                        "数字动画",
                        "影视动画",
                        "商用动画"
                    });
                    break;
            }
        }
        private void AddList(string[] specList)
        {
            lbSpec.Items.Clear();
            lbSpec.Items.AddRange(specList);
        }
    }
}
