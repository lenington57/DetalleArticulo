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
            registrarArticulos.MdiParent = this;
            registrarArticulos.Show();
        }

        private void registrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDetalle.UI.Registros.RegistrarPersonas registrarPersonas = new UI.Registros.RegistrarPersonas();
            registrarPersonas.MdiParent = this;
            registrarPersonas.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void registrarCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDetalle.UI.Registros.RegistrarCotizacion registrarCotizacion = new UI.Registros.RegistrarCotizacion();
            registrarCotizacion.MdiParent = this;
            registrarCotizacion.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            registrarPersonasToolStripMenuItem_Click(sender, e);
        }
        private void ArticulosToolStripButton_Click(object sender, EventArgs e)
        {
            registrarArticulosToolStripMenuItem_Click(sender, e);
        }

        private void CotizacionesToolStripButton_Click(object sender, EventArgs e)
        {
            registrarCotizacionToolStripMenuItem_Click(sender, e);
        }


        private void RegistrarPersonasToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
