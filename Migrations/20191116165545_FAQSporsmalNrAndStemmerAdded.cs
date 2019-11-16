using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class FAQSporsmalNrAndStemmerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "antallStemmer",
                table: "Sporsmaler");

            migrationBuilder.DropColumn(
                name: "poeng",
                table: "Sporsmaler");

            migrationBuilder.AddColumn<int>(
                name: "sporsmalNr",
                table: "Sporsmaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "totalOppStemmer",
                table: "Sporsmaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "totalStemmer",
                table: "Sporsmaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 1,
                column: "sporsmalNr",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 2,
                column: "sporsmalNr",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 3,
                column: "sporsmalNr",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 4,
                column: "sporsmalNr",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 5,
                column: "sporsmalNr",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sporsmalNr",
                table: "Sporsmaler");

            migrationBuilder.DropColumn(
                name: "totalOppStemmer",
                table: "Sporsmaler");

            migrationBuilder.DropColumn(
                name: "totalStemmer",
                table: "Sporsmaler");

            migrationBuilder.AddColumn<int>(
                name: "antallStemmer",
                table: "Sporsmaler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "poeng",
                table: "Sporsmaler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
