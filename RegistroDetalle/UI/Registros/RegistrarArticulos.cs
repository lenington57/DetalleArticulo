using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;

namespace RegistroDetalle.UI.Registros
{
    public partial class RegistrarArticulos : Form
    {
        public RegistrarArticulos()
        {
            InitializeComponent();
        }

        private void RegistrarArticulos_Load(object sender, EventArgs e)
        {

        }

        private Articulos LlenaClase()
        {
            Articulos articulo = new Articulos();

            articulo.ArticulosId = Convert.ToInt32(ArticulosIdNumericUpDown.Value);
            articulo.FechaVencimiento = FechaVenciDateTimePicker.Value;
            articulo.Descripcion = DescripcionTextBox.Text;
            articulo.Precio = Convert.ToSingle(PrecioTextBox.Text);
            articulo.Existencia = Convert.ToSingle(ExistenciaTextBox.Text);
            articulo.CantCotizada = Convert.ToSingle(CantCotizTextBox.Text);

            return articulo;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticulosIdNumericUpDown.Value);
            Articulos articulo = BLL.ArticulosBLL.Buscar(id);

            if (articulo != null)
            {
                FechaVenciDateTimePicker.Value = articulo.FechaVencimiento;
                DescripcionTextBox.Text = articulo.Descripcion;
                PrecioTextBox.Text = articulo.Precio.ToString();
                ExistenciaTextBox.Text = articulo.Existencia.ToString();
                CantCotizTextBox.Text = articulo.CantCotizada.ToString();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ArticulosIdNumericUpDown.Value = 0;
            FechaVenciDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
            CantCotizTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Articulos articulo;            
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            articulo = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (ArticulosIdNumericUpDown.Value == 0)
                Paso = BLL.ArticulosBLL.Guardar(articulo);
            else
                Paso = BLL.ArticulosBLL.Modificar(LlenaClase());

            //Informar el resutado
            if (Paso)
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticulosIdNumericUpDown.Value);

            if (BLL.PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox,
                    "Debes escribir una Decripción para el artículo");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                MyErrorProvider.SetError(PrecioTextBox,
                    "Debes digitar un precio para el artículo");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(ExistenciaTextBox.Text))
            {
                MyErrorProvider.SetError(ExistenciaTextBox,
                    "Debes digitar una Cantidad en Existencia para el artículo");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(CantCotizTextBox.Text))
            {
                MyErrorProvider.SetError(CantCotizTextBox,
                    "Debes digitar una Cantidad que desea del artículo");
                HayErrores = true;
            }

            return HayErrores;
        }
    }
}

