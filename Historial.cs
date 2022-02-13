using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Común.Cache;
using LógicaNegocio;

namespace BarberShop
{
    public partial class Historial : Form
    {
        readonly ModeladoHistorial datosNegocio = new ModeladoHistorial();

        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = datosNegocio.ObtenerHistorial();
           
            cboBarbero.DataSource = null;
            cboBarbero.Items.Add("Todos");
            cboBarbero.SelectedIndex = 0;
            cboBarbero.Enabled = false;


            cboServicio.DataSource = null;
            cboServicio.Items.Add("Todos");
            cboServicio.SelectedIndex = 0;
            cboServicio.Enabled = false;

            cboMetodoPago.DataSource = null;
            cboMetodoPago.Items.Add("Todos");
            cboMetodoPago.SelectedIndex = 0;
            cboMetodoPago.Enabled = false;

            //Carga el historial de cortes del día.
            //dataGridView1.DataSource = datosNegocio.ObtenerHistorialRangoFechas(dt1.Value.ToShortDateString(), dt2.Value.ToShortDateString());
            
               dataGridView1.DataSource = datosNegocio.ObtenerHistorialRangoFechas(dt1.Value.ToShortDateString(), dt2.Value.ToShortDateString());

           
            
            

            ConfiguracionDatagrid();
        }

        //Devuelve la cantidad de filas totales en un datagridview.
        private string ContarFilas(DataGridView dataGrid)
        {
            string resultado;
            int cantidad = 0;

            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                cantidad = cantidad + 1;
            }

            resultado = "Cantidad: " + cantidad; 
            return resultado; ;
        }

        //Suma la cantidad de dinero en el datagridview..
        private string ContarDinero(DataGridView dataGrid)
        {
            const int columna = 3;
            string resultado;
            int suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                suma += (int)row.Cells[columna].Value;
            }

            resultado = "Total Dinero: " + suma;

            return resultado;
        }

        //Configurar el datagridview1
        private void ConfiguracionDatagrid()
        {
            dataGridView1.Columns[0].Visible = false;

            lblDinero.Text = ContarDinero(dataGridView1);
            lblCantidad.Text = ContarFilas(dataGridView1);
        }


        private void checkBarbero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBarbero.Checked)
            {
                cboBarbero.DataSource = datosNegocio.ObtenerBarberos();
                cboBarbero.DisplayMember = "Barbero";
                cboBarbero.Enabled = true;
            }
            else
            {
                cboBarbero.DataSource = null;
                cboBarbero.Items.Add("Todos");
                cboBarbero.SelectedIndex = 0;
                cboBarbero.Enabled = false;
            }
        }

        private void checkMetodoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMetodoPago.Checked)
            {
                cboMetodoPago.DataSource = datosNegocio.ObtenerMetodoPago();
                cboMetodoPago.DisplayMember = "MetodoPago";
                cboMetodoPago.Enabled = true;
            }
            else
            {
                cboMetodoPago.DataSource = null;
                cboMetodoPago.Items.Add("Todos");
                cboMetodoPago.SelectedIndex = 0;
                cboMetodoPago.Enabled = false;
            }
        }

        private void checkServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkServicio.Checked)
            {
                cboServicio.DataSource = datosNegocio.ObtenerServicios();
                cboServicio.DisplayMember = "Servicio";
                cboServicio.Enabled = true;
            }
            else
            {
                cboServicio.DataSource = null;
                cboServicio.Items.Add("Todos");
                cboServicio.SelectedIndex = 0;
                cboServicio.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = datosNegocio.ObtenerHistorialRangoFechas(dt1.Value.ToShortDateString(), dt2.Value.ToShortDateString());


            string columna = "Barbero";
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format(""+ columna + " LIKE '%{0}%'", cboBarbero.Text);
           

            ConfiguracionDatagrid();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
