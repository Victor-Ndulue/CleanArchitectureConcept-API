using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanArchitectureConcept_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Country", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "3d490a70-94ce-4d15-9494-5248280c2ce3", "312 Forest Avenue, BF 923", "USA", new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1622), new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1622), "Admin_Solutions Ltd" },
                    { "c9d4c053-49b6-410c-bc78-2d54a9991870", "583 Wall Dr. Gwynn Oak, MD 21207", "USA", new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1579), "IT_Solutions Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CompanyId", "CreatedAt", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { "80abbca8-664d-4b20-b5de-024705497d4a", 26, "c9d4c053-49b6-410c-bc78-2d54a9991870", new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2033), new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2034), "Sam Raiden", "Software developer" },
                    { "86dba8c0-d178-41e7-938c-ed49778fb52a", 30, "3d490a70-94ce-4d15-9494-5248280c2ce3", new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2046), "Jana McLeaf", "Software developer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
