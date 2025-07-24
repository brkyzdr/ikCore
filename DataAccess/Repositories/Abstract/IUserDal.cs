using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IUserDal : IGenericRepository<User>
    {
        User GetByEmail(string email); // Giriş işlemleri için kullanılabilir
    }
}
