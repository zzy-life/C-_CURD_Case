using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace UI
{
    public partial class FrmStudentInfo : Form
    {
        private Student s = new Student();
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Student> students = query.GetStudents();
            dataGridView1.DataSource = students;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            FrmAddOrEditStudent frmAddOrEditStudent = new FrmAddOrEditStudent();
            frmAddOrEditStudent.add = true;
            frmAddOrEditStudent.ShowDialog();
            FrmStudentInfo_Load(sender, e);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrEditStudent frmAddOrEditStudent = new FrmAddOrEditStudent();
            frmAddOrEditStudent.add = false;
            frmAddOrEditStudent.s = s;
            frmAddOrEditStudent.ShowDialog();
            FrmStudentInfo_Load(sender, e);
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            s.Sno = row.Cells["Sno"].Value.ToString();
            s.Sname = row.Cells["Sname"].Value.ToString();
            s.Ssex = row.Cells["Ssex"].Value.ToString();
            s.Sbirthday = DateTime.Parse(row.Cells["SBirthday"].Value.ToString());
            s.Sdept = row.Cells["Sdept"].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定要删除学号为" + s.Sno + "，姓名为" + s.Sname + "的学生吗？", "确定", MessageBoxButtons.YesNo);
            if(res == DialogResult.No)
            {
                return;
            }
            Manager manager = new Manager();
            manager.StudentDelete(s.Sno);
            FrmStudentInfo_Load(sender, e);
        }
    }
}
