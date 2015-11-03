using System.Data.Entity;
using LL_LinkedIn.Models;

namespace LL_LinkedIn.Data
{
    public interface  IApplicationDbContext
    {
         IDbSet<Certification> Certifications { get; set; }

         IDbSet<Discussion> Discussions { get; set; }

         IDbSet<Experience> Experiences { get; set; }

         IDbSet<Group> Groups { get; set; }

         IDbSet<UserLanguage> Languages { get; set; }

         IDbSet<Project> Projects { get; set; }

         IDbSet<Skill> Skills { get; set; }

         IDbSet<Endorcement> Endorcements { get; set; }

         IDbSet<AdministrationLog> AdministrationLogs { get; set; }

        int SaveChanges();
    }
}
