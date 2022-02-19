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
    public partial class IngresarDatos : Form
    {
        public IngresarDatos()
        {
            InitializeComponent();
        }

        readonly ModeladoIngresarDatos datosNegocio = new ModeladoIngresarDatos();

        private void IngresarDatos_Load(object sender, EventArgs e)
        {
            cboBarbero.DataSource = datosNegocio.ObtenerBarberos();
            cboBarbero.DisplayMember = "Barbero";

            
            cboServicios.DataSource = datosNegocio.ObtenerServicios();
            cboServicios.DisplayMember = "Servicio";

            cboMetodosPago.DataSource = datosNegocio.ObtenerMetodoPago();
            cboMetodosPago.DisplayMember = "MetodoPago";

        }

        private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Text = datosNegocio.ObtenerPrecio(cboServicios.Text).ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            datosNegocio.InsertarHistorial(cboBarbero.Text, cboServicios.Text,Convert.ToInt32(txtTotal.Text), cboMetodosPago.Text, DateTime.Now);
            MessageBox.Show("Datos cargados correctamente.");
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }          
        }
    }
}
