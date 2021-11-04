using Microsoft.EntityFrameworkCore.Migrations;

namespace VetHouse.App.Persistencia.Migrations
{
    public partial class Entidadesv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_Histories_HistoryId",
                table: "VitalSigns");

            migrationBuilder.RenameColumn(
                name: "HistoryId",
                table: "VitalSigns",
                newName: "historyId");

            migrationBuilder.RenameIndex(
                name: "IX_VitalSigns_HistoryId",
                table: "VitalSigns",
                newName: "IX_VitalSigns_historyId");

            migrationBuilder.AddColumn<int>(
                name: "idHistory",
                table: "VitalSigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "careSuggestionId",
                table: "CareSuggestions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idCareSuggestion",
                table: "CareSuggestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CareSuggestions_careSuggestionId",
                table: "CareSuggestions",
                column: "careSuggestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CareSuggestions_CareSuggestions_careSuggestionId",
                table: "CareSuggestions",
                column: "careSuggestionId",
                principalTable: "CareSuggestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_Histories_historyId",
                table: "VitalSigns",
                column: "historyId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareSuggestions_CareSuggestions_careSuggestionId",
                table: "CareSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_Histories_historyId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_CareSuggestions_careSuggestionId",
                table: "CareSuggestions");

            migrationBuilder.DropColumn(
                name: "idHistory",
                table: "VitalSigns");

            migrationBuilder.DropColumn(
                name: "careSuggestionId",
                table: "CareSuggestions");

            migrationBuilder.DropColumn(
                name: "idCareSuggestion",
                table: "CareSuggestions");

            migrationBuilder.RenameColumn(
                name: "historyId",
                table: "VitalSigns",
                newName: "HistoryId");

            migrationBuilder.RenameIndex(
                name: "IX_VitalSigns_historyId",
                table: "VitalSigns",
                newName: "IX_VitalSigns_HistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_Histories_HistoryId",
                table: "VitalSigns",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
