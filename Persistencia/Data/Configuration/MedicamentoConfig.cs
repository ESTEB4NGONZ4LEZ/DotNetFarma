
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicamentoConfig : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.ToTable("medicamento");

            builder.Property(x => x.Nombre)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.Precio)
                   .HasColumnType("decimal(8, 2)")
                   .IsRequired();

            builder.Property(x => x.Precio)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(x => x.FechaExpiracion)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne(a => a.Proveedor)
                   .WithMany(e => e.Medicamentos)
                   .HasForeignKey(i => i.IdProveedor)
                   .IsRequired();
        }
    }
}