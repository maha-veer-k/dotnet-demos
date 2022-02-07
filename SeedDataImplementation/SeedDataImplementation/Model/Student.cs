using System.ComponentModel.DataAnnotations;

namespace SeedDataImplementation.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is a required field")]
        [MaxLength(50, ErrorMessage = "Length must be less than 50")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
