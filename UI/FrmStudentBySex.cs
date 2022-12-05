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
    public partial class FrmStudentBySex : Form
    {
        private SC sc = new SC();
        private Course c = new Course();
        public FrmStudentBySex()
        {
            InitializeComponent();
  
            cboSex.Items.Add("男");
            cboSex.Items.Add("女");

        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
           
        }

        private void FrmSCInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Student> ss = query.GetStudents();
            List<Course> cs = query.GetCourses();
           
            List<SCAll> scAlls = query.GetSCAlls();
            dataGridView1.DataSource = scAlls;


        }

        private void FrmStudentBySexDept_Load(object sender, EventArgs e)
        {
            Query query = new Query();

            List<Student> students = query.GetStudents();
            var depts = students.Select(s => new { s.Sdept }).Distinct().ToList();


            cboDept.Items.Clear();
            cboDept.Items.Add("");
            foreach (var dept in depts)
                cboDept.Items.Add(dept.Sdept);

            btnFind_Click(this, null);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Student> students = query.GetStudentsBySexDept(cboSex.Text, cboDept.Text);
            dataGridView1.DataSource = students;

            // 自动创建DataGridView的列后，再修改列的部分属性
            DataGridViewColumn cols = dataGridView1.Columns["Sno"];
            cols.HeaderText = "学号";
            cols.Width = 60;

            cols = dataGridView1.Columns["Sname"];
            cols.HeaderText = "姓名";
            cols.Width = 80;

            cols = dataGridView1.Columns["Ssex"];
            cols.HeaderText = "性别";
            cols.Width = 60;

            cols = dataGridView1.Columns["Sbirthday"];
            cols.HeaderText = "年龄";
            cols.Width = 60;

            cols = dataGridView1.Columns["Sdept"];
            cols.HeaderText = "所在系";
            cols.Width = 80;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentBySex frmStudentBySexDept = new FrmStudentBySex();
            frmStudentBySexDept.ShowDialog();

        }
    }
}
