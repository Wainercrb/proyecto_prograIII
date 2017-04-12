using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repuesto
    {
        public void agregarRepuesto(ENT.RepuestoVehiculo repuesto)
        {
            DAL.Repuesto DalRepesto = new DAL.Repuesto();
            try
            {
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
                if (repuesto.Id < 0)
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
                        throw new Exception("Error al editar el repuesto");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
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
                    throw new Exception("Error al eliminar el repuesto");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

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
                    throw new Exception("Error al eliminar la marca del repuesto "+ DalRepesto.ErrorMsg);
                }
            }
            catch (Exception ex)
            {            
                throw ex;
            }
        }
    }
}
