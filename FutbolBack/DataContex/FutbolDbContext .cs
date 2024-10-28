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

            // Relación uno a uno entre Entrenador y Equipo
            modelBuilder.Entity<Equipo>()
                .HasOne(e => e.Entrenador)
                .WithOne(e => e.Equipo)
                .HasForeignKey<Entrenador>(e => e.EquipoId);

            // Relación uno a muchos entre Equipo y Partido (equipo local)
            modelBuilder.Entity<Partido>()
                .HasOne(p => p.EquipoLocal)
                .WithMany(e => e.PartidosLocal)
                .HasForeignKey(p => p.EquipoLocalId);

            // Relación uno a muchos entre Equipo y Partido (equipo visitante)
            modelBuilder.Entity<Partido>()
                .HasOne(p => p.EquipoVisitante)
                .WithMany(e => e.PartidosVisitante)
                .HasForeignKey(p => p.EquipoVisitanteId);

            // Datos semilla (si lo necesitas)
            modelBuilder.Entity<Entrenador>().HasData(
                new Entrenador { Id = 1, Nombre = "Pep Guardiola", EquipoId = 1 },
                new Entrenador { Id = 2, Nombre = "Carlo Ancelotti", EquipoId = 2 }
            );

            modelBuilder.Entity<Equipo>().HasData(
                new Equipo { Id = 1, Nombre = "Barcelona", Estadio = "Camp Nou" },
                new Equipo { Id = 2, Nombre = "Real Madrid", Estadio = "Santiago Bernabéu" }
            );

            modelBuilder.Entity<Partido>().HasData(
                new Partido { Id = 1, EquipoLocalId = 1, EquipoVisitanteId = 2, Fecha = DateTime.Now.AddDays(-10) },
                new Partido { Id = 2, EquipoLocalId = 2, EquipoVisitanteId = 1, Fecha = DateTime.Now.AddDays(-5) }
            );
        }
    }
}
