using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using Model;
using BLL;

namespace 过雨烟云
{
    public partial class Form_InVoiceEntry : Form
    {
        StepPrompt _stepPrompt = null;
        private string keyWord;
        Bitmap bm;
        Point point;
        public Form_InVoiceEntry()
        {
            InitializeComponent();
        }

        private string _fileDir;

        public string FileDir { get => _fileDir; set => _fileDir = value; }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            MessageBox.Show(dataGridView1.Rows.Count.ToString());
            //Dictionary<Control, string> inVoiceInfo = new Dictionary<Control, string>();
            //foreach (Control item in this.Controls)
            //{
            //    if (item.GetType().ToString() != "System.Windows.Forms.Label" && item.GetType().ToString() != "System.Windows.Forms.Button")
            //    {
            //        inVoiceInfo.Add(item, "unknow");
            //    }
            //}
            //MessageBox.Show();
            //inVoiceInfo.in
            //List<>
        }

        private void tb_buyersname_TextChanged(object sender, EventArgs e)
        {
            keyWord = tb_buyersname.Text;
            DisplayListView();
        }

        //判断购买方或销售方 把公司信息自动填充到单元格
        private void CommpanyInfo(string id, string commpanyName,string taxNumber, string address, string bank)
        {
            if (ActiveControl.Name == "tb_buyersname")
            {
                this.tb_buyersname.TextChanged -= tb_buyersname_TextChanged;
                buyersId.Text = id;
                tb_buyersname.Text = commpanyName;
                tb_buyerstaxnumber.Text = taxNumber;
                tb_buyersaddress.Text = address;
                tb_buyersbank.Text = bank;
                this.tb_buyersname.TextChanged += tb_buyersname_TextChanged;
            }
            else
            {
                this.tb_sellersname.TextChanged -= tb_sellersname_TextChanged;
                sellersId.Text = id;
                tb_sellersname.Text = commpanyName;
                tb_sellerstaxnumber.Text = taxNumber;
                tb_sellersaddress.Text = address;
                tb_sellersbank.Text = bank;
                this.tb_sellersname.TextChanged += tb_sellersname_TextChanged;
            }

            
        }

        private void tb_sellersname_TextChanged(object sender, EventArgs e)
        {
            keyWord = tb_sellersname.Text;
            DisplayListView();
        }

