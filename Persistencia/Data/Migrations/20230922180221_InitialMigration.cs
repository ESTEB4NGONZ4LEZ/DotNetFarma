using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "arl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arl", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "eps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eps", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paciente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departamento_pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_compra_proveedor_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "date", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamento_proveedor_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_rol_IdRol",
                        column: x => x.IdRol,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ciudad_departamento_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamento_compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCompra = table.Column<int>(type: "int", nullable: false),
                    IdMedicamento = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamento_compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamento_compra_compra_IdCompra",
                        column: x => x.IdCompra,
                        principalTable: "compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamento_compra_medicamento_IdMedicamento",
                        column: x => x.IdMedicamento,
                        principalTable: "medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "refresh_token",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime", nullable: false),
                    EsRevocado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EstaActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refresh_token", x => x.Id);
                    table.ForeignKey(
                        name: "FK_refresh_token_usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaContratacion = table.Column<DateTime>(type: "date", nullable: false),
                    IdCargo = table.Column<int>(type: "int", nullable: false),
                    IdCiudad = table.Column<int>(type: "int", nullable: false),
                    IdArl = table.Column<int>(type: "int", nullable: false),
                    IdEps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empleado_arl_IdArl",
                        column: x => x.IdArl,
                        principalTable: "arl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_cargo_IdCargo",
                        column: x => x.IdCargo,
                        principalTable: "cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_ciudad_IdCiudad",
                        column: x => x.IdCiudad,
                        principalTable: "ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_eps_IdEps",
                        column: x => x.IdEps,
                        principalTable: "eps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_venta_empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamento_venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdMedicamento = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamento_venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamento_venta_medicamento_IdMedicamento",
                        column: x => x.IdMedicamento,
                        principalTable: "medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamento_venta_venta_IdVenta",
                        column: x => x.IdVenta,
                        principalTable: "venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "arl",
                columns: new[] { "Id", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Calle arl 456", "arl1@gmail.com", "Arl1", "4342443324" },
                    { 2, "Calle arl 789", "arl2@gmail.com", "Arl2", "2342346563" },
                    { 3, "Calle arl 123", "arl3@gmail.com", "Arl3", "2457324355" }
                });

            migrationBuilder.InsertData(
                table: "cargo",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "... Gerente", "Gerente" },
                    { 2, "... Admin", "Administrador" },
                    { 3, "... Vendedor", "Vendedor" }
                });

            migrationBuilder.InsertData(
                table: "eps",
                columns: new[] { "Id", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Calle Eps 456", "eps1@gmail.com", "Eps1", "4342443324" },
                    { 2, "Calle Eps 789", "eps2@gmail.com", "Eps2", "2342346563" },
                    { 3, "Calle Eps 123", "eps3@gmail.com", "Eps3", "2457324355" }
                });

            migrationBuilder.InsertData(
                table: "paciente",
                columns: new[] { "Id", "Apellidos", "Direccion", "Nombres", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", "Calle 123", "Juan", "555-1234" },
                    { 2, "Villamizar", "Calle 456", "Maria", "555-5678" },
                    { 3, "Garcia", "Calle 789", "Luis", "555-9012" }
                });

            migrationBuilder.InsertData(
                table: "pais",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Colombia" },
                    { 2, "Argentina" },
                    { 3, "Mexico" }
                });

            migrationBuilder.InsertData(
                table: "proveedor",
                columns: new[] { "Id", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Calle Proveedor 456", "contacto@proveedora.com", "ProveedorA", "32335232" },
                    { 2, "Calle Proveedor 789", "contacto@proveedorb.com", "ProveedorB", "67835424" },
                    { 3, "Calle Proveedor 123", "contacto@proveedorc.com", "ProveedorC", "34578724" }
                });

            migrationBuilder.InsertData(
                table: "compra",
                columns: new[] { "Id", "Fecha", "IdProveedor" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "departamento",
                columns: new[] { "Id", "IdPais", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Santander" },
                    { 2, 2, "Buenos Aires" },
                    { 3, 3, "Ciudad Mexico" }
                });

            migrationBuilder.InsertData(
                table: "medicamento",
                columns: new[] { "Id", "FechaExpiracion", "IdProveedor", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Paracetamol", 20, 150 },
                    { 2, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Ibuprofeno", 25, 50 },
                    { 3, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Aspirina", 15, 30 },
                    { 4, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Amoxicilina", 40, 75 },
                    { 5, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cetirizina", 10, 110 },
                    { 6, new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Losartan", 55, 95 },
                    { 7, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Metformina", 60, 180 },
                    { 8, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Atorvastatina", 45, 200 },
                    { 9, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Clonazepam", 35, 25 },
                    { 10, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Loratadina", 22, 120 }
                });

            migrationBuilder.InsertData(
                table: "ciudad",
                columns: new[] { "Id", "IdDepartamento", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Bucaramanga" },
                    { 2, 1, "Piedecuesta" },
                    { 3, 1, "Giron" }
                });

            migrationBuilder.InsertData(
                table: "medicamento_compra",
                columns: new[] { "Id", "Cantidad", "IdCompra", "IdMedicamento", "Precio" },
                values: new object[,]
                {
                    { 1, 50, 1, 1, 15m },
                    { 2, 25, 2, 2, 20m },
                    { 3, 10, 3, 3, 12m },
                    { 4, 30, 4, 4, 35m },
                    { 5, 50, 5, 5, 8m },
                    { 6, 40, 6, 6, 50m },
                    { 7, 60, 7, 7, 55m },
                    { 8, 70, 8, 8, 40m },
                    { 9, 15, 9, 9, 32m },
                    { 10, 50, 10, 10, 20m }
                });

            migrationBuilder.InsertData(
                table: "empleado",
                columns: new[] { "Id", "Apellidos", "Direccion", "FechaContratacion", "IdArl", "IdCargo", "IdCiudad", "IdEps", "Nombres", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", "Calle 123", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1, 1, "Pedro", "555-1234" },
                    { 2, "Villamizar", "Calle 123", new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, 1, 2, "Ana", "555-1234" },
                    { 3, "Garcia", "Calle 123", new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 3, "Luis", "555-1234" },
                    { 4, "Garcia", "Calle 123", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, 3, "Sofia", "555-1234" }
                });

            migrationBuilder.InsertData(
                table: "venta",
                columns: new[] { "Id", "Fecha", "IdEmpleado", "IdPaciente" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 4, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 5, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 6, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 7, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 8, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 9, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 10, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "medicamento_venta",
                columns: new[] { "Id", "Cantidad", "IdMedicamento", "IdVenta", "Precio" },
                values: new object[,]
                {
                    { 1, 2, 1, 1, 20m },
                    { 2, 1, 2, 2, 25m },
                    { 3, 2, 3, 2, 15m },
                    { 4, 1, 4, 3, 40m },
                    { 5, 1, 5, 4, 10m },
                    { 6, 1, 6, 5, 55m },
                    { 7, 1, 7, 6, 60m },
                    { 8, 1, 8, 7, 45m },
                    { 9, 1, 9, 8, 35m },
                    { 10, 1, 10, 9, 22m },
                    { 11, 2, 1, 10, 20m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_IdDepartamento",
                table: "ciudad",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_compra_IdProveedor",
                table: "compra",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_IdPais",
                table: "departamento",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdArl",
                table: "empleado",
                column: "IdArl");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdCargo",
                table: "empleado",
                column: "IdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdCiudad",
                table: "empleado",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdEps",
                table: "empleado",
                column: "IdEps");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_IdProveedor",
                table: "medicamento",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_compra_IdCompra",
                table: "medicamento_compra",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_compra_IdMedicamento",
                table: "medicamento_compra",
                column: "IdMedicamento");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_venta_IdMedicamento",
                table: "medicamento_venta",
                column: "IdMedicamento");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_venta_IdVenta",
                table: "medicamento_venta",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_refresh_token_IdUsuario",
                table: "refresh_token",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdRol",
                table: "usuario",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_Username_Email",
                table: "usuario",
                columns: new[] { "Username", "Email" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdEmpleado",
                table: "venta",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdPaciente",
                table: "venta",
                column: "IdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medicamento_compra");

            migrationBuilder.DropTable(
                name: "medicamento_venta");

            migrationBuilder.DropTable(
                name: "refresh_token");

            migrationBuilder.DropTable(
                name: "compra");

            migrationBuilder.DropTable(
                name: "medicamento");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "paciente");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "arl");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "eps");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
