﻿using LL_LinkedIn.Data.Repositories;
using LL_LinkedIn.Models;

namespace LL_LinkedIn.Data
{
    public interface ILL_LinkedInData
    {
        IRepository<User> Users { get; }

        IRepository<Certification> Certifications { get; }

        IRepository<Discussion> Discussions { get; }

        IRepository<Experience> Experiences { get; }

        IRepository<Group> Groups { get; }

        IRepository<Project> Projects { get; }

        IRepository<Skill> Skills { get; }

        IRepository<Endorcement> Endorcements { get; }

        IRepository<AdministrationLog> AdministrationLogs { get; }

        int SaveChanges();
    }
}
