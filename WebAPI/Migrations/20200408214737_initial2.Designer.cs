﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200408214737_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Aluguel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DataDevolucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdFerramenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdLocador")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Algueis");
                });

            modelBuilder.Entity("WebAPI.Models.Ferramenta", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdDoDono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDaFerramenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Preco")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Ferramentas");
                });

            modelBuilder.Entity("WebAPI.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apartamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
