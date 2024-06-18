using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoRelacionamentoArtistaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musica SET ArtistaId = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Musica SET ArtistaId = 2 WHERE Id = 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musica SET ArtistaId = 0 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Musica SET ArtistaId = 0 WHERE Id = 2");
        }
    }
}
