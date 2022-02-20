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
    public class ModificarDatosDAO : ConexiónSQL
    {
        #region "Barbero"
        public DataTable ConsultarBarberos()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "ListaBarberos";
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

        //Inserta los datos de los nuevos barberos.
        public void AgregarBarbero(string Barbero)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "AgregarBarbero";
                        comando.Parameters.AddWithValue("@Barbero", Barbero);                  

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

        //Actualizar los datos en la tabla historial.
        public void ActualizarBarbero(int id, string Barbero)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "ActualizarBarbero";
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@Barbero", Barbero);                       

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

        //Eliminar Barbero.
        public void EliminarBarbero(int id)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "EliminarBarbero";
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
        #endregion

        #region "Servicio"
        public DataTable ConsultarServicio()
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "ListaServicios";
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

        //Inserta los datos de los nuevos Servicios.
        public void AgregarServicio(string servicio,int precio)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "AgregarServicio";
                        comando.Parameters.AddWithValue("@Servicio", servicio);
                        comando.Parameters.AddWithValue("@Precio", precio);

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

        //Actualizar los datos en la tabla historial.
        public void ActualizarServicios(int id, string servicio, int precio)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "ActualizarServicio";
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@Servicio", servicio);
                        comando.Parameters.AddWithValue("@Precio", precio);

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

        //Eliminar Barbero.
        public void EliminarServicios(int id)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "EliminarServicios";
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
        #endregion

        #region "MetodoPago"
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
                        comando.CommandText = "ListaMetodoPago";
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

        //Inserta los datos de los nuevos Servicios.
        public void AgregarMetodoPago(string metodoPago)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "AgregarMetodoPago";
                        comando.Parameters.AddWithValue("@MetodoPago", metodoPago);                        

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

        //Actualizar los datos en la tabla historial.
        public void ActualizarMetodoPago(int id, string metodoPago)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "ActualizarMetodoPago";
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@MetodoPago", metodoPago);                        

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

        //Eliminar Barbero.
        public void EliminarMetodoPago(int id)
        {

            using (var cn = ObtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                try
                {
                    cn.Open(); //Se procede abrir la conexión SQL.

                    using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                    {
                        comando.Connection = cn;
                        comando.CommandText = "EliminarMetodoPago";
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
        #endregion
    }
}
