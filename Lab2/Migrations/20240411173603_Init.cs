using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FrontDefault = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PokemonEntries",
                columns: new[] { "Id", "FrontDefault", "Name" },
                values: new object[] { 1, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", "Bulbasaur" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonEntries");
        }
    }
}
