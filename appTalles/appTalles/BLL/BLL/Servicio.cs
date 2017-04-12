using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Servicio
    {

        public void agregarServicio(ENT.Servicio servicio)
        {

            DAL.Servicio DalServicio = new DAL.Servicio();
            try
            {
                if (servicio.Impuesto <= 0)
                {
                    throw new Exception("Impuesto del servicio requerido");
                }
                if (servicio.Precio <= 0)
                {
                    throw new Exception("Precio del servicio requerido");
                }
                if (servicio.pServicio == string.Empty)
                {
                    throw new Exception("Tipo de servicio requerido");
                }
                if (servicio.Id <= 0)
                {
                    DalServicio.agregarservicio(servicio);
                    if (DalServicio.Error)
                    {
                        throw new Exception("Error al agregar el servicio " + DalServicio.ErrorMsg);
                    }
                }
                else
                {

                    DalServicio.actualizarServicio(servicio);
                    if (DalServicio.Error)
                    {
                        throw new Exception("Error al actualizar el servicio " + DalServicio.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarServicio(ENT.Servicio servicio)
        {
            DAL.Servicio DalServicio = new DAL.Servicio();
            try
            {
                DalServicio.borrarservicio(servicio);
                if (DalServicio.Error)
                {
                    throw new Exception("Error al eliminar el servicio");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ENT.Servicio> cargarServicio()
        {
            DAL.Servicio DalServicio = new DAL.Servicio();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            try
            {
                //servicios = DalServicio.Obtenerservicios();
                if (DalServicio.Error)
                {
                    throw new Exception("Error al cargar los servicios " + DalServicio.ErrorMsg);
                }
                if (servicios.Count <= 0)
                {
                    throw new Exception("No hay servicios en la base de datos");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return servicios;
        }

    }
}
