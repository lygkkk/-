using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Model;
namespace DAL
{
    public class InvoiceInfoDAL
    {
        public int AddInvoiceInfo(InvoiceInfo invoiceInfo)
        {
            String sql = "INSERT INTO invoiceinfo VALUES(@invoicecode, @invoicenumber, @date, @buyersid, @productname,@productnumber, @unitprice, @money, " +
                         "@taxrate, @taxamount, @totalamount, @totaltaxamount, @moneyupper, @moneylow, @sellersid, @comment, @payee, @check, @drawer, " +
                         "@invoicestate, @returnmoney) ";
            return AddAndUpdateInvoiceInfo(1, sql, invoiceInfo);
        }

        private int AddAndUpdateInvoiceInfo(int tmp, string sql, InvoiceInfo invoiceInfo )
        {
            SQLiteParameter[] sqLiteParameter =
            {
                new SQLiteParameter("@invoicecode", invoiceInfo.Invoicecode),
                new SQLiteParameter("@invoicenumber", invoiceInfo.Invoicenumber),
                new SQLiteParameter("@date", invoiceInfo.Date),
                new SQLiteParameter("@buyersid", invoiceInfo.Buyersid),
                new SQLiteParameter("@productname", invoiceInfo.Productname),
                new SQLiteParameter("@productnumber", invoiceInfo.Productnumber),
                new SQLiteParameter("@unitprice", invoiceInfo.Unitprice),
                new SQLiteParameter("@money", invoiceInfo.Money),
                new SQLiteParameter("@taxrate", invoiceInfo.Taxrate),
                new SQLiteParameter("@taxamount", invoiceInfo.Taxamount),
                new SQLiteParameter("@totalamount", invoiceInfo.Totalamount),
                new SQLiteParameter("@totaltaxamount", invoiceInfo.Totaltaxamount),
                new SQLiteParameter("@moneyupper", invoiceInfo.Moneyupper),
                new SQLiteParameter("@moneylow", invoiceInfo.Moneylow),
                new SQLiteParameter("@sellersid", invoiceInfo.Sellersid),
                new SQLiteParameter("@comment", invoiceInfo.Comment),
                new SQLiteParameter("@payee", invoiceInfo.Payee),
                new SQLiteParameter("@check", invoiceInfo.Check),
                new SQLiteParameter("@drawer", invoiceInfo.Drawer),
                new SQLiteParameter("@invoicestate", invoiceInfo.Invoicestate),
                new SQLiteParameter("@returnmoney", invoiceInfo.Returnmoney),
            };

            List<SQLiteParameter> list = new List<SQLiteParameter>();
            list.AddRange(sqLiteParameter);

            if (tmp == 1)
            {
                list.Add(new SQLiteParameter("@id", "NULL"));
            }else if (tmp == 2)
            {
                list.Add(new SQLiteParameter("@id", invoiceInfo.Id));
            }

            return SqliteConn.ExecuteNonQuery(sql,list.ToArray());
        }
    }
}