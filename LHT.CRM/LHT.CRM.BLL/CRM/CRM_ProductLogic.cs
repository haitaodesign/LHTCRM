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

        public int Add(CRM_Product product)
        {
            cpl.Add(product);
            int result = cpl.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Delete(int productId)
        {
            cpl.Delete(productId);
            int result = cpl.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Update(CRM_Product product)
        {
            cpl.Update(product);
            int result = cpl.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 根据Id返回一个产品实体
        /// </summary>
        /// <param name="proId"></param>
        /// <returns></returns>
        public CRM_Product GetCRM_ProductModel(int proId)
        {
            return cpl.GetAll().Find(p => p.Id == proId);
        }
    }
}
