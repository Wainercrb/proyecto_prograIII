using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdenRepuesto
    {
        //Metodo verifica que los datos esten correctos y verifica si hay 
        //error para mostrarlo en interfaz
        public void agregarOrdenRepuesto(ENT.OrdenRepuesto ordenRepuesto) {
            DAL.OrdenRepuesto DalOrdenRepuesto = new DAL.OrdenRepuesto();
         
                if (ordenRepuesto.Orden.Id<=0)
                {
                    throw new Exception("Debes de seleccionar una orden");
                }
                if (ordenRepuesto.Empleado.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un empleado");
                }
                if (ordenRepuesto.Repuesto1.Id<=0)
                {
                    throw new Exception("Debes seleccionar un repuesto");
                }
                if (ordenRepuesto.Id > 0)
                {
                    if (ordenRepuesto.TotalRepuestos<= 0)
                    {
                        throw new Exception("Debes seleccionar un costo para los repuestos");
                    }
                    DalOrdenRepuesto.editarOrdenRepuesto(ordenRepuesto);
                }
                else {
                    DalOrdenRepuesto.agregarOrdenRepuesto(ordenRepuesto);
                }
           
        }
        //Metodo verifica que los datos sean correcto cuando se editen
        //para que den error  y si hay error mostrarlo en interfaz
        public List<ENT.OrdenRepuesto> cargarOrdenRepuesto(int valor) {
            List<ENT.OrdenRepuesto> ordenRepuestos = new List<ENT.OrdenRepuesto>();
            DAL.OrdenRepuesto DalOrdenRepuesto = new DAL.OrdenRepuesto();
            try
            {
                if (valor <= 0)
                {
                    throw new Exception("Debes seleccionar una orden, para cargar los repusetos añadidos a esa orden");
                }
                ordenRepuestos = DalOrdenRepuesto.buscarOrdenRepuestoPorID(valor);

                if (DalOrdenRepuesto.Error)
                {
                    throw new Exception("Error al cargar los repuestos a la orden "+ valor +", "+DalOrdenRepuesto.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordenRepuestos;
        }
        //Metodo verifica que los datos esten correctos para que no den error
        //si hay error mostrarlos en interfaz
        public void eliminarOrdenRepuesto(ENT.OrdenRepuesto ordenRepuesto)
        {
            DAL.OrdenRepuesto DalOrdenRepuesto = new DAL.OrdenRepuesto();
            try
            {
                if (ordenRepuesto.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un repuesto para eliminar");
                }
                DalOrdenRepuesto.borraOrdenRepuesto(ordenRepuesto);
                if (DalOrdenRepuesto.Error)
                {
                    throw new Exception("Error al eliminar el repuesto,  " + DalOrdenRepuesto.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable cargarInformeRepuestoPorId(int valor) {

            DataTable tabla = new DataTable();
            try
            {
                DAL.OrdenRepuesto DalOrden = new DAL.OrdenRepuesto();
                tabla = DalOrden.cargarInformeRepuestoPorId(valor);
                if (DalOrden.Error)
                {
                    throw new Exception("Error al cargar los repuestos");
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
