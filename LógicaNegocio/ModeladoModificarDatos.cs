using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Común.Cache;
using AccesoDatos;

namespace LógicaNegocio
{
   public class ModeladoModificarDatos
    {
        readonly ModificarDatosDAO datos = new ModificarDatosDAO();//Objeto para invocar la clase de objeto de acceso a Datos (IngresarDatosDAO).
        #region Barbero
        public DataTable ObtenerBarberos()
        {
            return datos.ConsultarBarberos();
        }

        public void AgregarBarbero(string Barbero)
        {
            datos.AgregarBarbero(Barbero);
        }

        public void ActualizarBarbero(int id, String Barbero)
        {
            datos.ActualizarBarbero(id, Barbero);
        }

        public void EliminarBarbero(int id)
        {
            datos.EliminarBarbero(id);
        }
        #endregion

        #region Servicios
        public DataTable ObtenerServicio()
        {
            return datos.ConsultarServicio();
        }

        public void AgregarServicio(string servicio, int precio)
        {
            datos.AgregarServicio(servicio,precio);
        }

        public void ActualizarServicio(int id, String servicio, int precio)
        {
            datos.ActualizarServicios(id, servicio,precio);
        }

        public void EliminarServicio(int id)
        {
            datos.EliminarServicios(id);
        }
        #endregion

        #region MetodoPago
        public DataTable ObtenerMetodoPago()
        {
            return datos.ConsultarMetodoPago();
        }

        public void AgregarMetodoPago(string metodoPago)
        {
            datos.AgregarMetodoPago(metodoPago);
        }

        public void ActualizarMetodoPago(int id, String metodoPago)
        {
            datos.ActualizarMetodoPago(id, metodoPago);
        }

        public void EliminarMetodoPago(int id)
        {
            datos.EliminarMetodoPago(id);
        }
        #endregion

    }
}
