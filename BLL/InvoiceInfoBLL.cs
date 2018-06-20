using System.Collections.Generic;
using Model;
using DAL;
namespace BLL
{
    public class InvoiceInfoBLL
    {
        InvoiceInfoDAL invoiceInfo = new InvoiceInfoDAL();

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