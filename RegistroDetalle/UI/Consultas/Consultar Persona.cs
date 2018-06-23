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
    public partial class Consultar_Persona : Form
    {
        public Consultar_Persona()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Personas, bool>> filtro = p => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID de la Persona.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = p => p.PersonaId == id;
                    break;
                case 1://Filtrando por Fecha de la Persona.
                    filtro = p => p.Fecha >= DesdeDateTimePicker.Value && p.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 2://Filtrando por Nombres de la Persona.
                    filtro = p => p.Nombres.Contains(CriterioTextBox.Text) && p.Fecha >= DesdeDateTimePicker.Value && p.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 3://Filtrando por Direccion de la Persona.
                    filtro = p => p.Direccion.Contains(CriterioTextBox.Text) && p.Fecha >= DesdeDateTimePicker.Value && p.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 4://Filtrando por Cedula de la Persona.
                    filtro = p => p.Cedula.Equals(CriterioTextBox.Text) && p.Fecha >= DesdeDateTimePicker.Value && p.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 5://Filtrando por Telefono de la Persona.
                    filtro = p => p.Telefono.Equals(CriterioTextBox.Text) && p.Fecha >= DesdeDateTimePicker.Value && p.Fecha <= HastaDateTimePicker.Value;
                    break;
            }

            ConsultaDataGridView.DataSource = BLL.PersonasBLL.GetList(filtro);
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


        private void Consultar_Persona_Load(object sender, EventArgs e)
        {

        }
    }
}
