using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Online_Shop.Models
{
    public class specialTag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string specialTageName { get; set; }

    }
}
