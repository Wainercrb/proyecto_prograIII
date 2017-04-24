using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Orden
    {
        //Metodo verifica los datos que ingresan, si estan incorrectos
        //que muestre el error en interfaz y retorne el id de esa orden agregada
        public int consecutivogAregarOrden(ENT.Orden orden)
        {
            int consecutivo = 0;
            try
            {
                DAL.Orden DalOrden = new DAL.Orden();
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
                if (orden.Estado == string.Empty)
                {
                    throw new Exception("Debes seleccionar un estado para esta orden");
                }
                if (orden.Id <= 0)
                {
                    consecutivo = DalOrden.agregarOrden(orden);
                    if (DalOrden.Error)
                    {
                        throw new Exception("Error al guardar la orden " + DalOrden.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return consecutivo;
        }
        //Metodo verifica los datos que ingresan por parametro 
        //y verifican si estan correctos, de lo contrari que los
        //muestre en interfaz, igual cuando se inserta o actualiza
        public void agregarOrden(ENT.Orden orden)
        {
            DAL.Orden DalOrden = new DAL.Orden();
            try
            {
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
                if (orden.Estado == string.Empty)
                {
                    throw new Exception("Debes seleccionar un estado para esta orden");
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
                    AccesoDatosPostgre cnx = AccesoDatosPostgre.Instance;
                    cnx.iniciarTransaccion();
                    DalOrden.actualizarOrden(orden);
                    if (DalOrden.Error)
                    {
                        cnx.rollbackTransaccion();
                        throw new Exception("Error al actualizar la orden " + DalOrden.ErrorMsg);
                    }
                    DalOrden.actualizarTotal(orden);
                    if (DalOrden.Error)
                    {
                        cnx.rollbackTransaccion();
                        throw new Exception("Error al agregar el total de reparaciónes y servicios");
                    }
                    cnx.commitTransaccion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo valida los datos para que se eliminen correctamente
        //si hay error mostrarlo en interfaz y que los parametros sean correctos
        public void eliminarOrden(int valor)
        {
            DAL.Orden DalOrden = new DAL.Orden();
            try
            {
                if (valor <= 0)
                {
                    throw new Exception("Debes seccionar una orden");
                }
                DalOrden.eliminarOrden(valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al eliminar la orden detalle tecnico, " + DalOrden.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes, si hay errores
        //mostrarlos en interfaz
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo verifica si la busqueda de la orden esta correcta
        //si hay erros mostrarlos en interfaz
        public List<ENT.Orden> buscarFechas(DateTime fecha_uno, DateTime fecha_dos)
        {

            DAL.Orden DalOrden = new DAL.Orden();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            try
            {
                ordenes = DalOrden.obtenerFechaOrden(fecha_uno, fecha_dos);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar las ordenes " + DalOrden.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo  busca un valor int y carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes, si hay erros mostrarlos en interfaz
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo  busca un valor string y carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes, si hay error mostrarlos en interfaz
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo  busca un valor por fechas y carga las ordenes y verifica que si hay 
        //un error cuando se cargan las ordenes, si hay error mostrarlos en interfaz
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenes;
        }
        //Metodo verifica los datos que ingresan este correcto
        //verifica la actualizacion de las ordenes sea correcto, de lo
        //contrario monstrarlos en interfas
        public void actualizarEstadoOrden(ENT.Orden EntOrden, string estado, DateTime valor)
        {
            AccesoDatosPostgre cnx = AccesoDatosPostgre.Instance;
            cnx.iniciarTransaccion();
            DAL.Orden DalOrden = new DAL.Orden();
            BLL.Vehiculo BllVehiculo = new BLL.Vehiculo();
            try
            {
                DalOrden.actualizarEstadoOrden(EntOrden, valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al actualizar el estado de la orden");
                    cnx.rollbackTransaccion();
                }
                BllVehiculo.actualizarEstado(EntOrden.Empleado.Id, estado);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al actualizar el estado del vehículo");
                    cnx.rollbackTransaccion();
                }
                cnx.commitTransaccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica que la buscar del datatable sea correcta, de lo
        // contrarrio que dispare los errores a la interfaz
        public DataTable cargarInformeOrdenFinalizada(DateTime valor)
        {
            DataTable tabla = new DataTable();
            try
            {
                DAL.Orden DalOrden = new DAL.Orden();
                tabla = DalOrden.cargarReporteOrdenFinalizada(valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al buscar y cargar la orden, " + DalOrden.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tabla;
        }
        //Metodo verifica cuando se carga un informe, que la carga 
        //se correcto, si hay error mostrarlos en interfaz


        public DataTable cargarInformeOrdenPorId(int valor)
        {
            DataTable tabla = new DataTable();
            try
            {
                DAL.Orden DalOrden = new DAL.Orden();
                tabla = DalOrden.cargarReporteOrdenPorId(valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al buscar y cargar los repuestos, " + DalOrden.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tabla;
        }

        public DataTable cargarInformeOrdenPendiente(DateTime valor)
        {
            DataTable tabla = new DataTable();
            try
            {
                DAL.Orden DalOrden = new DAL.Orden();
                tabla = DalOrden.cargarReporteOrdenPendiente(valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al buscar y cargar los repuestos, " + DalOrden.ErrorMsg);
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
