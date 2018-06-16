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

namespace 过雨烟云
{
    public partial class CommpanyInfoModify : Form
    {
        private commpanyInfo _commpanyInfo = null;

        public commpanyInfo CommpanyInfo { get => _commpanyInfo; set => _commpanyInfo = value; }

        public CommpanyInfoModify(commpanyInfo commpanyInfo)
        {
            CommpanyInfo = commpanyInfo;
            InitializeComponent();
        }

        private void CommpanyInfoModify_Load(object sender, EventArgs e)
        {

        }

        internal void TextBoxAssignment(string[] str)
        {
            label7.Text = str[0];
            textBox1.Text = str[1];
            textBox2.Text = str[2];
            textBox3.Text = str[3];
            textBox4.Text = str[4];
            textBox5.Text = str[5];
            textBox6.Text = str[6];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] tmp = new string[6];
            //string sql = "
            tmp[0] = textBox1.Text;
            tmp[1] = textBox2.Text;
            tmp[2] = textBox3.Text;
            tmp[3] = textBox4.Text;
            tmp[4] = textBox5.Text;
            tmp[5] = textBox6.Text;
            string[] sqlCommand = new[] 
                { "UPDATE commpanyinfo SET " 
                    +"commpanyname = '" + textBox1.Text 
                    + "', taxnumber = '" + textBox2.Text 
                    + "', address = '" + textBox3.Text 
                    + "', bank = '" + textBox4.Text 
                    + "', contact = '" + textBox5.Text
                    + "', phone = '" + textBox6.Text 
                    + "' WHERE id = " + int.Parse(label7.Text)
                };
            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);

            for (int i = 0; i < tmp.Length; i++)
            {
                //MessageBox.Show(CommpanyInfo.dgv.RowCount.ToString());
                CommpanyInfo.dgv.Rows[int.Parse(label7.Text) - 1].Cells[i].Value = tmp[i];
            }
            //CommpanyInfo.dgv.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
