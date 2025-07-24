using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IDocumentTypeDal : IGenericRepository<DocumentType>
    {
        // Firma bazlı belge türü filtreleme gibi işlemler burada tanımlanabilir
    }
}
