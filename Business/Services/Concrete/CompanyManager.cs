using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Create(Company company)
        {
            _companyDal.Add(company);
        }

        public void Delete(int id)
        {
            var company = _companyDal.Get(x => x.Id == id);
            if (company != null)
            {
                _companyDal.Delete(company);
            }
        }

        public Company GetByUserId(int userId)
        {
            // Bu metot, kullanıcıdan şirket bilgisi çekmek için.
            // Eğer bu yapı mevcut değilse, User üzerinden ilişki kurularak servisler arası çağrı yapılmalı.
            return _companyDal.Get(x => x.Users.Any(u => u.Id == userId));
        }

        public bool IsCompanyCodeAvailable(string code)
        {
            return !_companyDal.GetAll().Any(x => x.UniqueCode == code);
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetAll();
        }

        public Company GetById(int id)
        {
            return _companyDal.Get(x => x.Id == id);
        }

        public void Update(Company company)
        {
            _companyDal.Update(company);
        }
    }
}
