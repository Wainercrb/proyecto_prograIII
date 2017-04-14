using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Orden
    {
        public void agregarOrden(ENT.Orden orden)
        {

            DAL.Orden DalOrden = new DAL.Orden();
            try
            {
                if (orden.CostoTotal <= 0)
                {
                    throw new Exception("Costo total de la orden requerido");
                }
                if (orden.FechaFacturacion == null)
                {
                    throw new Exception("Fecha de la facturació de la orden requerida");
                }
                if (orden.FechaIngreso.Date == null)
                {
                    throw new Exception("Fecha de ingreso de la orden requerida");
                }
                if (orden.FechaSalida.Date == null)
                {
                    throw new Exception("Fecha de salida de la orden requerido");
                }
                if (orden.Empleado.Id <= 0)
                {
                    throw new Exception("Debes seleccionar el empleado que creo esta orden");
                }
                if (orden.Id <= 0)
                {
                    DalOrden.agregarOrden(orden);
                    if (DalOrden.Error)
                    {
                        throw new Exception("Error al guardar la orden " + DalOrden.ErrorMsg);
                    }
                }
                else
                {
                    DalOrden.actualizarOrden(orden);
                    if (DalOrden.Error)
                    {
                        throw new Exception("Error al actualizar la orden " + DalOrden.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Metodo valida los datos para que se eliminen correctamente
        //si hay error mostrarlo en interfaz
        public void eliminarOrden(ENT.Orden orden)
        {
            DAL.Orden DalOrden = new DAL.Orden();
            try
            {
                if (orden.Id <= 0)
                {
                    throw new Exception("Debes seccionar una orden");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Metodo carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes
        public List<ENT.Orden> cargarOrden()
        {
            DAL.Orden DalOrden = new DAL.Orden();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            try
            {
                ordenes = DalOrden.obtenerOrden();
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar las ordenes " + DalOrden.ErrorMsg);
                }
                if (ordenes.Count <= 0)
                {
                    throw new Exception("No hay ordenes en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo  busca un valor int y carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes
        public List<ENT.Orden> cargarIntOrden(int valor, string columna)
        {
            DAL.Orden DalOrden = new DAL.Orden();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            try
            {
                if (valor <= 0)
                {
                    throw new Exception("Debes ingresar un valor valido a buscar");
                }
                ordenes = DalOrden.obtenerIntOrden(valor, columna);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar las ordenes " + DalOrden.ErrorMsg);
                }
                if (ordenes.Count <= 0)
                {
                    throw new Exception("No hay ordenes en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo  busca un valor string y carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes
        public List<ENT.Orden> cargarStringOrden(string valor, string columna)
        {
            DAL.Orden DalOrden = new DAL.Orden();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            try
            {
                if (valor == "")
                {
                    throw new Exception("Debes ingresar un valor valido a buscar");
                }
                ordenes = DalOrden.obtenerStringOrden(valor, columna);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar las ordenes " + DalOrden.ErrorMsg);
                }
                if (ordenes.Count <= 0)
                {
                    throw new Exception("No hay ordenes en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo  busca un valor por fechas y carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes
        public List<ENT.Orden> cargarStringOrden(DateTime ingreso, DateTime salida)
        {
            DAL.Orden DalOrden = new DAL.Orden();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            try
            {
                ordenes = DalOrden.obtenerFechaOrden(ingreso, salida);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar las ordenes " + DalOrden.ErrorMsg);
                }
                if (ordenes.Count <= 0)
                {
                    throw new Exception("No hay ordenes en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
    }
}
