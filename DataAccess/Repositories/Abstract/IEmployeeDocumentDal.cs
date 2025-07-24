using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IEmployeeDocumentDal : IGenericRepository<EmployeeDocument>
    {
        // Belge tipi, çalışan ID’si veya tarih filtreli sorgular burada tanımlanabilir
    }
}
