namespace 期末作业.Views
{
    partial class NewCourseInfo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCourseInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudExp = new System.Windows.Forms.NumericUpDown();
            this.nudPrelection = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCredit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoElective = new System.Windows.Forms.RadioButton();
            this.rdoRequired = new System.Windows.Forms.RadioButton();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSureInfo = new System.Windows.Forms.TabPage();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tpCourseInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpSureInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCourseInfo);
            this.tabControl1.Controls.Add(this.tpSureInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 390);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpCourseInfo
            // 
            this.tpCourseInfo.Controls.Add(this.btnNext);
            this.tpCourseInfo.Controls.Add(this.groupBox2);
            this.tpCourseInfo.Controls.Add(this.nudCredit);
            this.tpCourseInfo.Controls.Add(this.label3);
            this.tpCourseInfo.Controls.Add(this.groupBox1);
            this.tpCourseInfo.Controls.Add(this.tbName);
            this.tpCourseInfo.Controls.Add(this.label1);
            this.tpCourseInfo.Location = new System.Drawing.Point(4, 25);
            this.tpCourseInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tpCourseInfo.Name = "tpCourseInfo";
            this.tpCourseInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tpCourseInfo.Size = new System.Drawing.Size(804, 361);
            this.tpCourseInfo.TabIndex = 2;
            this.tpCourseInfo.Text = "课程信息";
            this.tpCourseInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(319, 299);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 29);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "下一步(&C)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudExp);
            this.groupBox2.Controls.Add(this.nudPrelection);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(667, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学时分配";
            // 
            // nudExp
            // 
            this.nudExp.Location = new System.Drawing.Point(400, 38);
            this.nudExp.Margin = new System.Windows.Forms.Padding(4);
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(160, 25);
            this.nudExp.TabIndex = 6;
            // 
            // nudPrelection
            // 
            this.nudPrelection.Location = new System.Drawing.Point(93, 38);
            this.nudPrelection.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrelection.Name = "nudPrelection";
            this.nudPrelection.Size = new System.Drawing.Size(160, 25);
            this.nudPrelection.TabIndex = 5;
            this.nudPrelection.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "实验学时：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "理论学时：";
            // 
            // nudCredit
            // 
            this.nudCredit.Location = new System.Drawing.Point(119, 170);
            this.nudCredit.Margin = new System.Windows.Forms.Padding(4);
            this.nudCredit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCredit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCredit.Name = "nudCredit";
            this.nudCredit.Size = new System.Drawing.Size(160, 25);
            this.nudCredit.TabIndex = 4;
            this.nudCredit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "学分：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoElective);
            this.groupBox1.Controls.Add(this.rdoRequired);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类别";
            // 
            // rdoElective
            // 
            this.rdoElective.AutoSize = true;
            this.rdoElective.Location = new System.Drawing.Point(464, 25);
            this.rdoElective.Margin = new System.Windows.Forms.Padding(4);
            this.rdoElective.Name = "rdoElective";
            this.rdoElective.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoElective.Size = new System.Drawing.Size(58, 19);
            this.rdoElective.TabIndex = 2;
            this.rdoElective.Text = "选修";
            this.rdoElective.UseVisualStyleBackColor = true;
            // 
            // rdoRequired
            // 
            this.rdoRequired.AutoSize = true;
            this.rdoRequired.Checked = true;
            this.rdoRequired.Location = new System.Drawing.Point(329, 25);
            this.rdoRequired.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRequired.Name = "rdoRequired";
            this.rdoRequired.Size = new System.Drawing.Size(58, 19);
            this.rdoRequired.TabIndex = 2;
            this.rdoRequired.TabStop = true;
            this.rdoRequired.Text = "必修";
            this.rdoRequired.UseVisualStyleBackColor = true;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "公共必修",
            "专业必修",
            "公共选修",
            "专业选修"});
            this.cboClass.Location = new System.Drawing.Point(92, 25);
            this.cboClass.Margin = new System.Windows.Forms.Padding(4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(160, 23);
            this.cboClass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程类别：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 20);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(573, 25);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名称：";
            // 
            // tpSureInfo
            // 
            this.tpSureInfo.Controls.Add(this.btnColor);
            this.tpSureInfo.Controls.Add(this.btnFont);
            this.tpSureInfo.Controls.Add(this.btnYes);
            this.tpSureInfo.Controls.Add(this.rtbInfo);
            this.tpSureInfo.Location = new System.Drawing.Point(4, 25);
            this.tpSureInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tpSureInfo.Name = "tpSureInfo";
            this.tpSureInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tpSureInfo.Size = new System.Drawing.Size(804, 361);
            this.tpSureInfo.TabIndex = 3;
            this.tpSureInfo.Text = "确定信息";
            this.tpSureInfo.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(307, 299);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 29);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "颜色(&C)";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(92, 298);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(100, 29);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "字体(&F)";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(521, 299);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 29);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "确定(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(729, 290);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // NewCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 386);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewCourseInfo";
            this.Text = "添加课程信息";
            this.tabControl1.ResumeLayout(false);
            this.tpCourseInfo.ResumeLayout(false);
            this.tpCourseInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpSureInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCourseInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpSureInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rdoElective;
        private System.Windows.Forms.RadioButton rdoRequired;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudExp;
        private System.Windows.Forms.NumericUpDown nudPrelection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
    }
}