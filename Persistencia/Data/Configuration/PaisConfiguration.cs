using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pai>
    {
        public void Configure(EntityTypeBuilder<Pai> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("pais");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}