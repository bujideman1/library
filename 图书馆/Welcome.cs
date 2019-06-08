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

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
