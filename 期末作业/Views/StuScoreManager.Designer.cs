namespace 期末作业.Views
{
    partial class StuScoreManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbCourseNo = new System.Windows.Forms.TextBox();
            this.tbStuNo = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "总评成绩：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生学号：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbCourseNo
            // 
            this.tbCourseNo.Location = new System.Drawing.Point(107, 24);
            this.tbCourseNo.Name = "tbCourseNo";
            this.tbCourseNo.Size = new System.Drawing.Size(100, 21);
            this.tbCourseNo.TabIndex = 2;
            this.tbCourseNo.TextChanged += new System.EventHandler(this.tbCourseNo_TextChanged);
            this.tbCourseNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // tbStuNo
            // 
            this.tbStuNo.Location = new System.Drawing.Point(107, 70);
            this.tbStuNo.Name = "tbStuNo";
            this.tbStuNo.Size = new System.Drawing.Size(100, 21);
            this.tbStuNo.TabIndex = 2;
            this.tbStuNo.TextChanged += new System.EventHandler(this.tbStuNo_TextChanged);
            this.tbStuNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(107, 116);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(100, 21);
            this.tbScore.TabIndex = 2;
            this.tbScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(301, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加(&S)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(115, 167);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一个(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(22, 167);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "上一个(&F)";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStuName);
            this.groupBox1.Controls.Add(this.tbCourseName);
            this.groupBox1.Location = new System.Drawing.Point(301, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参考信息：";
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(23, 69);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.ReadOnly = true;
            this.tbStuName.Size = new System.Drawing.Size(100, 21);
            this.tbStuName.TabIndex = 0;
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(23, 42);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.ReadOnly = true;
            this.tbCourseName.Size = new System.Drawing.Size(100, 21);
            this.tbCourseName.TabIndex = 0;
            // 
            // StuScoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbStuNo);
            this.Controls.Add(this.tbCourseNo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StuScoreManager";
            this.Text = "StuScoreManager";
            this.Load += new System.EventHandler(this.StuScoreManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbCourseNo;
        private System.Windows.Forms.TextBox tbStuNo;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.TextBox tbCourseName;
    }
}