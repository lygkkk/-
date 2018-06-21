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
using Model;
using BLL;

using commpanyInfo = 过雨烟云.commpanyInfo;

namespace 过雨烟云
{
    public delegate String GetInfo();
    public partial class Form1 : Form
    {
        private commpanyInfo _commpany= null;
        private InvoiceInfo _inVoiceInfo = null;
        private CommpanyInfoModify _commpanyInfoModify = null;
        private Form_InVoiceEntry _formInVoiceEntry = null;
        private Form _formInvoice = null;

        public commpanyInfo CommpanyInfo { get => _commpany; set => _commpany = value; }
        public InvoiceInfo InvoiceInfo { get => _inVoiceInfo; set => _inVoiceInfo = value; }
        public CommpanyInfoModify CommpanyInfoModify { get => _commpanyInfoModify; set => _commpanyInfoModify = value; }
        public Form_InVoiceEntry FormInVoiceEntry { get => _formInVoiceEntry; set => _formInVoiceEntry = value; }
        public Form FormInvoice { get => _formInvoice; set => _formInvoice = value; }


        public Form1()
        {
            InitializeComponent();
        }

        private void 发票录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form_InVoiceEntry inVoiceEntry = new Form_InVoiceEntry();
            //inVoiceEntry.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }

        #region 单位信息
        private void 基础信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CommpanyInfo == null || CommpanyInfo.IsDisposed == true)
            {
                CommpanyInfo = new commpanyInfo();
                Action initLabel = () => InitToolStripLabel("tssl_commpanyInfo", "单位信息");
                initLabel();

                CommpanyInfo.MdiParent = this;
                CommpanyInfo.FormBorderStyle = FormBorderStyle.None;
                CommpanyInfo.Dock = DockStyle.Fill;

                if (ActiveMdiChild != null) this.ActiveMdiChild.Visible = false;

                CommpanyInfo.Show();
                toolStrip1.Visible = true;

                if (statusStrip1.Items.Count > 1)
                {
                    for (int i = 0; i < statusStrip1.Items.Count - 1; i++)
                    {
                        statusStrip1.Items[i].BackColor = DefaultBackColor;
                    }
                }

                return;
            }

