
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class RefreshTokenConfig : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("refresh_token");

            builder.Property(x => x.Token)
                   .IsRequired();

            builder.Property(x => x.FechaCreacion)
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(x => x.FechaExpiracion)
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(x => x.EsRevocado)
                   .IsRequired();

            builder.Property(x => x.EstaActivo)
                   .IsRequired();

            builder.HasOne(a => a.Usuario)
                   .WithMany(e => e.RefreshTokens)
                   .HasForeignKey(i => i.IdUsuario)
                   .IsRequired();
        }
    }
}