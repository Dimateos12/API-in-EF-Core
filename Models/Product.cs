using Microsoft.EntityFrameworkCore;

namespace Projekt.Models
{
    public class Product : BaseEntity
    {
        [Comment("Nazwa produktu")]
        public string ProductName { get; set; }

        [Comment("Cena produktu")]
        public double Price { get; set; }

        [Comment("Obraz produktu")]
        public string? Image { get; set; }

        [Comment("Opis")]

        public string ProductDescription { get; set; }

        [Comment("Kategoria produktu")]
        public string ProductCategory { get; set; }

        [Comment("Sekcja popularne")]
        public string IsPopular { get; set; }

        [Comment("Produkt usuniety")]
        public bool IsVisibility { get; set; }
    }
}
