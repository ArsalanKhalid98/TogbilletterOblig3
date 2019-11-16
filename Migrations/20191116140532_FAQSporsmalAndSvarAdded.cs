using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class FAQSporsmalAndSvarAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Svarer");

            migrationBuilder.AddColumn<int>(
                name: "antallStemmer",
                table: "Sporsmaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "poeng",
                table: "Sporsmaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "svar",
                table: "Sporsmaler",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 1,
                column: "svar",
                value: "Vi jobber hele tiden med å utvide tilbudet vårt. Beklager for eventuelle problemer.");

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 2,
                column: "svar",
                value: "Du kan gå inn på nettsiden vår og kjøpe billetter.");

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 3,
                column: "svar",
                value: "Du kan sende epost til oss på Togbillett@Kundeservice.no");

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 4,
                column: "svar",
                value: "Ja alle togene våres har mulighet for barnevogn.");

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 5,
                column: "svar",
                value: "Send oss bilde av betalingen på epost, så skal vi fikse det.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "antallStemmer",
                table: "Sporsmaler");

            migrationBuilder.DropColumn(
                name: "poeng",
                table: "Sporsmaler");

            migrationBuilder.DropColumn(
                name: "svar",
                table: "Sporsmaler");

            migrationBuilder.CreateTable(
                name: "Svarer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    svar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Svarer", x => x.ID);
                });
        }
    }
}
