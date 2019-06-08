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
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }
        private Form releationForm;
        public void SetReleationForm(Form form)
        {
            releationForm = form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("不能输入空值");
            }
            else
            {
                SqlCommand sql = new SqlCommand();
                try
                {
                    if(Function.conn.State != ConnectionState.Open)
                        Function.conn.Open();
                    sql.Connection = Function.conn;
                    sql.CommandText = $"delete from lendbook where bno='{textBox1.Text}'";
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        sql.CommandText = $"update book set bborrow=0 where bno='{textBox1.Text}'";
                        if (sql.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("还书成功");
                        }
                    }
                    else
                    {
                        MessageBox.Show("还书失败！");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Function.conn.Close();
                }
            }
        }

        private void returnbook_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.releationForm!=null)
                this.releationForm.Show();
        }
    }
}
