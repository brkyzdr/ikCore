using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class EmployeeShiftManager : IEmployeeShiftService
    {
        private readonly IEmployeeShiftDal _employeeShiftDal;

        public EmployeeShiftManager(IEmployeeShiftDal employeeShiftDal)
        {
            _employeeShiftDal = employeeShiftDal;
        }

        public void AssignShift(EmployeeShift entity)
        {
            _employeeShiftDal.Add(entity);
        }

        public void Update(EmployeeShift entity)
        {
            _employeeShiftDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _employeeShiftDal.Get(x => x.Id == id);
            if (entity != null)
                _employeeShiftDal.Delete(entity);
        }

        public EmployeeShift GetById(int id)
        {
            return _employeeShiftDal.Get(x => x.Id == id);
        }

        public List<EmployeeShift> GetAll()
        {
            return _employeeShiftDal.GetAll().ToList();
        }

        public List<EmployeeShift> GetByEmployeeId(int employeeId)
        {
            return _employeeShiftDal.GetAll(x => x.EmployeeId == employeeId).ToList();
        }

        public List<EmployeeShift> GetByDateRange(int employeeId, DateTime start, DateTime end)
        {
            return _employeeShiftDal
                .GetAll(x => x.EmployeeId == employeeId && x.WorkDate >= start && x.WorkDate <= end)
                .ToList();
        }

        public List<EmployeeShift> GetByCompanyId(int companyId)
        {
            return _employeeShiftDal.GetAll(x => x.CompanyId == companyId).ToList();
        }
    }
}
