namespace Nucleo.Modelo
{
    /// <summary>
    /// Representa un proyecto de pruebas gestionado por la plataforma.
    /// </summary>
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Proyecto(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
