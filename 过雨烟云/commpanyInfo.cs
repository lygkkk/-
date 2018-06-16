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
    public partial class commpanyInfo : Form
    {
        public commpanyInfo()
        {
            InitializeComponent();
        }

        public DataGridView dgv
        {
            get { return dataGridView1;}
            set { dataGridView1 = value; }
        }

        private void commpanyInfo_load(object sender, EventArgs e)
        {
            //从数据库获取数据
            DataTable dataTable = new DataTable();

            string FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] sqlCommand = new[] { "SELECT * FROM commpanyinfo" };
            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);
            dataTable = query.DataTable;

 
            dataGridView1.Rows.Add(dataTable.Rows.Count);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView1.RowHeadersWidth = 60;
                for (int j = 1; j < dataTable.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j - 1].Value = dataTable.Rows[i][j];
                } 
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
