﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _07_Fiap.Web.AspNet.Persistence;

namespace _07_Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(AllCorridaContext))]
    partial class AllCorridaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_07_Fiap.Web.AspNet.Models.Corrida", b =>
                {
                    b.Property<int>("CorridaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria");

                    b.Property<float>("Distancia");

                    b.Property<string>("Nome");

                    b.Property<bool>("Premiacao");

                    b.HasKey("CorridaId");

                    b.ToTable("TB_CORRIDAA");
                });
#pragma warning restore 612, 618
        }
    }
}