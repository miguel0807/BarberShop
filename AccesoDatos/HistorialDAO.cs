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

        //Realiza una consulta sql para obtener el historial filtrado por nombre de barbero.
        public DataTable ConsultarHistorialBarbero(string barbero)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "ConsultarBarberos";                        
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Barbero", barbero);

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


        //Realiza una consulta sql para obtener el historial filtrado por rango de fechas.
        public DataTable ConsultarHistorialRangoFechas(string FechaInicial, string  FechaFinal)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "HistorialFechas";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@FechaInicial", FechaInicial);
                        comando.Parameters.AddWithValue("@FechaFinal", FechaFinal);

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

        //Realiza una consulta sql para obtener las columnas de Historial.
        public DataTable ConsultarNombresColumnas()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Historial' and COLUMN_NAME <> 'id' and COLUMN_NAME <> 'Precio'";
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

        //Inserta los datos en la tabla historial.
        public void EliminarDatos(int id)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "EliminarDatos";
                        comando.Parameters.AddWithValue("@id", id);

                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();

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
