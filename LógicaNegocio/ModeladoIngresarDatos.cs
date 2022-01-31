﻿using System;
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
        
        IngresarDatosDAO datos = new IngresarDatosDAO();//Objeto para invocar la clase de objeto de acceso a Datos (IngresarDatosDAO).

        public DataTable obtenerBarberos()
        {
            return datos.consultarBarberos();
        }
        
    }
}
