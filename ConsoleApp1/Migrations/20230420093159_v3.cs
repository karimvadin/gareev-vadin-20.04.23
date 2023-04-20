using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("49632c36-c6f9-44a7-803a-34c448df50ff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("c0777496-98de-49d9-9738-184e77d20d8b"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("7fd4a9f8-b410-4319-a2e2-ec49008bd580"), "Овощи" },
                    { new Guid("c1fc30e8-e403-4d8e-b84d-8721021c9381"), "Фрукты" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("7fd4a9f8-b410-4319-a2e2-ec49008bd580"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("c1fc30e8-e403-4d8e-b84d-8721021c9381"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("49632c36-c6f9-44a7-803a-34c448df50ff"), "Овощи" },
                    { new Guid("c0777496-98de-49d9-9738-184e77d20d8b"), "Фрукты" }
                });
        }
    }
}
