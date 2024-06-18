using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] {"Nome", "Bio",
                "FotoPerfil"}, new object[] { "Claudio", "O claudio cantava muito", "foto.png" });

            migrationBuilder.InsertData("Artistas", new string[] {"Nome", "Bio",
                "FotoPerfil"}, new object[] { "Carlos", "O carlos cantava muito", "foto.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Artistas");
        }
    }
}
