using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LL_LinkedIn.Models
{
    [ComplexType]
    public class ContactInfo
    {
        [DisplayFormat(NullDisplayText = "No")]
        public string Phone { get; set; }

        [DisplayFormat(NullDisplayText = "No")]
        public string Twitter { get; set; }

        [DisplayFormat(NullDisplayText = "No")]
        public string Website { get; set; }

        [DisplayFormat(NullDisplayText = "No")]
        public string Facebook { get; set; }
    }
}
