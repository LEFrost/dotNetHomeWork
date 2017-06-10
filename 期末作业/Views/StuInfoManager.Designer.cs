namespace 期末作业.Views
{
    partial class StuInfoManager
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
            this.lvStudents = new System.Windows.Forms.ListView();
            this.StuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StuSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speciality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hobby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StuNo,
            this.StuName,
            this.StuSex,
            this.Birthday,
            this.Department,
            this.Speciality,
            this.Hobby});
            this.lvStudents.FullRowSelect = true;
            this.lvStudents.GridLines = true;
            this.lvStudents.LabelEdit = true;
            this.lvStudents.Location = new System.Drawing.Point(10, 10);
            this.lvStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvStudents.MultiSelect = false;
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(482, 286);
            this.lvStudents.TabIndex = 0;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // StuNo
            // 
            this.StuNo.Text = "学号";
            this.StuNo.Width = 80;
            // 
            // StuName
            // 
            this.StuName.Text = "姓名";
            this.StuName.Width = 80;
            // 
            // StuSex
            // 
            this.StuSex.Text = "性别";
            this.StuSex.Width = 80;
            // 
            // Birthday
            // 
            this.Birthday.Text = "出生年月";
            this.Birthday.Width = 80;
            // 
            // Department
            // 
            this.Department.Text = "院系";
            this.Department.Width = 80;
            // 
            // Speciality
            // 
            this.Speciality.Text = "专业";
            this.Speciality.Width = 80;
            // 
            // Hobby
            // 
            this.Hobby.Text = "爱好";
            this.Hobby.Width = 80;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(527, 48);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(56, 26);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 191);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 26);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StuInfoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 306);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lvStudents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StuInfoManager";
            this.Text = "StuInfoManager";
            this.Load += new System.EventHandler(this.StuInfoManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader StuNo;
        private System.Windows.Forms.ColumnHeader StuName;
        private System.Windows.Forms.ColumnHeader StuSex;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Speciality;
        private System.Windows.Forms.ColumnHeader Hobby;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}