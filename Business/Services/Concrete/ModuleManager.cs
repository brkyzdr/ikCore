using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class ModuleManager : IModuleService
    {
        private readonly IModuleDal _moduleDal;

        public ModuleManager(IModuleDal moduleDal)
        {
            _moduleDal = moduleDal;
        }

        public void Create(Module entity)
        {
            _moduleDal.Add(entity);
        }

        public void Update(Module entity)
        {
            _moduleDal.Update(entity);
        }

        public void Delete(int id)
        {
            var module = _moduleDal.Get(x => x.Id == id);
            if (module != null)
                _moduleDal.Delete(module);
        }

        public Module GetById(int id)
        {
            return _moduleDal.Get(x => x.Id == id);
        }

        public List<Module> GetAll()
        {
            return _moduleDal.GetAll().ToList();
        }

        public Module GetByCode(string code)
        {
            return _moduleDal.Get(x => x.Code == code);
        }
    }
}
