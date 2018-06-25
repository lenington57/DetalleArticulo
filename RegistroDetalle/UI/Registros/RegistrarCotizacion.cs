using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroDetalle.BLL;
using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;

namespace RegistroDetalle.UI.Registros
{
    public partial class RegistrarCotizacion : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-YOJAIRI; Initial catalog = DetalleDb;
        //Integrated Security = True;");

        public RegistrarCotizacion()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistrarCotizacion_Load(object sender, EventArgs e)
        {
            //LlenarPersonaComboBOx();
            //LlenarArticuloComboBOx();
        }

        /*private void LlenarPersonaComboBOx()
        {
            string comsql = "select PersonaId, Nombres from Personas ";
            SqlCommand comando = new SqlCommand(comsql, con);
            con.Open();

            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                PersonaComboBox.Items.Add(reader["Nombres"].ToString());
            }
            con.Close();
        }

        private void LlenarArticuloComboBOx()
        {
            string ComSql = "select Descripcion from Articulos";
            SqlCommand Comando = new SqlCommand(ComSql, con);
            con.Open();

            SqlDataReader Reader = Comando.ExecuteReader();
            if (Reader.Read() == true)
            {           
                ArticuloComboBox.Items.Add(Reader["Descripcion"].ToString());
            }
            con.Close();
        }*/

        private void LlenarCampos(Cotizaciones cotizaciones)
        {
            CotizacionIdNumericUpDown.Value = cotizaciones.CotizacionId;
            FechaDateTimePicker.Value = cotizaciones.Fecha;
            ObservacionesTextBox.Text = cotizaciones.Observaciones;

            DetalleCotizacionDataGridView.DataSource = cotizaciones.Detalle;//Cargar el detalle al Grid
            
            DetalleCotizacionDataGridView.Columns["Id"].Visible = false;//Ocultar columnas
            DetalleCotizacionDataGridView.Columns["CotizacionId"].Visible = false;//Ocultar columnas
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private int ToSingle(object valor)
        {
            float retorno = 0;
            float.TryParse(valor.ToString(), out retorno);

            return Convert.ToInt32(retorno);
        }

        private Cotizaciones LlenaClase()
        {
            Cotizaciones cotizaciones = new Cotizaciones();

            cotizaciones.CotizacionId = Convert.ToInt32(CotizacionIdNumericUpDown.Value);
            cotizaciones.Fecha = FechaDateTimePicker.Value;
            cotizaciones.Observaciones = ObservacionesTextBox.Text;
            
            foreach (DataGridViewRow item in DetalleCotizacionDataGridView.Rows)//Agregar cada linea del Grid al detalle
            {
                cotizaciones.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["CotizacionId"].Value),
                    ToInt(item.Cells["PersonaId"].Value),
                    ToInt(item.Cells["ArticulosId"].Value),
                    ToSingle(item.Cells["Cantidad"].Value),
                    ToSingle(item.Cells["Precio"].Value),
                    ToSingle(item.Cells["Importe"].Value)
                );
            }

            return cotizaciones;
        }

        private void LlenarComboBox()
        {
            Repositorio<Personas> PerRepositorio = new Repositorio<Personas>(new Contexto());
            Repositorio<Articulos> ArtRepositorio = new Repositorio<Articulos>(new Contexto());

            PersonaComboBox.DataSource = PerRepositorio.GetList(c => true);
            PersonaComboBox.ValueMember = "PersonaId";
            PersonaComboBox.DisplayMember = "Nombres";
            ArticuloComboBox.DataSource = ArtRepositorio.GetList(c => true);
            ArticuloComboBox.ValueMember = "ArticulosId";
            ArticuloComboBox.DisplayMember = "Descripcion";
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(ObservacionesTextBox.Text))
            {
                MyErrorProvider.SetError(ObservacionesTextBox,
                    "Escriba alguna observacion por lo menos");
                HayErrores = true;
            }

            if (DetalleCotizacionDataGridView.RowCount == 0)
            {
                MyErrorProvider.SetError(DetalleCotizacionDataGridView,
                    "Es obligatorio seleccionar los articulos cotizados");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(CantidadCotizadaTextBox.Text))
            {
                MyErrorProvider.SetError(CantidadCotizadaTextBox,
                    "Digite una cantidad");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                MyErrorProvider.SetError(PrecioTextBox,
                    "Digite un precio");
                HayErrores = true;
            }
            
            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CotizacionIdNumericUpDown.Value);
            Cotizaciones cotizaciones = BLL.CotizacionesBLL.Buscar(id);

            if (cotizaciones != null)
            {
                LlenarCampos(cotizaciones);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButtton_Click(object sender, EventArgs e)
        {
            List<DetalleCotizaciones> detalle = new List<DetalleCotizaciones>();

            if (DetalleCotizacionDataGridView.DataSource != null)
            {
                detalle = (List<DetalleCotizaciones>)DetalleCotizacionDataGridView.DataSource;
            }

            //Agregar un nuevo detalle con los datos introducidos.
            detalle.Add(
                new DetalleCotizaciones(
                    id: 0,
                    cotizacionId: (int)CotizacionIdNumericUpDown.Value,
                    personaId: (int)PersonaComboBox.SelectedValue,
                    articulosId: (int)ArticuloComboBox.SelectedValue,
                    cantidadCotizada: (float)Convert.ToSingle(CantidadCotizadaTextBox.Text),
                    precio: (float)Convert.ToSingle(PrecioTextBox.Text),
                    importe: (float)Convert.ToSingle(ImporteTextBox.Text)

                ));

            //Cargar el detalle al Grid
            DetalleCotizacionDataGridView.DataSource = null;
            DetalleCotizacionDataGridView.DataSource = detalle;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CotizacionIdNumericUpDown.Value = 0;
            CantidadCotizadaTextBox.Clear();
            PrecioTextBox.Clear();
            ImporteTextBox.Clear();
            TotalTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            ObservacionesTextBox.Clear();
            DetalleCotizacionDataGridView.DataSource = null;
            MyErrorProvider.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cotizaciones cotizaciones;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cotizaciones = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (CotizacionIdNumericUpDown.Value == 0)
                Paso = BLL.CotizacionesBLL.Guardar(cotizaciones);
            else
                Paso = BLL.CotizacionesBLL.Modificar(cotizaciones);

            //Informar el resultado
            if (Paso)
            {
                NuevoButton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CotizacionIdNumericUpDown.Value);

            if (BLL.CotizacionesBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PrecioTextBox_TextChanged(object sender, EventArgs e)
        {
            int val;
            bool result = int.TryParse(CantidadCotizadaTextBox.Text, out val);
            if (!result)
                return;

            int valor;
            bool resulta = int.TryParse(PrecioTextBox.Text, out valor);
            if (!result)
                return;

            int cantCot = Convert.ToInt32(val);
            int pre = Convert.ToInt32(valor);
            float res = cantCot * pre;

            ImporteTextBox.Text = res.ToString();
        }

        private void PersonaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
