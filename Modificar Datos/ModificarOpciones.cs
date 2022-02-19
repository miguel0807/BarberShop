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

namespace BarberShop.Modificar_Datos
{
    public partial class ModificarOpciones : Form
    {
        private int id;
        private readonly bool barbero,servicio,MetodoPago;
        ModeladoModificarDatos datosNegocio = new ModeladoModificarDatos();

        public ModificarOpciones(int id,String barbero,String lbl1)
        {
            InitializeComponent();
            this.id = id;
            this.txt1.Text = barbero;           
            this.lbl1.Text = lbl1;
            this.barbero = true;
        }

        public ModificarOpciones(int id,String servicio, int precio, String lbl1, String lbl2)
        {
            InitializeComponent();
            this.id = id;
            this.txt1.Text = servicio;
            this.txt2.Text = precio.ToString();
            this.lbl1.Text = lbl1;
            this.lbl2.Text = lbl2;
            this.servicio = true;

        }

        public ModificarOpciones(int id, String metodoPago, String lbl1 ,String MetodoPago)
        {
            InitializeComponent();
            this.id = id;
            this.txt1.Text = metodoPago;
            this.lbl1.Text = lbl1;
            this.MetodoPago = true;
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModificarOpciones_Load(object sender, EventArgs e)
        {
            if (barbero == true)
            {
                txt2.Visible = true;
                lbl2.Visible = true;
            }
            else if(servicio == true)
            {
                txt2.Visible = true;
                lbl2.Visible = true;
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(barbero == true)
            {
                datosNegocio.ActualizarBarbero(id, txt1.Text);
                this.Close();
            }
            else if (servicio == true)
            {
                datosNegocio.ActualizarServicio(id,txt1.Text,Int32.Parse(txt2.Text));
                this.Close();
            }

            else if(MetodoPago == true)
            {
                datosNegocio.ActualizarMetodoPago(id, txt1.Text);
                this.Close();
            }
            
        }
    }
}
