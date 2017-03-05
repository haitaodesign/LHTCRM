using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_CustomerService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Customer
    {
        public CRM_CustomerService(LHTCRMEntities context) : base(context) { }
        public CRM_CustomerService() : base(new LHTCRMEntities()) { }

        public void Add(CRM_Customer customer)
        {
            if (customer != null)
            {
                _dbContext.CRM_Customer.Add(customer);
            }
        }

        public void Delete(int cusId)
        {
            var customer = _dbContext.CRM_Customer.Find(cusId);
            if (customer != null)
            {
                _dbContext.CRM_Customer.Remove(customer);
            }
        }

        public List<CRM_Customer> GetAll()
        {
            return _dbContext.CRM_Customer.ToList();
        }

        public List<CRM_Customer> GetAll(int saleid)
        {
            return _dbContext.CRM_Customer.Where(r => r.SaleId == saleid).ToList();
        }


        public void Update(CRM_Customer customer)
        {
            var updatecustomer = _dbContext.CRM_Customer.Find(customer.CusCode);
            if (updatecustomer != null)
            {
                updatecustomer.MId = customer.MId;
                updatecustomer.MDate = customer.MDate;
                updatecustomer.Province = customer.Province;
                updatecustomer.City = customer.City;
                updatecustomer.CusName = customer.CusName;
                updatecustomer.BussinessType = customer.BussinessType;
                updatecustomer.CusType = customer.CusType;
                updatecustomer.HomePage = customer.HomePage;
                updatecustomer.PhoneNum = customer.PhoneNum;
                updatecustomer.SaleId = customer.SaleId;
                updatecustomer.IsPublisCus = customer.IsPublisCus;
                updatecustomer.Scale = customer.Scale;
            }
        }
    }
}
