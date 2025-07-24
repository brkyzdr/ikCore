using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IJobApplicationDal : IGenericRepository<JobApplication>
    {
        // İlan ID’si, aday e-posta adresi gibi özel filtreler burada tanımlanabilir
    }
}
