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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
           
        }
        private void ingresar()
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    ModeladoUsuario usuario = new ModeladoUsuario();
                    var validarLogin = usuario.LoginUsuario(txtUsuario.Text, txtContraseña.Text);

                    if (validarLogin == true)
                    {
                        Principal principal = new Principal();
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña es incorrecta.");
                        txtContraseña.Text = "";
                        txtContraseña.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Favor escriba una contraseña.");
                }
            }
            else
            {
                MessageBox.Show("Favor escriba un usuario.");
            }
        }
        private void CerrarSesion(object enviar,FormClosedEventArgs e)
        {
            txtContraseña.Text = "";
            this.Show();
            txtContraseña.Focus();

        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                ingresar();
            }
            
            
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                ingresar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
