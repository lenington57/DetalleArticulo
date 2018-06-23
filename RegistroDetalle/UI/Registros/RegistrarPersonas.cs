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
    public partial class RegistrarPersonas : Form
    {
        public RegistrarPersonas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarPersonas_Load(object sender, EventArgs e)
        {

        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();

            persona.PersonaId = Convert.ToInt32(PersonaIdNumericUpDown.Value);
            persona.Fecha = FechaDateTimePicker.Value;
            persona.Nombres = NombreTextBox.Text;
            persona.Cedula = CedulaMaskedTextBox.Text;            
            persona.Telefono = TelefonoMaskedTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;

            return persona;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PersonaIdNumericUpDown.Value);

            Personas persona = BLL.PersonasBLL.Buscar(id);

            if (persona != null)
            {
                FechaDateTimePicker.Value = persona.Fecha;
                NombreTextBox.Text = persona.Nombres;
                CedulaMaskedTextBox.Text = persona.Cedula;   
                TelefonoMaskedTextBox.Text = persona.Telefono;
                DireccionTextBox.Text = persona.Direccion;
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            PersonaIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            NombreTextBox.Clear();
            CedulaMaskedTextBox.Clear();            
            TelefonoMaskedTextBox.Clear();
            DireccionTextBox.Clear();
            MyErrorProvider.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Personas persona;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            persona = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (PersonaIdNumericUpDown.Value == 0)
                Paso = BLL.PersonasBLL.Guardar(persona);
            else
                Paso = BLL.PersonasBLL.Modificar(persona);

            //Informar el resultado
            if (Paso)
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PersonaIdNumericUpDown.Value);

            if (BLL.PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox,
                    "Debes escribir tu Nombre");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox,
                    "Debes digitar tu número de Cédula");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox,
                    "Debes digitar tu número de Teléfono");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox,
                    "Debes escribir tu Dirección");
                HayErrores = true;
            }

            return HayErrores;
        }      
       
    }
}
