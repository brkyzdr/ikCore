using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IEmployeeShiftService
    {
        void AssignShift(EmployeeShift entity);
        void Update(EmployeeShift entity);
        void Delete(int id);

        EmployeeShift GetById(int id);
        List<EmployeeShift> GetAll();
        List<EmployeeShift> GetByEmployeeId(int employeeId);
        List<EmployeeShift> GetByDateRange(int employeeId, DateTime start, DateTime end);
        List<EmployeeShift> GetByCompanyId(int companyId);
    }
}
