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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog();
        }

        private void tsbNewStudent_Click(object sender, EventArgs e)
        {
            NewStuInfo newStuIfon = new NewStuInfo();
            //newStuIfon.StartPosition = FormStartPosition.CenterScreen;
            //newStuIfon.ShowDialog();
            MDIWindow(newStuIfon);
        }

        private void tsbNewCourse_Click(object sender, EventArgs e)
        {
            NewCourseInfo newCourseInfo = new NewCourseInfo();
            //newCourseInfo.StartPosition = FormStartPosition.CenterScreen;
            //newCourseInfo.ShowDialog();
            MDIWindow(newCourseInfo);
        }

        private void MDIWindow(Form form)
        {
            if (this.MdiChildren.Count() > 0)
                this.MdiChildren[0].Close();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tsbStuMsgMag_Click(object sender, EventArgs e)
        {
            StuInfoManager stuInfoManager = new StuInfoManager();
            MDIWindow(stuInfoManager);
        }

        private void tsbScoreMsg_Click(object sender, EventArgs e)
        {
            MDIWindow(new StuScoreManager());
        }
    }
}
