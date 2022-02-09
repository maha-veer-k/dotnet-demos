using System.ComponentModel.DataAnnotations;

namespace MysqlUserAPI.Model
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }   
    }
}
