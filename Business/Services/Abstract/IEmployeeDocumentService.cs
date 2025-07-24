using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IEmployeeDocumentService
    {
        void Upload(EmployeeDocument document);
        void Update(EmployeeDocument document);
        void Delete(int id);

        EmployeeDocument GetById(int id);
        List<EmployeeDocument> GetAll();
        List<EmployeeDocument> GetByEmployeeId(int employeeId);
        List<EmployeeDocument> GetByCompanyId(int companyId);
    }
}
