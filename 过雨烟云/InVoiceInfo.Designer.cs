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
            this.invoiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersTaxNumbeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceCode,
            this.invoiceNumber,
            this.date,
            this.buyersname,
            this.buyersTaxNumbeu,
            this.buyersAddress,
            this.buyersBank,
            this.productName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(821, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // invoiceCode
            // 
            this.invoiceCode.HeaderText = "发票编码";
            this.invoiceCode.Name = "invoiceCode";
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.HeaderText = "发票号码";
            this.invoiceNumber.Name = "invoiceNumber";
            // 
            // date
            // 
            this.date.HeaderText = "日期";
            this.date.Name = "date";
            // 
            // buyersname
            // 
            this.buyersname.HeaderText = "购买方单位名称";
            this.buyersname.Name = "buyersname";
            // 
            // buyersTaxNumbeu
            // 
            this.buyersTaxNumbeu.HeaderText = "购买方纳税人识别号";
            this.buyersTaxNumbeu.Name = "buyersTaxNumbeu";
            // 
            // buyersAddress
            // 
            this.buyersAddress.HeaderText = "购买方地址电话";
            this.buyersAddress.Name = "buyersAddress";
            // 
            // buyersBank
            // 
            this.buyersBank.HeaderText = "购买方开户行及帐号";
            this.buyersBank.Name = "buyersBank";
            // 
            // productName
            // 
            this.productName.HeaderText = "产品名称";
            this.productName.Name = "productName";
            // 
            // InvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 364);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InvoiceInfo";
            this.Text = "InVoiceInfo";
            this.Load += new System.EventHandler(this.InVoiceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersname;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersTaxNumbeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
    }
}