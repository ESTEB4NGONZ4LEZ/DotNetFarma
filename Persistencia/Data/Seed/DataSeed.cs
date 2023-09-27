
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data.Seed
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedor>()
                        .HasData
                        (
                            new Proveedor {Id = 1, Nombre = "ProveedorA", Telefono = "32335232", Email = "contacto@proveedora.com", Direccion = "Calle Proveedor 456"},
                            new Proveedor {Id = 2, Nombre = "ProveedorB", Telefono = "67835424", Email = "contacto@proveedorb.com", Direccion = "Calle Proveedor 789"},
                            new Proveedor {Id = 3, Nombre = "ProveedorC", Telefono = "34578724", Email = "contacto@proveedorc.com", Direccion = "Calle Proveedor 123"}
                        );

            modelBuilder.Entity<Pais>()
                        .HasData
                        (
                            new Pais {Id = 1, Nombre = "Colombia"},
                            new Pais {Id = 2, Nombre = "Argentina"},
                            new Pais {Id = 3, Nombre = "Mexico"}
                        );

            modelBuilder.Entity<Departamento>()
                        .HasData
                        (
                            new Departamento {Id = 1, Nombre = "Santander", IdPais = 1},
                            new Departamento {Id = 2, Nombre = "Buenos Aires", IdPais = 2},
                            new Departamento {Id = 3, Nombre = "Ciudad Mexico", IdPais = 3}
                        );

            modelBuilder.Entity<Ciudad>()
                        .HasData
                        (
                            new Ciudad {Id = 1, Nombre = "Bucaramanga", IdDepartamento = 1},
                            new Ciudad {Id = 2, Nombre = "Piedecuesta", IdDepartamento = 1},
                            new Ciudad {Id = 3, Nombre = "Giron", IdDepartamento = 1}
                        );

            modelBuilder.Entity<Cargo>()
                        .HasData
                        (
                            new Cargo {Id = 1, Nombre = "Gerente", Descripcion = "... Gerente"},
                            new Cargo {Id = 2, Nombre = "Administrador", Descripcion = "... Admin"},
                            new Cargo {Id = 3, Nombre = "Vendedor", Descripcion = "... Vendedor"}
                        );

            modelBuilder.Entity<Arl>()
                        .HasData
                        (
                            new Arl {Id = 1, Nombre = "Arl1", Telefono = "4342443324", Email = "arl1@gmail.com", Direccion = "Calle arl 456"},
                            new Arl {Id = 2, Nombre = "Arl2", Telefono = "2342346563", Email = "arl2@gmail.com", Direccion = "Calle arl 789"},
                            new Arl {Id = 3, Nombre = "Arl3", Telefono = "2457324355", Email = "arl3@gmail.com", Direccion = "Calle arl 123"}
                        );

            modelBuilder.Entity<Eps>()
                        .HasData
                        (
                            new Eps {Id = 1, Nombre = "Eps1", Telefono = "4342443324", Email = "eps1@gmail.com", Direccion = "Calle Eps 456"},
                            new Eps {Id = 2, Nombre = "Eps2", Telefono = "2342346563", Email = "eps2@gmail.com", Direccion = "Calle Eps 789"},
                            new Eps {Id = 3, Nombre = "Eps3", Telefono = "2457324355", Email = "eps3@gmail.com", Direccion = "Calle Eps 123"}
                        );

            modelBuilder.Entity<Paciente>()
                        .HasData
                        (
                            new Paciente {Id = 1, Nombres = "Juan", Apellidos = "Perez", Direccion = "Calle 123", Telefono = "555-1234"},
                            new Paciente {Id = 2, Nombres = "Maria", Apellidos = "Villamizar", Direccion = "Calle 456", Telefono = "555-5678"},
                            new Paciente {Id = 3, Nombres = "Luis", Apellidos = "Garcia", Direccion = "Calle 789", Telefono = "555-9012"}
                        );

            modelBuilder.Entity<Empleado>()
                        .HasData
                        (
                            new Empleado {Id = 1, Nombres = "Pedro", Apellidos = "Perez", Direccion = "Calle 123", Telefono = "555-1234", FechaContratacion = new DateTime(2020, 01, 01) , IdCargo = 3, IdCiudad = 1, IdArl = 1, IdEps = 1},
                            new Empleado {Id = 2, Nombres = "Ana", Apellidos = "Villamizar", Direccion = "Calle 123", Telefono = "555-1234", FechaContratacion = new DateTime(2019, 05, 15) , IdCargo = 3, IdCiudad = 1, IdArl = 2, IdEps = 2},
                            new Empleado {Id = 3, Nombres = "Luis", Apellidos = "Garcia", Direccion = "Calle 123", Telefono = "555-1234", FechaContratacion = new DateTime(2018, 02, 10) , IdCargo = 1, IdCiudad = 1, IdArl = 3, IdEps = 3},
                            new Empleado {Id = 4, Nombres = "Sofia", Apellidos = "Garcia", Direccion = "Calle 123", Telefono = "555-1234", FechaContratacion = new DateTime(2021, 03, 01) , IdCargo = 2, IdCiudad = 1, IdArl = 1, IdEps = 3}
                            
                        );

            modelBuilder.Entity<Compra>()
                        .HasData
                        (
                            new Compra {Id = 1, Fecha = new DateTime(2023, 01, 01), IdProveedor = 1},
                            new Compra {Id = 2, Fecha = new DateTime(2023, 01, 10), IdProveedor = 2},
                            new Compra {Id = 3, Fecha = new DateTime(2023, 02, 01), IdProveedor = 3},
                            new Compra {Id = 4, Fecha = new DateTime(2023, 02, 15), IdProveedor = 1},
                            new Compra {Id = 5, Fecha = new DateTime(2023, 03, 05), IdProveedor = 2},
                            new Compra {Id = 6, Fecha = new DateTime(2023, 04, 01), IdProveedor = 3},
                            new Compra {Id = 7, Fecha = new DateTime(2023, 04, 20), IdProveedor = 1},
                            new Compra {Id = 8, Fecha = new DateTime(2023, 05, 05), IdProveedor = 2},
                            new Compra {Id = 9, Fecha = new DateTime(2023, 06, 10), IdProveedor = 3},
                            new Compra {Id = 10, Fecha = new DateTime(2023, 06, 30), IdProveedor = 1}
                        );

            modelBuilder.Entity<Medicamento>()
                        .HasData
                        (
                            new Medicamento {Id = 1, Nombre = "Paracetamol", Precio = 20, Stock = 150, FechaExpiracion = new DateTime(2024, 06, 15), IdProveedor = 1},
                            new Medicamento {Id = 2, Nombre = "Ibuprofeno", Precio = 25, Stock = 50, FechaExpiracion = new DateTime(2024, 12, 01), IdProveedor = 2},
                            new Medicamento {Id = 3, Nombre = "Aspirina", Precio = 15, Stock = 30, FechaExpiracion = new DateTime(2024, 05, 20), IdProveedor = 3},
                            new Medicamento {Id = 4, Nombre = "Amoxicilina", Precio = 40, Stock = 75, FechaExpiracion = new DateTime(2025, 08, 11), IdProveedor = 1},
                            new Medicamento {Id = 5, Nombre = "Cetirizina", Precio = 10, Stock = 110, FechaExpiracion = new DateTime(2024, 01, 23), IdProveedor = 2},
                            new Medicamento {Id = 6, Nombre = "Losartan", Precio = 55, Stock = 95, FechaExpiracion = new DateTime(2024, 07, 30), IdProveedor = 3},
                            new Medicamento {Id = 7, Nombre = "Metformina", Precio = 60, Stock = 180, FechaExpiracion = new DateTime(2024, 09, 29), IdProveedor = 1},
                            new Medicamento {Id = 8, Nombre = "Atorvastatina", Precio = 45, Stock = 200, FechaExpiracion = new DateTime(2024, 10, 05), IdProveedor = 2},
                            new Medicamento {Id = 9, Nombre = "Clonazepam", Precio = 35, Stock = 25, FechaExpiracion = new DateTime(2024, 04, 21), IdProveedor = 3},
                            new Medicamento {Id = 10, Nombre = "Loratadina", Precio = 22, Stock = 120, FechaExpiracion = new DateTime(2025, 02, 19), IdProveedor = 1}
                        );

            modelBuilder.Entity<Venta>()
                        .HasData
                        (
                            new Venta {Id = 1, Fecha = new DateTime(2023, 01, 10), IdEmpleado = 1, IdPaciente = 1},
                            new Venta {Id = 2, Fecha = new DateTime(2023, 01, 15), IdEmpleado = 2, IdPaciente = 2},
                            new Venta {Id = 3, Fecha = new DateTime(2023, 02, 05), IdEmpleado = 1, IdPaciente = 3},
                            new Venta {Id = 4, Fecha = new DateTime(2023, 02, 12), IdEmpleado = 1, IdPaciente = 2},
                            new Venta {Id = 5, Fecha = new DateTime(2023, 03, 10), IdEmpleado = 2, IdPaciente = 1},
                            new Venta {Id = 6, Fecha = new DateTime(2023, 04, 15), IdEmpleado = 2, IdPaciente = 2},
                            new Venta {Id = 7, Fecha = new DateTime(2023, 05, 05), IdEmpleado = 1, IdPaciente = 2},
                            new Venta {Id = 8, Fecha = new DateTime(2023, 05, 25), IdEmpleado = 1, IdPaciente = 2},
                            new Venta {Id = 9, Fecha = new DateTime(2023, 06, 10), IdEmpleado = 2, IdPaciente = 1},
                            new Venta {Id = 10, Fecha = new DateTime(2023, 06, 30), IdEmpleado = 2, IdPaciente = 2}
                        );

            modelBuilder.Entity<MedicamentoCompra>()
                        .HasData
                        (
                            new MedicamentoCompra {Id = 1, IdCompra = 1, IdMedicamento = 1, Cantidad = 50, Precio = 15},
                            new MedicamentoCompra {Id = 2, IdCompra = 2, IdMedicamento = 2, Cantidad = 25, Precio = 20},
                            new MedicamentoCompra {Id = 3, IdCompra = 3, IdMedicamento = 3, Cantidad = 10, Precio = 12},
                            new MedicamentoCompra {Id = 4, IdCompra = 4, IdMedicamento = 4, Cantidad = 30, Precio = 35},
                            new MedicamentoCompra {Id = 5, IdCompra = 5, IdMedicamento = 5, Cantidad = 50, Precio = 8},
                            new MedicamentoCompra {Id = 6, IdCompra = 6, IdMedicamento = 6, Cantidad = 40, Precio = 50},
                            new MedicamentoCompra {Id = 7, IdCompra = 7, IdMedicamento = 7, Cantidad = 60, Precio = 55},
                            new MedicamentoCompra {Id = 8, IdCompra = 8, IdMedicamento = 8, Cantidad = 70, Precio = 40},
                            new MedicamentoCompra {Id = 9, IdCompra = 9, IdMedicamento = 9, Cantidad = 15, Precio = 32},
                            new MedicamentoCompra {Id = 10, IdCompra =10 , IdMedicamento = 10, Cantidad = 50, Precio = 20}
                        );

            modelBuilder.Entity<MedicamentoVenta>()
                        .HasData
                        (
                            new MedicamentoVenta {Id = 1, IdVenta = 1, IdMedicamento = 1,Cantidad = 2, Precio = 20},
                            new MedicamentoVenta {Id = 2, IdVenta = 2, IdMedicamento = 2,Cantidad = 1, Precio = 25},
                            new MedicamentoVenta {Id = 3, IdVenta = 2, IdMedicamento = 3,Cantidad = 2, Precio = 15},
                            new MedicamentoVenta {Id = 4, IdVenta = 3, IdMedicamento = 4,Cantidad = 1, Precio = 40},
                            new MedicamentoVenta {Id = 5, IdVenta = 4, IdMedicamento = 5,Cantidad = 1, Precio = 10},
                            new MedicamentoVenta {Id = 6, IdVenta = 5, IdMedicamento = 6,Cantidad = 1, Precio = 55},
                            new MedicamentoVenta {Id = 7, IdVenta = 6, IdMedicamento = 7,Cantidad = 1, Precio = 60},
                            new MedicamentoVenta {Id = 8, IdVenta = 7, IdMedicamento = 8,Cantidad = 1, Precio = 45},
                            new MedicamentoVenta {Id = 9, IdVenta = 8, IdMedicamento = 9,Cantidad = 1, Precio = 35},
                            new MedicamentoVenta {Id = 10, IdVenta = 9, IdMedicamento = 10,Cantidad = 1, Precio = 22},
                            new MedicamentoVenta {Id = 11, IdVenta = 10, IdMedicamento = 1,Cantidad = 2, Precio = 20}
                        );
        }
    }
}