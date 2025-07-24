using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface ICompanyModuleDal : IGenericRepository<CompanyModule>
    {
        // Firma bazlı aktif modül kontrolü gibi işlemler burada tanımlanabilir
    }
}
