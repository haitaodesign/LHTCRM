using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_ContactService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Contact
    {
        public CRM_ContactService(LHTCRMEntities context) : base(context){}

        public CRM_ContactService() : base(new LHTCRMEntities()) { }

        public void Add(CRM_Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Delete(int conId)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Contact> GetAll()
        {
            return _dbContext.CRM_Contact.ToList();
        }

        public void Update(CRM_Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
