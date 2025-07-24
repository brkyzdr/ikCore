using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IDepartmentService
    {
        void Create(Department entity);
        void Update(Department entity);
        void Delete(int id);

        Department GetById(int id);
        List<Department> GetAll();
        List<Department> GetByCompanyId(int companyId);
    }
}
