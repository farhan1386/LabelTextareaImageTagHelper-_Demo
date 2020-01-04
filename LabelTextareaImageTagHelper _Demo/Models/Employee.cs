using System.ComponentModel.DataAnnotations;

namespace LabelTextareaImageTagHelper__Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
