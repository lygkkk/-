using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 过雨烟云
{
    public partial class InvoiceInfo : Form
    {

        internal DataGridView dgv
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }

        }

        public InvoiceInfo()
        {
            InitializeComponent();
        }

        private void InVoiceInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceInfoBLL invoiceInfoBll = new InvoiceInfoBLL();
            Form_InVoiceEntry inVoiceEntry = new Form_InVoiceEntry();
            DataTable dt = invoiceInfoBll.GetInvoiceNumberDetail(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            inVoiceEntry.ShowDialog();


            MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
