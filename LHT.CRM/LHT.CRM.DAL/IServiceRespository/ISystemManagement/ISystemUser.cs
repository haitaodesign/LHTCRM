using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ISystemManagement
{
    public interface ISystemUser
    {
        List<SystemUser> GetAll();

        void Add(SystemUser user);

        void Delete(int userId);

        void Update(SystemUser user);

    }
}
