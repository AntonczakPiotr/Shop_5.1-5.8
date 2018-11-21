namespace Shop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Shop.Models.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.Name, new Models.Category { Name = "Kategoria G³ówna" },
                                                        new Models.Category { Name = "Elektronika" },
                                                        new Models.Category { Name = "Ksi¹¿ki" },
                                                        new Models.Category { Name = "Bi¿uteria" },
                                                        new Models.Category { Name = "Odzie¿" },
                                                        new Models.Category { Name = "Sport" },
                                                        new Models.Category { Name = "Motoryzacja" },
                                                        new Models.Category { Name = "Dom" }
                                                        );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
