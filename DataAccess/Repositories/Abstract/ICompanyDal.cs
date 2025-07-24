using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface ICompanyDal : IGenericRepository<Company>
    {
        // Örn: Firma kodu ile firma arama gibi ek sorgular burada tanımlanabilir
    }
}
