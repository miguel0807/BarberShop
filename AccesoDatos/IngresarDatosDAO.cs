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
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select*from Barbero";
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


        //Realiza una consulta a sql para obtener los datos de los servicios.
        public DataTable consultarServicios()
        {

            using (var cn = obtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select*from Servicios";
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

        //Realiza una consulta a sql para obtener los datos de los metodos de pago.
        public DataTable consultarMetodoPago()
        {

            using (var cn = obtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select*from MetodoPago";
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


        //Realiza una consulta a sql para verificar si es el usuario y la contraseña son correctos.
        public decimal consultarPrecio(string servicio)
        {
            decimal precio = 0;
            using (var cn = obtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "select*from Servicios where Servicio = @Servicio and [Estado] = 1";
                        comando.Parameters.AddWithValue("@Servicio", servicio);
                        
                        comando.CommandType = CommandType.Text;

                        SqlDataReader lector = comando.ExecuteReader(); //Se ejecuta el comando.

                        if (lector.HasRows) //Condicional si hay filas en el reader.
                        {
                            while (lector.Read()) //Mientras haya información en el reader, la enviara a la capa Común para guardarla en el cache.
                            {
                               precio = lector.GetDecimal(2);
                                
                           
                            }
                            return precio;
                        }
                        else
                        {
                            return precio;
                        }

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
