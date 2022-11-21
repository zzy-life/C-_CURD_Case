namespace UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DataManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SCInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryStudentByDeptAndSexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataManageToolStripMenuItem,
            this.QueryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1178, 46);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DataManageToolStripMenuItem
            // 
            this.DataManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentInfoToolStripMenuItem,
            this.CourseInfoToolStripMenuItem,
            this.SCInfoToolStripMenuItem});
            this.DataManageToolStripMenuItem.Name = "DataManageToolStripMenuItem";
            this.DataManageToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.DataManageToolStripMenuItem.Text = "数据管理";
            // 
            // StudentInfoToolStripMenuItem
            // 
            this.StudentInfoToolStripMenuItem.Name = "StudentInfoToolStripMenuItem";
            this.StudentInfoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.StudentInfoToolStripMenuItem.Text = "学生信息";
            this.StudentInfoToolStripMenuItem.Click += new System.EventHandler(this.StudentInfoToolStripMenuItem_Click);
            // 
            // CourseInfoToolStripMenuItem
            // 
            this.CourseInfoToolStripMenuItem.Name = "CourseInfoToolStripMenuItem";
            this.CourseInfoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.CourseInfoToolStripMenuItem.Text = "课程信息";
            this.CourseInfoToolStripMenuItem.Click += new System.EventHandler(this.CourseInfoToolStripMenuItem_Click);
            // 
            // SCInfoToolStripMenuItem
            // 
            this.SCInfoToolStripMenuItem.Name = "SCInfoToolStripMenuItem";
            this.SCInfoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.SCInfoToolStripMenuItem.Text = "成绩信息";
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryStudentByDeptAndSexToolStripMenuItem});
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.QueryToolStripMenuItem.Text = "数据查询";
            // 
            // QueryStudentByDeptAndSexToolStripMenuItem
            // 
            this.QueryStudentByDeptAndSexToolStripMenuItem.Name = "QueryStudentByDeptAndSexToolStripMenuItem";
            this.QueryStudentByDeptAndSexToolStripMenuItem.Size = new System.Drawing.Size(411, 44);
            this.QueryStudentByDeptAndSexToolStripMenuItem.Text = "按性别和所在系查询学生";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 608);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DataManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CourseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SCInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryStudentByDeptAndSexToolStripMenuItem;
    }
}

