
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicamentoVentaConfig : IEntityTypeConfiguration<MedicamentoVenta>
    {
        public void Configure(EntityTypeBuilder<MedicamentoVenta> builder)
        {
            builder.ToTable("medicamento_venta");

            builder.HasOne(a => a.Venta)
                   .WithMany(e => e.MedicamentoVentas)
                   .HasForeignKey(i => i.IdVenta)
                   .IsRequired();

            builder.HasOne(a => a.Medicamento)
                   .WithMany(e => e.MedicamentoVentas)
                   .HasForeignKey(i => i.IdMedicamento)
                   .IsRequired();

            builder.Property(x => x.Cantidad)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(x => x.Precio)
                   .HasColumnType("decimal(8, 2)")
                   .IsRequired();
        }
    }
}