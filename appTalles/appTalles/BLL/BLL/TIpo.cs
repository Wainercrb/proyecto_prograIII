using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tipo
    {

        public void agregarTipoVehiculo(ENT.TipoVehiculo tipo)
        {
            DAL.Tipo DalTipo = new DAL.Tipo();
            try
            {
                if (tipo.Tipo == string.Empty)
                {
                    throw new Exception("Debes seleccionar un tipo de vehículo");
                }

                if (tipo.Id <= 0)
                {
                    DalTipo.agregarTipo(tipo);
                    if (DalTipo.Error)
                    {
                        throw new Exception("Error al agregar el tipo de vehículo " + DalTipo.ErrorMsg);
                    }
                }
                else
                {
                    DalTipo.editarTipos(tipo);
                    if (DalTipo.Error)
                    {
                        throw new Exception("Error al editar el tipo de vehículo " + DalTipo.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarTipoVehiculo(ENT.TipoVehiculo tipo)
        {

            DAL.Tipo DalTipo = new DAL.Tipo();
            try
            {
                if (tipo.Id <= 0)
                {
                    throw new Exception("No ha seleccionado un tipo de vehículo");
                }
                DalTipo.borrarTipo(tipo);
                if (DalTipo.Error)
                {
                    throw new Exception("Error al eliminar el vehiculo " + DalTipo.ErrorMsg);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ENT.TipoVehiculo> cargarTiposVehiculos()
        {
            DAL.Tipo DalTipo = new DAL.Tipo();
            List<ENT.TipoVehiculo> tipos = new List<ENT.TipoVehiculo>();
            try
            {
                tipos = DalTipo.obtenerTiposVehiculo();
                if (tipos.Count <= 0)
                {
                    throw new Exception("No se encotraron tipo de vehículos en la base de datos");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tipos;
        }
    }

}
