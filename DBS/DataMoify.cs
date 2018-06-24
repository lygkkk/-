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
            dcArray[0].ColumnName = "invicecode";
            dcArray[1].ColumnName = "invicenumber";
            dcArray[2].ColumnName = "date";

            dcArray[3].ColumnName = "buyersid";
            dcArray[4].ColumnName = "buyersname";
            dcArray[5].ColumnName = "buyerstaxnumber";
            dcArray[6].ColumnName = "buyersaddress";
            dcArray[7].ColumnName = "buyersbank";

            dcArray[8].ColumnName = "totalamount";
            dcArray[9].ColumnName = "totaleaxamount";
            dcArray[10].ColumnName = "moneyupper";
            dcArray[11].ColumnName = "moneylower";
            dcArray[12].ColumnName = "moneylower";

            dcArray[13].ColumnName = "sellersid";
            dcArray[14].ColumnName = "sellersname";
            dcArray[15].ColumnName = "sellerstaxnumber";
            dcArray[16].ColumnName = "sellersaddress";
            dcArray[17].ColumnName = "sellersbank";

            dcArray[18].ColumnName = "comment";
            dcArray[19].ColumnName = "payee";
            dcArray[20].ColumnName = "check";
            dcArray[21].ColumnName = "drawer";

            dt.Columns.AddRange(dcArray);

           

        }


    }
}
