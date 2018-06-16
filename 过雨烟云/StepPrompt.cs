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
    public delegate void CommpanyInfo(string commpanyName, string taxNumber, string address, string bank );
    public partial class StepPrompt : Form
    {
        CommpanyInfo _commpanyInfor;
        public StepPrompt(CommpanyInfo commpanyInfo)
        {
            _commpanyInfor  = commpanyInfo;
            
            InitializeComponent();
        }

        public void ListViewItemsValue(DataTable dataTable)
        {
            ListViewItem listViewItem = new ListViewItem();
            

            listView1.Items.Clear();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                listViewItem = listView1.Items.Add(dataTable.Rows[i][0].ToString());
                listViewItem.SubItems.Add(dataTable.Rows[i][1].ToString());
                listViewItem.SubItems.Add(dataTable.Rows[i][2].ToString());
                listViewItem.SubItems.Add(dataTable.Rows[i][3].ToString());
            }
        }

        private void StepPrompt_Load(object sender, EventArgs e)
        {

            listView1.Columns[0].Width = 135;
            listView1.Columns[1].Width = 120;
            listView1.Columns[2].Width = 120;
            listView1.Columns[3].Width = 120;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _commpanyInfor(listView1.SelectedItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text, 
                            listView1.SelectedItems[0].SubItems[2].Text, listView1.SelectedItems[0].SubItems[3].Text);
            this.Dispose();
        }

    }
}
