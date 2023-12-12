using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
/*             migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoriapersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipocontacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipodireccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipopersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "turno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraInicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    HoraFin = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "departamento_ibfk_1",
                        column: x => x.IdPaisFk,
                        principalTable: "pais",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamentoFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "ciudad_ibfk_1",
                        column: x => x.IdDepartamentoFk,
                        principalTable: "departamento",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: true),
                    IdCategoriaFk = table.Column<int>(type: "int", nullable: true),
                    IdCiudadFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "persona_ibfk_1",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "tipopersona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "persona_ibfk_2",
                        column: x => x.IdCategoriaFk,
                        principalTable: "categoriapersona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "persona_ibfk_3",
                        column: x => x.IdCiudadFk,
                        principalTable: "ciudad",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contactopersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: true),
                    IdTipoContactoFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "contactopersona_ibfk_1",
                        column: x => x.IdPersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "contactopersona_ibfk_2",
                        column: x => x.IdTipoContactoFk,
                        principalTable: "tipocontacto",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: true),
                    FechaContrato = table.Column<DateOnly>(type: "date", nullable: true),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: true),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: true),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "contrato_ibfk_1",
                        column: x => x.IdClienteFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "contrato_ibfk_2",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "contrato_ibfk_3",
                        column: x => x.IdEstadoFk,
                        principalTable: "estado",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "direccionpersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: true),
                    IdTipoDireccionFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "direccionpersona_ibfk_1",
                        column: x => x.IdPersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "direccionpersona_ibfk_2",
                        column: x => x.IdTipoDireccionFk,
                        principalTable: "tipodireccion",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "programacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdContratoFk = table.Column<int>(type: "int", nullable: true),
                    IdTurnoFk = table.Column<int>(type: "int", nullable: true),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "programacion_ibfk_1",
                        column: x => x.IdContratoFk,
                        principalTable: "contrato",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "programacion_ibfk_2",
                        column: x => x.IdTurnoFk,
                        principalTable: "turno",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "programacion_ibfk_4",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk");

            migrationBuilder.CreateIndex(
                name: "IdPersonaFk",
                table: "contactopersona",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IdTipoContactoFk",
                table: "contactopersona",
                column: "IdTipoContactoFk");

            migrationBuilder.CreateIndex(
                name: "IdClienteFk",
                table: "contrato",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IdEmpleadoFk",
                table: "contrato",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IdEstadoFk",
                table: "contrato",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IdPaisFk",
                table: "departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IdPersonaFk1",
                table: "direccionpersona",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IdTipoDireccionFk",
                table: "direccionpersona",
                column: "IdTipoDireccionFk");

            migrationBuilder.CreateIndex(
                name: "IdCategoriaFk",
                table: "persona",
                column: "IdCategoriaFk");

            migrationBuilder.CreateIndex(
                name: "IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk");

            migrationBuilder.CreateIndex(
                name: "IdTipoPersonaFk",
                table: "persona",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IdContratoFk",
                table: "programacion",
                column: "IdContratoFk");

            migrationBuilder.CreateIndex(
                name: "IdEmpleadoFk1",
                table: "programacion",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IdTurnoFk",
                table: "programacion",
                column: "IdTurnoFk"); */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.DropTable(
                name: "contactopersona");

            migrationBuilder.DropTable(
                name: "direccionpersona");

            migrationBuilder.DropTable(
                name: "programacion");

            migrationBuilder.DropTable(
                name: "tipocontacto");

            migrationBuilder.DropTable(
                name: "tipodireccion");

            migrationBuilder.DropTable(
                name: "contrato");

            migrationBuilder.DropTable(
                name: "turno");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "tipopersona");

            migrationBuilder.DropTable(
                name: "categoriapersona");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "pais"); */
        }
    }
}
