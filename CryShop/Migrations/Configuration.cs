namespace CryShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CryShop.Data.ConnectDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CryShop.Data.ConnectDb";
        }

        protected override void Seed(CryShop.Data.ConnectDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
