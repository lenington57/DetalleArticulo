using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;

namespace RegistroDetalle.UI.Consultas
{
    public partial class ConsultarArticulos : Form
    {
        public ConsultarArticulos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filtro = a => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID del Artículo.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.ArticulosId == id;
                    break;
                case 1://Filtrando por la Fecha de Vencimiento del Artículo.
                    filtro = a => a.FechaVencimiento >= DesdeDateTimePicker.Value && a.FechaVencimiento <= HastaDateTimePicker.Value;
                    break;
                case 2://Filtrando por Descripcion del Artículo.
                    filtro = a => a.Descripcion.Contains(CriterioTextBox.Text) && a.FechaVencimiento >= DesdeDateTimePicker.Value && a.FechaVencimiento <= HastaDateTimePicker.Value;
                    break;
                case 3://Filtrando por Precio del Artículo.
                    filtro = a => a.Precio.Equals(CriterioTextBox.Text) && a.FechaVencimiento >= DesdeDateTimePicker.Value && a.FechaVencimiento <= HastaDateTimePicker.Value;
                    break;
                case 4://Filtrando por Existencia del Artículo.
                    filtro = a => a.Existencia.Equals(CriterioTextBox.Text) && a.FechaVencimiento >= DesdeDateTimePicker.Value && a.FechaVencimiento <= HastaDateTimePicker.Value;
                    break;
                case 5://Filtrando por Cantidad Cotizada del Artículo.
                    filtro = a => a.CantCotizada.Equals(CriterioTextBox.Text) && a.FechaVencimiento >= DesdeDateTimePicker.Value && a.FechaVencimiento <= HastaDateTimePicker.Value;
                    break;
            }

            ConsultaDataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.Visible = false;
                CriterioLabel.Visible = false;
            }
            else
            {
                CriterioTextBox.Visible = true;
                CriterioLabel.Visible = true;
            }
        }

        private void ConsultarArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}