        //显示逐步提示
        private void DisplayListView()
        {
            //从数据库获取数据
            DataTable dataTable = new DataTable();
            
            FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] sqlCommand = new[] { "SELECT id,commpanyname, taxnumber, address, bank FROM commpanyinfo WHERE commpanyname LIKE '%" + keyWord + "%'" };
            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);
            dataTable = query.DataTable;

            //实例化逐步提示窗体并赋值给listview
            if (_stepPrompt == null || _stepPrompt.IsDisposed == true)
            {
                _stepPrompt = new StepPrompt(CommpanyInfo);
            }
            _stepPrompt.ListViewItemsValue(dataTable);
            _stepPrompt.TopMost = true;
            Point p = new Point(tb_buyersname.Width, 0);
            _stepPrompt.Location = tb_buyersname.PointToScreen(p);
            _stepPrompt.Show();
            dataTable.Dispose();
        }

        //窗体启动初始化datagridview
        private void Form_InVoiceEntry_Load(object sender, EventArgs e)
        {
            DataGridViewColumn dgvcolumn = new DataGridViewColumn();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Width = 183;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "货物或应税劳务、服务名称";
            dataGridView1.Columns[1].Name = "规格型号";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "单位";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Name = "数量";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Name = "单价(含税)";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Name = "金额(含税)";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Name = "税率";
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Name = "税额";
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Size = new Size(1200,768);
            this.AutoScroll = true;
        }

        #region 插入或修改数据

        //保存数据
        private void tsbtn_submit_Click(object sender, EventArgs e)
        {

            if (CheckIsEmpty() == false) return;

            int rowCount = dataGridView1.RowCount;
            int columnCount = dataGridView1.ColumnCount;
            List<Model.InvoiceInfo> list = new List<Model.InvoiceInfo>();
            for (int i = 0; i < rowCount; i++)
            {
                Model.InvoiceInfo invoiceInfo = new Model.InvoiceInfo();

                invoiceInfo.Invoicecode = tb_invoicecode.Text;
                invoiceInfo.Invoicenumber = tb_invoicenumber.Text;
                invoiceInfo.Date = dtp_date.Text;
                invoiceInfo.Buyersid = Convert.ToInt32(buyersId.Text);

                invoiceInfo.Productname = dataGridView1.Rows[i].Cells[0].Value.ToString();
                invoiceInfo.Productnumber = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                invoiceInfo.Unitprice = dataGridView1.Rows[i].Cells[4].Value.ToString();
                invoiceInfo.Money = dataGridView1.Rows[i].Cells[5].Value.ToString();
                invoiceInfo.Taxrate = dataGridView1.Rows[i].Cells[6].Value.ToString();
                invoiceInfo.Taxamount = dataGridView1.Rows[i].Cells[7].Value.ToString();

                invoiceInfo.Totalamount = tb_totalamount.Text;
                invoiceInfo.Totaltaxamount = tb_totaltaxamount.Text;
                invoiceInfo.Moneyupper = tb_moneyupper.Text;
                invoiceInfo.Moneylow = tb_moneylow.Text;
                invoiceInfo.Sellersid = Convert.ToInt32(sellersId.Text);
                invoiceInfo.Comment = tb_comment.Text;
                invoiceInfo.Payee = tb_payee.Text;
                invoiceInfo.Check = tb_check.Text;
                invoiceInfo.Drawer = tb_drawer.Text;
                invoiceInfo.Invoicestate = cbb_invoiceStatus.Text;
                invoiceInfo.Returnmoney = tb_returnMoney.Text;
                invoiceInfo.Flag = "0";  //删除标记 0 没有删除 1 已经删除
                list.Add(invoiceInfo);
            }

            InvoiceInfoBLL invoiceInfoBll = new InvoiceInfoBLL();
            MessageBox.Show(invoiceInfoBll.SaveInvoiceInfo(ActiveForm.Text, list));

            tb_buyersname.TextChanged -= new EventHandler(tb_buyersname_TextChanged);
            tb_sellersname.TextChanged -= new EventHandler(tb_sellersname_TextChanged);
            foreach (Control tb in panel1.Controls)
            {
                if (tb.GetType().ToString().Contains("TextBox")) tb.Text = "";
            }

            while (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }

            tb_buyersname.TextChanged += new EventHandler(tb_buyersname_TextChanged);
            tb_sellersname.TextChanged += new EventHandler(tb_sellersname_TextChanged);
        }

        #endregion


        #region 检查是否有必填项为空

        /// <summary>
        /// 检查是否有必填项为空
        /// </summary>
        /// <returns>返回一个真或假</returns>
        private bool CheckIsEmpty()
        {
            if (string.IsNullOrEmpty(tb_invoicecode.Text.Trim()))
            {
                MessageBox.Show("发票编号不得为空！");
                tb_invoicecode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tb_invoicecode.Text.Trim()))
            {
                MessageBox.Show("发票号码不得为空！");
                tb_invoicenumber.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tb_buyersname.Text.Trim()))
            {
                MessageBox.Show("购货方不得为空！");
                tb_buyersname.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tb_sellersname.Text.Trim()))
            {
                MessageBox.Show("销售方不得为空！");
                tb_sellersname.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbb_invoiceStatus.Text.Trim()))
            {
                MessageBox.Show("发票状态不得为空！");
                cbb_invoiceStatus.Focus();
                return false;
            }

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("产品明细不得为空！");
                return false;
            }

            return true;
        }

        #endregion


        private void Form_InVoiceEntry_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
        }

        #region 点击窗体右上角X提示

        // 窗体×掉提示
        private void Form_InVoiceEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认关闭窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region 按钮点击关闭窗体

        //窗体关闭
        private void tsbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
