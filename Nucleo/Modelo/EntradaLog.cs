namespace Nucleo.Modelo
{
    /// <summary>
    /// Representa una entrada del registro de actividad (log) de la aplicación.
    /// </summary>
    public class EntradaLog
    {
        public DateTime FechaHora { get; }
        public string TipoEvento { get; set; }
        public string Descripcion { get; set; }
        public string Cuenta { get; set; }

        public EntradaLog(string tipoEvento, string descripcion, string cuenta)
        {
            FechaHora = DateTime.Now;
            TipoEvento = tipoEvento;
            Descripcion = descripcion;
            Cuenta = cuenta;
        }
    }
}
