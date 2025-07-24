using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IShiftDal : IGenericRepository<Shift>
    {
        // Firma bazlı vardiya listeleme gibi özel sorgular burada tanımlanabilir
    }
}
