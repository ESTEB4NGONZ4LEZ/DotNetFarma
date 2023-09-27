
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.Property(x => x.Username)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(x => x.Email)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Password)
                   .IsRequired();

            builder.HasIndex(x => new {x.Username, x.Email})
                   .IsUnique();

            builder.Property(x => x.IdUsuario)
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(a => a.Rol)
                   .WithMany(e => e.Usuarios)
                   .HasForeignKey(i => i.IdRol)
                   .IsRequired();
            
        }
    }
}