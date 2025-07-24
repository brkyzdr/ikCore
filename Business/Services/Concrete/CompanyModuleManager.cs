using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class CompanyModuleManager : ICompanyModuleService
    {
        private readonly ICompanyModuleDal _companyModuleDal;

        public CompanyModuleManager(ICompanyModuleDal companyModuleDal)
        {
            _companyModuleDal = companyModuleDal;
        }

        public void AssignModuleToCompany(int companyId, int moduleId)
        {
            var exists = _companyModuleDal.Get(x => x.CompanyId == companyId && x.ModuleId == moduleId);
            if (exists == null)
            {
                _companyModuleDal.Add(new CompanyModule
                {
                    CompanyId = companyId,
                    ModuleId = moduleId,
                    IsActive = true // varsayılan olarak aktif
                });
            }
        }

        public void RemoveModuleFromCompany(int companyId, int moduleId)
        {
            var entity = _companyModuleDal.Get(x => x.CompanyId == companyId && x.ModuleId == moduleId);
            if (entity != null)
                _companyModuleDal.Delete(entity);
        }

        public List<CompanyModule> GetModulesByCompanyId(int companyId)
        {
            return _companyModuleDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public bool IsModuleActiveForCompany(int companyId, string moduleCode)
        {
            return _companyModuleDal
                .GetAll(x => x.CompanyId == companyId && x.IsActive && x.Module.Code == moduleCode)
                .Any();
        }
    }
}
