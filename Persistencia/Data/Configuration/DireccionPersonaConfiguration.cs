using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DireccionPersonaConfiguration : IEntityTypeConfiguration<Direccionpersona>
    {
        public void Configure(EntityTypeBuilder<Direccionpersona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("direccionpersona");

            builder.HasIndex(e => e.IdPersonaFk, "IdPersonaFk");

            builder.HasIndex(e => e.IdTipoDireccionFk, "IdTipoDireccionFk");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Direccion).HasMaxLength(50);

            builder.HasOne(d => d.IdPersonaFkNavigation).WithMany(p => p.Direccionpersonas)
                .HasForeignKey(d => d.IdPersonaFk)
                .HasConstraintName("direccionpersona_ibfk_1");

            builder.HasOne(d => d.IdTipoDireccionFkNavigation).WithMany(p => p.Direccionpersonas)
                .HasForeignKey(d => d.IdTipoDireccionFk)
                .HasConstraintName("direccionpersona_ibfk_2");
        }
    }
}