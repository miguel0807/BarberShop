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
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
        }
       

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = DatosUsuario.Nombre + " " + DatosUsuario.Apellido;
            lblPuesto.Text = DatosUsuario.Puesto;
            panelLateral.Size = new Size(291, 764);
        }

     

        
        private void abrirFormHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new IngresarDatos());
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (panelLateral.Width == 218)
            {
                panelLateral.Width = 70;
                panelDatos.Height = 110;
                btnIngresarDatos.Text = "";
            }
            else
            {

                panelLateral.Width = 218;
                // panelDatos.Height = 180;
                btnIngresarDatos.Text = "Registrar Servicio";
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            panelLateral.Size = new Size(291, 764);
        }
    }
}
