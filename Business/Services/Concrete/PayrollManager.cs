using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class PayrollManager : IPayrollService
    {
        private readonly IPayrollDal _payrollDal;

        public PayrollManager(IPayrollDal payrollDal)
        {
            _payrollDal = payrollDal;
        }

        public void Create(Payroll entity)
        {
            entity.GeneratedAt = DateTime.UtcNow;
            _payrollDal.Add(entity);
        }

        public void Update(Payroll entity)
        {
            _payrollDal.Update(entity);
        }

        public void Delete(int id)
        {
            var payroll = _payrollDal.Get(x => x.Id == id);
            if (payroll != null)
                _payrollDal.Delete(payroll);
        }

        public Payroll GetById(int id)
        {
            return _payrollDal.Get(x => x.Id == id);
        }

        public List<Payroll> GetAll()
        {
            return _payrollDal.GetAll().ToList();
        }

        public List<Payroll> GetByEmployeeId(int employeeId)
        {
            return _payrollDal.GetAll(x => x.EmployeeId == employeeId).ToList();
        }

        public List<Payroll> GetByCompanyId(int companyId)
        {
            return _payrollDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public List<Payroll> GetByMonth(int companyId, int year, int month)
        {
            var start = new DateTime(year, month, 1);
            var end = start.AddMonths(1).AddDays(-1);

            return _payrollDal.GetAll(x =>
                x.CompanyId == companyId &&
                x.PeriodStart >= start &&
                x.PeriodEnd <= end).ToList();
        }

        public decimal CalculatePayroll(int employeeId, DateTime period)
        {
            var start = new DateTime(period.Year, period.Month, 1);
            var end = start.AddMonths(1).AddDays(-1);

            var payrolls = _payrollDal.GetAll(x =>
                x.EmployeeId == employeeId &&
                x.PeriodStart >= start &&
                x.PeriodEnd <= end);

            return payrolls.Sum(x => x.NetSalary);
        }
    }
}
