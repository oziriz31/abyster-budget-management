using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABStr.Budget.Manag.Migrations
{
    public partial class InitialCustomShema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCategory_AppCategory_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AppCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppOperation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    OpType = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOperation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOperation_AppCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AppCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppCategory_ParentId",
                table: "AppCategory",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOperation_CategoryId",
                table: "AppOperation",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppOperation");

            migrationBuilder.DropTable(
                name: "AppCategory");
        }
    }
}
