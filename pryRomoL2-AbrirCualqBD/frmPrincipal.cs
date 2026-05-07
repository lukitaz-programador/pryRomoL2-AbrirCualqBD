using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRomoL2_AbrirCualqBD
{
    public partial class frmPrincipal : Form
    {
        private string cadenaConexion;
        bool openCorrect = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        // BOTÓN: Abrir base de datos
        private void btnAbrirBD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Base de datos Access (*.accdb;*.mdb)|*.accdb;*.mdb";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaDB = ofd.FileName;

                cadenaConexion = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaDB};Persist Security Info=False;";

                CargarTablas();

                openCorrect = true;
                if (openCorrect == false)
                {
                    lblEstado.Text = "Sin conexión...";
                }
                else
                {
                    lblEstado.Text = "Conexión exitosa.";
                }
            }
        }

        // Cargar tablas en el ComboBox
        private void CargarTablas()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    DataTable esquema = conexion.GetSchema("Tables");

                    cmbTablas.Items.Clear();

                    foreach (DataRow row in esquema.Rows)
                    {
                        string tipo = row["TABLE_TYPE"].ToString();

                        // Solo tablas reales (no vistas del sistema)
                        if (tipo == "TABLE")
                        {
                            cmbTablas.Items.Add(row["TABLE_NAME"].ToString());
                        }
                    }

                    if (cmbTablas.Items.Count > 0)
                        cmbTablas.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tablas: " + ex.Message);
                openCorrect = false;
                if (openCorrect == false)
                {
                    lblEstado.Text = "Sin conexión...";
                }
                else
                {
                    lblEstado.Text = "Conexión exitosa.";
                }
            }
        }

        // Cuando seleccionás una tabla → mostrar datos
        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem != null)
            {
                string tabla = cmbTablas.SelectedItem.ToString();
                MostrarDatos(tabla);
            }
        }

        // Mostrar datos en el DataGridView
        private void MostrarDatos(string tabla)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = $"SELECT * FROM [{tabla}]";

                    OleDbDataAdapter da = new OleDbDataAdapter(query, conexion);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvDatos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
            }
        }
    }
}


//falta separar en clases 