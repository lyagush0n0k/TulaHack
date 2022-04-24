using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryWeb.Data.Migrations
{
    public partial class TTTT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_AspNetUsers_ApplicationUserId",
                schema: "Identity",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Count",
                schema: "Identity",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                schema: "Identity",
                table: "Book",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_ApplicationUserId",
                schema: "Identity",
                table: "Book",
                newName: "IX_Book_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_AspNetUsers_UserId",
                schema: "Identity",
                table: "Book",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_AspNetUsers_UserId",
                schema: "Identity",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "Identity",
                table: "Book",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_UserId",
                schema: "Identity",
                table: "Book",
                newName: "IX_Book_ApplicationUserId");

            migrationBuilder.AddColumn<long>(
                name: "Count",
                schema: "Identity",
                table: "Book",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_AspNetUsers_ApplicationUserId",
                schema: "Identity",
                table: "Book",
                column: "ApplicationUserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
