using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NocturnoWeb.Migrations
{
    /// <inheritdoc />
    public partial class MapSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MapEmbedding",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MapsUri",
                table: "Events",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapEmbedding",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "MapsUri",
                table: "Events");
        }
    }
}
