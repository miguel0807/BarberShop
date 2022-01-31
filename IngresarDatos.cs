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

        ModeladoIngresarDatos datosNegocio = new ModeladoIngresarDatos();

        private void IngresarDatos_Load(object sender, EventArgs e)
        {
            cboBarbero.DataSource = datosNegocio.obtenerBarberos();
            cboBarbero.DisplayMember = "Barbero";
        }
    }
}
