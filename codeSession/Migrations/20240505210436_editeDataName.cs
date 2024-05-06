using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codeSession.Migrations
{
    /// <inheritdoc />
    public partial class editeDataName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatePuplish",
                table: "Books3",
                newName: "Deadline");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "Books3",
                newName: "DatePuplish");
        }
    }
}
