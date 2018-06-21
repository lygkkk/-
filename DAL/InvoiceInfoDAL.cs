using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Model;
namespace DAL
{
    public class InvoiceInfoDAL
    {

        #region 获取所有发票信息的唯一项 不包含删除的

        /// <summary>
        /// 获取所有发票信息的唯一项 不包含删除的
        /// </summary>
        /// <returns>返回发票信息类实例的List</returns>
        public DataTable GetAllInvoiceInfos()
        {
            //string sql = "SELECT id, invoicecode, invoicenumber, date, buyersid, productname, productnumber, unitprice, money, taxrate, " +
            //             "taxamount, totalamount, totaltaxamount, moneyupper, moneylow, sellersid, comment, payee, \"check\", drawer, invoicestate, returnmoney " +
            //             "FROM invoiceinfo WHERE flag = '0' GROUP BY invoicenumber";

            string sql = "SELECT a.id, a.invoicecode, a.invoicenumber, a.date, a.buyersid, b.commpanyname, b.taxnumber, b.address, b.bank, " +
            "a.productname, a.productnumber, a.unitprice, a.money, a.taxrate, a.taxamount, a.totalamount, a.totaltaxamount, " +
            "a.moneyupper, a.moneylow, a.sellersid, c.commpanyname AS 销售方名称, c.taxnumber AS 销售方税号, c.address AS 销售方地址及电话, " +
                "c.bank AS 销售方开户行及帐号, a.comment, a.payee, a.\"check\", a.drawer, a.invoicestate, a.returnmoney FROM invoiceinfo AS a " +
                "LEFT OUTER JOIN commpanyinfo AS b ON a.buyersid = b.id LEFT OUTER JOIN commpanyinfo AS c ON a.sellersid = c.id WHERE flag = '0' " +
            "GROUP BY invoicenumber";

            DataTable dataTable = SqliteConn.ExecuteTable(sql);
            //List<InvoiceInfo> list = new List<InvoiceInfo>();
            //if (dataTable.Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dataTable.Rows)
            //    {
            //        list.Add(RowToinvoiceInfo(dr)); ;
            //    }
            //}
            return dataTable;
        }

        #endregion

        #region 双击发票信息某行 查看详细开票信息
        /// <summary>
        /// 双击发票信息某行 查看详细开票信息
        /// </summary>
        /// <param name="invoiceNumber">发票号码</param>
        /// <returns>返回一个Datatable</returns>
        public DataTable GetInvoiceNumberDetail(string invoiceNumber)
        {
            string sql = "SELECT a.id, a.invoicecode, a.invoicenumber, a.date, a.buyersid, b.commpanyname, b.taxnumber, b.address, b.bank, " +
                         "a.productname, a.productnumber, a.unitprice, a.money, a.taxrate, a.taxamount, a.totalamount, a.totaltaxamount, " +
                         "a.moneyupper, a.moneylow, a.sellersid, c.commpanyname AS 销售方名称, c.taxnumber AS 销售方税号, c.address AS 销售方地址及电话, " +
                         "c.bank AS 销售方开户行及帐号, a.comment, a.payee, a.\"check\", a.drawer, a.invoicestate, a.returnmoney FROM invoiceinfo AS a " +
                         "LEFT OUTER JOIN commpanyinfo AS b ON a.buyersid = b.id LEFT OUTER JOIN commpanyinfo AS c ON a.sellersid = c.id WHERE flag = '0' " +
                         "AND invoicenumber = '" + invoiceNumber + "'";
            DataTable dt = SqliteConn.ExecuteTable(sql);
            return dt;
        }

        #endregion


        #region 新增或修改一条数据 语句配置

        public int AddInvoiceInfo(InvoiceInfo invoiceInfo)
        {
            String sql = "INSERT INTO invoiceinfo VALUES(@invoicecode, @invoicenumber, @date, @buyersid, @productname,@productnumber, @unitprice, @money, " +
                         "@taxrate, @taxamount, @totalamount, @totaltaxamount, @moneyupper, @moneylow, @sellersid, @comment, @payee, @check, @drawer, " +
                         "@invoicestate, @returnmoney, @flag) ";
            return AddAndUpdateInvoiceInfo(1, sql, invoiceInfo);
        }

        #endregion

