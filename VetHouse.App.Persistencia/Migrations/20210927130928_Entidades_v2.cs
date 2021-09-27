using Microsoft.EntityFrameworkCore.Migrations;

namespace VetHouse.App.Persistencia.Migrations
{
    public partial class Entidades_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreathingFreq",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "HeartRate",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "HealthStatus",
                table: "Histories",
                newName: "VitalSignsId");

            migrationBuilder.CreateTable(
                name: "VitalSigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeartRate = table.Column<float>(type: "real", nullable: false),
                    BreathingFreq = table.Column<float>(type: "real", nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    HealthStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalSigns", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Histories_VitalSignsId",
                table: "Histories",
                column: "VitalSignsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_VitalSigns_VitalSignsId",
                table: "Histories",
                column: "VitalSignsId",
                principalTable: "VitalSigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_VitalSigns_VitalSignsId",
                table: "Histories");

            migrationBuilder.DropTable(
                name: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_Histories_VitalSignsId",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "VitalSignsId",
                table: "Histories",
                newName: "HealthStatus");

            migrationBuilder.AddColumn<float>(
                name: "BreathingFreq",
                table: "Histories",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "HeartRate",
                table: "Histories",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Temperature",
                table: "Histories",
                type: "real",
                nullable: true);
        }
    }
}
