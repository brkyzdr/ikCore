using ikCore.Entities.Models;

namespace ikCore.DataAccess.Repositories.Interfaces
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Company GetByName(string name);
    }
}
