using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.EntityConfig
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Curso> builder)
        {
            builder.Property(cs => cs.Materia)
            .HasColumnType("varchar(400)")
            .IsRequired();

            builder.Property(cs => cs.Codigo)
            .HasColumnType("varchar(10)")
            .IsRequired();

            builder.Property(cs => cs.Descricao)
            .HasColumnType("varchar(1000)")
            .IsRequired();
        }
    }
}
