namespace 期末作业.Views
{
    partial class NewStuInfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lablel5 = new System.Windows.Forms.Label();
            this.lbSpec = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.timeGo = new System.Windows.Forms.Timer(this.components);
            this.gbSex.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出生年月：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "院系：";
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(94, 27);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(200, 21);
            this.tbStuName.TabIndex = 1;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(6, 19);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(35, 16);
            this.rbMan.TabIndex = 2;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "男";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbWoman);
            this.gbSex.Controls.Add(this.rbMan);
            this.gbSex.Location = new System.Drawing.Point(94, 54);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(200, 41);
            this.gbSex.TabIndex = 4;
            this.gbSex.TabStop = false;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(103, 21);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(35, 16);
            this.rbWoman.TabIndex = 2;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "女";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(94, 120);
            this.dtpBirthday.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 21);
            this.dtpBirthday.TabIndex = 5;
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Items.AddRange(new object[] {
            "计算机系",
            "微电子技术系",
            "电子信息工程系",
            "经济与管理工程系",
            "图形艺术系"});
            this.cboDept.Location = new System.Drawing.Point(94, 164);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(200, 20);
            this.cboDept.TabIndex = 6;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // lablel5
            // 
            this.lablel5.AutoSize = true;
            this.lablel5.Location = new System.Drawing.Point(343, 30);
            this.lablel5.Name = "lablel5";
            this.lablel5.Size = new System.Drawing.Size(41, 12);
            this.lablel5.TabIndex = 7;
            this.lablel5.Text = "专业：";
            // 
            // lbSpec
            // 
            this.lbSpec.FormattingEnabled = true;
            this.lbSpec.ItemHeight = 12;
            this.lbSpec.Location = new System.Drawing.Point(390, 27);
            this.lbSpec.Name = "lbSpec";
            this.lbSpec.Size = new System.Drawing.Size(164, 64);
            this.lbSpec.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "爱好：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(390, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(114, 36);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 16);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "其它";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(114, 14);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 16);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "音乐";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 36);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 16);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "上网";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(60, 36);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(48, 16);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "旅游";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(60, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "体育";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "阅读";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(156, 200);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "确定";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(423, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(-137, 234);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(137, 12);
            this.lblTip.TabIndex = 12;
            this.lblTip.Text = "天行健，君子自强不息！";
            // 
            // timeGo
            // 
            this.timeGo.Tick += new System.EventHandler(this.timeGo_Tick);
            // 
            // NewStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 271);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSpec);
            this.Controls.Add(this.lablel5);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStuInfo";
            this.Text = "添加学生信息";
            this.Load += new System.EventHandler(this.NewStuInfo_Load);
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label lablel5;
        private System.Windows.Forms.ListBox lbSpec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Timer timeGo;
    }
}