            if (CommpanyInfo != null)
            {
                Action setBackColor = () => SetStatusStripBackColor("tssl_commpanyInfo", "commpanyInfo");
                setBackColor();
                return;
            }
        }

        #endregion

        #region 发票信息

        private void 发票录入ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (InvoiceInfo == null || InvoiceInfo.IsDisposed == true)
            {
                InvoiceInfo = new InvoiceInfo();
                InvoiceInfo.Text = "发票信息";
                InvoiceInfo.Name = "InvoiceInfo";
                InvoiceInfo.MdiParent = this;
                InvoiceInfo.Dock = DockStyle.Fill;
                InvoiceInfo.FormBorderStyle = FormBorderStyle.None;

                Action initLabel = () => InitToolStripLabel("tssl_InvoiceInfo", "发票信息");
                initLabel();


                if (statusStrip1.Items.Count > 1)
                {
                    for (int i = 0; i < statusStrip1.Items.Count - 1; i++)
                    {
                        statusStrip1.Items[i].BackColor = DefaultBackColor;
                    }
                }

                InvoiceInfoBLL invoiceInfoBll = new InvoiceInfoBLL();
                InvoiceInfo.dgv.DataSource = invoiceInfoBll.GetAllInvoiceInfos();

                InvoiceInfo.Show();
                toolStrip1.Visible = true;
                return;
            }

            if (InvoiceInfo != null)
            {
                Action setBackColor = () => SetStatusStripBackColor("tssl_InvoiceInfo", "InvoiceInfo");
                setBackColor();
                return;
            }


        }

        #endregion

        #region 新增信息

        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tsbtn_add_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;

            switch (ActiveMdiChild.Text)
            {
                case "单位信息":
                    AddCustomerInfo addCustomerInfo = new AddCustomerInfo(CommpanyInfo);
                    addCustomerInfo.StartPosition = FormStartPosition.CenterScreen;
                    addCustomerInfo.ShowDialog();
                    break;
                case "发票信息":
                    FormInVoiceEntry = new Form_InVoiceEntry();
                    FormInVoiceEntry.StartPosition = FormStartPosition.CenterScreen;
                    FormInVoiceEntry.WindowState = FormWindowState.Maximized;
                    FormInVoiceEntry.Text = "发票新增";
                    FormInVoiceEntry.ShowDialog();
                    break;
            }
        }

        #endregion

        #region 修改数据

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tsbtn_modify_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;

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
                    if (CommpanyInfoModify == null || CommpanyInfoModify.IsDisposed == true) CommpanyInfoModify = new CommpanyInfoModify(CommpanyInfo);
                    CommpanyInfoModify.TextBoxAssignment(str);
                    CommpanyInfoModify.ShowDialog();

                    break;
                case "InvoiceInfo":
                    dgvIndex = InvoiceInfo.dgv.CurrentRow.Index;
                    dgvColumnCount = InvoiceInfo.dgv.ColumnCount;

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

        #endregion

        #region 数据查找

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_query_Click(object sender, EventArgs e)
        {
            CommpanyInfoQuery commpanyInfoQuery = new CommpanyInfoQuery(CommpanyInfo);
            commpanyInfoQuery.ShowDialog();
        }

        #endregion

        #region 显示子窗体信息

        /// <summary>
        /// 显示子窗体信息
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private void DisplayBaseInfo(object send, EventArgs e)
        {
            ToolStripLabel tmpLabel = (ToolStripLabel)send;
            string labelName = tmpLabel.Name;
            string formName = tmpLabel.Name.Substring(5);
            Action tmpAction = () => SetStatusStripBackColor(labelName, formName);
            tmpAction();
        }

        #endregion

        #region 修改StatusStripLable背景颜色

        /// <summary>
        /// 修改StatusStripLable背景颜色
        /// </summary>
        /// <param name="itemName">控件名称</param>
        /// <param name="mdiChildName">子窗体名称</param>
        private void SetStatusStripBackColor(string itemName, string mdiChildName)
        {
            foreach (ToolStripLabel item in statusStrip1.Items)
            {
                if (item.Name == itemName)
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = DefaultBackColor;
                }
            }

            foreach (Control control in this.MdiChildren)
            {
                if (control.Name == mdiChildName)
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            }
        }

        #endregion

        #region 初始化ToolStripLabel

        private void InitToolStripLabel(string name, string text)
        {
            ToolStripStatusLabel tsslLabel = new ToolStripStatusLabel
            {
                Name = name,
                Size = new Size(35, 20),
                Text = text,
                BackColor = Color.White,
                BorderSides = ToolStripStatusLabelBorderSides.Left,
                BorderStyle = Border3DStyle.Sunken
            };
            statusStrip1.Items.AddRange(new ToolStripItem[]{
                tsslLabel
            });

            statusStrip1.Items[name].Click += new EventHandler(DisplayBaseInfo);
        }

        #endregion

        #region 关闭子窗体

        private void tsbtn_close_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            statusStrip1.Items.Remove(statusStrip1.Items["tssl_" + ActiveMdiChild.Name]);
            ActiveMdiChild.Dispose();
            

            int itemCount = statusStrip1.Items.Count;
            //if (itemCount > 0) statusStrip1.Items[itemCount - 1].Select();
            if (itemCount <= 0) return;
            SetStatusStripBackColor(statusStrip1.Items[itemCount - 1].Name, statusStrip1.Items[itemCount - 1].Name.Substring(5));

            //MessageBox.Show(statusStrip1.Items[0].CanSelect.ToString());
        }

        #endregion

    }
}
