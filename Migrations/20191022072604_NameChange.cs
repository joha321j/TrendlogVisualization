using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendlogVisualization.Migrations
{
    public partial class NameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperData",
                table: "SuperDatas");

            migrationBuilder.RenameTable(
                name: "SuperDatas",
                newName: "SuperData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperData",
                table: "SuperData",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperData",
                table: "SuperData");

            migrationBuilder.RenameTable(
                name: "SuperData",
                newName: "SuperDatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperDatas",
                table: "SuperDatas",
                column: "Id");
        }
    }
}
