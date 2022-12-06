using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shop.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }
        [Display(Name ="Product Color")]
        public string ProductColor { get; set; }
        [Required]
        [Display(Name ="Available")]
        public bool IsAvailable { get; set; }
        [Display(Name ="Product Type")]
        [Required]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType ProductTypes { get; set; }
        [Display(Name ="Special Tag")]
        [Required]
        public int SpcialTagId { get; set; }
        [ForeignKey("SpcialTagId")]
        public specialTag specialTag  { get; set; }

    }
}
