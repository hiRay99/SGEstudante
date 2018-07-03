using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder
                .HasOne(c => c.Estudante)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.EstudanteId)
                .HasPrincipalKey(c => c.EstudanteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            builder.Property(c => c.Email)
            .HasColumnType("varchar(100)")
            .IsRequired();

            builder.Property(c => c.Telefone)
            .HasColumnType("varchar(15)");

        }
    }
}
