using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Services.Abstract
{
    public interface IAdvanceRequestService
    {
        void Create(AdvanceRequest entity);
        void Update(AdvanceRequest entity);
        void Delete(int id);

        AdvanceRequest GetById(int id);
        List<AdvanceRequest> GetAll();
        List<AdvanceRequest> GetByEmployeeId(int employeeId);
        List<AdvanceRequest> GetByCompanyId(int companyId);
    }
}
