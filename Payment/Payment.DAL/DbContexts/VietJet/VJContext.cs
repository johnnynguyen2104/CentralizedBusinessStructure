
using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DbContexts.VietJet
{
    public class VJContext : BaseDbContext, IDbContext
    {

        public VJContext() : base("VJDatabase")
        {
            DbContextId = 2;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<VJContext, Configuration>("VJDatabase"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
