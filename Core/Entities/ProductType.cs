using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ProductType:BaseEntity
    {
        [Required]
        [MaxLength(50)]
         public string Name { get; set; }
    }
}