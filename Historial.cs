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
            cboBarbero.DataSource = null;
            cboBarbero.Items.Add("Todos");
            cboBarbero.SelectedIndex = 0;
            cboBarbero.Enabled = false;

            cboServicio.DataSource = null;
            cboServicio.Items.Add("Todos");
            cboServicio.SelectedIndex = 0;
            cboServicio.Enabled = false;

            cboMetodoPago.DataSource = null;
            cboMetodoPago.Items.Add("Todos");
            cboMetodoPago.SelectedIndex = 0;
            cboMetodoPago.Enabled = false;
            dt1.Value = DateTime.Now.Date;
            dt2.Value = DateTime.Now.Date;

            //Carga el historial de cortes del día.
            dataGridView1.DataSource = datosNegocio.ObtenerHistorialRangoFechas(dt1.Value.ToShortDateString(), dt2.Value.ToShortDateString());             
            ConfiguracionDatagrid();
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

            resultado = "Total de servicios: " + cantidad; 
            return resultado; ;
        }

        //Suma la cantidad de dinero en el datagridview.
        private string ContarDinero(DataGridView dataGrid)
        {
            const int columna = 3;
            string resultado;
            int suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells[2].Value != "Vale")
                {
                    suma += (int)row.Cells[columna].Value;
                }               
                    
            }
            resultado = "Total Dinero: ₡" + suma;

            return resultado;
        }

        //Cuenta la cantidad de servicios especificados.
        private string ContarServicio(DataGridView dataGrid,string servicio)
        {
            const int columna = 2;
            string resultado;
            int suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells[columna].Value == servicio)
                {
                    suma = suma + 1;
                }                
            }

            resultado = servicio + ": " + suma;

            return resultado;
        }

        //Configurar el datagridview1
        private void ConfiguracionDatagrid()
        {
            dataGridView1.Columns[0].Visible = false;

            lblDinero.Text = ContarDinero(dataGridView1);
            lblCantidad.Text = ContarFilas(dataGridView1);
            lblBarba.Text = ContarServicio(dataGridView1, "Barba");
            lblCorteYbarba.Text = ContarServicio(dataGridView1, "Corte y barba");
            lblCorte.Text = ContarServicio(dataGridView1, "Corte");
            lblNiños.Text = ContarServicio(dataGridView1, "Niños");
            lblMarcado.Text = ContarServicio(dataGridView1, "Marcado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        
        }   

        private void Buscar()
        {
            dataGridView1.DataSource = datosNegocio.ObtenerHistorialRangoFechas(dt1.Value.ToShortDateString(), dt2.Value.ToShortDateString());

            if (rbBarbero.Checked)
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("[Barbero]= '{0}'", cboBarbero.Text);
            }

            else if (rbMetodoPago.Checked)
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("[Metodo de pago]= '{0}'", cboMetodoPago.Text);
            }

            else if (rbServicio.Checked)
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Servicio = '{0}'", cboServicio.Text);
            }

            ConfiguracionDatagrid();
        }

        private void rbBarbero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBarbero.Checked)
            {
                cboBarbero.DataSource = datosNegocio.ObtenerBarberos();
                cboBarbero.DisplayMember = "Barbero";
                cboBarbero.Enabled = true;
            }
            else
            {
                cboBarbero.DataSource = null;
                cboBarbero.Items.Add("Todos");
                cboBarbero.SelectedIndex = 0;
                cboBarbero.Enabled = false;
            }
        }

        private void rbMetodoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetodoPago.Checked)
            {
                cboMetodoPago.DataSource = datosNegocio.ObtenerMetodoPago();
                cboMetodoPago.DisplayMember = "MetodosPago";
                cboMetodoPago.Enabled = true;
            }
            else
            {
                cboMetodoPago.DataSource = null;
                cboMetodoPago.Items.Add("Todos");
                cboMetodoPago.SelectedIndex = 0;
                cboMetodoPago.Enabled = false;
            }
        }

        private void rbServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbServicio.Checked)
            {
                cboServicio.DataSource = datosNegocio.ObtenerServicios();
                cboServicio.DisplayMember = "Servicio";
                cboServicio.Enabled = true;
            }
            else
            {
                cboServicio.DataSource = null;
                cboServicio.Items.Add("Todos");
                cboServicio.SelectedIndex = 0;
                cboServicio.Enabled = false;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                  //  MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int id,Total;
                    String Barbero, Servicio, MetodoPago;
                    id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Barbero = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Servicio = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Total = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    MetodoPago = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]; //Selecciona la fila del datagridview.


                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Items.Add("Modificar", default(Image), (snd, evt) => { Modificar(id,Barbero,Servicio,Total,MetodoPago); });
                    menu.Items[0].BackColor = Color.FromArgb(151, 143, 255);

                    menu.Items.Add("Eliminar", default(Image), (snd, evt) => { Eliminar(id); });
                    menu.Items[1].BackColor = Color.FromArgb(151, 143, 255);


                    //Obtienes las coordenadas de la celda seleccionada. 
                    Rectangle coordenada = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                    int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                    int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                    //Y para mostrar el menú lo haces de esta forma:  
                    int X = anchoCelda + dataGridView1.Location.X+20;
                    int Y = altoCelda + dataGridView1.Location.Y + 20;

                    menu.Show(dataGridView1, new Point(X, Y));
                }


            }
            catch
            {

            }
        }

        private void Modificar(int id, String Barbero, String Servicio,int Total,String MetodoPago)
        {
            ModificarHistorial frm = new ModificarHistorial(id,Barbero,Servicio,Total,MetodoPago);
            frm.ShowDialog();
            Buscar();
        }

        private void Eliminar(int id)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {

                datosNegocio.EliminarDatos(id);
            }
            
            Buscar();
        }


    }
}
