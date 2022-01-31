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
        UsuarioDAO datosUsuario = new UsuarioDAO();//Objeto para invocar la clase de objeto de acceso a Datos (UsuarioDAO).

        public DataTable obtenerBarberos()
        {
            return datosUsuario.consultarBarberos();
        }
        
    }
}
