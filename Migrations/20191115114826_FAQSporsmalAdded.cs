using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class FAQSporsmalAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sporsmaler",
                columns: new[] { "ID", "sp" },
                values: new object[,]
                {
                    { 1, "Hvorfor går ikke toget fra stasjonen min?" },
                    { 2, "Hvordan kjøper jeg billett?" },
                    { 3, "Noe gikk galt med bestillingen min. Hva gjør jeg?" },
                    { 4, "Kan jeg ta med barnevogn?" },
                    { 5, "Jeg ble trukket penger, men fikk ingen billett?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
