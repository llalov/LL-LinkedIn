using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL_LinkedIn.Models
{
    public class Discussion
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Details { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
