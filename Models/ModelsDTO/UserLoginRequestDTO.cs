using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.ModelsDTO
{
    public class UserLoginRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
