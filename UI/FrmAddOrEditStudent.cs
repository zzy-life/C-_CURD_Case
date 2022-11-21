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
    public partial class FrmAddOrEditStudent : Form
    {
        public Student s = new Student();
        public bool add;
        public FrmAddOrEditStudent()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            s.Sno = txtSno.Text.Trim();
            s.Sname = txtSname.Text.Trim();
            s.Ssex = cbxSsex.Text.Trim();
            s.Sbirthday = dtpSbirthday.Value;
            s.Sdept = txtSdept.Text.Trim();

            if (String.IsNullOrEmpty(s.Sno))
            {
                MessageBox.Show("学号不能为空，请输入学号！", "错误");
                txtSno.SelectAll();
                txtSno.Focus();
                return;
            }

            if (String.IsNullOrEmpty(s.Sname))
            {
                MessageBox.Show("姓名不能为空，请输入姓名！", "错误");
                txtSname.SelectAll();
                txtSname.Focus();
                return;
            }

            if (String.IsNullOrEmpty(s.Sdept))
            {
                MessageBox.Show("所在系不能为空，请输入所在系！", "错误");
                txtSdept.SelectAll();
                txtSdept.Focus();
                return;
            }

            Manager manager = new Manager();
            if (add)
            {
                manager.StudentInsert(s);
            }
            else
            {
                manager.StudentUpdate(s);
            }
            this.Close();
        }

        private void FrmAddOrEditStudent_Load(object sender, EventArgs e)
        {
            if (add)
            {
                txtSno.Enabled = true;
                this.Text = "新增学生信息";
            }
            else
            {
                txtSno.Enabled = false;
                txtSno.Text = s.Sno;
                txtSname.Text = s.Sname;
                cbxSsex.Text = s.Ssex;
                dtpSbirthday.Value = s.Sbirthday;
                txtSdept.Text = s.Sdept;
                this.Text = "修改学生信息";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
