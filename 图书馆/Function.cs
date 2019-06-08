using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 图书馆
{
    public static class Function
    {
        public  static SqlConnection conn=new SqlConnection ("server=.;database=library;integrated security=true;");

        public  static bool CheakLogin(string username,string password,bool checkAdmin = false)
        {
            string commText = string.Format("select count(*) from yonghu where Sno='{0}' and Spassword='{1}' and Sadmin={2}",username,password,checkAdmin==true?1:0);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(commText, conn);
                int res = (int)command.ExecuteScalar();
                if (res > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
