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

namespace BarberShop
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PanelLateral.Width == 218)
            {
                PanelLateral.Width = 70;
                panelDatos.Height = 110;
                btnIngresarDatos.Text = "";
                btnCerrarSesion.Text = "";
                lblNombre.Visible = false;
                lblPuesto.Visible= false;
                lblNombreP.Visible = false;
                lblPuestoP.Visible = false;
                lineaDatos.Visible = false;


            }
            else
            {

                PanelLateral.Width = 218;
                
                btnIngresarDatos.Text = "Registrar Servicio";
                btnCerrarSesion.Text = "Cerrar Sesión";
                lblNombre.Visible = true;
                lblPuesto.Visible = true;
                lblNombreP.Visible = true;
                lblPuestoP.Visible = true;
                lineaDatos.Visible = true;

            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = DatosUsuario.Nombre + " " + DatosUsuario.Apellido;
            lblPuesto.Text = DatosUsuario.Puesto;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
