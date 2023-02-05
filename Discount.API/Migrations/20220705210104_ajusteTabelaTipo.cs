using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Discount.API.Migrations
{
    public partial class ajusteTabelaTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Coupon",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Coupon",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }
    }
}
