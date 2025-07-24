using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IEmployeeService
    {
        void Create(Employee entity);
        void Update(Employee entity);
        void Delete(int id);

        Employee GetById(int id);
        List<Employee> GetAll();
        List<Employee> GetByCompanyId(int companyId);
        List<Employee> GetByDepartmentId(int departmentId);
        List<Employee> GetActiveEmployeesByCompanyId(int companyId);
    }
}
