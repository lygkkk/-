using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 过雨烟云
{
    public partial class CommpanyInfoQuery : Form
    {
        private commpanyInfo _commpanyInfo = null;
        public CommpanyInfoQuery(commpanyInfo commpanyInfo)
        {
            CommpanyInfo = commpanyInfo;
            InitializeComponent();
        }

        public commpanyInfo CommpanyInfo { get => _commpanyInfo; set => _commpanyInfo = value; }

        private void CommpanyInfoQuery_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            int rowCount = CommpanyInfo.dgv.RowCount - 1;
            int columnCount = CommpanyInfo.dgv.ColumnCount;

            for (int i = 0; i < columnCount; i++)
            {
                dataGridView1.Columns.Add(CommpanyInfo.dgv.Columns[i].Name, CommpanyInfo.dgv.Columns[i].HeaderText);
            }

            dataGridView1.Rows.Add(rowCount);
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView1.RowHeadersWidth = 60;
                for (int j = 0; j < columnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = CommpanyInfo.dgv.Rows[i].Cells[j].Value;
                }
            }


            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.ReadOnly = true;
            dataGridView1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DoubleClick += new EventHandler(dgvDouble_Click);
            textBox1.TextChanged += new EventHandler(Text_Change);
        }

        private void dgvDouble_Click(object send, EventArgs e)
        {
            CommpanyInfo.dgv.ClearSelection();
            CommpanyInfo.dgv.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            this.Dispose();
        }

        private void Text_Change(object send, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            int rowCount = dataGridView1.RowCount;

            if (str.Length == 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                return;
            }
            

            String str1;
            
            for (int i = 0; i < rowCount; i++)
            {
                str1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (str1.Contains(str))
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }

        }
    }
}
