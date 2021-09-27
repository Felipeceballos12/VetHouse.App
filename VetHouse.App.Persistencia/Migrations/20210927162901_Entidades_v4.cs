using Microsoft.EntityFrameworkCore.Migrations;

namespace VetHouse.App.Persistencia.Migrations
{
    public partial class Entidades_v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Histories_CareSuggestionsId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_VitalSigns_VitalSignsId",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "VitalSignsId",
                table: "Histories",
                newName: "VitalSignId");

            migrationBuilder.RenameColumn(
                name: "CareSuggestionsId",
                table: "Histories",
                newName: "CareSuggestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_VitalSignsId",
                table: "Histories",
                newName: "IX_Histories_VitalSignId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_CareSuggestionsId",
                table: "Histories",
                newName: "IX_Histories_CareSuggestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Histories_CareSuggestionId",
                table: "Histories",
                column: "CareSuggestionId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_VitalSigns_VitalSignId",
                table: "Histories",
                column: "VitalSignId",
                principalTable: "VitalSigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Histories_CareSuggestionId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_VitalSigns_VitalSignId",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "VitalSignId",
                table: "Histories",
                newName: "VitalSignsId");

            migrationBuilder.RenameColumn(
                name: "CareSuggestionId",
                table: "Histories",
                newName: "CareSuggestionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_VitalSignId",
                table: "Histories",
                newName: "IX_Histories_VitalSignsId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_CareSuggestionId",
                table: "Histories",
                newName: "IX_Histories_CareSuggestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Histories_CareSuggestionsId",
                table: "Histories",
                column: "CareSuggestionsId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_VitalSigns_VitalSignsId",
                table: "Histories",
                column: "VitalSignsId",
                principalTable: "VitalSigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
