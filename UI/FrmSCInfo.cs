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
    public partial class FrmSCInfo : Form
    {
        private SC s = new SC();
        public FrmSCInfo()
        {
            InitializeComponent();
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Sno";
            col.DataPropertyName = "Sno";
            col.HeaderText = "学号";
            col.Width = 60;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Sname";
            col.DataPropertyName = "Sname";
            col.HeaderText = "姓名";
            col.Width = 80;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Cname";
            col.DataPropertyName = "Cname";
            col.HeaderText = "课程名称";
            col.Width = 100;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Grade";
            col.DataPropertyName = "Grade";
            col.HeaderText = "成绩";
            col.Width = 60;
            dataGridView1.Columns.Add(col);

        }
        private void FrmScInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<SC> sc = query.GetSc();
            dataGridView1.DataSource = sc;
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            FrmAddOrEditSC frmAddOrEditSc = new FrmAddOrEditSC();
            frmAddOrEditSc.add = true;
            frmAddOrEditSc.ShowDialog();
            FrmScInfo_Load(sender, e);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrEditSC frmAddOrEditSc = new FrmAddOrEditSC();
            frmAddOrEditSc.add = false;
            frmAddOrEditSc.s = s;
            Console.WriteLine(s.ToString());
            frmAddOrEditSc.ShowDialog();
            FrmScInfo_Load(sender, e);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定要删除姓名为" + s.Sname + "，课程号为" + s.Cname + "的成绩吗？", "确定", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            Manager manager = new Manager();
            manager.ScDelete(s);
            FrmScInfo_Load(sender, e);
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            s.Sno = row.Cells["Sno"].Value.ToString();
            s.Cno = row.Cells["Cno"].Value.ToString();
            s.Sname = row.Cells["Sname"].Value.ToString();
            s.Cname = row.Cells["Cname"].Value.ToString();
            s.Grade = int.Parse(row.Cells["Grade"].Value.ToString());
        }
    }
}
