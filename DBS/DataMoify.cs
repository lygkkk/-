using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS
{
    public static class DataMoify
    {
        public static DataTable dt = new DataTable();

        public static void InvoiceDataMoify()
        {
            DataColumn[] dcArray = new DataColumn[21];


            dt.Columns.AddRange(dcArray);

            dt.Columns.Add(new DataColumn("invoicecode"));
            dt.Columns.Add(new DataColumn("invoicenumber"));
            dt.Columns.Add(new DataColumn("date"));
            dt.Columns.Add(new DataColumn("buyersid"));
            dt.Columns.Add(new DataColumn("buyersname"));
            dt.Columns.Add(new DataColumn("buyerstaxnumber"));
            dt.Columns.Add(new DataColumn("buyersaddress"));
            dt.Columns.Add(new DataColumn("buyersbank"));
            dt.Columns.Add(new DataColumn("totalamount"));
            dt.Columns.Add(new DataColumn("totaltaxamount"));
            dt.Columns.Add(new DataColumn("moneyupper"));
            dt.Columns.Add(new DataColumn("moneylow"));
            dt.Columns.Add(new DataColumn("sellersid"));
            dt.Columns.Add(new DataColumn("sellersname"));
            dt.Columns.Add(new DataColumn("sellerstaxnumber"));
            dt.Columns.Add(new DataColumn("sellersaddress"));
            dt.Columns.Add(new DataColumn("sellersbank"));
            dt.Columns.Add(new DataColumn("comment"));
            dt.Columns.Add(new DataColumn("payee"));
            dt.Columns.Add(new DataColumn("check"));
            dt.Columns.Add(new DataColumn("drawer"));
            dt.Columns.Add(new DataColumn("invoicestatus"));
            dt.Columns.Add(new DataColumn("returnmoney"));

            dt.Columns.Add(new DataColumn("id"));
            dt.Columns.Add(new DataColumn("productname"));
            dt.Columns.Add(new DataColumn("productnumber"));
            dt.Columns.Add(new DataColumn("unitprice"));
            dt.Columns.Add(new DataColumn("money"));
            dt.Columns.Add(new DataColumn("taxrate"));
            dt.Columns.Add(new DataColumn("taxamount"));
            


            //dcArray[0].ColumnName = "invicecode";
            //dcArray[1].ColumnName = "invicenumber";
            //dcArray[2].ColumnName = "date";

            //dcArray[3].ColumnName = "buyersid";
            //dcArray[4].ColumnName = "buyersname";
            //dcArray[5].ColumnName = "buyerstaxnumber";
            //dcArray[6].ColumnName = "buyersaddress";
            //dcArray[7].ColumnName = "buyersbank";

            //dcArray[8].ColumnName = "totalamount";
            //dcArray[9].ColumnName = "totaleaxamount";
            //dcArray[10].ColumnName = "moneyupper";
            //dcArray[11].ColumnName = "moneylower";
            //dcArray[12].ColumnName = "moneylower";

            //dcArray[13].ColumnName = "sellersid";
            //dcArray[14].ColumnName = "sellersname";
            //dcArray[15].ColumnName = "sellerstaxnumber";
            //dcArray[16].ColumnName = "sellersaddress";
            //dcArray[17].ColumnName = "sellersbank";

            //dcArray[18].ColumnName = "comment";
            //dcArray[19].ColumnName = "payee";
            //dcArray[20].ColumnName = "check";
            //dcArray[21].ColumnName = "drawer";

            

           

        }


    }
}
