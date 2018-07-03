using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.EntityConfig
{
    public class EstudanteMap : IEntityTypeConfiguration<Estudante>
    {

        public void Configure(EntityTypeBuilder<Estudante> builder)
        {
            builder
                .HasKey(e => e.EstudanteId);

            builder
                .HasMany(e => e.Contatos)
                .WithOne(e => e.Estudante)
                .HasForeignKey(e => e.EstudanteId)
                .HasPrincipalKey(e => e.EstudanteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Endereco)
                .WithOne(x => x.Estudante)
                .HasForeignKey<Endereco>(x => x.EstudanteId);

            builder.Property(e => e.CPF)
            .HasColumnType("varchar(11)")
            .IsRequired();

            builder.Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            builder.Property(e => e.Inscricao)
            .HasColumnType("varchar(8)")
            .IsRequired();

        }
    }
}
