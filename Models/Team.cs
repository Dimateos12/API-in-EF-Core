using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Projekt.Models
{
    public class Team : BaseEntity
    {
        [Comment("Nazwa")]
        public string? Name { get; set; }

        [Comment("Kraj")]
        public string? Country { get; set; }
        
        [Comment("Opis")]
        public string? Description { get; set; }

        [Comment("Id właściciela drużyny")]
        public int? OwnerID { get; set; }
        public User? Owner { get; set; }


    }
}
