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
using BarberShop.Modificar_Datos;

namespace BarberShop.Modificar_Datos
{
    public partial class ModificarMetodoPago : Form
    {
        private Point posicionMouse;
        readonly ModeladoModificarDatos datosNegocio = new ModeladoModificarDatos();

        public ModificarMetodoPago()
        {
            InitializeComponent();
        }

        private void ModificarMetodoPago_Load(object sender, EventArgs e)
        {
            CargarMetodoPago();
        }

        public void CargarMetodoPago()
        {
            dataGridView1.DataSource = datosNegocio.ObtenerMetodoPago();

            dataGridView1.Columns[0].Visible = false;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMetodoPago.Text != "")
            {
                
                DialogResult resultado = MessageBox.Show("Esta seguro de crear el metodo de pago?", "Validación de datos", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    datosNegocio.AgregarMetodoPago(txtMetodoPago.Text);
                    MessageBox.Show("Datos cargados correctamente.", "Registro");
                    txtMetodoPago.Text = "";
                    CargarMetodoPago();

                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    //  MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int id;
                    String metodoPago;
                    id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    metodoPago = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]; //Selecciona la fila del datagridview.

                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Items.Add("Modificar", default(Image), (snd, evt) => { Modificar(id, metodoPago); });
                    menu.Items[0].BackColor = Color.FromArgb(151, 143, 255);

                    menu.Items.Add("Eliminar", default(Image), (snd, evt) => { Eliminar(id); });
                    menu.Items[1].BackColor = Color.FromArgb(151, 143, 255);

                    menu.Show(dataGridView1, posicionMouse);

                }
            }
            catch
            {

            }
        }
        private void Modificar(int id, String metodoPago)
        {
            ModificarOpciones frm = new ModificarOpciones(id, metodoPago, "Metodo de Pago","");
            frm.ShowDialog();
            CargarMetodoPago();

        }

        private void Eliminar(int id)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {

                datosNegocio.EliminarMetodoPago(id);
            }

            CargarMetodoPago();
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            posicionMouse = new Point(e.X, e.Y);
        }
    }
}
