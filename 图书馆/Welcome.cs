using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书馆
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void 读者借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lendbook form = new lendbook();
            form.Show();
        }

        private void 读者还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook form = new returnbook();
            form.Show();
        }
        private void successLogin(bool status = false)
        {
            读者服务ToolStripMenuItem.Enabled = true;
            书籍管理ToolStripMenuItem.Enabled = true;
            读者管理ToolStripMenuItem.Enabled = true;
            注销ToolStripMenuItem.Enabled = true;
            登录ToolStripMenuItem.Enabled = false;
            loginStatus.Text = Function.UserID + "已登录";
            if (status == true)
            {
                添加管理员ToolStripMenuItem1.Enabled = true;
                登录ToolStripMenuItem.Enabled = false;
                删除管理员ToolStripMenuItem.Enabled = true;
            }
        }
        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            switch (form.DialogResult)
            {
                case DialogResult.OK:
                    {
                        successLogin(false);
                        this.Show();
                    }
                    break;
                case DialogResult.Yes:
                    {
                        successLogin(true);
                        this.Show();
                    }
                    break;
                default:
                    this.Show();
                    break;
            }
        

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult res= MessageBox.Show("是否注销当前账户？", "温馨提示", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                读者服务ToolStripMenuItem.Enabled = false;
                书籍管理ToolStripMenuItem.Enabled = false;
                读者管理ToolStripMenuItem.Enabled = false;
                注销ToolStripMenuItem.Enabled = false;
                登录ToolStripMenuItem.Enabled = true;
                添加管理员ToolStripMenuItem1.Enabled = false;
                删除管理员ToolStripMenuItem.Enabled = false;
                loginStatus.Text = "未登录";
                MessageBox.Show("当前用户已注销", "提示");
            }
        }


        private void 按读者号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void 查询所有逾期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            Label label = new Label();
            label.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 24);
            label1.Name = "label3";
            label1.Size = new System.Drawing.Size(53, 15);
       label1.TabIndex = 0;
            label1.Text = "用户ID";
            panel1.Controls.Add(label1);
            //this.label3.Hide();
            //this.textBox1.Hide();
            //this.button1.Hide();
        }
    }
}
