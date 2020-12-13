using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrueba : Form
    {
        private SqlConnection conexion = null;
        public FormPrueba()
        {
            InitializeComponent();
            conexion = new SqlConnection(ConfigConnection.connectionString);
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            try
            {
                // Probar a abrir la conexión
                conexion.Open();
                txtVersion.Text = "Versión del servidor: " + conexion.ServerVersion;
                txtPrueba.Text = "La conexion está: ";
                txtPrueba.Text += conexion.State.ToString();
                txtPrueba.Text += "\nSe accede a la base de datos";
            }
            catch (Exception ex)
            {
                // Manipular la excepción
                txtPrueba.Text = "Error al acceder a la base de datos. "
                + ex.Message;
            }
            finally
            {
                // Asegurarse de que la conexión queda cerrada.
                // Aunque la conexión estuviera cerrada,
                // llamar a Close() no produce un error.
                conexion.Close();
                txtPrueba.Text += "\n Ahora la conexion está: " +
                conexion.State.ToString();
            }
        }
    }
}
