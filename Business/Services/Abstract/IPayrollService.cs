using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IPayrollService
    {
        void Create(Payroll entity);
        void Update(Payroll entity);
        void Delete(int id);

        Payroll GetById(int id);
        List<Payroll> GetAll();
        List<Payroll> GetByEmployeeId(int employeeId);
        List<Payroll> GetByCompanyId(int companyId);
        List<Payroll> GetByMonth(int companyId, int year, int month);

        decimal CalculatePayroll(int employeeId, DateTime period); // Örneğin: 2025-07 için
    }
}
