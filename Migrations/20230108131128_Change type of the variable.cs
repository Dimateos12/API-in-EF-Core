using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class Changetypeofthevariable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsVisibility",
                table: "Products",
                type: "boolean",
                nullable: false,
                comment: "Produkt usuniety",
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Produkt usuniety");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsVisibility",
                table: "Products",
                type: "text",
                nullable: false,
                comment: "Produkt usuniety",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldComment: "Produkt usuniety");
        }
    }
}
