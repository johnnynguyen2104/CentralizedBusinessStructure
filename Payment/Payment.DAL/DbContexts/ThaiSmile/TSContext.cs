using Payment.DAL.ContextMigrations.ThaiSmile;
using Payment.DAL.DbContexts.ThaiSmile.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DbContexts.ThaiSmile
{
    public class TSContext : BaseDbContext
    { 

        public TSContext() : base("TSDatabase")
        {
            DbContextId = 0;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TSContext, Configuration>("TSDatabase"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TSTransaction>().HasKey(a => a.Id);
            modelBuilder.Entity<TSTransaction>().Property(a => a.Id)
           .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            base.OnModelCreating(modelBuilder);
        }
    }
}
