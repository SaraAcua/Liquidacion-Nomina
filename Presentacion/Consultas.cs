﻿using BLL;
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
    public partial class Consultas : Form
    {
        CargaDatosLiquidacionService liquidacion;
        public Consultas()
        {
            InitializeComponent();
            liquidacion = new CargaDatosLiquidacionService(ConfigConnection.connectionString);
            cmbo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbo2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbo3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbo1.Items.Add(2020);
            cmbo1.Items.Add(2021);
            cmbo2.Items.Add(11);
            cmbo3.Items.Add("02");
            cmbo3.Items.Add("01");

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaCargaRespuesta respuesta = new ConsultaCargaRespuesta();
            if (respuesta.Error)
            {
                MessageBox.Show("No hay datos");
            }
            else if (cmbo1.Text.Equals(""))
            {
                MessageBox.Show("combo vacio");
            }
            else
            {
                respuesta = liquidacion.Buscar(cmbo1.Text, cmbo2.Text, cmbo3.Text);
                dtgvConsulta.DataSource = respuesta.Liquidacions;
               
            }
           
        }
    }
}
