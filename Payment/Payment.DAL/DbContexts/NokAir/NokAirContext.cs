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
        public new int? DbContextId { get; set; } = 1;

        public NokAirContext():base("NokAirDatabase")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Add more Fluent API 
            modelBuilder.Entity<NokAirUser>().Property(a => a.UpdatedDate).IsOptional();
        }
    }
}
