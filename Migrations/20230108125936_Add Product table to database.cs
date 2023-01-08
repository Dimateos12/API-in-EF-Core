using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class AddProducttabletodatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Id użytkownika")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false, comment: "Nazwa produktu"),
                    Price = table.Column<double>(type: "double precision", nullable: false, comment: "Cena produktu"),
                    Image = table.Column<string>(type: "text", nullable: true, comment: "Obraz produktu"),
                    ProductDescription = table.Column<string>(type: "text", nullable: false, comment: "Opis"),
                    ProductCategory = table.Column<string>(type: "text", nullable: false, comment: "Kategoria produktu"),
                    IsPopular = table.Column<string>(type: "text", nullable: false, comment: "Sekcja popularne"),
                    IsVisibility = table.Column<string>(type: "text", nullable: false, comment: "Produkt usuniety"),
                    Status = table.Column<int>(type: "integer", nullable: false, comment: "Status użytkownika"),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Data dodania"),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Data aktualizacji")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
