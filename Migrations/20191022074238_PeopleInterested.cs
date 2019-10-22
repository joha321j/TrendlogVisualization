using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendlogVisualization.Migrations
{
    public partial class PeopleInterested : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeopleInterested",
                table: "SuperData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeopleInterested",
                table: "SuperData");
        }
    }
}
