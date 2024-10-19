using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumReview.Migrations
{
    /// <inheritdoc />
    public partial class MigrationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Albums",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Albums");
        }
    }
}
