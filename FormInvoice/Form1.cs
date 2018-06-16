using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public class Form1
    {
        private Form _form = null;
        private string _formNmae;
        private string _formText;

        public Form Form { get => _form; set => _form = value; }

        public Form1()
        {
            Form = new Form();

            Form.Text = "新增";
            
        }

        private void NormalForm()
        {

        }
    }
}
