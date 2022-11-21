using BLL;
using Models;
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
    public partial class FrmCourseInfo : Form
    {
        private Course s = new Course();
        public FrmCourseInfo()
        {
            InitializeCourseComponent();
        }
        private void FrmCourseInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Course> students = query.GetCourses();
            dataGridView1.DataSource = students;
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            FrmAddOrEditCourse frmAddOrEditCourse = new FrmAddOrEditCourse();
            frmAddOrEditCourse.add = true;
            frmAddOrEditCourse.ShowDialog();
            FrmCourseInfo_Load(sender, e);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrEditCourse frmAddOrEditCourse = new FrmAddOrEditCourse();
            frmAddOrEditCourse.add = false;
            frmAddOrEditCourse.s = s;
            Console.WriteLine(s.ToString());
            frmAddOrEditCourse.ShowDialog();
            FrmCourseInfo_Load(sender, e);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定要删除课程号为" + s.Cno + "，姓名为" + s.Cname + "的课程吗？", "确定", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }
            
            Manager manager = new Manager();
            manager.CourseDelete(s.Cno);
            FrmCourseInfo_Load(sender, e);
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            s.Cno = row.Cells["Cno"].Value.ToString();
            s.Cname = row.Cells["Cname"].Value.ToString();
            s.Cpno = int.Parse (row.Cells["Cpno"].Value.ToString());
            s.Credit = int.Parse( row.Cells["Credit"].Value.ToString());
        }
    }
}
