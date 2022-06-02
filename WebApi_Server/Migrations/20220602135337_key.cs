using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi_Server.Migrations
{
    public partial class key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
