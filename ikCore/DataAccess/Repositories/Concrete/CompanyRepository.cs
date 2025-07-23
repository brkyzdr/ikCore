using ikCore.DataAccess.Context;
using ikCore.DataAccess.Repositories.Interfaces;
using ikCore.Entities.Models;
using System.Linq;

namespace ikCore.DataAccess.Repositories.Concrete
{
    public class CompanyRepository : EfRepository<Company>, ICompanyRepository
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Company GetByName(string name)
        {
            return _context.Companies.FirstOrDefault(c => c.Name == name);
        }
    }
}
