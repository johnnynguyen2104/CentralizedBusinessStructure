using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Payment.DAL.DbContexts.NokAir.Entities;

namespace Payment.DAL.DbContexts.NokAir
{
    public class NokAirContext : BaseDbContext
    {

        public NokAirContext():base("NokAirDatabase")
        {
            DbContextId = 1;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NokAirContext, ContextMigrations.NokAir.Configuration>("NokAirDatabase"));

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Add more Fluent API 
            modelBuilder.Entity<NokTransaction>().ToTable("dbo.Transaction");

            modelBuilder.Entity<NokTransaction>().HasKey(a=> a.Id);
            modelBuilder.Entity<NokTransaction>().Property(a => a.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            base.OnModelCreating(modelBuilder);

            
        }
    }
}
