using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConexiónSQL
    {
        private readonly string cadenaConexión;

        //Almacena la dirección del servidor.
        public ConexiónSQL()
        {
            cadenaConexión = "Data Source=MAT-COS-DB-10Z2\\SQLEXPRESS;Initial Catalog=Barberia; User Id=test; Password=test"; //Miguel
        }

        //Obtiene la dirección del servidor en una clase heredada.
        protected SqlConnection obtenerConexión()
        {
            return new SqlConnection(cadenaConexión);
        }
    }
}
