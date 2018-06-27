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
        public DataTable dt = null;         //存放发票明细的所有字段信息
        public DataTable dt1 = null;        //存放发票明细的基本信息 不包含DGV的内容
        private string keyWord;
        Bitmap bm;
        Point point;
        public Form_InVoiceEntry()
        {
            InitializeComponent();
        }

        private string _fileDir;

        public string FileDir { get => _fileDir; set => _fileDir = value; }


        #region 不知道啥玩意
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
        #endregion

        #region 逐步提示 判断购买方或销售方 把公司信息自动填充到单元格
        //判断购买方或销售方 把公司信息自动填充到单元格
        private void CommpanyInfo(string id, string commpanyName, string taxNumber, string address, string bank)
        {
            if (tsbtn_submit.Text == "新增")
            {
                if (ActiveControl.Parent.Name == "tb_buyersname")
                {
                    lb_buyersid.Text = id;
                    tb_buyersname.Text = commpanyName;
                    tb_buyerstaxnumber.Text = taxNumber;
                    tb_buyersaddress.Text = address;
                    tb_buyersbank.Text = bank;
                }
                else if (ActiveControl.Parent.Name == "tb_sellersname")
                {
                    lb_sellersid.Text = id;
                    tb_sellersname.Text = commpanyName;
                    tb_sellerstaxnumber.Text = taxNumber;
                    tb_sellersaddress.Text = address;
                    tb_sellersbank.Text = bank;
                }
            }
            else if (tsbtn_submit.Text == "修改")
            {
                if (ActiveControl.Parent.Name == "tb_buyersname")
                {

                    dt1.Rows[0]["buyersid"] = id;
                    dt1.Rows[0]["buyersname"] = commpanyName;
                    dt1.Rows[0]["buyerstaxnumber"] = taxNumber;
                    dt1.Rows[0]["buyersaddress"] = address;
                    dt1.Rows[0]["buyersbank"] = bank;


                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    if(dt.Rows[i].RowState == DataRowState.Deleted) continue;

                    //    dt.Rows[i]["buyersid"] = id;
                    //    dt.Rows[i]["buyersname"] = commpanyName;
                    //    dt.Rows[i]["buyerstaxnumber"] = taxNumber;
                    //    dt.Rows[i]["buyersaddress"] = address;
                    //    dt.Rows[i]["buyersbank"] = bank;
                    //}
                }
                else if(ActiveControl.Parent.Name == "tb_sellersname")
                {
                    dt1.Rows[0]["sellersid"] = id;
                    dt1.Rows[0]["sellersname"] = commpanyName;
                    dt1.Rows[0]["sellerstaxnumber"] = taxNumber;
                    dt1.Rows[0]["sellersaddress"] = address;
                    dt1.Rows[0]["sellersbank"] = bank;
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    //    dt.Rows[i]["sellersid"] = id;
                    //    dt.Rows[i]["sellersname"] = commpanyName;
                    //    dt.Rows[i]["sellerstaxnumber"] = taxNumber;
                    //    dt.Rows[i]["sellersaddress"] = address;
                    //    dt.Rows[i]["sellersbank"] = bank;
                    //}
                }
            }
        }
        #endregion

        #region 显示逐步提示窗体
        //显示逐步提示
        public void DisplayListView(object sender, EventArgs e)
        {
            //从数据库获取数据
            DataTable dataTable = new DataTable();
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                keyWord = tb.Text;
            }
            else
            {
                keyWord = "";
            }
            FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] sqlCommand = new[] { "SELECT id,commpanyname, taxnumber, address, bank FROM commpanyinfo WHERE commpanyname LIKE '%" + keyWord + "%'" };
            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);
            dataTable = query.DataTable;

            //实例化逐步提示窗体并赋值给listview
            if (_stepPrompt == null || _stepPrompt.IsDisposed == true)
            {
                _stepPrompt = new StepPrompt(CommpanyInfo, DisplayListView);
            }
            _stepPrompt.ListViewItemsValue(dataTable);
            _stepPrompt.TopMost = true;
            Point p = new Point(tb_buyersname.Width, 0);
            _stepPrompt.Location = tb_buyersname.PointToScreen(p);
            _stepPrompt.Location = tb_buyersname.PointToScreen(p);
            _stepPrompt.Show();
            dataTable = null;
        }
        #endregion

        #region 窗体加载
        //窗体启动初始化datagridview
        private void Form_InVoiceEntry_Load(object sender, EventArgs e)
        {
            CreateButton(tb_buyersname);
            CreateButton(tb_sellersname);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Size = new Size(1200, 768);
            this.AutoScroll = true;

            dt1 = dt.Copy();
            if (dt1.Rows.Count > 1)
            {
                for (int i = 1; i < dt1.Rows.Count; i++)
                {
                    dt1.Rows[i].Delete();
                }
            }

            if (this.Text == "发票修改")
            {
                int charIndexOf = -1;
                foreach (Control ctl in panel1.Controls)
                {
                    charIndexOf = ctl.Name.IndexOf("_") + 1;
                    if (charIndexOf != 0)
                    {
                        ctl.DataBindings.Add("Text", dt1, ctl.Name.Substring(ctl.Name.IndexOf("_") + 1), false, DataSourceUpdateMode.OnPropertyChanged);
                    }
                }

                dataGridView1.DataSource = dt;
                tsbtn_submit.Text = "修改";
            }

        }
        #endregion

        #region 点击按钮 新增或修改数据

        //保存数据
        private void tsbtn_submit_Click(object sender, EventArgs e)
        {
            if (CheckIsEmpty() == false) return;

            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if (tsbtn_submit.Text == "修改")
            {
                InvoiceInfoBLL invoiceInfoBll = new InvoiceInfoBLL();
                MessageBox.Show(invoiceInfoBll.ModifyData(dt, dt1));

                return;
            }

            if (tsbtn_submit.Text == "新增")
            {
                

                int rowCount = dataGridView1.RowCount;
                int columnCount = dataGridView1.ColumnCount;
                List<Model.InvoiceInfo> list = new List<Model.InvoiceInfo>();
                for (int i = 0; i < rowCount; i++)
                {
                    Model.InvoiceInfo invoiceInfo = new Model.InvoiceInfo();

                    invoiceInfo.Invoicecode = tb_invoicecode.Text;
                    invoiceInfo.Invoicenumber = tb_invoicenumber.Text;
                    invoiceInfo.Date = dtp_date.Value.ToString("yyyy-MM-dd");
                    invoiceInfo.Buyersid = Convert.ToInt32(lb_buyersid.Text);
                    
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
                    invoiceInfo.Sellersid = Convert.ToInt32(lb_sellersid.Text);
                    invoiceInfo.Comment = tb_comment.Text;
                    invoiceInfo.Payee = tb_payee.Text;
                    invoiceInfo.Check = tb_check.Text;
                    invoiceInfo.Drawer = tb_drawer.Text;
                    invoiceInfo.Invoicestate = cbb_invoicestate.Text;
                    invoiceInfo.Returnmoney = tb_returnMoney.Text;
                    invoiceInfo.Flag = "0";  //删除标记 0 没有删除 1 已经删除
                    list.Add(invoiceInfo);
                }

                InvoiceInfoBLL invoiceInfoBll = new InvoiceInfoBLL();
                MessageBox.Show(invoiceInfoBll.SaveInvoiceInfo("发票新增", list));

                //清空所有控件的内容
                foreach (Control tb in panel1.Controls)
                {
                    if (tb.GetType().ToString().Contains("TextBox")) tb.Text = "";
                }

                //新增提交后 清空DGV行
                while (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }


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

            if (string.IsNullOrEmpty(cbb_invoicestate.Text.Trim()))
            {
                MessageBox.Show("发票状态不得为空！");
                cbb_invoicestate.Focus();
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

        #region 窗体尺寸事件
        private void Form_InVoiceEntry_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
        }
        #endregion

        #region 点击窗体右上角X提示

        // 窗体×掉提示
        private void Form_InVoiceEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认关闭窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //DataMoify.dt.Rows.Clear();
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

        #region 点击提交按钮 用于新增或者修改信息
        /// <summary>
        /// 点击提交按钮 用于新增或者修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int rowNum = 0;
            if (tsbtn_submit.Text == "新增")
            {
                dataGridView1.Rows.Add();
                rowNum = dataGridView1.RowCount - 1;
                dataGridView1["id", rowNum].Value = "1";
                dataGridView1.Rows[rowNum].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = rowNum;
                return;
            }

            if (tsbtn_submit.Text == "修改")
            {
                dt.Rows.Add();
               

                dt.Rows[dt.Rows.Count - 1]["id"] = dt.Rows[0]["id"];
                dt.Rows[dt.Rows.Count - 1]["invoicecode"] = dt.Rows[0]["invoicecode"];
                dt.Rows[dt.Rows.Count - 1]["invoicenumber"] = dt.Rows[0]["invoicenumber"];
                dt.Rows[dt.Rows.Count - 1]["date"] = dt.Rows[0]["date"];
                dt.Rows[dt.Rows.Count - 1]["totalamount"] = dt.Rows[0]["totalamount"];
                dt.Rows[dt.Rows.Count - 1]["totaltaxamount"] = dt.Rows[0]["totaltaxamount"];
                dt.Rows[dt.Rows.Count - 1]["moneyupper"] = dt.Rows[0]["moneyupper"];
                dt.Rows[dt.Rows.Count - 1]["moneylow"] = dt.Rows[0]["moneylow"];
                dt.Rows[dt.Rows.Count - 1]["comment"] = dt.Rows[0]["comment"];
                dt.Rows[dt.Rows.Count - 1]["payee"] = dt.Rows[0]["payee"];
                dt.Rows[dt.Rows.Count - 1]["check"] = dt.Rows[0]["check"];
                dt.Rows[dt.Rows.Count - 1]["drawer"] = dt.Rows[0]["drawer"];
                dt.Rows[dt.Rows.Count - 1]["invoicestate"] = dt.Rows[0]["invoicestate"];
                dt.Rows[dt.Rows.Count - 1]["returnmoney"] = dt.Rows[0]["returnmoney"];



                dt.Rows[dt.Rows.Count - 1]["buyersid"] = dt.Rows[0]["buyersid"];
                dt.Rows[dt.Rows.Count - 1]["buyersname"] = dt.Rows[0]["buyersname"];
                dt.Rows[dt.Rows.Count - 1]["buyerstaxnumber"] = dt.Rows[0]["buyerstaxnumber"];
                dt.Rows[dt.Rows.Count - 1]["buyersaddress"] = dt.Rows[0]["buyersaddress"];
                dt.Rows[dt.Rows.Count - 1]["buyersbank"] = dt.Rows[0]["buyersbank"];

                dt.Rows[dt.Rows.Count - 1]["sellersid"] = dt.Rows[0]["sellersid"];
                dt.Rows[dt.Rows.Count - 1]["sellersname"] = dt.Rows[0]["sellersname"];
                dt.Rows[dt.Rows.Count - 1]["sellerstaxnumber"] = dt.Rows[0]["sellerstaxnumber"];
                dt.Rows[dt.Rows.Count - 1]["sellersaddress"] = dt.Rows[0]["sellersaddress"];
                dt.Rows[dt.Rows.Count - 1]["sellersbank"] = dt.Rows[0]["sellersbank"];

                return;
            }
        }
        #endregion

        #region 删除DGV一行
        /// <summary>
        /// 删除一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.tsbtn_submit.Text == "新增")
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                return;
            }

            if (this.tsbtn_submit.Text == "修改")
            {
                if (dt.Rows.Count > 1)
                {
                    dt.Rows[dataGridView1.CurrentRow.Index].Delete();
                }
                return;
            }
        }
        #endregion

        #region 生成一个TextBox内置的Button按钮
        private void CreateButton(Control ctl)
        {
            Button btn = new Button();
            btn.Text = "...";
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Font = new Font("微软雅黑", 9);
            ctl.Controls.Add(btn);
            btn.BackColor = Color.LightGray;
            btn.TabStop = false;
            btn.Width = 30;
            btn.Height = ctl.Height - 4;
            btn.Top = 2;
            btn.Left = ctl.Width - 32;
            btn.Cursor = DefaultCursor;
            
            btn.Click += new EventHandler(DisplayListView);
        }
        #endregion


        #region 值改变的事件触发
        /// <summary>
        /// 内容修改后修改数据源方法
        /// </summary>
        /// <param name="ctlText">控件Text的名称</param>
        /// <param name="val">控件的值</param>
        private void ValueChange(string ctlText, string val)
        {
            //int rowCount;
            //rowCount = dataGridView1.RowCount;
            //dt.Rows[]
        }
        #endregion

        private void tb_returnMoney_TextChanged(object sender, EventArgs e)
        {
            //ValueChange("returnmoney", tb_returnMoney.Text);
        }
    }
}
