using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SnappExam.Infrastructure.Persistence.EF.Migrations
{
    /// <inheritdoc />
    public partial class addseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "InsertionTime", "IsActive", "IsDelete", "ModificationTime", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1956, 12, 2, 18, 29, 13, 0, DateTimeKind.Unspecified), true, false, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(6017), "case" },
                    { 2, new DateTime(1957, 10, 8, 16, 36, 9, 0, DateTimeKind.Unspecified), true, true, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(6731), "ennui" },
                    { 3, new DateTime(1937, 4, 16, 16, 10, 19, 0, DateTimeKind.Unspecified), true, false, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(7150), "future" },
                    { 4, new DateTime(2015, 6, 15, 15, 24, 58, 0, DateTimeKind.Unspecified), true, true, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(7601), "Gluten-free" },
                    { 5, new DateTime(1941, 1, 28, 7, 43, 27, 0, DateTimeKind.Unspecified), true, true, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(8032), "Vinyl" },
                    { 6, new DateTime(1904, 2, 13, 18, 37, 40, 0, DateTimeKind.Unspecified), true, false, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(8484), "gentrify" },
                    { 7, new DateTime(2003, 12, 1, 20, 32, 28, 0, DateTimeKind.Unspecified), true, true, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(8920), "haven't" },
                    { 8, new DateTime(1956, 4, 3, 19, 33, 6, 0, DateTimeKind.Unspecified), true, false, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(9347), "Gluten-free" },
                    { 9, new DateTime(1945, 12, 17, 16, 30, 48, 0, DateTimeKind.Unspecified), true, false, new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(9774), "american" },
                    { 10, new DateTime(1901, 10, 4, 18, 19, 59, 0, DateTimeKind.Unspecified), true, false, new DateTime(2024, 2, 20, 17, 33, 36, 84, DateTimeKind.Local).AddTicks(171), "rights" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
