namespace 过雨烟云
{
    partial class Form_InVoiceEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InVoiceEntry));
            this.tb_buyersname = new System.Windows.Forms.TextBox();
            this.tb_buyerstaxnumber = new System.Windows.Forms.TextBox();
            this.tb_buyersaddress = new System.Windows.Forms.TextBox();
            this.tb_buyersbank = new System.Windows.Forms.TextBox();
            this.tb_invoicenumber = new System.Windows.Forms.TextBox();
            this.tb_totalamount = new System.Windows.Forms.TextBox();
            this.tb_totaltaxamount = new System.Windows.Forms.TextBox();
            this.tb_moneyupper = new System.Windows.Forms.TextBox();
            this.tb_moneylow = new System.Windows.Forms.TextBox();
            this.tb_sellersbank = new System.Windows.Forms.TextBox();
            this.tb_sellersaddress = new System.Windows.Forms.TextBox();
            this.tb_sellerstaxnumber = new System.Windows.Forms.TextBox();
            this.tb_sellersname = new System.Windows.Forms.TextBox();
            this.tb_payee = new System.Windows.Forms.TextBox();
            this.tb_check = new System.Windows.Forms.TextBox();
            this.tb_drawer = new System.Windows.Forms.TextBox();
            this.tb_invoicecode = new System.Windows.Forms.TextBox();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_submit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_invoiceStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_returnMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buyersId = new System.Windows.Forms.Label();
            this.sellersId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_buyersname
            // 
            this.tb_buyersname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_buyersname.Location = new System.Drawing.Point(386, 214);
            this.tb_buyersname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_buyersname.Name = "tb_buyersname";
            this.tb_buyersname.Size = new System.Drawing.Size(357, 21);
            this.tb_buyersname.TabIndex = 1;
            this.tb_buyersname.TextChanged += new System.EventHandler(this.tb_buyersname_TextChanged);
            // 
            // tb_buyerstaxnumber
            // 
            this.tb_buyerstaxnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_buyerstaxnumber.Location = new System.Drawing.Point(386, 238);
            this.tb_buyerstaxnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_buyerstaxnumber.Name = "tb_buyerstaxnumber";
            this.tb_buyerstaxnumber.Size = new System.Drawing.Size(357, 21);
            this.tb_buyerstaxnumber.TabIndex = 2;
            // 
            // tb_buyersaddress
            // 
            this.tb_buyersaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_buyersaddress.Location = new System.Drawing.Point(386, 261);
            this.tb_buyersaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_buyersaddress.Name = "tb_buyersaddress";
            this.tb_buyersaddress.Size = new System.Drawing.Size(357, 21);
            this.tb_buyersaddress.TabIndex = 3;
            // 
            // tb_buyersbank
            // 
            this.tb_buyersbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_buyersbank.Location = new System.Drawing.Point(386, 284);
            this.tb_buyersbank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_buyersbank.Name = "tb_buyersbank";
            this.tb_buyersbank.Size = new System.Drawing.Size(357, 21);
            this.tb_buyersbank.TabIndex = 4;
            // 
            // tb_invoicenumber
            // 
            this.tb_invoicenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_invoicenumber.Location = new System.Drawing.Point(895, 130);
            this.tb_invoicenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_invoicenumber.Name = "tb_invoicenumber";
            this.tb_invoicenumber.Size = new System.Drawing.Size(244, 21);
            this.tb_invoicenumber.TabIndex = 6;
            // 
            // tb_totalamount
            // 
            this.tb_totalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_totalamount.Location = new System.Drawing.Point(809, 472);
            this.tb_totalamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_totalamount.Name = "tb_totalamount";
            this.tb_totalamount.Size = new System.Drawing.Size(132, 21);
            this.tb_totalamount.TabIndex = 47;
            // 
            // tb_totaltaxamount
            // 
            this.tb_totaltaxamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_totaltaxamount.Location = new System.Drawing.Point(977, 472);
            this.tb_totaltaxamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_totaltaxamount.Name = "tb_totaltaxamount";
            this.tb_totaltaxamount.Size = new System.Drawing.Size(135, 21);
            this.tb_totaltaxamount.TabIndex = 48;
            // 
            // tb_moneyupper
            // 
            this.tb_moneyupper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_moneyupper.Location = new System.Drawing.Point(515, 501);
            this.tb_moneyupper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_moneyupper.Name = "tb_moneyupper";
            this.tb_moneyupper.Size = new System.Drawing.Size(360, 21);
            this.tb_moneyupper.TabIndex = 49;
            // 
            // tb_moneylow
            // 
            this.tb_moneylow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_moneylow.Location = new System.Drawing.Point(922, 501);
            this.tb_moneylow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_moneylow.Name = "tb_moneylow";
            this.tb_moneylow.Size = new System.Drawing.Size(190, 21);
            this.tb_moneylow.TabIndex = 50;
            // 
            // tb_sellersbank
            // 
            this.tb_sellersbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sellersbank.Location = new System.Drawing.Point(386, 590);
            this.tb_sellersbank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sellersbank.Name = "tb_sellersbank";
            this.tb_sellersbank.Size = new System.Drawing.Size(357, 21);
            this.tb_sellersbank.TabIndex = 54;
            // 
            // tb_sellersaddress
            // 
            this.tb_sellersaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sellersaddress.Location = new System.Drawing.Point(386, 569);
            this.tb_sellersaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sellersaddress.Name = "tb_sellersaddress";
            this.tb_sellersaddress.Size = new System.Drawing.Size(357, 21);
            this.tb_sellersaddress.TabIndex = 53;
            // 
            // tb_sellerstaxnumber
            // 
            this.tb_sellerstaxnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sellerstaxnumber.Location = new System.Drawing.Point(386, 548);
            this.tb_sellerstaxnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sellerstaxnumber.Name = "tb_sellerstaxnumber";
            this.tb_sellerstaxnumber.Size = new System.Drawing.Size(357, 21);
            this.tb_sellerstaxnumber.TabIndex = 52;
            // 
            // tb_sellersname
            // 
            this.tb_sellersname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sellersname.Location = new System.Drawing.Point(386, 527);
            this.tb_sellersname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sellersname.Name = "tb_sellersname";
            this.tb_sellersname.Size = new System.Drawing.Size(357, 21);
            this.tb_sellersname.TabIndex = 51;
            this.tb_sellersname.TextChanged += new System.EventHandler(this.tb_sellersname_TextChanged);
            // 
            // tb_payee
            // 
            this.tb_payee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_payee.Location = new System.Drawing.Point(318, 617);
            this.tb_payee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_payee.Name = "tb_payee";
            this.tb_payee.Size = new System.Drawing.Size(172, 21);
            this.tb_payee.TabIndex = 55;
            // 
            // tb_check
            // 
            this.tb_check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_check.Location = new System.Drawing.Point(552, 617);
            this.tb_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_check.Name = "tb_check";
            this.tb_check.Size = new System.Drawing.Size(140, 21);
            this.tb_check.TabIndex = 56;
            // 
            // tb_drawer
            // 
            this.tb_drawer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_drawer.Location = new System.Drawing.Point(739, 617);
            this.tb_drawer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_drawer.Name = "tb_drawer";
            this.tb_drawer.Size = new System.Drawing.Size(136, 21);
            this.tb_drawer.TabIndex = 57;
            // 
            // tb_invoicecode
            // 
            this.tb_invoicecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_invoicecode.Location = new System.Drawing.Point(255, 130);
            this.tb_invoicecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_invoicecode.Name = "tb_invoicecode";
            this.tb_invoicecode.Size = new System.Drawing.Size(273, 21);
            this.tb_invoicecode.TabIndex = 58;
            // 
            // tb_comment
            // 
            this.tb_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_comment.Location = new System.Drawing.Point(767, 529);
            this.tb_comment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(345, 80);
            this.tb_comment.TabIndex = 59;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(964, 178);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(175, 21);
            this.dtp_date.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(255, 309);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(857, 161);
            this.dataGridView1.TabIndex = 65;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_exit,
            this.toolStripLabel3,
            this.tsbtn_submit,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1432, 45);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbtn_exit
            // 
            this.tsbtn_exit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_exit.Image")));
            this.tsbtn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_exit.Name = "tsbtn_exit";
            this.tsbtn_exit.Size = new System.Drawing.Size(56, 42);
            this.tsbtn_exit.Text = "退出";
            this.tsbtn_exit.Click += new System.EventHandler(this.tsbtn_exit_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Enabled = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(76, 42);
            this.toolStripLabel3.Text = "                 ";
            // 
            // tsbtn_submit
            // 
            this.tsbtn_submit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_submit.Image")));
            this.tsbtn_submit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_submit.Name = "tsbtn_submit";
            this.tsbtn_submit.Size = new System.Drawing.Size(56, 42);
            this.tsbtn_submit.Text = "新增";
            this.tsbtn_submit.ToolTipText = "保存数据";
            this.tsbtn_submit.Click += new System.EventHandler(this.tsbtn_submit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 42);
            this.toolStripButton1.Text = "添加一行";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sellersId);
            this.panel1.Controls.Add(this.buyersId);
            this.panel1.Controls.Add(this.cbb_invoiceStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_returnMoney);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_buyersname);
            this.panel1.Controls.Add(this.tb_invoicecode);
            this.panel1.Controls.Add(this.tb_buyerstaxnumber);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tb_buyersaddress);
            this.panel1.Controls.Add(this.tb_buyersbank);
            this.panel1.Controls.Add(this.tb_invoicenumber);
            this.panel1.Controls.Add(this.tb_totalamount);
            this.panel1.Controls.Add(this.tb_totaltaxamount);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.tb_moneyupper);
            this.panel1.Controls.Add(this.tb_comment);
            this.panel1.Controls.Add(this.tb_moneylow);
            this.panel1.Controls.Add(this.tb_drawer);
            this.panel1.Controls.Add(this.tb_sellersname);
            this.panel1.Controls.Add(this.tb_check);
            this.panel1.Controls.Add(this.tb_sellerstaxnumber);
            this.panel1.Controls.Add(this.tb_payee);
            this.panel1.Controls.Add(this.tb_sellersaddress);
            this.panel1.Controls.Add(this.tb_sellersbank);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 751);
            this.panel1.TabIndex = 68;
            // 
            // cbb_invoiceStatus
            // 
            this.cbb_invoiceStatus.FormattingEnabled = true;
            this.cbb_invoiceStatus.Items.AddRange(new object[] {
            "正常",
            "作废",
            "红字"});
            this.cbb_invoiceStatus.Location = new System.Drawing.Point(1043, 91);
            this.cbb_invoiceStatus.Name = "cbb_invoiceStatus";
            this.cbb_invoiceStatus.Size = new System.Drawing.Size(96, 20);
            this.cbb_invoiceStatus.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(974, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 69;
            this.label2.Text = "发票状态";
            // 
            // tb_returnMoney
            // 
            this.tb_returnMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_returnMoney.Location = new System.Drawing.Point(895, 92);
            this.tb_returnMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_returnMoney.Name = "tb_returnMoney";
            this.tb_returnMoney.Size = new System.Drawing.Size(79, 21);
            this.tb_returnMoney.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(852, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 67;
            this.label1.Text = "回款";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 751);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // buyersId
            // 
            this.buyersId.AutoSize = true;
            this.buyersId.Location = new System.Drawing.Point(255, 186);
            this.buyersId.Name = "buyersId";
            this.buyersId.Size = new System.Drawing.Size(0, 12);
            this.buyersId.TabIndex = 71;
            this.buyersId.Visible = false;
            // 
            // sellersId
            // 
            this.sellersId.AutoSize = true;
            this.sellersId.Location = new System.Drawing.Point(237, 531);
            this.sellersId.Name = "sellersId";
            this.sellersId.Size = new System.Drawing.Size(0, 12);
            this.sellersId.TabIndex = 72;
            this.sellersId.Visible = false;
            // 
            // Form_InVoiceEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1432, 869);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_InVoiceEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发票录入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_InVoiceEntry_FormClosing);
            this.Load += new System.EventHandler(this.Form_InVoiceEntry_Load);
            this.Resize += new System.EventHandler(this.Form_InVoiceEntry_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_buyersname;
        private System.Windows.Forms.TextBox tb_buyerstaxnumber;
        private System.Windows.Forms.TextBox tb_buyersaddress;
        private System.Windows.Forms.TextBox tb_buyersbank;
        private System.Windows.Forms.TextBox tb_invoicenumber;
        private System.Windows.Forms.TextBox tb_totalamount;
        private System.Windows.Forms.TextBox tb_totaltaxamount;
        private System.Windows.Forms.TextBox tb_moneyupper;
        private System.Windows.Forms.TextBox tb_moneylow;
        private System.Windows.Forms.TextBox tb_sellersbank;
        private System.Windows.Forms.TextBox tb_sellersaddress;
        private System.Windows.Forms.TextBox tb_sellerstaxnumber;
        private System.Windows.Forms.TextBox tb_sellersname;
        private System.Windows.Forms.TextBox tb_payee;
        private System.Windows.Forms.TextBox tb_check;
        private System.Windows.Forms.TextBox tb_drawer;
        private System.Windows.Forms.TextBox tb_invoicecode;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tsbtn_submit;
        private System.Windows.Forms.ToolStripButton tsbtn_exit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cbb_invoiceStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_returnMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sellersId;
        private System.Windows.Forms.Label buyersId;
    }
}