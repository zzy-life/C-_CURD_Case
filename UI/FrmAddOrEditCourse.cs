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
    public partial class FrmAddOrEditCourse : Form
    {
        public Course s = new Course();
        public bool add;
        public FrmAddOrEditCourse()
        {
            InitializeComponent();
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            s.Cno = txtSno.Text.Trim();
            s.Cname = txtSname.Text.Trim();
            s.Cpno = int.Parse (textCpno.Text.Trim().ToString());
            s.Credit = int.Parse( txtCredit.Text.Trim());

            if (String.IsNullOrEmpty(s.Cno))
            {
                MessageBox.Show("课程号不能为空，请输入！", "错误");
                txtSno.SelectAll();
                txtSno.Focus();
                return;
            }

            if (String.IsNullOrEmpty(s.Cname))
            {
                MessageBox.Show("课程名不能为空，请输入！", "错误");
                txtSname.SelectAll();
                txtSname.Focus();
                return;
            }

        

            Manager manager = new Manager();
            if (add)
            {
                manager.CourseInsert(s);
            }
            else
            {
                manager.CourseUpdate(s);
            }
            this.Close();
        }

        private void FrmAddOrEditCourse_Load(object sender, EventArgs e)
        {
            if (add)
            {
                txtSno.Enabled = true;
                this.Text = "新增课程信息";
            }
            else
            {
                txtSno.Enabled = false;
                txtSno.Text = s.Cno;
                txtSname.Text = s.Cname;
                textCpno.Text =  s.Cpno.ToString();
                txtCredit.Text = s.Credit.ToString();
                this.Text = "修改课程信息";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
