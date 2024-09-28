﻿// <auto-generated />
using System;
using FutbolBack.DataContex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FutbolBack.Migrations
{
    [DbContext(typeof(FutbolDbContext))]
    partial class FutbolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("FutbolBack.Modelos.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Equipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Entrenadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Equipo = "Manchester City",
                            Nombre = "Pep Guardiola"
                        },
                        new
                        {
                            Id = 2,
                            Equipo = "Real Madrid",
                            Nombre = "Carlo Ancelotti"
                        });
                });

            modelBuilder.Entity("FutbolBack.Modelos.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estadio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Equipos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estadio = "Camp Nou",
                            Nombre = "Barcelona"
                        },
                        new
                        {
                            Id = 2,
                            Estadio = "Santiago Bernabéu",
                            Nombre = "Real Madrid"
                        });
                });

            modelBuilder.Entity("FutbolBack.Modelos.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Equipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Posicion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Jugadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Equipo = "PSG",
                            Nombre = "Lionel Messi",
                            Posicion = "Delantero"
                        },
                        new
                        {
                            Id = 2,
                            Equipo = "Al-Nassr",
                            Nombre = "Cristiano Ronaldo",
                            Posicion = "Delantero"
                        });
                });

            modelBuilder.Entity("FutbolBack.Modelos.Liga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Ligas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "La Liga"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Premier League"
                        });
                });

            modelBuilder.Entity("FutbolBack.Modelos.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EquipoLocal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EquipoVisitante")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Partidos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EquipoLocal = "Barcelona",
                            EquipoVisitante = "Real Madrid",
                            Fecha = new DateTime(2024, 9, 17, 23, 18, 23, 911, DateTimeKind.Local).AddTicks(7119)
                        },
                        new
                        {
                            Id = 2,
                            EquipoLocal = "PSG",
                            EquipoVisitante = "Manchester City",
                            Fecha = new DateTime(2024, 9, 22, 23, 18, 23, 911, DateTimeKind.Local).AddTicks(7158)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
