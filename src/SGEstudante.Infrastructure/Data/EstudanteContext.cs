using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using SGEstudante.Infrastructure.EntityConfig;
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
            modelBuilder.ApplyConfiguration(new EstudanteMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new CursoEstudanteMap());
            modelBuilder.ApplyConfiguration(new MenuMap());  
                                         
        }
    }
}
    

