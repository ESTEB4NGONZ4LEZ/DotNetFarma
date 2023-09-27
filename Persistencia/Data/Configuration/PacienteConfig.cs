
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PacienteConfig : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("paciente");

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
        }
    }
}