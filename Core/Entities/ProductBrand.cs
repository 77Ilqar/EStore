using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ProductBrand:BaseEntity
    {
        [Required]
        [MaxLength(50)]
         public string Name { get; set; }
    }
}