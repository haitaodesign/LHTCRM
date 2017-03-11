using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.CRM;
using LHT.CRM.Model;

namespace LHT.CRM.BLL.CRM
{
    public class CRM_ProductLogic
    {
        CRM_ProductService cpl = new CRM_ProductService();

        /// <summary>
        /// 返回产品列表
        /// </summary>
        /// <returns></returns>
        public List<CRM_Product> GetAll()
        {
            return cpl.GetAll();
        }
    }
}
