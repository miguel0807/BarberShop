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
            cboBarbero.SelectedIndex = -1;
            
            cboServicios.DataSource = datosNegocio.ObtenerServicios();
            cboServicios.DisplayMember = "Servicio";
            cboServicios.SelectedIndex = -1;

            cboMetodosPago.DataSource = datosNegocio.ObtenerMetodoPago();
            cboMetodosPago.DisplayMember = "MetodoPago";
            cboMetodosPago.SelectedIndex = -1;



        }

        private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Text = datosNegocio.ObtenerPrecio(cboServicios.Text).ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cboBarbero.Text == "" || cboMetodosPago.Text == "" || cboServicios.Text == "")
            {
                datosNegocio.InsertarHistorial(cboBarbero.Text, cboServicios.Text, Convert.ToInt32(txtTotal.Text), cboMetodosPago.Text, DateTime.Now);
                MessageBox.Show("Complete todos los campos para proceder con el registro.","Verificación de datos");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de ingresar el registro?", "Registro", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    datosNegocio.InsertarHistorial(cboBarbero.Text, cboServicios.Text, Convert.ToInt32(txtTotal.Text), cboMetodosPago.Text, DateTime.Now);
                    MessageBox.Show("Datos cargados correctamente.","Registro");
                }

            }

        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtComentarios.ReadOnly = false;
                txtComentarios.Text = "";
                txtComentarios.Focus();
            }
            else
            {
                txtComentarios.ReadOnly = true;
                txtComentarios.Text = "N/A";                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtTotal.ReadOnly = false;
                txtTotal.Text = "";
                txtTotal.Focus();
            }
            else
            {
                txtTotal.ReadOnly = true;
                txtTotal.Text = "0";
            }
        }
    }
}
