using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.IServiceRespository.ISystemManagement
{
    public interface ISystemLogin
    {
        List<SystemLogin> GetAll();

        void Add(SystemLogin login);

        void Delete(int loginId);

        void Update(SystemLogin login);
    }
}
