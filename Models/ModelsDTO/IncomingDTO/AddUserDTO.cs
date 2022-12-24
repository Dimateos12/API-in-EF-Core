using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.ModelsDTO.IncomingDTO
{
    public class AddUserDTO
    {
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        [MaxLength(12)]
        public string Password { get; set; }

    }
}
