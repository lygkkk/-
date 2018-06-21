using System;

namespace Model
{
    public class InvoiceInfo
    {
        private int _id;
        private string _invoicecode;
        private string _invoicenumber;
        private string _date;
        private int _buyersid;
        private string _productname;
        private int _productnumber;
        private string _unitprice;
        private string _money;
        private string _taxrate;
        private string _taxamount;
        private string _totalamount;
        private string _totaltaxamount;
        private string _moneyupper;
        private string _moneylow;
        private int _sellersid;
        private string _comment;
        private string _payee;
        private string _check;
        private string _drawer;
        private string _invoicestate;
        private string _returnmoney;
        private string _flag;

        public int Id { get => _id; set => _id = value; }
        public string Invoicecode { get => _invoicecode; set => _invoicecode = value; }
        public string Invoicenumber { get => _invoicenumber; set => _invoicenumber = value; }
        public string Date { get => _date; set => _date = value; }
        public int Buyersid { get => _buyersid; set => _buyersid = value; }
        public string Productname { get => _productname; set => _productname = value; }
        public string Unitprice { get => _unitprice; set => _unitprice = value; }
        public string Money { get => _money; set => _money = value; }
        public string Taxrate { get => _taxrate; set => _taxrate = value; }
        public string Taxamount { get => _taxamount; set => _taxamount = value; }
        public string Moneyupper { get => _moneyupper; set => _moneyupper = value; }
        public string Moneylow { get => _moneylow; set => _moneylow = value; }
        public int Sellersid { get => _sellersid; set => _sellersid = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public string Payee { get => _payee; set => _payee = value; }
        public string Check { get => _check; set => _check = value; }
        public string Drawer { get => _drawer; set => _drawer = value; }
        public string Invoicestate { get => _invoicestate; set => _invoicestate = value; }
        public string Returnmoney { get => _returnmoney; set => _returnmoney = value; }
        public int Productnumber { get => _productnumber; set => _productnumber = value; }
        public string Totalamount { get => _totalamount; set => _totalamount = value; }
        public string Totaltaxamount { get => _totaltaxamount; set => _totaltaxamount = value; }
        public string Flag { get => _flag; set => _flag = value; }
    }
}