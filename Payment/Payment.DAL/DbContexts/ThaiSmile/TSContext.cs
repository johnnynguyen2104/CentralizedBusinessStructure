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
        public new int? DbContextId { get; set; } = 0;

        public TSContext() : base("TSDatabase")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
