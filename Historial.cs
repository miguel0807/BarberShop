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
            gunaDataGridView1.DataSource = datosNegocio.obtenerHistorial();
        }
    }
}
