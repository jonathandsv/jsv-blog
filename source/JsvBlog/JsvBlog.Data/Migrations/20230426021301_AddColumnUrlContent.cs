using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsvBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnUrlContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlContent",
                table: "Post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlContent",
                table: "Post");
        }
    }
}
