using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IDocumentTypeService
    {
        void Create(DocumentType entity);
        void Update(DocumentType entity);
        void Delete(int id);

        DocumentType GetById(int id);
        List<DocumentType> GetAll();
        List<DocumentType> GetByCompanyId(int companyId); // Firma özel belge türleri
    }
}
