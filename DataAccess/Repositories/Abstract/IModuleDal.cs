using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IModuleDal : IGenericRepository<Module>
    {
        // Kod ile modül arama gibi özel sorgular burada tanımlanabilir
    }
}
