using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IPositionService
    {
        void Create(Position entity);
        void Update(Position entity);
        void Delete(int id);

        Position GetById(int id);
        List<Position> GetAll();
        List<Position> GetByCompanyId(int companyId);
    }
}
