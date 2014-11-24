using System.ComponentModel.DataAnnotations;

namespace Demo.Entities
{
    /// <summary>
    /// catalog product
    /// </summary>
    public class Product
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}