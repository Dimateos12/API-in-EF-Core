using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Projekt.Models
{
    
    public class BaseEntity
    {
        [Comment("Id użytkownika")]
        public int Id { get; set; }

        [Comment("Status użytkownika")]
        public int Status { get; set; }
        [Comment("Data dodania")]
        public DateTime DateAdded { get; set; }

        [Comment("Data aktualizacji")]
        public DateTime DateUpdated { get; set; }

    }
}
