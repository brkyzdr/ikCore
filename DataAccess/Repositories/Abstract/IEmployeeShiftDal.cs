using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IEmployeeShiftDal : IGenericRepository<EmployeeShift>
    {
        // Tarih aralığı, çalışan veya firma bazlı özel sorgular burada tanımlanabilir
    }
}
