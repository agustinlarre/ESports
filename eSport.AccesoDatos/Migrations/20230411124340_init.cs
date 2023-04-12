using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eSport.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Jugadoresporequipo = table.Column<int>(name: "Jugadores por equipo", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => new { x.Nombre, x.Jugadoresporequipo });
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Integrantes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ficha_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TorneoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuegoNombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JuegoJugadoresPorEquipo = table.Column<int>(type: "int", nullable: false),
                    GanadorId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conempate = table.Column<bool>(name: "Con empate", type: "bit", nullable: true),
                    Cantidaddegrupos = table.Column<int>(name: "Cantidad de grupos", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Torneos_Equipos_GanadorId",
                        column: x => x.GanadorId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Torneos_Juegos_JuegoNombre_JuegoJugadoresPorEquipo",
                        columns: x => new { x.JuegoNombre, x.JuegoJugadoresPorEquipo },
                        principalTable: "Juegos",
                        principalColumns: new[] { "Nombre", "Jugadores por equipo" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_TorneoId",
                table: "Equipos",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_GanadorId",
                table: "Torneos",
                column: "GanadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_JuegoNombre_JuegoJugadoresPorEquipo",
                table: "Torneos",
                columns: new[] { "JuegoNombre", "JuegoJugadoresPorEquipo" });

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Torneos_TorneoId",
                table: "Equipos",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Torneos_TorneoId",
                table: "Equipos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Juegos");
        }
    }
}
