using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IAuditLogDal : IGenericRepository<AuditLog>
    {
        // Özel log filtreleme methodları burada tanımlanabilir
    }
}
