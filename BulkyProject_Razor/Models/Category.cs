using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyProject_Razor.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public String? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
