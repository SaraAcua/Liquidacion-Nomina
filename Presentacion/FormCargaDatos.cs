using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCargaDatos : Form
    {
        CargaDatosLiquidacionService service;
        public FormCargaDatos()
        {
            InitializeComponent();
            var connectionString = ConfigConnection.connectionString;
            service = new CargaDatosLiquidacionService(connectionString);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName != null)
            {
                string file = openFile.FileName;
                txtRuta.Text = openFile.FileName;
                var respuesta = service.ConsultaTodos(file);
                if (service.ValidarCarga(respuesta.Liquidacions,cmboVigencia.Text,cmboPerido.Text, cmboSede.Text ))
                {
                    string mensaje = service.GuardarCargaLiquidacion(respuesta.Liquidacions, ); // Crear la clase ProductoSedeService y el método guardar
                   // service.GuardarCargaLiquidacion(respuesta.Liquidacions);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Formate incorrecta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
