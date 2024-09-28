using FutbolBack.Modelos;
using Microsoft.EntityFrameworkCore;

namespace FutbolBack.DataContex
{
    public class FutbolDbContext : DbContext
    {
        public FutbolDbContext(DbContextOptions<FutbolDbContext> options) : base(options) { }

        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Liga> Ligas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Jugador>().HasData(
                new Jugador { Id = 1, Nombre = "Lionel Messi", Posicion = "Delantero", Equipo = "PSG" },
                new Jugador { Id = 2, Nombre = "Cristiano Ronaldo", Posicion = "Delantero", Equipo = "Al-Nassr" }
            );

            modelBuilder.Entity<Entrenador>().HasData(
                new Entrenador { Id = 1, Nombre = "Pep Guardiola", Equipo = "Manchester City" },
                new Entrenador { Id = 2, Nombre = "Carlo Ancelotti", Equipo = "Real Madrid" }
            );

            modelBuilder.Entity<Equipo>().HasData(
                new Equipo { Id = 1, Nombre = "Barcelona", Estadio = "Camp Nou" },
                new Equipo { Id = 2, Nombre = "Real Madrid", Estadio = "Santiago Bernabéu" }
            );

            modelBuilder.Entity<Partido>().HasData(
                new Partido { Id = 1, EquipoLocal = "Barcelona", EquipoVisitante = "Real Madrid", Fecha = DateTime.Now.AddDays(-10) },
                new Partido { Id = 2, EquipoLocal = "PSG", EquipoVisitante = "Manchester City", Fecha = DateTime.Now.AddDays(-5) }
            );

            modelBuilder.Entity<Liga>().HasData(
                new Liga { Id = 1, Nombre = "La Liga" },
                new Liga { Id = 2, Nombre = "Premier League" }
            );
        }
    }
}
