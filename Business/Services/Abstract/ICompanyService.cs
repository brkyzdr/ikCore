using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface ICompanyService
    {
        void Create(Company entity);
        void Update(Company entity);
        void Delete(int id);

        Company GetById(int id);
        List<Company> GetAll();
        Company GetByUserId(int userId); // Kullanıcıya bağlı firma ilişkisi

        bool IsCompanyCodeAvailable(string companyCode); // Firma katılımı için ID kodu kontrolü
    }
}
