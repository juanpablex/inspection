using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_People_PersonId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PersonId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Bill",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bill",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PersonId",
                table: "Products",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_People_PersonId",
                table: "Products",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
