namespace 期末作业.Views
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息管理TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbNewStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbStuMsgMag = new System.Windows.Forms.ToolStripButton();
            this.tsbNewCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbCurMsgMag = new System.Windows.Forms.ToolStripButton();
            this.tsbScoreMsg = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.学生管理MToolStripMenuItem,
            this.课程管理CToolStripMenuItem,
            this.成绩管理AToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理(&E)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.退出ToolStripMenuItem.Text = "退出(&E)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 学生管理MToolStripMenuItem
            // 
            this.学生管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息AToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem});
            this.学生管理MToolStripMenuItem.Name = "学生管理MToolStripMenuItem";
            this.学生管理MToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.学生管理MToolStripMenuItem.Text = "学生管理(&M)";
            // 
            // 添加学生信息AToolStripMenuItem
            // 
            this.添加学生信息AToolStripMenuItem.Name = "添加学生信息AToolStripMenuItem";
            this.添加学生信息AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.添加学生信息AToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.添加学生信息AToolStripMenuItem.Text = "添加学生信息(&A)";
            this.添加学生信息AToolStripMenuItem.Click += new System.EventHandler(this.tsbNewStudent_Click);
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理(&I)";
            this.学生信息管理ToolStripMenuItem.Click += new System.EventHandler(this.tsbStuMsgMag_Click);
            // 
            // 课程管理CToolStripMenuItem
            // 
            this.课程管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加课程AToolStripMenuItem,
            this.课程信息管理TToolStripMenuItem});
            this.课程管理CToolStripMenuItem.Name = "课程管理CToolStripMenuItem";
            this.课程管理CToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.课程管理CToolStripMenuItem.Text = "课程管理(&C)";
            // 
            // 添加课程AToolStripMenuItem
            // 
            this.添加课程AToolStripMenuItem.Name = "添加课程AToolStripMenuItem";
            this.添加课程AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.添加课程AToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.添加课程AToolStripMenuItem.Text = "添加课程(&A)";
            this.添加课程AToolStripMenuItem.Click += new System.EventHandler(this.tsbNewCourse_Click);
            // 
            // 课程信息管理TToolStripMenuItem
            // 
            this.课程信息管理TToolStripMenuItem.Name = "课程信息管理TToolStripMenuItem";
            this.课程信息管理TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.课程信息管理TToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.课程信息管理TToolStripMenuItem.Text = "课程信息管理(&T)";
            this.课程信息管理TToolStripMenuItem.Click += new System.EventHandler(this.tsbCurMsgMag_Click);
            // 
            // 成绩管理AToolStripMenuItem
            // 
            this.成绩管理AToolStripMenuItem.Name = "成绩管理AToolStripMenuItem";
            this.成绩管理AToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.成绩管理AToolStripMenuItem.Text = "成绩管理(&A)";
            this.成绩管理AToolStripMenuItem.Click += new System.EventHandler(this.tsbScoreMsg_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewStudent,
            this.tsbStuMsgMag,
            this.tsbNewCourse,
            this.tsbCurMsgMag,
            this.tsbScoreMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "常用命令";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(760, 20);
            this.tssMsg.Spring = true;
            this.tssMsg.Text = "请选择一个操作";
            this.tssMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssStatus
            // 
            this.tssStatus.Image = global::期末作业.Properties.Resources.round_clock_502px_1159612_easyicon_net;
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(52, 20);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbNewStudent
            // 
            this.tsbNewStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewStudent.Image = global::期末作业.Properties.Resources.student_224px_1150106_easyicon_net;
            this.tsbNewStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewStudent.Name = "tsbNewStudent";
            this.tsbNewStudent.Size = new System.Drawing.Size(36, 36);
            this.tsbNewStudent.Text = "添加学生信息";
            this.tsbNewStudent.Click += new System.EventHandler(this.tsbNewStudent_Click);
            // 
            // tsbStuMsgMag
            // 
            this.tsbStuMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStuMsgMag.Image = global::期末作业.Properties.Resources.message_650px_1192837_easyicon_net;
            this.tsbStuMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStuMsgMag.Name = "tsbStuMsgMag";
            this.tsbStuMsgMag.Size = new System.Drawing.Size(36, 36);
            this.tsbStuMsgMag.Text = "学生信息管理";
            this.tsbStuMsgMag.Click += new System.EventHandler(this.tsbStuMsgMag_Click);
            // 
            // tsbNewCourse
            // 
            this.tsbNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCourse.Image = global::期末作业.Properties.Resources.course_assignments_48px_1138136_easyicon_net;
            this.tsbNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCourse.Name = "tsbNewCourse";
            this.tsbNewCourse.Size = new System.Drawing.Size(36, 36);
            this.tsbNewCourse.Text = "添加课程信息";
            this.tsbNewCourse.Click += new System.EventHandler(this.tsbNewCourse_Click);
            // 
            // tsbCurMsgMag
            // 
            this.tsbCurMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurMsgMag.Image = global::期末作业.Properties.Resources.computer_694px_1196180_easyicon_net;
            this.tsbCurMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurMsgMag.Name = "tsbCurMsgMag";
            this.tsbCurMsgMag.Size = new System.Drawing.Size(36, 36);
            this.tsbCurMsgMag.Text = "课程信息管理";
            this.tsbCurMsgMag.Click += new System.EventHandler(this.tsbCurMsgMag_Click);
            // 
            // tsbScoreMsg
            // 
            this.tsbScoreMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreMsg.Image = global::期末作业.Properties.Resources.test_413px_1197298_easyicon_net;
            this.tsbScoreMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreMsg.Name = "tsbScoreMsg";
            this.tsbScoreMsg.Size = new System.Drawing.Size(36, 36);
            this.tsbScoreMsg.Text = "成绩管理";
            this.tsbScoreMsg.Click += new System.EventHandler(this.tsbScoreMsg_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 427);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加课程AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息管理TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewStudent;
        private System.Windows.Forms.ToolStripButton tsbStuMsgMag;
        private System.Windows.Forms.ToolStripButton tsbNewCourse;
        private System.Windows.Forms.ToolStripButton tsbCurMsgMag;
        private System.Windows.Forms.ToolStripButton tsbScoreMsg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
    }
}