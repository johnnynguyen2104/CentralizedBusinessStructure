using Payment.DAL.DbContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.Interfaces
{
    public interface IDbContextStrategy
    {
        int CommitChanges(AirlineType airlineType);

        DbSet<TEntity> Set<TEntity>(AirlineType airlineType) where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(AirlineType airlineType, TEntity entity) where TEntity : class;

        void Dispose(AirlineType airlineType);
    }
}
