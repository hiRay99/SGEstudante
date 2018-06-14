using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.Data
{
    public class EstudanteContext : DbContext
    {
        private object e;

        public EstudanteContext(DbContextOptions<EstudanteContext> options) : base(options)
        {
                
        }

        public DbSet <Estudante> Estudantes { get; set; }

        public DbSet <Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<CursoEstudante>().ToTable("CursoEstudante");

            #region Configuração de Estudante

            modelBuilder.Entity<Estudante>()
                .HasKey(e=> e.EstudanteId);

            modelBuilder.Entity<Estudante>()
                .HasMany(e=> e.Contatos)
                .WithOne(e=> e.Estudante)
                .HasForeignKey(e=> e.EstudanteId)
                .HasPrincipalKey(e=> e.EstudanteId);

            modelBuilder.Entity<Estudante>().Property(e => e.CPF)
            .HasColumnType("varchar(11)")
            .IsRequired();

            modelBuilder.Entity<Estudante>().Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Estudante>().Property(e => e.Inscricao)
            .HasColumnType("varchar(8)")
            .IsRequired();

            #endregion

            #region Configuração de Contato

            modelBuilder.Entity<Contato>()
                .HasOne(c => c.Estudante)
                .WithMany(c=> c.Contatos)
                .HasForeignKey(c=> c.EstudanteId)
                .HasPrincipalKey(c=> c.EstudanteId);

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
            .HasColumnType("varchar(100)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
            .HasColumnType("varchar(15)");

            #endregion

            #region Configuração de Curso

            modelBuilder.Entity<Curso>().Property(e => e.Materia)
            .HasColumnType("varchar(400)")
            .IsRequired();

            modelBuilder.Entity<Curso>().Property(e => e.Codigo)
            .HasColumnType("varchar(10)")
            .IsRequired();

            modelBuilder.Entity<Curso>().Property(e => e.Descricao)
            .HasColumnType("varchar(1000)")
            .IsRequired();

            #endregion

            #region Configuração de Endereço
            modelBuilder.Entity<Endereco>().Property(e => e.Lougradouro)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.CPE)
            .HasColumnType("varchar(15)")
            .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Referencia)
            .HasColumnType("varchar(400)");

            #endregion
        }
    }
}
    

