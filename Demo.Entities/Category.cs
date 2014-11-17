using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Entities
{
    /// <summary>
    /// catalog category
    /// </summary>
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public IEnumerable<Category> Children;
    }
}