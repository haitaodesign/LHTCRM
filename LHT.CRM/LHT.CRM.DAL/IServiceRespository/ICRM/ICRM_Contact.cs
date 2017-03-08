using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Contact
    {
        List<CRM_Contact> GetAll();

        void Add(CRM_Contact contact);

        void Delete(int conId);

        void Update(CRM_Contact contact);
    }
}
