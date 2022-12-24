using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class FktoTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "text",
                nullable: true,
                comment: "Nazwa",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Teams",
                type: "text",
                nullable: true,
                comment: "Opis",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Teams",
                type: "text",
                nullable: true,
                comment: "Kraj",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Teams",
                type: "integer",
                nullable: true,
                comment: "Id właściciela drużyny");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_OwnerID",
                table: "Teams",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Users_OwnerID",
                table: "Teams",
                column: "OwnerID",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Users_OwnerID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_OwnerID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldComment: "Nazwa");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldComment: "Opis");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldComment: "Kraj");
        }
    }
}
