
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CompraConfig : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("compra");

            builder.Property(x => x.Fecha)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne(a => a.Proveedor)
                   .WithMany(e => e.Compras)
                   .HasForeignKey(i => i.IdProveedor)
                   .IsRequired();
        }
    }
}