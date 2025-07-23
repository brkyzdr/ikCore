using System;
using ikCore.DataAccess.Repositories.Interfaces;

namespace ikCore.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }
        int Complete();
    }
}
