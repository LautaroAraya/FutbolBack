namespace FutbolBack.Modelos
{
    public class Entrenador
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        // Relación uno a uno con Equipo
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }
    }

}
