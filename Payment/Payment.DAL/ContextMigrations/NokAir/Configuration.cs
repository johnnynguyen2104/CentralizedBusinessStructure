namespace Payment.DAL.ContextMigrations.NokAir
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Payment.DAL.DbContexts.NokAir.NokAirContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ContextMigrations/NokAir";
        }

        protected override void Seed(Payment.DAL.DbContexts.NokAir.NokAirContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
