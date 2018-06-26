using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Model;
using DAL;
namespace BLL
{
    public class InvoiceInfoBLL
    {
        InvoiceInfoDAL invoiceInfo = new InvoiceInfoDAL();


        #region 获取所有发票信息的唯一项 不包含删除的

        /// <summary>
        /// 获取所有发票信息的唯一项 不包含删除的
        /// </summary>
        /// <returns>返回发票信息类实例的List</returns>
        public DataTable GetAllInvoiceInfos()
        {
            return invoiceInfo.GetAllInvoiceInfos();
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
            return invoiceInfo.GetInvoiceNumberDetail(invoiceNumber);
        }

        #endregion

        #region 获取发票货物明细
        /// <summary>
        /// 获取发票货物明细
        /// </summary>
        /// <param name="str">发票号码</param>
        /// <returns>返回DataTable</returns>
        public DataTable GetProductDetail(string str)
        {
            return invoiceInfo.GetProductDetail(str);
        }

        #endregion

        #region 发票修改

        public int ModifyData(string tableName)
        {
            return invoiceInfo.ModifyData("invoiceinfo");
        }

        #endregion

            public string SaveInvoiceInfo(string addOrUpdate, List<InvoiceInfo> list)
        {
            int yxhs = 0;
            string msg = "";
            switch (addOrUpdate)
            {
                case "发票新增":
                    yxhs = invoiceInfo.AddInvoiceInfo(list);
                    if (yxhs > 0)
                    {
                        msg = "新增成功！";
                    }
                    else
                    {
                        msg = "新增失败！";
                    }
                    break;
            }
            return msg;
        }


        public bool SaveInvoiceInfo(InvoiceInfo invoiceInfo, int tmp)
        {
            int r = -1;
            if (tmp == 1)
            {
                r = this.invoiceInfo.AddInvoiceInfo(invoiceInfo);
            }
            else if (tmp == 2)
            {

            }

            return r > 0;
        }
    }
}