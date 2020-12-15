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
            LlenarCombo();
            cmboVigencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboPerido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboSede.DropDownStyle = ComboBoxStyle.DropDownList;
        

            service = new CargaDatosLiquidacionService(ConfigConnection.connectionString);
        }

        void LlenarCombo()
        {

            cmboVigencia.Items.Add(2020);
            cmboPerido.Items.Add(11);
            cmboSede.Items.Add("02");
            cmboSede.Items.Add("01");

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            int valor = service.ConsultarValor();

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName != null)
            {
                string file = openFile.FileName;
                txtRuta.Text = openFile.FileName;
                var respuesta = service.ConsultaTodos(file);
                if (service.ValidarCarga(respuesta.Liquidacions,cmboVigencia.Text,cmboPerido.Text, cmboSede.Text ))
                {
                    string mensaje = service.GuardarCargaLiquidacion(respuesta.Liquidacions,valor ); // Crear la clase ProductoSedeService y el método guardar
                   //service.GuardarCargaLiquidacion(respuesta.Liquidacions);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Formato incorrecta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
