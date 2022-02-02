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
    public class HistorialDAO : ConexiónSQL
    {
        public DataTable ConsultarHistorial()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "CargarHistorial";
                        comando.CommandType = CommandType.StoredProcedure;

                        DataTable datos = new DataTable();

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando); //Se ejecuta el comando.

                        adaptador.Fill(datos);

                        return datos;

                    }

                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }

            }


        }
    }
}
