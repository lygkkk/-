using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI;

namespace BLL
{
    public class Class1
    {
         private UI.Class1 _class1 = null;
        private string _controlName;
        public string ControlName { get => _controlName; set => _controlName = value; }
        public Class1(string controlName)
        {
            ControlName = controlName;
            
            //Invoice.Form1 invoiceform1 = new Invoice.Form1();

            //invoiceform1.Form.Text = "sjb";
            //invoiceform1.Form.Show();
        }

        private void WhatFrameWork()
        {
            switch (ControlName)
            {
                case "基础信息":
                    _class1 = new UI.Class1();
                    
                    break;
                case "发票信息":
                    _class1 = new UI.Class1();
                    _class1.InvoiceInfo();
                    break;
            }
        }

    }
}
