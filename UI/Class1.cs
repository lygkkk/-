using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public class Class1
    {
        private Form _form = null;
        public Form Form { get => _form; set => _form = value; }
        public Class1()
        {
            MessageBox.Show("");
        }

        

        public void InvoiceInfo()
        {
            Form = new Form();
            Form.Text = "发票信息";
            Form.Name = "InvoiceInfo";
            
            DataGridView dataGridView = new DataGridView();
            Form.Controls.Add(dataGridView);
        }
    }
}
