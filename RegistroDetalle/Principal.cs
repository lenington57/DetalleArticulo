using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroDetalle.UI.Registros;
using RegistroDetalle.UI.Consultas;

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
            RegistrarArticulos registrarArticulos = new RegistrarArticulos();
            registrarArticulos.MdiParent = this;
            registrarArticulos.Show();
        }

        private void registrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonas registrarPersonas = new RegistrarPersonas();
            registrarPersonas.MdiParent = this;
            registrarPersonas.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void registrarCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCotizacion registrarCotizacion = new RegistrarCotizacion();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarArticulos consultarArticulos = new ConsultarArticulos();
            consultarArticulos.MdiParent = this;
            consultarArticulos.Show();
        }

        private void consultarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Persona consultar_Persona = new Consultar_Persona();
            consultar_Persona.MdiParent = this;
            consultar_Persona.Show();
        }
    }
}
