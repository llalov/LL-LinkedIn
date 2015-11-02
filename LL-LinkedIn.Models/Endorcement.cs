using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL_LinkedIn.Models
{
    public class Endorcement
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int UserSkillId { get; set; }

        public virtual UserSkill UserSkill { get; set; }
    }
}
