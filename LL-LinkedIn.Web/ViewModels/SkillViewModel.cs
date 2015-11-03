using System;
using System.Linq;
using System.Linq.Expressions;
using LL_LinkedIn.Models;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace LL_LinkedIn.Web.ViewModels
{
    public class SkillViewModel
    {
        public static Expression<Func<UserSkill, SkillViewModel>> ViewModel
        {
            get
            {
                return x => new SkillViewModel()
                {
                    Id = x.Id,
                    Name = x.Skill.Name,
                    EndorcementsCount = x.Endorcements.Count,
                    Endorcers = x.Endorcements.Select(e => e.User.UserName) 
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int EndorcementsCount { get; set; }

        public IEnumerable<string> Endorcers { get; set; } 
    }
}