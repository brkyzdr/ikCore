using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IEmployeeDal : IGenericRepository<Employee>
    {
        // Departman veya pozisyona göre özel sorgular burada tanımlanabilir
    }
}
