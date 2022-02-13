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
    public class ModeladoHistorial
    {
        readonly HistorialDAO datos = new HistorialDAO();//Objeto para invocar la clase de objeto de acceso a Datos (IngresarDatosDAO).

        public DataTable ObtenerHistorial()
        {
            return datos.ConsultarHistorial();
        }

        public DataTable ObtenerColumnasHistorial()
        {
            return datos.ConsultarNombresColumnas();
        }

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

        public DataTable ObtenerHistorialBarbero(string barbero)
        {
            return datos.ConsultarHistorialBarbero(barbero);
        }

        public DataTable ObtenerHistorialRangoFechas(string fechaInicial, string fechaFinal)
        {
            return datos.ConsultarHistorialRangoFechas(fechaInicial + " 00:00",fechaFinal + " 23:59");
        }
    }
}
