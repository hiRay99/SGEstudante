using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.EntityConfig
{
    public class CursoEstudanteMap : IEntityTypeConfiguration<CursoEstudante>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CursoEstudante> builder)
        {
            builder
                .HasKey(ce => ce.Id);

            builder
                .HasOne(ce => ce.Estudante)
                .WithMany(ce => ce.CursosEstudante)
                .HasForeignKey(ce => ce.EstudanteId);

            builder
                .HasOne(ce => ce.Curso)
                .WithMany(ce => ce.CursosEstudante)
                .HasForeignKey(ce => ce.CursoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
