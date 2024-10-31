namespace FutbolBack.Modelos
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Estadio { get; set; } = string.Empty;

        // Relación uno a uno con Entrenador
        public int? EntrenadorId { get; set; }
        public Entrenador? Entrenador { get; set; }

        // Relación uno a muchos con Partido
        public ICollection<Partido> PartidosLocal { get; set; } = new List<Partido>();
        public ICollection<Partido> PartidosVisitante { get; set; } = new List<Partido>();
    }

}
