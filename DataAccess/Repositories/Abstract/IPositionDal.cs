using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IPositionDal : IGenericRepository<Position>
    {
        // Firma bazlı pozisyon filtreleme gibi özel sorgular burada tanımlanabilir
    }
}
