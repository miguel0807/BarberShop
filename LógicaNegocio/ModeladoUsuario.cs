using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Común.Cache;

namespace LógicaNegocio
{
    public class ModeladoUsuario
    {
        readonly UsuarioDAO datosUsuario = new UsuarioDAO();//Objeto para invocar la clase de objeto de acceso a Datos (UsuarioDAO).

        //Función que valida el usuario y la contraseña, si es valido devuelve un true.
        public bool LoginUsuario(string usuario, string contraseña)
        {
            return datosUsuario.Login(usuario, contraseña);
        }

        //Función que habilita la seguridad y los permisos de usuario.
        public void SeguridadUsuario()
        {
            if (DatosUsuario.Puesto == NivelUsuario.Admin)
            {

            }

            if (DatosUsuario.Puesto == NivelUsuario.Usuario)
            {

            }
        }

    }
}
