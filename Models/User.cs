using Microsoft.EntityFrameworkCore;

namespace Projekt.Models
{
    public class User : BaseEntity
    {
        [Comment("Imię użytkownika")]
        public string Name { get; set; }

        [Comment("Email użytkownika")]
        public string Email { get; set; }

        [Comment("Hasło użytkownika")]
        public string Password { get; set; }

        public List<Team>? Team { get; set; }

    }
}
