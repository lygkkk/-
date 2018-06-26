namespace 过雨烟云
{
    partial class InvoiceInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerscommpanyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerstaxnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersbank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltaxamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyupper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneylow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellersid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerscommpanyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerstaxnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellersaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellersbank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicestate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.invoicecode,
            this.invoicenumber,
            this.date,
            this.buyersid,
            this.buyerscommpanyname,
            this.buyerstaxnumber,
            this.buyersaddress,
            this.buyersbank,
            this.productname,
            this.productnumber,
            this.unitprice,
            this.money,
            this.taxrate,
            this.taxamount,
            this.totalamount,
            this.totaltaxamount,
            this.moneyupper,
            this.moneylow,
            this.sellersid,
            this.sellerscommpanyname,
            this.sellerstaxnumber,
            this.sellersaddress,
            this.sellersbank,
            this.comment,
            this.payee,
            this.check,
            this.drawer,
            this.invoicestate,
            this.returnmoney});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // invoicecode
            // 
            this.invoicecode.DataPropertyName = "invoicecode";
            this.invoicecode.HeaderText = "发票编码";
            this.invoicecode.Name = "invoicecode";
            // 
            // invoicenumber
            // 
            this.invoicenumber.DataPropertyName = "invoicenumber";
            this.invoicenumber.HeaderText = "发票号码";
            this.invoicenumber.Name = "invoicenumber";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "开票日期";
            this.date.Name = "date";
            // 
            // buyersid
            // 
            this.buyersid.DataPropertyName = "buyersid";
            this.buyersid.HeaderText = "购物方id";
            this.buyersid.Name = "buyersid";
            this.buyersid.Visible = false;
            // 
            // buyerscommpanyname
            // 
            this.buyerscommpanyname.DataPropertyName = "commpanyname";
            this.buyerscommpanyname.HeaderText = "购货方名称";
            this.buyerscommpanyname.Name = "buyerscommpanyname";
            // 
            // buyerstaxnumber
            // 
            this.buyerstaxnumber.DataPropertyName = "taxnumber";
            this.buyerstaxnumber.HeaderText = "购货方税号";
            this.buyerstaxnumber.Name = "buyerstaxnumber";
            // 
            // buyersaddress
            // 
            this.buyersaddress.DataPropertyName = "address";
            this.buyersaddress.HeaderText = "购货方地址电话";
            this.buyersaddress.Name = "buyersaddress";
            // 
            // buyersbank
            // 
            this.buyersbank.DataPropertyName = "bank";
            this.buyersbank.HeaderText = "购货方开户行及帐号";
            this.buyersbank.Name = "buyersbank";
            // 
            // productname
            // 
            this.productname.DataPropertyName = "productname";
            this.productname.HeaderText = "产品名称";
            this.productname.Name = "productname";
            // 
            // productnumber
            // 
            this.productnumber.DataPropertyName = "productnumber";
            this.productnumber.HeaderText = "数量";
            this.productnumber.Name = "productnumber";
            // 
            // unitprice
            // 
            this.unitprice.DataPropertyName = "unitprice";
            this.unitprice.HeaderText = "单价";
            this.unitprice.Name = "unitprice";
            // 
            // money
            // 
            this.money.DataPropertyName = "money";
            this.money.HeaderText = "金额";
            this.money.Name = "money";
            // 
            // taxrate
            // 
            this.taxrate.DataPropertyName = "taxrate";
            this.taxrate.HeaderText = "税率";
            this.taxrate.Name = "taxrate";
            // 
            // taxamount
            // 
            this.taxamount.DataPropertyName = "taxamount";
            this.taxamount.HeaderText = "税额";
            this.taxamount.Name = "taxamount";
            // 
            // totalamount
            // 
            this.totalamount.DataPropertyName = "totalamount";
            this.totalamount.HeaderText = "合计金额";
            this.totalamount.Name = "totalamount";
            // 
            // totaltaxamount
            // 
            this.totaltaxamount.DataPropertyName = "totaltaxamount";
            this.totaltaxamount.HeaderText = "合计税额";
            this.totaltaxamount.Name = "totaltaxamount";
            // 
            // moneyupper
            // 
            this.moneyupper.DataPropertyName = "moneyupper";
            this.moneyupper.HeaderText = "金额大写";
            this.moneyupper.Name = "moneyupper";
            // 
            // moneylow
            // 
            this.moneylow.DataPropertyName = "moneylow";
            this.moneylow.HeaderText = "金额小写";
            this.moneylow.Name = "moneylow";
            // 
            // sellersid
            // 
            this.sellersid.DataPropertyName = "sellersid";
            this.sellersid.HeaderText = "销售方id";
            this.sellersid.Name = "sellersid";
            this.sellersid.Visible = false;
            // 
            // sellerscommpanyname
            // 
            this.sellerscommpanyname.DataPropertyName = "销售方名称";
            this.sellerscommpanyname.HeaderText = "销售方名称";
            this.sellerscommpanyname.Name = "sellerscommpanyname";
            // 
            // sellerstaxnumber
            // 
            this.sellerstaxnumber.DataPropertyName = "销售方税号";
            this.sellerstaxnumber.HeaderText = "销售方税号";
            this.sellerstaxnumber.Name = "sellerstaxnumber";
            // 
            // sellersaddress
            // 
            this.sellersaddress.DataPropertyName = "销售方地址及电话";
            this.sellersaddress.HeaderText = "销售方地址及电话";
            this.sellersaddress.Name = "sellersaddress";
            // 
            // sellersbank
            // 
            this.sellersbank.DataPropertyName = "销售方开户行及帐号";
            this.sellersbank.HeaderText = "销售方开户行及行号";
            this.sellersbank.Name = "sellersbank";
            // 
            // comment
            // 
            this.comment.DataPropertyName = "comment";
            this.comment.HeaderText = "备注";
            this.comment.Name = "comment";
            // 
            // payee
            // 
            this.payee.DataPropertyName = "payee";
            this.payee.HeaderText = "收款人";
            this.payee.Name = "payee";
            // 
            // check
            // 
            this.check.DataPropertyName = "check";
            this.check.HeaderText = "复核";
            this.check.Name = "check";
            // 
            // drawer
            // 
            this.drawer.DataPropertyName = "drawer";
            this.drawer.HeaderText = "开票人";
            this.drawer.Name = "drawer";
            // 
            // invoicestate
            // 
            this.invoicestate.DataPropertyName = "invoicestate";
            this.invoicestate.HeaderText = "发票状态";
            this.invoicestate.Name = "invoicestate";
            // 
            // returnmoney
            // 
            this.returnmoney.DataPropertyName = "returnmoney";
            this.returnmoney.HeaderText = "回款";
            this.returnmoney.Name = "returnmoney";
            // 
            // InvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 455);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InvoiceInfo";
            this.Text = "InVoiceInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerscommpanyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerstaxnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersbank;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaltaxamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyupper;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneylow;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellersid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerscommpanyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerstaxnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellersaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellersbank;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn payee;
        private System.Windows.Forms.DataGridViewTextBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawer;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicestate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnmoney;
    }
}