using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Promotion",
                table: "Contracts");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredInitialPaymentTime",
                table: "Contracts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Garante",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GarantePhone",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Promocion",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ProductId",
                table: "Contracts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Products_ProductId",
                table: "Contracts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Products_ProductId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ProductId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Garante",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "GarantePhone",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Promocion",
                table: "Contracts");

            migrationBuilder.AlterColumn<string>(
                name: "DeferredInitialPaymentTime",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<bool>(
                name: "Promotion",
                table: "Contracts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
