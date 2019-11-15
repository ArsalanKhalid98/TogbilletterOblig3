using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class FAQSvarAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SporsmalOgSvar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    svarID = table.Column<int>(nullable: true),
                    spID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SporsmalOgSvar", x => x.id);
                    table.ForeignKey(
                        name: "FK_SporsmalOgSvar_Sporsmaler_spID",
                        column: x => x.spID,
                        principalTable: "Sporsmaler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SporsmalOgSvar_Svarer_svarID",
                        column: x => x.svarID,
                        principalTable: "Svarer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Svarer",
                columns: new[] { "ID", "svar" },
                values: new object[,]
                {
                    { 1, "Vi jobber hele tiden med å utvide tilbudet vårt. Beklager for eventuelle problemer." },
                    { 2, "Du kan gå inn på nettsiden vår og kjøpe billetter." },
                    { 3, "Du kan sende epost til oss på Togbillett@Kundeservice.no" },
                    { 4, "Ja alle togene våres har mulighet for barnevogn." },
                    { 5, "Send oss bilde av betalingen på epost, så skal vi fikse det." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SporsmalOgSvar_spID",
                table: "SporsmalOgSvar",
                column: "spID");

            migrationBuilder.CreateIndex(
                name: "IX_SporsmalOgSvar_svarID",
                table: "SporsmalOgSvar",
                column: "svarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SporsmalOgSvar");

            migrationBuilder.DeleteData(
                table: "Svarer",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Svarer",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Svarer",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Svarer",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Svarer",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
