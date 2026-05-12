using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace pryRomoL2_AbrirCualqBD
{
    /// <summary>
    /// Provee operaciones de lectura sobre una base de datos Access:
    /// obtener nombres de tablas y cargar sus datos.
    /// </summary>
    public class TablaService
    {
        private readonly ConexionDB _conexionDB;

        public TablaService(ConexionDB conexionDB)
        {
            _conexionDB = conexionDB ?? throw new ArgumentNullException(nameof(conexionDB));
        }

        /// <summary>
        /// Devuelve la lista de nombres de tablas reales (excluye objetos del sistema).
        /// </summary>
        /// <exception cref="InvalidOperationException">Si no hay conexión activa.</exception>
        public List<string> ObtenerNombresDeTablas()
        {
            if (!_conexionDB.EstaConectado)
                throw new InvalidOperationException("No hay una conexión activa con la base de datos.");

            var tablas = new List<string>();

            using (OleDbConnection conexion = new OleDbConnection(_conexionDB.CadenaConexion))
            {
                conexion.Open();

                DataTable esquema = conexion.GetSchema("Tables");

                foreach (DataRow fila in esquema.Rows)
                {
                    if (fila["TABLE_TYPE"].ToString() == "TABLE")
                        tablas.Add(fila["TABLE_NAME"].ToString());
                }
            }

            return tablas;
        }

        /// <summary>
        /// Devuelve un DataTable con todos los registros de la tabla indicada.
        /// </summary>
        /// <param name="nombreTabla">Nombre de la tabla a consultar.</param>
        /// <exception cref="InvalidOperationException">Si no hay conexión activa.</exception>
        /// <exception cref="ArgumentException">Si el nombre de tabla es nulo o vacío.</exception>
        public DataTable ObtenerDatosDeTabla(string nombreTabla)
        {
            if (!_conexionDB.EstaConectado)
                throw new InvalidOperationException("No hay una conexión activa con la base de datos.");

            if (string.IsNullOrWhiteSpace(nombreTabla))
                throw new ArgumentException("El nombre de la tabla no puede estar vacío.");

            using (OleDbConnection conexion = new OleDbConnection(_conexionDB.CadenaConexion))
            {
                conexion.Open();

                string query = $"SELECT * FROM [{nombreTabla}]";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(query, conexion);

                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                return datos;
            }
        }
    }
}
