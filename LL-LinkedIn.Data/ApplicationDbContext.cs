using System.Data.Entity;
using LL_LinkedIn.Data.Migrations;
using LL_LinkedIn.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LL_LinkedIn.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endorcement>()
                .HasRequired(e => e.UserSkill)
                .WithMany(usrSkl => usrSkl.Endorcements)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
