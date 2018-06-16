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
    public partial class AddCustomerInfo : Form
    {
        public AddCustomerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = new String[6];

            str[0] = textBox1.Text.Trim();
            str[1] = textBox2.Text.Trim();
            str[2] = textBox3.Text.Trim();
            str[3] = textBox4.Text.Trim();
            str[4] = textBox5.Text.Trim();
            str[5] = textBox6.Text.Trim();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == 0)
                {
                    MessageBox.Show("信息没有填写完整！");
                    return;
                }
            }

            string FileDir = "Data Source = " + Environment.CurrentDirectory + @"\gyyy.db";
            string[] sqlCommand = new[] { "INSERT INTO commpanyinfo VALUES(NULL,'" + str[0] + "','" + str[1] + "','" + str[2]+ "','" 
                                          + str[3] + "','" + str[4] + "','" + str[5] + "')" };



            Query query = new Query(FileDir, DB.DbType.Sqlite);
            query.Execute(sqlCommand);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddCustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
