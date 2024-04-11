using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonEntries",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PokemonEntries",
                columns: new[] { "Id", "FrontDefault", "Name" },
                values: new object[] { 1, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", "Bulbasaur" });
        }
    }
}
