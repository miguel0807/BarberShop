using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Común.Cache;

namespace AccesoDatos
{
    public class IngresarDatosDAO : ConexiónSQL
    {
        //Realiza una consulta a sql para obtener los datos de los barberos.
        public DataTable consultarBarberos()
        {

            using (var cn = obtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                cn.Open(); //Se procede abrir la conexión SQL.

                using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                {
                    comando.Connection = cn;
                    comando.CommandText = "select*from Barberos";
                    comando.CommandType = CommandType.Text;

                    DataTable datos = new DataTable();

                    SqlDataAdapter adaptador = new SqlDataAdapter("ListaBarberos", cn); //Se ejecuta el comando.

                    adaptador.Fill(datos);

                    return datos;

                }


            }


        }
    }
}
