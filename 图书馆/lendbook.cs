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
    public partial class lendbook : Form
    {
        public lendbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check() == true && Function.CheakLogin(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("身份验证成功！检查是否可以借书......");
                try
                {
                    if (Function.conn.State != ConnectionState.Open)
                        Function.conn.Open();
                    SqlCommand sql = new SqlCommand("select count(*) from lendbook where sno='" + textBox1.Text + "'", Function.conn);
                    if ((int)sql.ExecuteScalar() > 5)
                    {
                        MessageBox.Show("已借图书超限,不能继续借书！");
                        return;
                    }
                    else
                    {
                    
                        sql.CommandText = $"select btime from typical,book where bno ='{textBox3.Text}' and book.btype=typical.btype";
                        short days = (short)sql.ExecuteScalar();
                        string returnTime = DateTime.Now.AddDays(days).ToString();
                        string CommandText = $"insert lendbook values('{textBox1.Text}','{textBox3.Text}','{DateTime.Now.ToString()}','{returnTime}')";
                        sql.CommandText = CommandText;
                        if (sql.ExecuteNonQuery() > 0)
                        {
                            sql.CommandText = $"update book set bborrow=1 where bno='{textBox3.Text}'";
                            if (sql.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show($"图书借阅成功！{days}天后记得还哦");
                            }
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Function.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("身份验证失败，请检查借书证和密码！");
            }
        }
        protected bool Check()
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("借书证不能为空");
                return false;
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空");
                return false;
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("所书书籍号不能为空");
                return false;
            }
            else
                return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            returnbook returnbook = new returnbook();
            this.Hide();
            returnbook.SetReleationForm(this);
            returnbook.Show();
        }
    }
}
