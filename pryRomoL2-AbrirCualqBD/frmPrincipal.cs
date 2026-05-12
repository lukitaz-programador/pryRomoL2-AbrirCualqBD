using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace pryRomoL2_AbrirCualqBD
{
    /// <summary>
    /// Formulario principal. Solo se encarga de la interfaz de usuario;
    /// delega toda la lógica a ConexionDB y TablaService.
    /// </summary>
    public partial class frmPrincipal : Form
    {
        private readonly ConexionDB _conexionDB;
        private readonly TablaService _tablaService;

        public frmPrincipal()
        {
            InitializeComponent();

            _conexionDB  = new ConexionDB();
            _tablaService = new TablaService(_conexionDB);
        }

        // ── EVENTOS ──────────────────────────────────────────────────────────

        private void btnAbrirBD_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Base de datos Access (*.accdb;*.mdb)|*.accdb;*.mdb";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                AbrirBaseDeDatos(ofd.FileName);
            }
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem != null)
                MostrarDatosDeTabla(cmbTablas.SelectedItem.ToString());
        }

        // ── MÉTODOS DE UI ────────────────────────────────────────────────────

        /// <summary>
        /// Conecta con la BD seleccionada y carga las tablas en el ComboBox.
        /// </summary>
        private void AbrirBaseDeDatos(string rutaArchivo)
        {
            try
            {
                _conexionDB.Conectar(rutaArchivo);

                List<string> tablas = _tablaService.ObtenerNombresDeTablas();

                cmbTablas.Items.Clear();
                cmbTablas.Items.AddRange(tablas.ToArray());

                if (cmbTablas.Items.Count > 0)
                    cmbTablas.SelectedIndex = 0;

                ActualizarEstado(true);
            }
            catch (Exception ex)
            {
                _conexionDB.Desconectar();
                ActualizarEstado(false);
                MessageBox.Show("Error al abrir la base de datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga y muestra los datos de la tabla indicada en el DataGridView.
        /// </summary>
        private void MostrarDatosDeTabla(string nombreTabla)
        {
            try
            {
                DataTable datos = _tablaService.ObtenerDatosDeTabla(nombreTabla);
                dgvDatos.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza el label de estado según si la conexión fue exitosa o no.
        /// </summary>
        private void ActualizarEstado(bool conectado)
        {
            lblEstado.Text = conectado ? "Conexión exitosa." : "Sin conexión...";
        }
    }
}
