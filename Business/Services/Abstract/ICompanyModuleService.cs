using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface ICompanyModuleService
    {
        void AssignModuleToCompany(int companyId, int moduleId);
        void RemoveModuleFromCompany(int companyId, int moduleId);

        List<CompanyModule> GetModulesByCompanyId(int companyId);
        bool IsModuleActiveForCompany(int companyId, string moduleCode); // örn: "LEAVE", "PAYROLL"
    }
}
