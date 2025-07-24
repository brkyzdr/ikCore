using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IDepartmentDal : IGenericRepository<Department>
    {
        // Firma bazlı departman listeleme gibi ek metotlar burada tanımlanabilir
    }
}
