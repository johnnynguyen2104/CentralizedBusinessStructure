using System;
using Payment.DAL.Interfaces;
using Payment.DAL.DbContexts;

namespace Payment.DAL.UnitOfWork
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextStrategy _dbContextStrategy;
        private bool _disposed; 

        public UnitOfWork(IDbContextStrategy dbContextStrategy)
        {
            _dbContextStrategy = dbContextStrategy;
        }

        public int CommitChanges(AirlineType airlineType)
        {
            return _dbContextStrategy.CommitChanges(airlineType);
        }

        public void Dispose(AirlineType airlineType)
        {
            Dispose(airlineType, true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(AirlineType airlineType, bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContextStrategy.Dispose(airlineType);
                }
            }
            this._disposed = true;
        }
    }
}
