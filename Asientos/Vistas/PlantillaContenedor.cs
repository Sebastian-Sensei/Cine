﻿using Asientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine.Vistas
{
    public partial class PlantillaContenedor : PlantillaLogin
    {
        public PlantillaContenedor()
        {
            InitializeComponent();
        }

        private void PlantillaContenedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
