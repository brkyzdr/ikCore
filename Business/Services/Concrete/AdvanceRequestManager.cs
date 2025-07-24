using System.Collections.Generic;
using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;

namespace Business.Services.Concrete
{
    public class AdvanceRequestManager : IAdvanceRequestService
    {
        private readonly IAdvanceRequestDal _advanceRequestDal;

        public AdvanceRequestManager(IAdvanceRequestDal advanceRequestDal)
        {
            _advanceRequestDal = advanceRequestDal;
        }

        public void Create(AdvanceRequest entity)
        {
            _advanceRequestDal.Add(entity);
        }

        public void Update(AdvanceRequest entity)
        {
            _advanceRequestDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _advanceRequestDal.Get(x => x.Id == id);
            if (entity != null)
            {
                _advanceRequestDal.Delete(entity);
            }
        }

        public AdvanceRequest GetById(int id)
        {
            return _advanceRequestDal.Get(x => x.Id == id);
        }

        public List<AdvanceRequest> GetAll()
        {
            return _advanceRequestDal.GetAll();
        }

        public List<AdvanceRequest> GetByEmployeeId(int employeeId)
        {
            return _advanceRequestDal.GetAll(x => x.EmployeeId == employeeId);
        }

        public List<AdvanceRequest> GetByCompanyId(int companyId)
        {
            return _advanceRequestDal.GetAll(x => x.CompanyId == companyId);
        }
    }
}
