using ikCore.DataAccess.Context;
using ikCore.DataAccess.Repositories.Concrete;
using ikCore.DataAccess.Repositories.Interfaces;

namespace ikCore.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Companies = new CompanyRepository(_context);
        }

        public ICompanyRepository Companies { get; private set; }

        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
