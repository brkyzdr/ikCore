using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class EmployeeDocumentManager : IEmployeeDocumentService
    {
        private readonly IEmployeeDocumentDal _employeeDocumentDal;

        public EmployeeDocumentManager(IEmployeeDocumentDal employeeDocumentDal)
        {
            _employeeDocumentDal = employeeDocumentDal;
        }

        public void Upload(EmployeeDocument document)
        {
            _employeeDocumentDal.Add(document);
        }

        public void Update(EmployeeDocument document)
        {
            _employeeDocumentDal.Update(document);
        }

        public void Delete(int id)
        {
            var entity = _employeeDocumentDal.Get(x => x.Id == id);
            if (entity != null)
                _employeeDocumentDal.Delete(entity);
        }

        public EmployeeDocument GetById(int id)
        {
            return _employeeDocumentDal.Get(x => x.Id == id);
        }

        public List<EmployeeDocument> GetAll()
        {
            return _employeeDocumentDal.GetAll().ToList();
        }

        public List<EmployeeDocument> GetByEmployeeId(int employeeId)
        {
            return _employeeDocumentDal.GetAll(x => x.EmployeeId == employeeId).ToList();
        }

        public List<EmployeeDocument> GetByCompanyId(int companyId)
        {
            return _employeeDocumentDal.GetAll(x => x.CompanyId == companyId).ToList();
        }
    }
}
