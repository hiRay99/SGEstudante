﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SGEstudante.Infrastructure.Data;
using System;

namespace SGEstudante.Infrastructure.Migrations
{
    [DbContext(typeof(EstudanteContext))]
    [Migration("20180703191543_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EstudanteId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(15)");

                    b.HasKey("ContatoId");

                    b.HasIndex("EstudanteId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Materia")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("CursoId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.CursoEstudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CursoId");

                    b.Property<int>("EstudanteId");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("EstudanteId");

                    b.ToTable("CursoEstudante");
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CPE")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("EstudanteId");

                    b.Property<string>("Lougradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(400)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("EstudanteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Estudante", b =>
                {
                    b.Property<int>("EstudanteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<int>("Inscricao")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("EstudanteId");

                    b.ToTable("Estudante");
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MenuId");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Contato", b =>
                {
                    b.HasOne("SGEstudante.ApplicationCore.Entity.Estudante", "Estudante")
                        .WithMany("Contatos")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.CursoEstudante", b =>
                {
                    b.HasOne("SGEstudante.ApplicationCore.Entity.Curso", "Curso")
                        .WithMany("CursosEstudante")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SGEstudante.ApplicationCore.Entity.Estudante", "Estudante")
                        .WithMany("CursosEstudante")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("SGEstudante.ApplicationCore.Entity.Estudante", "Estudante")
                        .WithOne("Endereco")
                        .HasForeignKey("SGEstudante.ApplicationCore.Entity.Endereco", "EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGEstudante.ApplicationCore.Entity.Menu", b =>
                {
                    b.HasOne("SGEstudante.ApplicationCore.Entity.Menu")
                        .WithMany("SubMenu")
                        .HasForeignKey("MenuId");
                });
#pragma warning restore 612, 618
        }
    }
}