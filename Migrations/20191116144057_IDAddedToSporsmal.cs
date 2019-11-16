using Microsoft.EntityFrameworkCore.Migrations;

namespace TogbilletterOblig3.Migrations
{
    public partial class IDAddedToSporsmal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "iden",
                table: "Sporsmaler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 1,
                column: "iden",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 2,
                column: "iden",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 3,
                column: "iden",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 4,
                column: "iden",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sporsmaler",
                keyColumn: "ID",
                keyValue: 5,
                column: "iden",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iden",
                table: "Sporsmaler");
        }
    }
}
