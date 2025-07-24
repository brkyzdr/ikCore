using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class DocumentTypeManager : IDocumentTypeService
    {
        private readonly IDocumentTypeDal _documentTypeDal;

        public DocumentTypeManager(IDocumentTypeDal documentTypeDal)
        {
            _documentTypeDal = documentTypeDal;
        }

        public void Create(DocumentType entity)
        {
            _documentTypeDal.Add(entity);
        }

        public void Update(DocumentType entity)
        {
            _documentTypeDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _documentTypeDal.Get(x => x.Id == id);
            if (entity != null)
                _documentTypeDal.Delete(entity);
        }

        public DocumentType GetById(int id)
        {
            return _documentTypeDal.Get(x => x.Id == id);
        }

        public List<DocumentType> GetAll()
        {
            return _documentTypeDal.GetAll().ToList();
        }

        public List<DocumentType> GetByCompanyId(int companyId)
        {
            return _documentTypeDal.GetAll(x => x.CompanyId == companyId).ToList();
        }
    }
}
