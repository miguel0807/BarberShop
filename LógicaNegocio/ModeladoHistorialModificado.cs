using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Común.Cache;
using AccesoDatos;
using System.Data;

namespace LógicaNegocio
{
    
    public class ModeladoHistorialModificado
    {
        readonly HistorialModificadoDAO datos = new HistorialModificadoDAO();//Objeto para invocar la clase de objeto de acceso a Datos (IngresarDatosDAO).

        public DataTable ObtenerBarberos()
        {
            return datos.ConsultarBarbero();
        }

        public DataTable ObtenerMetodoPago()
        {
            return datos.ConsultarMetodoPago();
        }

        public DataTable ObtenerServicios()
        {
            return datos.ConsultarSevicios();
        }

        public float ObtenerPrecio(string servicio)
        {
            return ((float)datos.ConsultarPrecio(servicio));

        }

        public void ActualizarDatos(int id,string Barbero, string Servicio, int Precio, string MetodoPago)
        {
            datos.ActualizarDatos(id,Barbero, Servicio, Precio, MetodoPago);
        }

        

    }
}
