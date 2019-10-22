using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendlogVisualization.Migrations
{
    public partial class OrderProfit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductPrice",
                table: "SuperData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "SuperData");
        }
    }
}
