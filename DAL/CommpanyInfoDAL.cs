using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Model;
namespace DAL
{
    public class CommpanyInfoDAL
    {


        public List<CommpanyInfo> GetAllCommpanyInfos()
        {
            //string sql = "SELECT id,commpanyname,taxnumber,address,bank,contact,phone FROM commpanyinfo";
            string sql = "SELECT * FROM commpanyinfo";
            SqliteConn sqliteConn = new SqliteConn();
            


            DataTable dataTable = SqliteConn.ExecuteTable(sql);
            List<CommpanyInfo> list = new List<CommpanyInfo>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    CommpanyInfo mem = RowToCommpanyInfo(dr);
                    list.Add(mem);
                }
            }
            return list;
        }




        private CommpanyInfo RowToCommpanyInfo(DataRow dataRow)
        {
            CommpanyInfo commpanyInfo = new CommpanyInfo();
            commpanyInfo.Id = Convert.ToInt32(dataRow["id"]);
            commpanyInfo.Commpanyname = dataRow["commpanyname"].ToString();
            commpanyInfo.Taxnumber = dataRow["taxnumber"].ToString();
            commpanyInfo.Address = dataRow["Address"].ToString();
            commpanyInfo.Bank = dataRow["bank"].ToString();
            commpanyInfo.Contact = dataRow["contact"].ToString();
            commpanyInfo.Phone = dataRow["phone"].ToString();
            return commpanyInfo;
        }
    }
}