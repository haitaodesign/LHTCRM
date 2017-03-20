using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_VisitService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Visit
    {
        public CRM_VisitService(LHTCRMEntities context) : base(context)
        {
        }
        public CRM_VisitService():base(new LHTCRMEntities()) { }

        public List<CRM_Visit> GetAll()
        {
            return _dbContext.CRM_Visit.ToList();
        }

        public void Add(CRM_Visit visit)
        {
            if (visit != null)
            {
                _dbContext.CRM_Visit.Add(visit);
            }
        }

        public void Delete(int visitId)
        {
            var visit = _dbContext.CRM_Visit.Find(visitId);
            if (visit != null)
            {
                _dbContext.CRM_Visit.Remove(visit);
            }
        }

        public void Update(CRM_Visit visit)
        {
            var updatevisit = _dbContext.CRM_Visit.Find(visit.Id);
            if (updatevisit != null)
            {
                updatevisit.MId = visit.MId;
                updatevisit.MDate = visit.MDate;
                updatevisit.CusId = visit.CusId;
                updatevisit.ConId = visit.ConId;
                updatevisit.VTitle = visit.VTitle;
                updatevisit.VContent = visit.VContent;
                updatevisit.VType = visit.VType;
                updatevisit.VPlanDate = visit.VCompleteDate;
                updatevisit.VCompleteDate = visit.VCompleteDate;
                updatevisit.VSuperiorDate = visit.VSuperiorDate;
                updatevisit.VSuperiorSuggestion = visit.VSuperiorSuggestion;
                updatevisit.VSuperiorId = visit.VSuperiorId;
                updatevisit.VStatus = visit.VStatus;
            }
        }
    }
}
