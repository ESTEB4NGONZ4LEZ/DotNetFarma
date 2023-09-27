
using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data.Seed;

namespace Persistencia
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Arl> Arls { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Eps> Epses { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<MedicamentoCompra> MedicamentoCompras { get; set; }
        public DbSet<MedicamentoVenta> MedicamentoVentas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }
    }
}