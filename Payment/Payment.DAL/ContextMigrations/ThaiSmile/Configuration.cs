namespace Payment.DAL.ContextMigrations.ThaiSmile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Payment.DAL.DbContexts.ThaiSmile.TSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ContextMigrations/ThaiSmile";
        }

        protected override void Seed(Payment.DAL.DbContexts.ThaiSmile.TSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
