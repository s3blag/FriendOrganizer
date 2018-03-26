namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Tomasz", LastName = "Huber" },
                new Friend { FirstName = "Andrzej", LastName = "Konieczny" },
                new Friend { FirstName = "Julia", LastName = "Konieczna" },
                new Friend { FirstName = "Marcelina", LastName = "Huber" }
                );
        }
    }
}
