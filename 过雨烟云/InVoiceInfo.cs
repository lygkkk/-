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
            /*

            //从数据库获取数据
            DataTable dataTable = new DataTable();

            string FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] sqlCommand = new[] { "SELECT * FROM commpanyinfo" };
            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);
            dataTable = query.DataTable;



            DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "acCode";
            acCode.DataPropertyName = "acCode";
            acCode.HeaderText = "A/C Code";
            dataGridView1.Columns.Add(acCode);


            //DataGridViewColumn[] dgvColumn = new DataGridViewColumn[{
            //    "1",
            //}];
            //dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] {
            //    "idColumn", titleColumn, subTitleColumn,
            //    summaryColumn, contentColumn });

            dataGridView1.Rows.Add(dataTable.Rows.Count);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView1.RowHeadersWidth = 50;
                for (int j = 1; j < dataTable.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j - 1].Value = dataTable.Rows[i][j];
                }
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            this.FormBorderStyle = FormBorderStyle.None;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            */
        }
    }
}
