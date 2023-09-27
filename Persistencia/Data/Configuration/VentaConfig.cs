
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class VentaConfig : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("venta");

            builder.Property(x => x.Fecha)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne(a => a.Empleado)
                   .WithMany(e => e.Ventas)
                   .HasForeignKey(i => i.IdEmpleado)
                   .IsRequired();

            builder.HasOne(a => a.Paciente)
                   .WithMany(e => e.Ventas)
                   .HasForeignKey(i => i.IdPaciente)
                   .IsRequired();
        }
    }
}