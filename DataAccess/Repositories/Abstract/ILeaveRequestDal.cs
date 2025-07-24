using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface ILeaveRequestDal : IGenericRepository<LeaveRequest>
    {
        // Onay durumu, departman ID veya tarih filtreli sorgular burada tanımlanabilir
    }
}
