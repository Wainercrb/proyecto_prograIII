using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Servicio
    {
        //Metodo valida los datos que recibe por parametro
        //para posteriormente insertarlos o actualizarlos desde DAL
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
        //Metodo valida los datos y comprueva cualquier error  
        //para posteriormente pasarlos a DAL
        public void eliminarServicio(ENT.Servicio servicio)
        {
            DAL.Servicio DalServicio = new DAL.Servicio();
            try
            {
                if (servicio.Id<=0)
                {
                    throw new Exception("Debes de seleccionar un servicio");
                }
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
        //Metodo verifica que los datos se cargaran correctamente
        //para retornarlos exitosamente
        public List<ENT.Servicio> cargarServicio()
        {
            DAL.Servicio DalServicio = new DAL.Servicio();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            try
            {
                servicios = DalServicio.cargarServicios();
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

        //Metodo verifica los datos a busca para id al DAL a buscar el servicio
        //con esta columna y con el valor
        public List<ENT.Servicio> buscarStringServicio(string valor, string columna) {

            DAL.Servicio DalServicio = new DAL.Servicio();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            try
            {
                if (valor == string.Empty)
                {
                    throw new Exception("Debes ingresar un valor a buscar valido");
                }           
                servicios = DalServicio.buscarStringServicio(valor, columna);
                if (DalServicio.Error)
                {
                    throw new Exception("Error al cargar los servicios, "+ DalServicio.ErrorMsg);
                }
                if (servicios.Count<= 0)
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
        //Metodo verifica los datos a busca para id al DAL a buscar el servicio
        //con esta columna y con el valor
        public List<ENT.Servicio> buscarIntServicio(int valor, string columna)
        {

            DAL.Servicio DalServicio = new DAL.Servicio();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            try
            {
                if (valor<= 0)
                {
                    throw new Exception("Debes ingresar un valor a buscar valido");
                }
                servicios = DalServicio.buscarIntServicio(valor, columna);
                if (DalServicio.Error)
                {
                    throw new Exception("Error al cargar los servicios, " + DalServicio.ErrorMsg);
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
