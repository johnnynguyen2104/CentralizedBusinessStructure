using System;
using Payment.DAL.Interfaces;
using Payment.DAL.DbContexts;
using System.Collections.Generic;
using System.Linq;
using Payment.DAL.Repositories;

namespace Payment.DAL.UnitOfWork
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextStrategy _dbContextStrategy;
        private readonly IAirlineCoordinator _coordinator;
        private bool _disposed;

        public UnitOfWork(IDbContextStrategy dbContextStrategy, IAirlineCoordinator coordinator)
        {
            _dbContextStrategy = dbContextStrategy;
            _coordinator = coordinator;
        }

        public Dictionary<Type, object> Repositories { get; set; } = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)) == true)
            {
                return Repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new Repository<T>(_dbContextStrategy.GetContextByType(_coordinator.GetAirlineId()));

            Repositories.Add(typeof(T), repo);
            return repo;
        }


        public int CommitChanges()
        {
            return _dbContextStrategy.CommitChanges(_coordinator.GetAirlineId());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContextStrategy.Dispose(_coordinator.GetAirlineId());
                }
            }
            this._disposed = true;
        }
    }
}
