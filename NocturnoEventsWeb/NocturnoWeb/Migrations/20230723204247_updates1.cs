using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NocturnoWeb.Migrations
{
    /// <inheritdoc />
    public partial class updates1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThumbnailSource",
                table: "Events",
                newName: "PosterUri");

            migrationBuilder.AddColumn<string>(
                name: "CoverUri",
                table: "Events",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverUri",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "PosterUri",
                table: "Events",
                newName: "ThumbnailSource");
        }
    }
}
