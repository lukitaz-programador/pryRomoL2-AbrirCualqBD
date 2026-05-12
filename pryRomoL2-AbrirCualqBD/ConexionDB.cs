using System;

namespace pryRomoL2_AbrirCualqBD
{
    /// <summary>
    /// Gestiona la cadena de conexión a la base de datos Access.
    /// </summary>
    public class ConexionDB
    {
        private string _rutaArchivo;

        public string CadenaConexion { get; private set; }
        public bool EstaConectado { get; private set; }

        /// <summary>
        /// Establece la ruta del archivo .accdb/.mdb y construye la cadena de conexión.
        /// </summary>
        public void Conectar(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("La ruta del archivo no puede estar vacía.");

            _rutaArchivo = rutaArchivo;
            CadenaConexion = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={_rutaArchivo};Persist Security Info=False;";
            EstaConectado = true;
        }

        /// <summary>
        /// Desconecta limpiando la cadena de conexión.
        /// </summary>
        public void Desconectar()
        {
            CadenaConexion = null;
            _rutaArchivo = null;
            EstaConectado = false;
        }
    }
}
