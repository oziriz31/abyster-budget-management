using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace budget_management.Migrations
{
    public partial class OperationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusType",
                table: "BMOperation",
                newName: "OpType");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "BMOperation",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpType",
                table: "BMOperation",
                newName: "StatusType");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "BMOperation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
