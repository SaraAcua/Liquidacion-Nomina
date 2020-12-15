﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {


            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            FormPrueba form = new FormPrueba();
            AbrirFormEnPanel(form);
        }

        private void pictureIncio_Click(object sender, EventArgs e)
        {
            FormInicio form = new FormInicio();
            AbrirFormEnPanel(form);
        }

        private void btbCargaDatos_Click(object sender, EventArgs e)
        {
            FormCargaDatos form = new FormCargaDatos();
            AbrirFormEnPanel(form);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            AbrirFormEnPanel(consultas);
        }
    }
}
