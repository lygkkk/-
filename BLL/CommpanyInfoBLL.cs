using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class CommpanyInfoBLL
    {
        CommpanyInfoDAL commpanyInfoDal = new CommpanyInfoDAL();
        public List<CommpanyInfo> GetAllCommpanyInfos()
        {
            return commpanyInfoDal.GetAllCommpanyInfos();
        }
    }
}