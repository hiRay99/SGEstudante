using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(en => en.Lougradouro)
            .HasColumnType("varchar(200)")
            .IsRequired();

            builder.Property(en => en.Bairro)
            .HasColumnType("varchar(200)")
            .IsRequired();

            builder.Property(en => en.CPE)
            .HasColumnType("varchar(15)")
            .IsRequired();

            builder.Property(en => en.Referencia)
            .HasColumnType("varchar(400)");
        }
    }
}
