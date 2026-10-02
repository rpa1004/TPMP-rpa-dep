using Nucleo.Seguridad;

namespace Nucleo.Modelo
{
    public class Usuario
    {
        int id;
        string cuenta;
        string eMail;
        string nombre;
        string apellidos;
        ResultadoHash contrasena;

        public Usuario(int id, string cuenta, string eMail, string nombre, string apellidos)
        {
            this.id = id;
            this.cuenta = cuenta;
            this.eMail = eMail;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.contrasena = new ResultadoHash();
        }

        public int Id { get { return id; } set { this.id = value; } }
        public string Cuenta { get { return cuenta; } set { this.cuenta = value; } }
        public string EMail { get { return eMail; } set { this.eMail = value; } }
        public string Nombre { get { return nombre; } set { this.nombre = value; } }
        public string Apellidos { get { return apellidos; } set { this.apellidos = value; } }

        // La contraseña no tiene get ni set: solo se modifica mediante este método.
        public void CambiarContrasena(ResultadoHash nuevaContrasena)
        {
            this.contrasena = nuevaContrasena;
        }
    }
}
