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
using BarberShop.Modificar_Datos;

namespace BarberShop.Modificar_Datos
{
    public partial class ModificarServicio : Form
    {
        ModeladoModificarDatos datosNegocio = new ModeladoModificarDatos();
        private Point posicionMouse;
        public ModificarServicio()
        {
            InitializeComponent();
        }

        private void ModificarServicio_Load(object sender, EventArgs e)
        {
            CargarServicios();
        }
        public void CargarServicios()
        {
            dataGridView1.DataSource = datosNegocio.ObtenerServicio();

            dataGridView1.Columns[0].Visible = false;

            txtCantidad.Text = ContarFilas(dataGridView1);
           
        }

        //Devuelve la cantidad de filas totales en un datagridview.
        private string ContarFilas(DataGridView dataGrid)
        {
            string resultado;
            int cantidad = 0;

            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                cantidad = cantidad + 1;
            }

            resultado = "Cantidad de registros: " + cantidad;
            return resultado; ;
        }
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            posicionMouse = new Point(e.X, e.Y);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Right)
                {
                    //  MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int id,precio;
                    String servicio;
                    id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    servicio = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    precio = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]; //Selecciona la fila del datagridview.

                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Items.Add("Modificar", default(Image), (snd, evt) => { Modificar(id, servicio, precio); });
                    menu.Items[0].BackColor = Color.FromArgb(151, 143, 255);

                    menu.Items.Add("Eliminar", default(Image), (snd, evt) => { Eliminar(id); });
                    menu.Items[1].BackColor = Color.FromArgb(151, 143, 255);

                    menu.Show(dataGridView1, posicionMouse);

                }
          
        }
        private void Modificar(int id, String servicio, int precio)
        {
            ModificarOpciones frm = new ModificarOpciones(id,servicio,precio,"Servicio","Precio");
            frm.ShowDialog();
            CargarServicios();
                
        }

        private void Eliminar(int id)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                datosNegocio.EliminarServicio(id);
            }

            CargarServicios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text != "" && txtPrecio.Text != "")
            {

                DialogResult resultado = MessageBox.Show("Esta seguro de crear el servicio?", "Validación de datos", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    datosNegocio.AgregarServicio(txtServicio.Text, Int32.Parse(txtPrecio.Text));
                    MessageBox.Show("Datos cargados correctamente.","Registro");
                    txtServicio.Text = "";
                    txtPrecio.Text = "";
                    CargarServicios();
                }

                
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
