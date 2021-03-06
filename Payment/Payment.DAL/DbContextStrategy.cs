﻿using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Payment.DAL.DbContexts;

namespace Payment.DAL
{
    public class DbContextStrategy : IDbContextStrategy
    {
        private readonly IList<IDbContext> _dbcontexts;

        public DbContextStrategy(IList<IDbContext> dbcontexts)
        {
            _dbcontexts = dbcontexts;
        }

        public int CommitChanges(int airlineType)
        {
            var dbcontext = GetContextByType(airlineType);

            return dbcontext.CommitChanges();
        }

        public void Dispose(int airlineType)
        {
            var dbcontext = GetContextByType(airlineType);

            dbcontext.Dispose();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(int airlineType, TEntity entity) where TEntity : class
        {
            var dbcontext = GetContextByType(airlineType);

            return dbcontext.Entry<TEntity>(entity);
        }

        public DbSet<TEntity> Set<TEntity>(int airlineType) where TEntity : class
        {
            var dbcontext = GetContextByType(airlineType);

            return dbcontext.Set<TEntity>();
        }

        public IDbContext GetContextByType(int airlineType)
        {
            if (_dbcontexts == null || _dbcontexts.Count == 0)
            {
                throw new Exception(string.Format("{0} was null or empty.", _dbcontexts.ToString()));
            }

            var result = _dbcontexts.FirstOrDefault(a => a.DbContextId == airlineType);

            if (result == null)
            {
                throw new Exception("Couldn't find any airline context map with Id: " + airlineType);
            }

            return result;
        }
    }
}
