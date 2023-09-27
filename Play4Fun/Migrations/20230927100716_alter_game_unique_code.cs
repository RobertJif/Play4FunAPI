using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Play4Fun.Migrations
{
    /// <inheritdoc />
    public partial class alter_game_unique_code : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Games_Code",
                table: "Games",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_Code",
                table: "Games");
        }
    }
}
