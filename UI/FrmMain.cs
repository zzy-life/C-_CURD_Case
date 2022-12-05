using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void StudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo();
            frmStudentInfo.MdiParent = this;
            frmStudentInfo.Show();
        }

        private void CourseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourseInfo frmCourseInfo = new FrmCourseInfo();
            frmCourseInfo.MdiParent = this;
            frmCourseInfo.Show();

        }

        private void SCInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSCInfo frmSCInfo = new FrmSCInfo();
            frmSCInfo.MdiParent = this;
            frmSCInfo.Show();

        }
        private void QueryStudentByDeptAndSexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentBySex frmStudentBySexDept = new FrmStudentBySex();
            frmStudentBySexDept.MdiParent = this;
            frmStudentBySexDept.Show();
        }
    }
}
