using System.Data.Entity;
using LL_LinkedIn.Data.Migrations;
using LL_LinkedIn.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LL_LinkedIn.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>, IApplicationDbContext
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

        public IDbSet<Certification> Certifications { get; set; }

        public IDbSet<Discussion> Discussions { get; set; }

        public IDbSet<Experience> Experiences { get; set; }

        public IDbSet<Group> Groups { get; set; }

        public IDbSet<UserLanguage> Languages { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<Skill> Skills { get; set; }

        public IDbSet<Endorcement> Endorcements { get; set; }

        public IDbSet<AdministrationLog> AdministrationLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasRequired(g => g.Owner)
                .WithOptional()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Endorcement>()
                .HasRequired(e => e.UserSkill)
                .WithMany(usrSkl => usrSkl.Endorcements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Experience>()
                .HasRequired(e => e.User)
                .WithMany(u => u.Experiences)
                .WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);
        }
    }
}
