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
    public class HistorialModificadoDAO : ConexiónSQL
    {
        //Realiza una consulta sql para obtener los metodos de pago.
        public DataTable ConsultarMetodoPago()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select RTRIM(MetodoPago) as MetodosPago from MetodoPago";
                        comando.CommandType = CommandType.Text;

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


        //Realiza una consulta sql para obtener los barberos.
        public DataTable ConsultarBarbero()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select RTRIM(Barbero) as Barbero from Barbero";
                        comando.CommandType = CommandType.Text;

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


        //Realiza una consulta sql para obtener los servicios.
        public DataTable ConsultarSevicios()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select RTRIM(Servicio) as Servicio from Servicios";
                        comando.CommandType = CommandType.Text;

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
