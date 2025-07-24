using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IAttendanceRecordDal : IGenericRepository<AttendanceRecord>
    {
        // Gerekirse özel sorgular burada tanımlanabilir
    }
}
