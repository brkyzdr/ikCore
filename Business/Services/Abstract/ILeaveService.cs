using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface ILeaveService
    {
        void Create(LeaveRequest entity);
        void Update(LeaveRequest entity);
        void Delete(int id);

        LeaveRequest GetById(int id);
        List<LeaveRequest> GetAll();
        List<LeaveRequest> GetByEmployeeId(int employeeId);
        List<LeaveRequest> GetByCompanyId(int companyId);
        List<LeaveRequest> GetPendingRequestsByDepartment(int departmentId);

        void Approve(int id);
        void Reject(int id);
    }
}
