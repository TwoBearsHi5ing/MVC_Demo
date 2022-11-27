using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_CRUD_Demo.Migrations
{
    public partial class AddPhotopathColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "units",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "units");
        }
    }
}
