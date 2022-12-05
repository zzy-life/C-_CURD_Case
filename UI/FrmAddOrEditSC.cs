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
    public partial class FrmAddOrEditSC : Form
    {

        public FrmAddOrEditSC()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
           
            s.Grade = int.Parse(textBox3.Text.Trim().ToString());
            
            if (String.IsNullOrEmpty(s.Cno))
            {
                MessageBox.Show("课程号不能为空，请输入！", "错误");
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }

            if (String.IsNullOrEmpty(s.Sno))
            {
                MessageBox.Show("课程名不能为空，请输入！", "错误");
                textBox2.SelectAll();
                textBox2.Focus();
                return;
            }

            Manager manager = new Manager();
            if (add)
            {
                manager.ScInsert(s);
            }
            else
            {
                Console.WriteLine(s.ToString());
                manager.ScUpdate(s);
            }
            this.Close();
        }

        private void FrmAddOrEditCourse_Load(object sender, EventArgs e)
        {
            if (add)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                this.Text = "新增课程信息";
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Text = s.Grade.ToString();
                this.Text = "修改课程信息";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
