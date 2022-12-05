namespace UI
{
    partial class FrmAddOrEditCourse
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSdept = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCpnotttt = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.textCpno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(759, 165);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(553, 165);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 40);
            this.btnOK.TabIndex = 65;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblSdept
            // 
            this.lblSdept.AutoSize = true;
            this.lblSdept.Location = new System.Drawing.Point(385, 96);
            this.lblSdept.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSdept.Name = "lblSdept";
            this.lblSdept.Size = new System.Drawing.Size(58, 24);
            this.lblSdept.TabIndex = 64;
            this.lblSdept.Text = "学分";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(467, 93);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(6);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(214, 35);
            this.txtCredit.TabIndex = 63;
            // 
            // txtCpnotttt
            // 
            this.txtCpnotttt.AutoSize = true;
            this.txtCpnotttt.Location = new System.Drawing.Point(39, 93);
            this.txtCpnotttt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtCpnotttt.Name = "txtCpnotttt";
            this.txtCpnotttt.Size = new System.Drawing.Size(58, 24);
            this.txtCpnotttt.TabIndex = 60;
            this.txtCpnotttt.Text = "编号";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(373, 19);
            this.lblSname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(82, 24);
            this.lblSname.TabIndex = 58;
            this.lblSname.Text = "课程名";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(467, 15);
            this.txtSname.Margin = new System.Windows.Forms.Padding(6);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(214, 35);
            this.txtSname.TabIndex = 57;
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Location = new System.Drawing.Point(19, 19);
            this.lblSno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(82, 24);
            this.lblSno.TabIndex = 56;
            this.lblSno.Text = "课程号";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(113, 15);
            this.txtSno.Margin = new System.Windows.Forms.Padding(6);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(214, 35);
            this.txtSno.TabIndex = 55;
            // 
            // textCpno
            // 
            this.textCpno.Location = new System.Drawing.Point(113, 90);
            this.textCpno.Margin = new System.Windows.Forms.Padding(6);
            this.textCpno.Name = "textCpno";
            this.textCpno.Size = new System.Drawing.Size(214, 35);
            this.textCpno.TabIndex = 67;
            // 
            // FrmAddOrEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 232);
            this.Controls.Add(this.textCpno);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSdept);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtCpnotttt);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.lblSno);
            this.Controls.Add(this.txtSno);
            this.Name = "FrmAddOrEditCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrEditCourse";
            this.Load += new System.EventHandler(this.FrmAddOrEditCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSdept;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label txtCpnotttt;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox textCpno;
    }
}