using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Común.Cache
{
   public static class DatosUsuario
    {
        //Variables comunes para usar en el proyecto, estas por ser static se borran una vez cerrada la aplicación.
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Puesto { get; set; }
        public static string Id { get; set; }
        public static int Estado { get; set; }

    }
}
