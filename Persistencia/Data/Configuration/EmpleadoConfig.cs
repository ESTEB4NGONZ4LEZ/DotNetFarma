
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpleadoConfig : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleado");

            builder.Property(x => x.Nombres)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Apellidos)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Direccion)
                   .IsRequired();

            builder.Property(x => x.Telefono)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.FechaContratacion)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne(a => a.Cargo)
                   .WithMany(e => e.Empleados)
                   .HasForeignKey(i => i.IdCargo)
                   .IsRequired();

            builder.HasOne(a => a.Ciudad)
                   .WithMany(e => e.Empleados)
                   .HasForeignKey(i => i.IdCiudad)
                   .IsRequired();

            builder.HasOne(a => a.Arl)
                   .WithMany(e => e.Empleados)
                   .HasForeignKey(i => i.IdArl)
                   .IsRequired();

            builder.HasOne(a => a.Eps)
                   .WithMany(e => e.Empleados)
                   .HasForeignKey(i => i.IdEps)
                   .IsRequired();
        }
    }
}