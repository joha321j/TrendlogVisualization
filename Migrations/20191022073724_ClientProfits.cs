using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendlogVisualization.Migrations
{
    public partial class ClientProfits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientProfits",
                table: "SuperData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientProfits",
                table: "SuperData");
        }
    }
}
