using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class KundeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: false),
                    Epost = table.Column<string>(nullable: false),
                    Sporsmal = table.Column<string>(nullable: false),
                    KundeNr = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Kunde",
                columns: new[] { "ID", "Epost", "KundeNr", "Navn", "Sporsmal" },
                values: new object[] { 1, "EliasKul123@gmail.com", 1, "Elias Larsen", "Hei, har dere planer om å få større toaletter på toget?" });

            migrationBuilder.InsertData(
                table: "Kunde",
                columns: new[] { "ID", "Epost", "KundeNr", "Navn", "Sporsmal" },
                values: new object[] { 2, "JørgenLetnes@outlook.com", 2, "Jørgen Letnes", "Når får dere flere avganger fra Trondheim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunde");
        }
    }
}
