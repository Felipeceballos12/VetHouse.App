using Microsoft.EntityFrameworkCore.Migrations;

namespace VetHouse.App.Persistencia.Migrations
{
    public partial class Entidades_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Pets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
