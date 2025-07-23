using ikCore.Business.Interfaces;
using ikCore.DataAccess.UnitOfWork;
using ikCore.Entities.Models;
using System.Collections.Generic;

namespace ikCore.Business.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Company> GetAll() => _unitOfWork.Companies.GetAll();

        public Company GetById(int id) => _unitOfWork.Companies.GetById(id);

        public Company GetByName(string name) => _unitOfWork.Companies.GetByName(name);

        public void Create(Company company)
        {
            _unitOfWork.Companies.Add(company);
            _unitOfWork.Complete();
        }
    }
}
