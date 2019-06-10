namespace 图书馆
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.读者服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询逾期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按读者号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询所有逾期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增添书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改书籍信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看在架图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看所有图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加管理员ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.loginStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(215, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用图书馆管理系统！";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者服务ToolStripMenuItem,
            this.书籍管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.管理员ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 读者服务ToolStripMenuItem
            // 
            this.读者服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者借书ToolStripMenuItem,
            this.读者还书ToolStripMenuItem,
            this.查询逾期ToolStripMenuItem});
            this.读者服务ToolStripMenuItem.Enabled = false;
            this.读者服务ToolStripMenuItem.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者服务ToolStripMenuItem.Name = "读者服务ToolStripMenuItem";
            this.读者服务ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.读者服务ToolStripMenuItem.Text = "读者服务";
            // 
            // 读者借书ToolStripMenuItem
            // 
            this.读者借书ToolStripMenuItem.Name = "读者借书ToolStripMenuItem";
            this.读者借书ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.读者借书ToolStripMenuItem.Text = "读者借书";
            this.读者借书ToolStripMenuItem.Click += new System.EventHandler(this.读者借书ToolStripMenuItem_Click);
            // 
            // 读者还书ToolStripMenuItem
            // 
            this.读者还书ToolStripMenuItem.Name = "读者还书ToolStripMenuItem";
            this.读者还书ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.读者还书ToolStripMenuItem.Text = "读者还书";
            this.读者还书ToolStripMenuItem.Click += new System.EventHandler(this.读者还书ToolStripMenuItem_Click);
            // 
            // 查询逾期ToolStripMenuItem
            // 
            this.查询逾期ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按读者号查询ToolStripMenuItem,
            this.查询所有逾期ToolStripMenuItem});
            this.查询逾期ToolStripMenuItem.Name = "查询逾期ToolStripMenuItem";
            this.查询逾期ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.查询逾期ToolStripMenuItem.Text = "查询逾期";
            // 
            // 按读者号查询ToolStripMenuItem
            // 
            this.按读者号查询ToolStripMenuItem.Name = "按读者号查询ToolStripMenuItem";
            this.按读者号查询ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.按读者号查询ToolStripMenuItem.Text = "按读者号查询";
            this.按读者号查询ToolStripMenuItem.Click += new System.EventHandler(this.按读者号查询ToolStripMenuItem_Click);
            // 
            // 查询所有逾期ToolStripMenuItem
            // 
            this.查询所有逾期ToolStripMenuItem.Name = "查询所有逾期ToolStripMenuItem";
            this.查询所有逾期ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.查询所有逾期ToolStripMenuItem.Text = "查询所有逾期";
            this.查询所有逾期ToolStripMenuItem.Click += new System.EventHandler(this.查询所有逾期ToolStripMenuItem_Click);
            // 
            // 书籍管理ToolStripMenuItem
            // 
            this.书籍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增添书籍ToolStripMenuItem,
            this.删除书籍ToolStripMenuItem,
            this.修改书籍信息ToolStripMenuItem,
            this.查看在架图书ToolStripMenuItem,
            this.查看所有图书ToolStripMenuItem});
            this.书籍管理ToolStripMenuItem.Enabled = false;
            this.书籍管理ToolStripMenuItem.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书籍管理ToolStripMenuItem.Name = "书籍管理ToolStripMenuItem";
            this.书籍管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.书籍管理ToolStripMenuItem.Text = "书籍管理";
            // 
            // 增添书籍ToolStripMenuItem
            // 
            this.增添书籍ToolStripMenuItem.Name = "增添书籍ToolStripMenuItem";
            this.增添书籍ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.增添书籍ToolStripMenuItem.Text = "增添书籍";
            // 
            // 删除书籍ToolStripMenuItem
            // 
            this.删除书籍ToolStripMenuItem.Name = "删除书籍ToolStripMenuItem";
            this.删除书籍ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.删除书籍ToolStripMenuItem.Text = "删除书籍";
            // 
            // 修改书籍信息ToolStripMenuItem
            // 
            this.修改书籍信息ToolStripMenuItem.Name = "修改书籍信息ToolStripMenuItem";
            this.修改书籍信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.修改书籍信息ToolStripMenuItem.Text = "修改书籍信息";
            // 
            // 查看在架图书ToolStripMenuItem
            // 
            this.查看在架图书ToolStripMenuItem.Name = "查看在架图书ToolStripMenuItem";
            this.查看在架图书ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.查看在架图书ToolStripMenuItem.Text = "查看在架图书";
            // 
            // 查看所有图书ToolStripMenuItem
            // 
            this.查看所有图书ToolStripMenuItem.Name = "查看所有图书ToolStripMenuItem";
            this.查看所有图书ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.查看所有图书ToolStripMenuItem.Text = "查看所有图书";
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者注册ToolStripMenuItem,
            this.读者注销ToolStripMenuItem,
            this.读者信息修改ToolStripMenuItem});
            this.读者管理ToolStripMenuItem.Enabled = false;
            this.读者管理ToolStripMenuItem.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            // 
            // 读者注册ToolStripMenuItem
            // 
            this.读者注册ToolStripMenuItem.Name = "读者注册ToolStripMenuItem";
            this.读者注册ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.读者注册ToolStripMenuItem.Text = "读者注册";
            // 
            // 读者注销ToolStripMenuItem
            // 
            this.读者注销ToolStripMenuItem.Name = "读者注销ToolStripMenuItem";
            this.读者注销ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.读者注销ToolStripMenuItem.Text = "读者注销";
            // 
            // 读者信息修改ToolStripMenuItem
            // 
            this.读者信息修改ToolStripMenuItem.Name = "读者信息修改ToolStripMenuItem";
            this.读者信息修改ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.读者信息修改ToolStripMenuItem.Text = "读者信息修改";
            // 
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.添加管理员ToolStripMenuItem1,
            this.删除管理员ToolStripMenuItem});
            this.管理员ToolStripMenuItem.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.管理员ToolStripMenuItem.Text = "管理员";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.添加管理员ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Enabled = false;
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 添加管理员ToolStripMenuItem1
            // 
            this.添加管理员ToolStripMenuItem1.Enabled = false;
            this.添加管理员ToolStripMenuItem1.Name = "添加管理员ToolStripMenuItem1";
            this.添加管理员ToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.添加管理员ToolStripMenuItem1.Text = "添加管理员";
            // 
            // 删除管理员ToolStripMenuItem
            // 
            this.删除管理员ToolStripMenuItem.Enabled = false;
            this.删除管理员ToolStripMenuItem.Name = "删除管理员ToolStripMenuItem";
            this.删除管理员ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.删除管理员ToolStripMenuItem.Text = "删除管理员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "状态：";
            // 
            // loginStatus
            // 
            this.loginStatus.AutoSize = true;
            this.loginStatus.Location = new System.Drawing.Point(680, 12);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(52, 15);
            this.loginStatus.TabIndex = 3;
            this.loginStatus.Text = "未登录";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 394);
            this.panel1.TabIndex = 4;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Welcome";
            this.Text = "智慧图书馆";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 读者服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询逾期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书籍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增添书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改书籍信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看在架图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看所有图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginStatus;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加管理员ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按读者号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询所有逾期ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}