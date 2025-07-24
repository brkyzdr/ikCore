using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IShiftService
    {
        void Create(Shift entity);
        void Update(Shift entity);
        void Delete(int id);

        Shift GetById(int id);
        List<Shift> GetAll();
        List<Shift> GetByCompanyId(int companyId);
    }
}