        #region 新增或修改多条数据 语句配置 
        public int AddInvoiceInfo(List<InvoiceInfo> list)
        {
            String sql = "INSERT INTO invoiceinfo VALUES(@id, @invoicecode, @invoicenumber, @date, @buyersid, @productname,@productnumber, @unitprice, @money, " +
                         "@taxrate, @taxamount, @totalamount, @totaltaxamount, @moneyupper, @moneylow, @sellersid, @comment, @payee, @check, @drawer, " +
                         "@invoicestate, @returnmoney, @flag) ";
            List<List<SQLiteParameter>> list1 = new List<List<SQLiteParameter>>();

            for (int i = 0; i < list.Count; i++)
            {
                list1.Add(AddAndUpdateParameter(1, list[i]));
            }
            return SqliteConn.ExecuteNonQueryMulit(sql, list1);
        }


        #endregion

        #region 新增或修改一条语句 参数配置

        /// <summary>
        /// 新增或修改一条语句 参数配置
        /// </summary>
        /// <param name="tmp">1--新增 2--修改</param>
        /// <param name="sql">sql语句</param>
        /// <param name="invoiceInfo"></param>
        /// <returns></returns>
        private int AddAndUpdateInvoiceInfo(int tmp, string sql, InvoiceInfo invoiceInfo)
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
            }
            else if (tmp == 2)
            {
                list.Add(new SQLiteParameter("@id", invoiceInfo.Id));
            }

            return SqliteConn.ExecuteNonQuery(sql, list.ToArray());
        }

        #endregion

        #region 新增或修改多条语句 参数配置

        /// <summary>
        /// 新增或修改多条语句 参数配置
        /// </summary>
        /// <param name="tmp"></param>
        /// <param name="invoiceInfo"></param>
        /// <returns></returns>
        private List<SQLiteParameter> AddAndUpdateParameter(int tmp, InvoiceInfo invoiceInfo)
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
                new SQLiteParameter("@flag", invoiceInfo.Flag),

            };
            List<SQLiteParameter> list = new List<SQLiteParameter>();
            list.AddRange(sqLiteParameter);
            if (tmp == 1)
            {
                list.Add(new SQLiteParameter("@id", null));
            }
            else if (tmp == 2)
            {
                list.Add(new SQLiteParameter("@id", invoiceInfo.Id));
            }
            return list;
        }

        #endregion

        #region DataTable 行转发票信息类

        /// <summary>
        /// DataTable的行转成发票信息类
        /// </summary>
        /// <param name="dr">DataRow DataTable的一行</param>
        /// <returns>返回发票信息类的对象实例</returns>
        private InvoiceInfo RowToinvoiceInfo(DataRow dr)
        {
            InvoiceInfo invoiceInfo = new InvoiceInfo();
            invoiceInfo.Id = Convert.ToInt32(dr["id"]);
            invoiceInfo.Invoicecode = dr["invoicecode"].ToString();
            invoiceInfo.Invoicenumber = dr["invoicenumber"].ToString();
            invoiceInfo.Date = dr["date"].ToString();
            invoiceInfo.Buyersid = Convert.ToInt32(dr["buyersid"]);
            invoiceInfo.Productname = dr["productname"].ToString();
            invoiceInfo.Productnumber = Convert.ToInt32(dr["productnumber"]);
            invoiceInfo.Unitprice = dr["unitprice"].ToString();
            invoiceInfo.Money = dr["money"].ToString();
            invoiceInfo.Taxrate = dr["taxrate"].ToString();
            invoiceInfo.Taxamount = dr["taxamount"].ToString();
            invoiceInfo.Totalamount = dr["totalamount"].ToString();
            invoiceInfo.Totaltaxamount = dr["totaltaxamount"].ToString();
            invoiceInfo.Moneyupper = dr["moneyupper"].ToString();
            invoiceInfo.Moneylow = dr["moneylow"].ToString();
            invoiceInfo.Sellersid = Convert.ToInt32(dr["sellersid"]);
            invoiceInfo.Comment = dr["comment"].ToString();
            invoiceInfo.Payee = dr["payee"].ToString();
            invoiceInfo.Check = dr["check"].ToString();
            invoiceInfo.Drawer = dr["drawer"].ToString();
            invoiceInfo.Invoicestate = dr["invoicestate"].ToString();
            invoiceInfo.Returnmoney = dr["returnmoney"].ToString();
            return invoiceInfo;
        }

        #endregion

    }
}