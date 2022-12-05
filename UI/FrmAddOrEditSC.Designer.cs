using Models;
using System;

namespace UI
{
    partial class FrmAddOrEditSC
    {
        public SC s = new SC();
        public bool add;
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
            this.lblSname = new System.Windows.Forms.Label();
            this.lblSno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(447, 58);
            this.lblSname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(82, 24);
            this.lblSname.TabIndex = 62;
            this.lblSname.Text = "课程名";
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Location = new System.Drawing.Point(93, 58);
            this.lblSno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(58, 24);
            this.lblSno.TabIndex = 60;
            this.lblSno.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "成绩";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 35);
            this.textBox1.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(552, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 35);
            this.textBox2.TabIndex = 65;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 163);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 35);
            this.textBox3.TabIndex = 66;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 300);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(207, 300);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 40);
            this.btnOK.TabIndex = 67;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FrmAddOrEditSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblSno);
            this.Name = "FrmAddOrEditSC";
            this.Text = "FormAchievementInfo";
            this.Load += new System.EventHandler(this.FrmAddOrEditSC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void FrmAddOrEditSC_Load(object sender, EventArgs e)
        {
            if (add)
            {
                textBox1.Enabled = true;
                this.Text = "新增成绩信息";
            }
            else
            {
                Console.WriteLine(s.ToString());
                textBox1.Text = s.Sname;
                textBox2.Text = s.Cname;
                textBox3.Text = s.Grade.ToString();
                
                this.Text = "修改成绩信息";
            }
        }

        #endregion
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}