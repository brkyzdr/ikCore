using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IModuleService
    {
        void Create(Module entity);
        void Update(Module entity);
        void Delete(int id);

        Module GetById(int id);
        List<Module> GetAll();
        Module GetByCode(string code); // Örnek: "LEAVE", "PAYROLL"
    }
}
