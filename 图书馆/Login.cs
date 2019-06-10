using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 图书馆
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("密码不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    if (Function.CheakLogin(textBox1.Text, textBox2.Text, true) == true)
                    {
                        MessageBox.Show("管理员登陆成功！进入系统！");
                        Function.UserID = textBox1.Text;
                        this.DialogResult = DialogResult.OK;
                        //this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，登录失败");
                        this.DialogResult = DialogResult.No;
                    }
                }
                else
                {
                    SqlCommand sql = new SqlCommand();
                    try
                    {
                        if(Function.conn.State==ConnectionState.Closed)
                            Function.conn.Open();
                        sql.Connection = Function.conn;
                        sql.CommandText = $"select count(*) from superuser where uid='{textBox1.Text}' and upassword='{textBox2.Text}'";
                        if ((int)sql.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("超级管理员登陆成功！");
                            Function.UserID = textBox1.Text;
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {
                            MessageBox.Show("登录失败，请检查用户名和密码！");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message) ;
                    }
                    finally
                    {
                        Function.conn.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
