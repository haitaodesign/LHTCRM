using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ISystemManagement
{
    public interface ISystemRole
    {
        List<SystemRole> GetAll();

        void Add(SystemRole role);

        void Delete(int roleId);

        void Update(SystemRole role);
    }
}
