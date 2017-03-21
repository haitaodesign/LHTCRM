using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_TargetService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Target
    {
        public CRM_TargetService(LHTCRMEntities context) : base(context) { }

        public CRM_TargetService():base(new LHTCRMEntities()) { }

        public void Add(CRM_Target target)
        {
            if (target != null)
            {
                _dbContext.CRM_Target.Add(target);
            }
        }

        public void Delete(int targetId)
        {
            var target = _dbContext.CRM_Target.Find(targetId);
            if (target != null)
            {
                _dbContext.CRM_Target.Remove(target);
            }
        }

        public List<CRM_Target> GetAll()
        {
            return _dbContext.CRM_Target.ToList();
        }

        public void Update(CRM_Target target)
        {
            var updatetarget = _dbContext.CRM_Target.Find(target.Id);
            if (updatetarget != null)
            {
                updatetarget.MId = target.MId;
                updatetarget.MDate = target.MDate;
                updatetarget.Period = target.Period;
                updatetarget.Target1 = target.Target1;
                updatetarget.Target2 = target.Target2;
                updatetarget.Target3 = target.Target3;
                updatetarget.Target4 = target.Target4;
                updatetarget.UserName = target.UserName;
            }
        }
    }
}
