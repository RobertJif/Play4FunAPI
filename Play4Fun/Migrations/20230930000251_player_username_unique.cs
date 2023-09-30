using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Play4Fun.Migrations
{
    /// <inheritdoc />
    public partial class player_username_unique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_players_username",
                table: "players",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_players_username",
                table: "players");
        }
    }
}
