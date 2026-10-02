namespace Nucleo.Modelo
{
    /// <summary>
    /// Representa un rol que agrupa los permisos de un usuario dentro de un proyecto.
    /// </summary>
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Rol(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
