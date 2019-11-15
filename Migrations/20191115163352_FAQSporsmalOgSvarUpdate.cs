using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class FAQSporsmalOgSvarUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SporsmalOgSvar");

            migrationBuilder.AddColumn<int>(
                name: "SporsmalID",
                table: "Svarer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "antallStemmer",
                table: "Svarer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "poeng",
                table: "Svarer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Svarer_SporsmalID",
                table: "Svarer",
                column: "SporsmalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Svarer_Sporsmaler_SporsmalID",
                table: "Svarer",
                column: "SporsmalID",
                principalTable: "Sporsmaler",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Svarer_Sporsmaler_SporsmalID",
                table: "Svarer");

            migrationBuilder.DropIndex(
                name: "IX_Svarer_SporsmalID",
                table: "Svarer");

            migrationBuilder.DropColumn(
                name: "SporsmalID",
                table: "Svarer");

            migrationBuilder.DropColumn(
                name: "antallStemmer",
                table: "Svarer");

            migrationBuilder.DropColumn(
                name: "poeng",
                table: "Svarer");

            migrationBuilder.DropColumn(
                name: "antallStemmer",
                table: "Sporsmaler");

            migrationBuilder.DropColumn(
                name: "poeng",
                table: "Sporsmaler");

            migrationBuilder.CreateTable(
                name: "SporsmalOgSvar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spID = table.Column<int>(type: "int", nullable: true),
                    svarID = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_SporsmalOgSvar_spID",
                table: "SporsmalOgSvar",
                column: "spID");

            migrationBuilder.CreateIndex(
                name: "IX_SporsmalOgSvar_svarID",
                table: "SporsmalOgSvar",
                column: "svarID");
        }
    }
}
