
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CargoConfig : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
           builder.ToTable("cargo");

           builder.Property(x => x.Nombre)
                  .HasMaxLength(50)
                  .IsRequired();
        }
    }
}