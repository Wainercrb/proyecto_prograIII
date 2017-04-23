using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repuesto
    {
        //Metodo verifica que los datos ingresados por parametros
        //esten correctos, para luego guardarlos en la db
        public void agregarRepuesto(ENT.RepuestoVehiculo repuesto)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            //try
            //{
                if (repuesto.Impuesto <= 0)
                {
                    throw new Exception("No se ha seleccionado un impuesto para este repuesto");
                }
                if (repuesto.Repuesto == string.Empty)
                {
                    throw new Exception("No se ha seleccionado un repuesto");
                }
                if (repuesto.Precio <= 0)
                {
                    throw new Exception("No se ha seleccionado un precio para este repuesto");
                }
                if (repuesto.Id <= 0)
                {
                    DalRepesto.agregarRepuesto(repuesto);
                    if (DalRepesto.Error)
                    {
                        throw new Exception("Error al agregar el repuesto " + DalRepesto.ErrorMsg);
                    }
                }
                else
                {
                    DalRepesto.editarRepuesto(repuesto);
                    if (DalRepesto.Error)
                    {
                        throw new Exception("Error al editar el repuesto, "+ DalRepesto.ErrorMsg);
                    }
                }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }
        //Metodo verifica, cuando carga que la carga sea correcto
        //si no que dispare los errores 
        public List<ENT.RepuestoVehiculo> cargarRepuestos()
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            List<ENT.RepuestoVehiculo> repuestos = new List<ENT.RepuestoVehiculo>();

            try
            {
                repuestos = DalRepesto.obtenerRepesto();
                if (DalRepesto.Error)
                {
                    throw new Exception("Error al cargar los repuesto " + DalRepesto.ErrorMsg);
                }
                if (repuestos.Count <= 0)
                {
                    throw new Exception("No hay repuesto en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return repuestos;
        }
        //Metodo verifica que los datos que recibe por parametros esten
        //correctos para luego pasarcelos a DAL
        public void eliminarRepuesto(ENT.RepuestoVehiculo repuesto)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            try
            {
                if (repuesto.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un repuesto a eliminar");
                }
                DalRepesto.borrarRepuesto(repuesto);
                if (DalRepesto.Error)
                {
                    throw new Exception("Error al eliminar el repuesto, " + DalRepesto.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo valida los datos que ingresan por parametos, que esten
        //correctos para pasarlos al DAL
        public void agregarRepuestoMarca(ENT.MarcaVehiculo marca, ENT.RepuestoVehiculo repuesto)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            try
            {
                if (marca.Id <= 0)
                {
                    throw new Exception("Debes seleccionar una marca");
                }
                if (repuesto.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un repuesto");
                }
                DalRepesto.agregarMarcasRepuesto(marca, repuesto);
                if (DalRepesto.Error)
                {
                    throw new Exception("Error al agregar la marca a este repuesto " + DalRepesto.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica que los datos esten correctos para luego
        //pasarcelos al dal
        public void borrarRepuestoMarca(ENT.MarcaVehiculo marca)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            try
            {
                if (marca.Id <= 0)
                {
                    throw new Exception("Debes seleccionar una marca a eliminar");
                }
                DalRepesto.borrarRepuestoMarca(marca);
                if (DalRepesto.Error)
                {
                    throw new Exception("Error al eliminar la marca del repuesto " + DalRepesto.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica, cuando se busca y ocurre un error que los verifique y los dispare a la 
        //interfas
        public List<ENT.RepuestoVehiculo> buscarStringRepuesto(string valor, string columna)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            List<ENT.RepuestoVehiculo> repuestos = new List<ENT.RepuestoVehiculo>();
            try
            {
                if (valor == string.Empty)
                {
                    throw new Exception("Debes ingresar un valor valido a buscar");
                }
                repuestos = DalRepesto.buscarStringRepuesto(valor, columna);
                if (DalRepesto.Error)
                {
                    throw new Exception("Error al cargar los repuesto " + DalRepesto.ErrorMsg);
                }
                if (repuestos.Count <= 0)
                {
                    throw new Exception("No hay repuesto en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return repuestos;
        }
        //Metodo verifica, cuando se busca y ocurre un error que los verifique y los dispare a la 
        //interfas
        public List<ENT.RepuestoVehiculo> buscarDoubleRepuesto(double valor, string columna)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            List<ENT.RepuestoVehiculo> repuestos = new List<ENT.RepuestoVehiculo>();
            try
            {
                if (valor <= 0)
                {
                    throw new Exception("Debe ingresar un valor a buscar valido(positivo)");
                }
                repuestos = DalRepesto.buscarDoubleRepuesto(valor, columna);
                if (DalRepesto.Error)
                {
                    throw new Exception("Error al cargar los repuesto " + DalRepesto.ErrorMsg);
                }
                if (repuestos.Count <= 0)
                {
                    throw new Exception("No hay repuesto en la base de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return repuestos;
        }

        public DataTable cargarRepuestoFrecuentes() {

            DAL.Repuesto DalRepuesto = new DAL.Repuesto();
            DataTable tabla = null;
            try
            {
                tabla = DalRepuesto.cargarInformeRepuestoFrecuente();
                if (DalRepuesto.Error)
                {
                    throw new Exception("Error al cargar los repuestos frecuentes, "+DalRepuesto.ErrorMsg);
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
