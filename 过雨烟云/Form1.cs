using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DB;
using commpanyInfo = 过雨烟云.commpanyInfo;

namespace 过雨烟云
{
    public delegate String GetInfo();
    public partial class Form1 : Form
    {
        private commpanyInfo _commpany= null;
        private InVoiceInfo _inVoiceInfo = null;
        private CommpanyInfoModify _commpanyInfoModify = null;

        public commpanyInfo CommpanyInfo { get => _commpany; set => _commpany = value; }
        public InVoiceInfo InVoiceInfo { get => _inVoiceInfo; set => _inVoiceInfo = value; }
        public CommpanyInfoModify CommpanyInfoModify { get => _commpanyInfoModify; set => _commpanyInfoModify = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void 发票录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_InVoiceEntry inVoiceEntry = new Form_InVoiceEntry();
            inVoiceEntry.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }

        private void 基础信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CommpanyInfo == null || CommpanyInfo.IsDisposed == true)
            {
                CommpanyInfo = new commpanyInfo();
                ToolStripStatusLabel tsslLabel = new ToolStripStatusLabel
                {
                    Name = "ss_commpanyInfo",
                    Size = new Size(35, 20),
                    Text = "单位信息"

                };
                statusStrip1.Items.AddRange(new ToolStripItem[]{
                    tsslLabel
                });
            }
            CommpanyInfo.MdiParent = this;
            CommpanyInfo.FormBorderStyle = FormBorderStyle.None;
            CommpanyInfo.Dock = DockStyle.Fill;

            if (ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Visible = false;
            }
            CommpanyInfo.Show();
            toolStrip1.Visible = true;
        }

        private void 发票录入ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formInvoice = new Form();
            formInvoice.Text = "发票信息";
            formInvoice.Name = "InvioceInfo";

            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;

            formInvoice.Controls.Add(dataGridView);
            formInvoice.MdiParent = this;
            formInvoice.Dock = DockStyle.Fill;
            formInvoice.FormBorderStyle = FormBorderStyle.None;
            

            //从数据库获取数据
            DataTable dataTable = new DataTable();

            string FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] sqlCommand = new[] { "SELECT id, a.invoicecode AS '发票代码', a.invoicenumber AS '发票号码', a.date AS '日期', " +
                                          "b.commpanyname AS '单位名称', b.taxnumber AS '纳税人税号', b.address AS '地址电话'," +
                                          "b.bank AS '开户行及帐号', a.productname AS '货物名称', a.unitprice AS '单价', a.money AS '金额'，" +
                                          "a.taxrate AS '税率', a.taxamount AS '税额', a.  FROM invoiceinfo" };
            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);
            dataTable = query.DataTable;


            formInvoice.Show();
            //============================================================
            //if (InVoiceInfo == null || InVoiceInfo.IsDisposed == true)
            //{
            //    InVoiceInfo = new InVoiceInfo();
            //}

            //InVoiceInfo.MdiParent = this;
            //InVoiceInfo.Dock = DockStyle.Fill;
            //if (ActiveMdiChild != null)
            //{
            //    this.ActiveMdiChild.Visible = false;
            //}

            //InVoiceInfo.FormBorderStyle = FormBorderStyle.None;
            //InVoiceInfo.Show();

        }

        private void tsbtn_add_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                return;
            }

            if (ActiveMdiChild.Text == "单位信息")
            {
                AddCustomerInfo addCustomerInfo = new AddCustomerInfo(CommpanyInfo);
                addCustomerInfo.ShowDialog();
            }

            
        }



        private void tsbtn_modify_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild == null) return;

            int dgvIndex = 0;
            int dgvColumnCount = 0;
            int dgvRowCount = 0;
            string[] str;

            switch (ActiveMdiChild.Name)
            {
                case "commpanyInfo":
                    dgvIndex = CommpanyInfo.dgv.CurrentRow.Index;
                    dgvColumnCount = CommpanyInfo.dgv.ColumnCount;

                    str = new string[dgvColumnCount + 1];
                    str[0] = (dgvIndex + 1).ToString();
                    for (int i = 1; i < str.Length; i++)
                    {
                        str[i] = CommpanyInfo.dgv.Rows[dgvIndex].Cells[i - 1].Value.ToString();
                    }
                    if(CommpanyInfoModify == null || CommpanyInfoModify.IsDisposed == true) CommpanyInfoModify = new CommpanyInfoModify(CommpanyInfo);
                    CommpanyInfoModify.TextBoxAssignment(str);
                    CommpanyInfoModify.ShowDialog();

                    break;
                case "InVoiceInfo":
                    dgvIndex = InVoiceInfo.dgv.CurrentRow.Index;
                    dgvColumnCount = CommpanyInfo.dgv.ColumnCount;

                    str = new string[dgvColumnCount + 1];
                    str[0] = (dgvIndex + 1).ToString();
                    for (int i = 1; i < str.Length; i++)
                    {
                        str[i] = CommpanyInfo.dgv.Rows[dgvIndex].Cells[i - 1].Value.ToString();
                    }
                    if (CommpanyInfoModify == null || CommpanyInfoModify.IsDisposed == true) CommpanyInfoModify = new CommpanyInfoModify(CommpanyInfo);
                    CommpanyInfoModify.TextBoxAssignment(str);
                    CommpanyInfoModify.ShowDialog();
                    break;
            }
        }

        private void tsbtn_query_Click(object sender, EventArgs e)
        {
           CommpanyInfoQuery commpanyInfoQuery = new CommpanyInfoQuery(CommpanyInfo);
            commpanyInfoQuery.ShowDialog();

        }
    }
}
