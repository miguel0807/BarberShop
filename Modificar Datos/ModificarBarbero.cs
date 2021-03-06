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

namespace BarberShop
{
    public partial class ModificarBarbero : Form
    {
        private Point posicionMouse;
        readonly ModeladoModificarDatos datosNegocio = new ModeladoModificarDatos();

        public ModificarBarbero()
        {
            InitializeComponent();
        }

        private void ModificarBarbero_Load(object sender, EventArgs e)
        {
            CargarBarberos();
        }       

       
        public void CargarBarberos()
        {
            dataGridView1.DataSource = datosNegocio.ObtenerBarberos();

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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtBarbero.Text != "") 
            { 
                
                DialogResult resultado = MessageBox.Show("Esta seguro de crear el metodo de pago?", "Validación de datos", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    datosNegocio.AgregarBarbero(txtBarbero.Text);
                    MessageBox.Show("Datos cargados correctamente.", "Registro");
                    txtBarbero.Text = "";
                    CargarBarberos();                                                            

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
                    String Barbero;
                    id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Barbero = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();     
                
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]; //Selecciona la fila del datagridview.

                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Items.Add("Modificar", default(Image), (snd, evt) => { Modificar(id, Barbero); });
                    menu.Items[0].BackColor = Color.FromArgb(151, 143, 255);

                    menu.Items.Add("Eliminar", default(Image), (snd, evt) => { Eliminar(id); });
                    menu.Items[1].BackColor = Color.FromArgb(151, 143, 255);
                           
                    menu.Show(dataGridView1,  posicionMouse);

                }
            }
            catch
            {

            }

        }                

        private void Modificar(int id, String Barbero)
        {
            ModificarOpciones frm = new ModificarOpciones(id, Barbero,"Barbero");
            frm.ShowDialog();
            CargarBarberos();

        }

        private void Eliminar(int id)
        {
            
            DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {

                datosNegocio.EliminarBarbero(id);
            }

            CargarBarberos();
        }



        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            posicionMouse = new Point(e.X, e.Y);
        }

        
    }
}
