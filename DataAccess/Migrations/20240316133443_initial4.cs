using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Products_ProductId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GetPeopleTye",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonTypeId = table.Column<int>(type: "int", nullable: false),
                    PersonTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetPeopleTye", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ClientId",
                table: "Contracts",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_People_ClientId",
                table: "Contracts",
                column: "ClientId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Products_ProductId",
                table: "Contracts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_People_ClientId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Products_ProductId",
                table: "Contracts");

            migrationBuilder.DropTable(
                name: "GetPeopleTye");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ClientId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Contracts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Products_ProductId",
                table: "Contracts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
