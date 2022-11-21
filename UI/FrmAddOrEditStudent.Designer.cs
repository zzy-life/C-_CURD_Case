namespace UI
{
    partial class FrmAddOrEditStudent
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
            this.txtSdept = new System.Windows.Forms.TextBox();
            this.dtpSbirthday = new System.Windows.Forms.DateTimePicker();
            this.cbxSsex = new System.Windows.Forms.ComboBox();
            this.lblSbirthday = new System.Windows.Forms.Label();
            this.lblSsex = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 20);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 87);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 20);
            this.btnOK.TabIndex = 53;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblSdept
            // 
            this.lblSdept.AutoSize = true;
            this.lblSdept.Location = new System.Drawing.Point(172, 56);
            this.lblSdept.Name = "lblSdept";
            this.lblSdept.Size = new System.Drawing.Size(41, 12);
            this.lblSdept.TabIndex = 52;
            this.lblSdept.Text = "所在系";
            // 
            // txtSdept
            // 
            this.txtSdept.Location = new System.Drawing.Point(222, 51);
            this.txtSdept.Name = "txtSdept";
            this.txtSdept.Size = new System.Drawing.Size(109, 21);
            this.txtSdept.TabIndex = 51;
            // 
            // dtpSbirthday
            // 
            this.dtpSbirthday.Location = new System.Drawing.Point(46, 51);
            this.dtpSbirthday.Name = "dtpSbirthday";
            this.dtpSbirthday.Size = new System.Drawing.Size(108, 21);
            this.dtpSbirthday.TabIndex = 50;
            // 
            // cbxSsex
            // 
            this.cbxSsex.FormattingEnabled = true;
            this.cbxSsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxSsex.Location = new System.Drawing.Point(392, 12);
            this.cbxSsex.Name = "cbxSsex";
            this.cbxSsex.Size = new System.Drawing.Size(49, 20);
            this.cbxSsex.TabIndex = 49;
            // 
            // lblSbirthday
            // 
            this.lblSbirthday.AutoSize = true;
            this.lblSbirthday.Location = new System.Drawing.Point(8, 51);
            this.lblSbirthday.Name = "lblSbirthday";
            this.lblSbirthday.Size = new System.Drawing.Size(29, 12);
            this.lblSbirthday.TabIndex = 48;
            this.lblSbirthday.Text = "生日";
            // 
            // lblSsex
            // 
            this.lblSsex.AutoSize = true;
            this.lblSsex.Location = new System.Drawing.Point(355, 14);
            this.lblSsex.Name = "lblSsex";
            this.lblSsex.Size = new System.Drawing.Size(29, 12);
            this.lblSsex.TabIndex = 47;
            this.lblSsex.Text = "性别";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(185, 14);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(29, 12);
            this.lblSname.TabIndex = 46;
            this.lblSname.Text = "姓名";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(222, 12);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(109, 21);
            this.txtSname.TabIndex = 45;
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Location = new System.Drawing.Point(8, 14);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(29, 12);
            this.lblSno.TabIndex = 44;
            this.lblSno.Text = "学号";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(45, 12);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(109, 21);
            this.txtSno.TabIndex = 43;
            // 
            // FrmAddOrEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 116);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSdept);
            this.Controls.Add(this.txtSdept);
            this.Controls.Add(this.dtpSbirthday);
            this.Controls.Add(this.cbxSsex);
            this.Controls.Add(this.lblSbirthday);
            this.Controls.Add(this.lblSsex);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.lblSno);
            this.Controls.Add(this.txtSno);
            this.Name = "FrmAddOrEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrEditStudent";
            this.Load += new System.EventHandler(this.FrmAddOrEditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSdept;
        private System.Windows.Forms.TextBox txtSdept;
        private System.Windows.Forms.DateTimePicker dtpSbirthday;
        private System.Windows.Forms.ComboBox cbxSsex;
        private System.Windows.Forms.Label lblSbirthday;
        private System.Windows.Forms.Label lblSsex;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.TextBox txtSno;
    }
}