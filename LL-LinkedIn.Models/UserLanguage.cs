using System.ComponentModel.DataAnnotations;


namespace LL_LinkedIn.Models
{
    public class UserLanguage
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
