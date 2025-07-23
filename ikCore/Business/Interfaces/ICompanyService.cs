using ikCore.Entities.Models;
using System.Collections.Generic;

namespace ikCore.Business.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
        Company GetById(int id);
        Company GetByName(string name);
        void Create(Company company);
    }
}
