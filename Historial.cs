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
            dataGridView1.DataSource = datosNegocio.ObtenerHistorial();

            cboTipoBusqueda.DataSource = datosNegocio.ObtenerColumnasHistorial();
            cboTipoBusqueda.DisplayMember = "COLUMN_NAME";

            lblCantidad.Text = ContarFilas(dataGridView1);
        }

        //Devuelve la cantidad de filas totales en un datagridview.
        public string ContarFilas(DataGridView dataGrid)
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

        private void cboTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoBusqueda.Text == "Barbero")
            {
                cboOpciones.DataSource = datosNegocio.ObtenerBarberos();
                cboOpciones.DisplayMember = "Barbero";
            }

            else if (cboTipoBusqueda.Text == "Servicio")
            {
                cboOpciones.DataSource = datosNegocio.ObtenerServicios();
                cboOpciones.DisplayMember = "Servicio";
            }

            else if (cboTipoBusqueda.Text == "MetodoPago")
            {
                cboOpciones.DataSource = datosNegocio.ObtenerMetodoPago();
                cboOpciones.DisplayMember = "MetodoPago";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipoBusqueda.Text == "Barbero")
            {
                dataGridView1.DataSource = datosNegocio.ObtenerHistorialBarbero(cboOpciones.Text);
            }

            else if (cboTipoBusqueda.Text == "Servicio")
            {
                cboOpciones.DataSource = datosNegocio.ObtenerServicios();
                cboOpciones.DisplayMember = "Servicio";
            }

            else if (cboTipoBusqueda.Text == "MetodoPago")
            {
                cboOpciones.DataSource = datosNegocio.ObtenerMetodoPago();
                cboOpciones.DisplayMember = "MetodoPago";
            }

            lblCantidad.Text = ContarFilas(dataGridView1);

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            cboOpciones.Visible = false;
            cboTipoBusqueda.Visible = false;
        }
    }
}
