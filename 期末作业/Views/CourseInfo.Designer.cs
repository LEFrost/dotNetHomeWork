namespace 期末作业.Views
{
    partial class CourseInfo
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Required = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrelectionCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperimentCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 288);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "保存更新(&S)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(491, 288);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消更新(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "提示，选中行在按<DEL>键可删除该行数据。双击末行，可添加新纪录。";
            // 
            // dgvCourse
            // 
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseName,
            this.CourseClass,
            this.Required,
            this.Credit,
            this.PrelectionCredit,
            this.ExperimentCredit});
            this.dgvCourse.Location = new System.Drawing.Point(16, 15);
            this.dgvCourse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.Size = new System.Drawing.Size(785, 231);
            this.dgvCourse.TabIndex = 3;
            this.dgvCourse.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCourse_RowsAdded);
            this.dgvCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCourse_KeyDown);
            this.dgvCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCourse_KeyPress);
            // 
            // CourseId
            // 
            this.CourseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "课程Id";
            this.CourseId.Name = "CourseId";
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名";
            this.CourseName.Name = "CourseName";
            // 
            // CourseClass
            // 
            this.CourseClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseClass.DataPropertyName = "CourseClass";
            this.CourseClass.HeaderText = "课程类别";
            this.CourseClass.Name = "CourseClass";
            // 
            // Required
            // 
            this.Required.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Required.DataPropertyName = "Required";
            this.Required.HeaderText = "必修";
            this.Required.Name = "Required";
            this.Required.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Required.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            // 
            // PrelectionCredit
            // 
            this.PrelectionCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrelectionCredit.DataPropertyName = "PrelectionCredit";
            this.PrelectionCredit.HeaderText = "理论学时";
            this.PrelectionCredit.Name = "PrelectionCredit";
            // 
            // ExperimentCredit
            // 
            this.ExperimentCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExperimentCredit.DataPropertyName = "ExperimentCredit";
            this.ExperimentCredit.HeaderText = "实验学时";
            this.ExperimentCredit.Name = "ExperimentCredit";
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 331);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CourseInfo";
            this.Text = "CourseInfo";
            this.Load += new System.EventHandler(this.CourseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseClass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Required;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrelectionCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperimentCredit;
    }
}