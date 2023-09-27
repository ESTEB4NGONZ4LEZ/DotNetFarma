
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicamentoCompraConfig : IEntityTypeConfiguration<MedicamentoCompra>
    {
        public void Configure(EntityTypeBuilder<MedicamentoCompra> builder)
        {
            builder.ToTable("medicamento_compra");

            builder.HasOne(a => a.Compra)
                   .WithMany(e => e.MedicamentoCompras)
                   .HasForeignKey(i => i.IdCompra)
                   .IsRequired();

            builder.HasOne(a => a.Medicamento)
                   .WithMany(e => e.MedicamentoCompras)
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