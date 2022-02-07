using System.ComponentModel.DataAnnotations;

namespace TestWebApi.API.Model
{
    public class SignUpModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "First Name Length Must be less than 20")]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(20, ErrorMessage = "Last Name Length Must be less than 20")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Should be in Email format")]
        public string Email { get; set; }
        
        [Required]
        [StringLength(6, ErrorMessage = "Password Length must be 6")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
