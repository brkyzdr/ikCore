using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IPayrollDal : IGenericRepository<Payroll>
    {
        // Ay ve yıl bazlı bordro sorguları gibi işlemler burada tanımlanabilir
    }
}
