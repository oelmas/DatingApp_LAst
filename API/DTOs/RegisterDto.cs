using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string nameUser { get; set; }
        [Required]
        public string password { get; set; }
    }
}