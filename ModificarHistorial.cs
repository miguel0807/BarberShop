using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LógicaNegocio;

namespace BarberShop
{
    public partial class ModificarHistorial : Form
    {
        private int id;
        private int Total;
        private String Barbero;
        private String Servicio;
        private String MetodoPago;

        public ModificarHistorial(int id,String Barbero,String Servicio,int Total,String MetodoPago)
        {
            InitializeComponent();
            this.id = id;
            this.Barbero = Barbero;
            this.Servicio = Servicio;
            this.MetodoPago = MetodoPago;
            this.Total = Total;
             
        }

        readonly ModeladoHistorialModificado datosNegocio = new ModeladoHistorialModificado();

        private void ModificarHistorial_Load(object sender, EventArgs e)
        {
            cboBarbero.DataSource = datosNegocio.ObtenerBarberos();
            cboBarbero.DisplayMember = "Barbero";

            cboServicios.DataSource = datosNegocio.ObtenerServicios();
            cboServicios.DisplayMember = "Servicio";

            cboMetodosPago.DataSource = datosNegocio.ObtenerMetodoPago();
            cboMetodosPago.DisplayMember = "MetodosPago";

            cboBarbero.Text = Barbero;
            cboServicios.Text = Servicio;
            cboMetodosPago.Text = MetodoPago;
            txtTotal.Text = Total.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datosNegocio.ActualizarDatos(id,cboBarbero.Text, cboServicios.Text, Convert.ToInt32(txtTotal.Text), cboMetodosPago.Text);
            this.Close();
        }

        private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Text = datosNegocio.ObtenerPrecio(cboServicios.Text).ToString();
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
