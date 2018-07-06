using Payment.DAL.DbContexts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.Interfaces
{
    public interface IUnitOfWork
    {

        Dictionary<Type, object> Repositories { get; set; }

        int CommitChanges();

        void Dispose();

        IRepository<T> Repository<T>() where T : class;
    }
}
