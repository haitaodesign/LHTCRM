using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_ProductService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Product
    {
        public CRM_ProductService(LHTCRMEntities context) : base(context){}
        public CRM_ProductService():base(new LHTCRMEntities()) { }

        public void Add(CRM_Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Product> GetAll()
        {
            return _dbContext.CRM_Product.ToList();
        }

        public void Update(CRM_Product product)
        {
            throw new NotImplementedException();
        }
    }
}
