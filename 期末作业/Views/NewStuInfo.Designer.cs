﻿namespace 期末作业.Views
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
            this.StuInfoControl = new 期末作业.Controls.StuInfoControl();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StuInfoControl
            // 
            this.StuInfoControl.Location = new System.Drawing.Point(-2, -2);
            this.StuInfoControl.Name = "StuInfoControl";
            this.StuInfoControl.Size = new System.Drawing.Size(699, 318);
            this.StuInfoControl.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(166, 224);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "确定(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewStuInfo
            // 
            this.ClientSize = new System.Drawing.Size(694, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.StuInfoControl);
            this.Name = "NewStuInfo";
            this.Load += new System.EventHandler(this.NewStuInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StuInfoControl StuInfoControl;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
    }
}