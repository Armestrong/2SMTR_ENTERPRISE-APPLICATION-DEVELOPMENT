﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _06_Fiap.Web.AspNet.Persistences;

namespace _06Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(RacerContext))]
    [Migration("20190919115007_inicioAtleta")]
    partial class inicioAtleta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Atleta", b =>
                {
                    b.Property<int>("AtletaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Profissional");

                    b.HasKey("AtletaId");

                    b.ToTable("Atleta");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Corrida", b =>
                {
                    b.Property<int>("CorridaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria");

                    b.Property<float>("Distancia");

                    b.Property<string>("Nome");

                    b.Property<bool>("Premiacao");

                    b.Property<int>("TrajetoId");

                    b.HasKey("CorridaId");

                    b.HasIndex("TrajetoId");

                    b.ToTable("Corridas");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.CorridaAtleta", b =>
                {
                    b.Property<int>("AtletaId");

                    b.Property<int>("CorridaId");

                    b.HasKey("AtletaId", "CorridaId");

                    b.HasIndex("CorridaId");

                    b.ToTable("CorridaAtleta");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Medalha", b =>
                {
                    b.Property<int>("MedalhaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaM");

                    b.Property<int>("CorridaId");

                    b.Property<float>("Peso");

                    b.Property<int>("Quantidade");

                    b.HasKey("MedalhaId");

                    b.HasIndex("CorridaId");

                    b.ToTable("Medalha");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Trajeto", b =>
                {
                    b.Property<int>("TrajetoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Distancia");

                    b.Property<string>("LocalInicio");

                    b.HasKey("TrajetoId");

                    b.ToTable("Trajeto");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Corrida", b =>
                {
                    b.HasOne("_06_Fiap.Web.AspNet.Models.Trajeto", "Trajeto")
                        .WithMany()
                        .HasForeignKey("TrajetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.CorridaAtleta", b =>
                {
                    b.HasOne("_06_Fiap.Web.AspNet.Models.Atleta", "Atleta")
                        .WithMany("CorridaAtletas")
                        .HasForeignKey("AtletaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_06_Fiap.Web.AspNet.Models.Corrida", "Corrida")
                        .WithMany("CorridaAtletas")
                        .HasForeignKey("CorridaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Medalha", b =>
                {
                    b.HasOne("_06_Fiap.Web.AspNet.Models.Corrida", "Corrida")
                        .WithMany("Medalhas")
                        .HasForeignKey("CorridaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
