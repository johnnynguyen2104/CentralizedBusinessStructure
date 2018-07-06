using Payment.DAL.BaseEntities;
using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DbContexts
{
    public abstract class BaseDbContext : DbContext, IDbContext
    { 
        public int DbContextId { get; set; } = -1;

        public BaseDbContext(string connectionString):base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        int IDbContext.CommitChanges()
        {
            return this.SaveChanges();
        }

        void IDbContext.Dispose()
        {
            this.Dispose();
        }

        DbEntityEntry<TEntity> IDbContext.Entry<TEntity>(TEntity entity)
        {
            return this.Entry<TEntity>(entity);
        }

        DbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return this.Set<TEntity>();
        }
    }
}
