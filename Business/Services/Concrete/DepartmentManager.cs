using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Create(Department entity)
        {
            _departmentDal.Add(entity);
        }

        public void Update(Department entity)
        {
            _departmentDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _departmentDal.Get(x => x.Id == id);
            if (entity != null)
                _departmentDal.Delete(entity);
        }

        public Department GetById(int id)
        {
            return _departmentDal.Get(x => x.Id == id);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll().ToList();
        }

        public List<Department> GetByCompanyId(int companyId)
        {
            return _departmentDal.GetAll(x => x.CompanyId == companyId).ToList();
        }
    }
}
