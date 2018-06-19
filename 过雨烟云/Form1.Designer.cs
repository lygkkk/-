namespace 过雨烟云
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtn_invoiceinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_add = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_modify = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_query = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_close = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息ToolStripMenuItem,
            this.tsbtn_invoiceinfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息ToolStripMenuItem
            // 
            this.基础信息ToolStripMenuItem.Name = "基础信息ToolStripMenuItem";
            this.基础信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.基础信息ToolStripMenuItem.Text = "单位信息";
            this.基础信息ToolStripMenuItem.Click += new System.EventHandler(this.基础信息ToolStripMenuItem_Click_1);
            // 
            // tsbtn_invoiceinfo
            // 
            this.tsbtn_invoiceinfo.Name = "tsbtn_invoiceinfo";
            this.tsbtn_invoiceinfo.Size = new System.Drawing.Size(81, 24);
            this.tsbtn_invoiceinfo.Text = "发票信息";
            this.tsbtn_invoiceinfo.Click += new System.EventHandler(this.发票录入ToolStripMenuItem_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_add,
            this.tsbtn_modify,
            this.tsbtn_query,
            this.toolStripSeparator1,
            this.tsbtn_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_add
            // 
            this.tsbtn_add.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_add.Image")));
            this.tsbtn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_add.Name = "tsbtn_add";
            this.tsbtn_add.Size = new System.Drawing.Size(63, 24);
            this.tsbtn_add.Text = "新增";
            this.tsbtn_add.Click += new System.EventHandler(this.tsbtn_add_Click);
            // 
            // tsbtn_modify
            // 
            this.tsbtn_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_modify.Image")));
            this.tsbtn_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_modify.Name = "tsbtn_modify";
            this.tsbtn_modify.Size = new System.Drawing.Size(63, 24);
            this.tsbtn_modify.Text = "修改";
            this.tsbtn_modify.Click += new System.EventHandler(this.tsbtn_modify_Click);
            // 
            // tsbtn_query
            // 
            this.tsbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_query.Image")));
            this.tsbtn_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_query.Name = "tsbtn_query";
            this.tsbtn_query.Size = new System.Drawing.Size(63, 24);
            this.tsbtn_query.Text = "查找";
            this.tsbtn_query.Click += new System.EventHandler(this.tsbtn_query_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtn_close
            // 
            this.tsbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_close.Image")));
            this.tsbtn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_close.Name = "tsbtn_close";
            this.tsbtn_close.Size = new System.Drawing.Size(63, 24);
            this.tsbtn_close.Text = "关闭";
            this.tsbtn_close.Click += new System.EventHandler(this.tsbtn_close_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 55);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发票系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbtn_invoiceinfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_add;
        private System.Windows.Forms.ToolStripButton tsbtn_modify;
        private System.Windows.Forms.ToolStripButton tsbtn_query;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_close;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

