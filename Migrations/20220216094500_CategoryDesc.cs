using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_management.Migrations
{
    public partial class CategoryDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BMCategory",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BMCategory");
        }
    }
}
