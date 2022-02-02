using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Común.Cache;
using AccesoDatos;

namespace LógicaNegocio
{
    public class ModeladoIngresarDatos
    {
        readonly IngresarDatosDAO datos = new IngresarDatosDAO();//Objeto para invocar la clase de objeto de acceso a Datos (IngresarDatosDAO).

        public DataTable ObtenerBarberos()
        {
            return datos.ConsultarBarberos();
        }

        public DataTable ObtenerServicios()
        {
            return datos.ConsultarServicios();
        }

        public DataTable ObtenerMetodoPago()
        {
            return datos.ConsultarMetodoPago();
        }

        public float ObtenerPrecio(string servicio)
        {
            return ((float)datos.ConsultarPrecio(servicio));
             
        }

        public void InsertarHistorial(string Barbero, string Servicio, int Precio, string MetodoPago, DateTime fecha)
        {
            datos.InsertarDatosHistorial( Barbero, Servicio, Precio, MetodoPago, fecha);
        }
        
    }
}
