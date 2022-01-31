﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Común.Cache;

namespace AccesoDatos
{
    public class UsuarioDAO:ConexiónSQL
    {
        //Realiza una consulta a sql para verificar si es el usuario y la contraseña son correctos.
        public bool Login(string usuario, string contraseña)
        {

            using (var cn = obtenerConexión()) //Asignamos la ubicación de la base de datos a la variable connection.
            {
                cn.Open(); //Se procede abrir la conexión SQL.

                using (var comando = new SqlCommand()) //Establecemos un comando SQL.
                {
                    comando.Connection = cn;
                    comando.CommandText = "select*from Usuarios where Usuario=@usuario and Contraseña=@Contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);
                    comando.CommandType = CommandType.Text;

                    SqlDataReader lector = comando.ExecuteReader(); //Se ejecuta el comando.

                    if (lector.HasRows) //Condicional si hay filas en el reader.
                    {
                        while (lector.Read()) //Mientras haya información en el reader, la enviara a la capa Común para guardarla en el cache.
                        {

                            DatosUsuario.Nombre = lector.GetString(3);
                            DatosUsuario.Apellido = lector.GetString(4);
                            DatosUsuario.Id = lector.GetString(1);
                            DatosUsuario.Puesto = lector.GetString(5);
                            DatosUsuario.Estado = lector.GetInt32(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }


            }


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

                    SqlDataAdapter adaptador = new SqlDataAdapter("ListaBarberos",cn); //Se ejecuta el comando.

                    adaptador.Fill(datos);

                    return datos;

                }


            }


        }

    }
}
