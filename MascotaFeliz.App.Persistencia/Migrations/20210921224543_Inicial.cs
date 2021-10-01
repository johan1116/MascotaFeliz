using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropietarioMascotaId = table.Column<int>(type: "int", nullable: true),
                    TipoMascota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascota_Persona_PropietarioMascotaId",
                        column: x => x.PropietarioMascotaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisitaDomiciliaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeterinarioId = table.Column<int>(type: "int", nullable: true),
                    MascotaId = table.Column<int>(type: "int", nullable: true),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdProfesional = table.Column<int>(type: "int", nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FRespiratoria = table.Column<float>(type: "real", nullable: false),
                    FCardiaca = table.Column<float>(type: "real", nullable: false),
                    EstadoAnimo = table.Column<int>(type: "int", nullable: false),
                    Recomendacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitaDomiciliaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitaDomiciliaria_Mascota_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisitaDomiciliaria_Persona_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_PropietarioMascotaId",
                table: "Mascota",
                column: "PropietarioMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitaDomiciliaria_MascotaId",
                table: "VisitaDomiciliaria",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitaDomiciliaria_VeterinarioId",
                table: "VisitaDomiciliaria",
                column: "VeterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitaDomiciliaria");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
