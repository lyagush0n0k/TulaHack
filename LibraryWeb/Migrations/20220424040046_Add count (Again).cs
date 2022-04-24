using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryWeb.Migrations
{
    public partial class AddcountAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Count",
                table: "Book",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Book");
        }
    }
}
