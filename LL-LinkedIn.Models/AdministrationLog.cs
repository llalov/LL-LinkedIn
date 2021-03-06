﻿using System.ComponentModel.DataAnnotations;

namespace LL_LinkedIn.Models
{
    public class AdministrationLog
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string IpAddress { get; set; }

        public string Requestedtype { get; set; }

        public string Url { get; set; }

        public string PostParams { get; set; }

    }
}
