using System.Collections.Generic;
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
        public List<InvoiceInfo> GetAllInvoiceInfos()
        {
            return invoiceInfo.GetAllInvoiceInfos();
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