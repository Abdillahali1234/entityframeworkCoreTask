using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codeSession.Migrations
{
    /// <inheritdoc />
    public partial class editeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books3");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books3",
                table: "Books3",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books3",
                table: "Books3");

            migrationBuilder.RenameTable(
                name: "Books3",
                newName: "books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "ID");
        }
    }
}
