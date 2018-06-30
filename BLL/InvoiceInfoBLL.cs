using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Model;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class InvoiceInfoBLL
    {
        InvoiceInfoDAL invoiceInfo = new InvoiceInfoDAL();



        #region 获取所有发票明细

        public DataTable GetAllInvoiceDetail(DataTable dt)
        {
            return invoiceInfo.GetAllInvoiceDetail(dt);
        }

        #endregion


        #region 获取所有的发票明细
        /// <summary>
        /// 获取所有的发票明细
        /// </summary>
        /// <returns>返回一个DataTable表</returns>
        public DataTable GetAllInvoiceDetail()
        {
            return invoiceInfo.GetAllInvoiceDetail();
        }

        #endregion

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

        #region 更新发票修改信息到数据库

        /// <summary>
        /// 发票修改 
        /// </summary>
        /// <param name="dt">DataTable 存放发票明细信息的表</param>
        /// <param name="dt1">DataTable 存放发票明细基本信息的表</param>
        /// <returns>返回影响行数</returns>

        public string ModifyData(DataTable dt, DataTable dt1)
        {
            int yxhs = 0;
            string msg = "";
            yxhs = invoiceInfo.ModifyData("invoiceinfo", dt, dt1);
            if (yxhs > 0)
            {
                msg = "修改成功！";
            }
            else
            {
                msg = "修改失败！";
            }
            return msg;
        }

        #endregion

        #region 删除一条信息
        /// <summary>
        /// 删除一条发票信息
        /// </summary>
        /// <param name="tableName">数据库表名</param>
        /// <param name="dgvRow">DataGridViewRow</param>
        /// <returns>返回成功或失败的信息 </returns>
        public string DeleteSingleInfo(string tableName, DataGridViewRow dgvRow)
        {
            int rowCount = invoiceInfo.DeleteSingleInfo(tableName, dgvRow);
            string msg = string.Empty;
            if (rowCount > 0)
            {
                msg = "删除成功！";
            }
            else
            {
                msg = "删除失败！";
            }
            return msg;
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