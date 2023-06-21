﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GradesBooks.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradePercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "GradePercent", "Name" },
                values: new object[,]
                {
                    { 15783, 88m, "Rodrigo Nogueira" },
                    { 27689, 90m, "John Walker" },
                    { 31659, 72m, "Mel Gibson" },
                    { 42578, 56m, "Mary Johnson" },
                    { 50116, 90m, "Kylie Jenner" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradePercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "StudentId", "GradePercent", "Name" },
                values: new object[,]
                {
                    { 15783, 88m, "Rodrigo Nogueira" },
                    { 27689, 90m, "John Walker" },
                    { 31659, 72m, "Mel Gibson" },
                    { 42578, 56m, "Mary Johnson" },
                    { 50116, 78m, "Kylie Burner" }
                });
        }
    }
}
