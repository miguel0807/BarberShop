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

    }
}
