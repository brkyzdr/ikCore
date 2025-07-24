using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface INotificationDal : IGenericRepository<Notification>
    {
        // Kullanıcıya ait okunmamış bildirim sorguları gibi işlemler burada tanımlanabilir
    }
}
