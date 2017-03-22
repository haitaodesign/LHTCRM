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
            if (product != null)
            {
                _dbContext.CRM_Product.Add(product);
            }
        }

        public void Delete(int productId)
        {
            var product = _dbContext.CRM_Product.Find(productId);
            if (product != null)
            {
                _dbContext.CRM_Product.Remove(product);
            }
        }

        public List<CRM_Product> GetAll()
        {
            return _dbContext.CRM_Product.ToList();
        }

        public void Update(CRM_Product product)
        {
            var updateproduct = _dbContext.CRM_Product.Find(product.Id);
            if (updateproduct != null)
            {
                updateproduct.MId = product.MId;
                updateproduct.MDate = product.MDate;
                updateproduct.Name = product.Name;
                updateproduct.Category = product.Category;
                updateproduct.Unit = product.Unit;
                updateproduct.Quantity = product.Quantity;
                updateproduct.Introduction = product.Introduction;
            }
        }
    }
}
