using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendlogVisualization.Migrations
{
    public partial class PicturePaths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Authors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Authors");
        }
    }
}
