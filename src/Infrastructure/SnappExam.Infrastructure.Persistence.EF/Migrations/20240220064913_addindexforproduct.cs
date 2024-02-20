using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnappExam.Infrastructure.Persistence.EF.Migrations
{
    /// <inheritdoc />
    public partial class addindexforproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_Title",
                table: "Products",
                column: "Title",
                unique: true,
                filter: "[Title] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Title",
                table: "Products");
        }
    }
}
