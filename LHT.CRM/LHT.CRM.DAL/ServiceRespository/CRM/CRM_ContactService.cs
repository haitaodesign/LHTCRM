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
            if (contact != null)
            {
                _dbContext.CRM_Contact.Add(contact);
            }
        }

        public void Delete(int conId)
        {
            var contact = _dbContext.CRM_Contact.Find(conId);
            if (contact != null)
            {
                _dbContext.CRM_Contact.Remove(contact);
            }
        }

        public List<CRM_Contact> GetAll()
        {
            return _dbContext.CRM_Contact.ToList();
        }

        public void Update(CRM_Contact contact)
        {
            var updatecontact = _dbContext.CRM_Contact.Find(contact.Id);
            if (updatecontact != null)
            {
                updatecontact.MId = contact.MId;
                updatecontact.MDate = contact.MDate;
                updatecontact.CusId = contact.CusId;
                updatecontact.Name = contact.Name;
                updatecontact.Gender = contact.Gender;
                updatecontact.JiGuan = contact.JiGuan;
                updatecontact.DeptName = contact.DeptName;
                updatecontact.Position = contact.Position;
                updatecontact.Mobile = contact.Mobile;
                updatecontact.WX = contact.WX;
                updatecontact.Email = contact.WX;
            }
        }
    }
}
