using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroDetalle
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registrarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDetalle.UI.Registros.RegistrarArticulos registrarArticulos = new UI.Registros.RegistrarArticulos();
            registrarArticulos.Show();
        }

        private void registrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDetalle.UI.Registros.RegistrarPersonas registrarPersonas = new UI.Registros.RegistrarPersonas();
            registrarPersonas.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
