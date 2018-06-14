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

            modelBuilder.Entity<Contato>().Property(c => c.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Email)
            .HasColumnType("varchar(100)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Telefone)
            .HasColumnType("varchar(15)");

            #endregion

            #region Configuração de Curso

            modelBuilder.Entity<Curso>().Property(cs => cs.Materia)
            .HasColumnType("varchar(400)")
            .IsRequired();

            modelBuilder.Entity<Curso>().Property(cs => cs.Codigo)
            .HasColumnType("varchar(10)")
            .IsRequired();

            modelBuilder.Entity<Curso>().Property(cs => cs.Descricao)
            .HasColumnType("varchar(1000)")
            .IsRequired();

            #endregion

            #region Configuração de Endereço
            modelBuilder.Entity<Endereco>().Property(en => en.Lougradouro)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Endereco>().Property(en => en.Bairro)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Endereco>().Property(en => en.CPE)
            .HasColumnType("varchar(15)")
            .IsRequired();

            modelBuilder.Entity<Endereco>().Property(en => en.Referencia)
            .HasColumnType("varchar(400)");

            #endregion

            #region Configuração de Curso Estudante

            modelBuilder.Entity<CursoEstudante>()
                .HasKey(ce => ce.Id);

            modelBuilder.Entity<CursoEstudante>()
                .HasOne(ce => ce.Estudante)
                .WithMany(ce => ce.CursosEstudante)
                .HasForeignKey(ce => ce.EstudanteId);

            modelBuilder.Entity<CursoEstudante>()
                .HasOne(ce => ce.Curso)
                .WithMany(ce => ce.CursosEstudante)
                .HasForeignKey(ce => ce.CursoId);

            #endregion

            #region Configurações de Menu

            modelBuilder.Entity<Menu>()
                .HasMany(m => m.SubMenu)
                .WithOne()
                .HasForeignKey(m => m.MenuId);

            #endregion
        }
    }
}
    

