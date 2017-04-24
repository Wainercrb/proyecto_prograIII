using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdenServicio
    {
        public void agregarOrdenServicio(ENT.OrdenServicio ordenServicio)
        {
            DAL.OrdenServicio DalOrdenServicio = new DAL.OrdenServicio();
           
            //try
            //{
                if (ordenServicio.Empleado.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un empleado para estos servicios");
                }
                if (ordenServicio.Orden.Id <= 0)
                {
                    throw new Exception("Debes seleccionar una orden para estos servicios");
                }
                if (ordenServicio.Servicio.pServicio == string.Empty)
                {
                    throw new Exception("Debes seleccionar un servicio");
                }
                if (ordenServicio.Cantidad <= 0)
                {
                    throw new Exception("Debes seleccionar una cantidad valida");
                }
                if (ordenServicio.Id <= 0)
                {                 
                    DalOrdenServicio.agregarOrdenServicio(ordenServicio);
                    if (DalOrdenServicio.Error)
                    {
                        throw new Exception("Error al agregar los servicios a la orden, "+DalOrdenServicio.ErrorMsg);
                    }
                }
                else
                {
                    if (ordenServicio.Costo <= 0)
                    {
                        throw new Exception("Costos de los servicios invalido verifique");
                    }
                    DalOrdenServicio.editarOrdenServicio(ordenServicio);
                    if (DalOrdenServicio.Error)
                    {
                        throw new Exception("Error al actualizar los servicios a la orden, "+DalOrdenServicio.ErrorMsg);
                    }
                }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }
        public void eliminarOrdenServicio(ENT.OrdenServicio ordenServicio)
        {
            DAL.OrdenServicio DalOrdenServicio = new DAL.OrdenServicio();
            try
            {
                if (ordenServicio.Id <= 0)
                {
                    throw new Exception("Debes seleccionar los servicios, necesarios para eliminar");
                }
                DalOrdenServicio.borraOrdenServicio(ordenServicio);
                if (DalOrdenServicio.Error)
                {
                    throw new Exception("Error al eliminar los servicios, " + DalOrdenServicio.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ENT.OrdenServicio> cargarOrdenServicio(int valor)
        {
            DAL.OrdenServicio DalOrdenServicio = new DAL.OrdenServicio();
            List<ENT.OrdenServicio> ordenServicios = new List<ENT.OrdenServicio>();
            try
            {
                if (valor <= 0)
                {
                    throw new Exception("Debes seleccionar una orden para cargar los servicios");
                }
                ordenServicios = DalOrdenServicio.buscarOrdenServicioPorID(valor);
                if (DalOrdenServicio.Error)
                {
                    throw new Exception("Error al cargar los servicios, " + DalOrdenServicio.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenServicios;
        }
        public DataTable cargarInformeServicoPorId(int valor)
        {

            DataTable tabla = new DataTable();
            try
            {
                DAL.OrdenServicio DalOrden = new DAL.OrdenServicio();
                tabla = DalOrden.cargarInformeServicioPorId(valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar los servicios, " + DalOrden.ErrorMsg);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tabla;
        }
    }
}

