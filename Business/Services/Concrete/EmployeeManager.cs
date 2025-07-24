using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Create(Employee entity)
        {
            _employeeDal.Add(entity);
        }

        public void Update(Employee entity)
        {
            _employeeDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _employeeDal.Get(x => x.Id == id);
            if (entity != null)
                _employeeDal.Delete(entity);
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(x => x.Id == id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll().ToList();
        }

        public List<Employee> GetByCompanyId(int companyId)
        {
            return _employeeDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public List<Employee> GetByDepartmentId(int departmentId)
        {
            return _employeeDal.GetAll(x => x.DepartmentId == departmentId).ToList();
        }

        public List<Employee> GetActiveEmployeesByCompanyId(int companyId)
        {
            return _employeeDal.GetAll(x => x.CompanyId == companyId && x.IsActive).ToList();
        }
    }
}
