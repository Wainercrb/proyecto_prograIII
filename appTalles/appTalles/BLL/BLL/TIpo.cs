using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tipo
    {
        //Metodo valida los datos y para agregarlos a la base de
        //datos o actualizarlos
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
        //Metodo valida los datos necesarios para eliminar este tipo de vehículo
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
        //Metodo cargar los tipos de vehículos y los agregar
        //a la lista para retornarlos a la interfaz
        public List<ENT.TipoVehiculo> cargarTiposVehiculos()
        {
            DAL.Tipo DalTipo = new DAL.Tipo();
            List<ENT.TipoVehiculo> tipos = new List<ENT.TipoVehiculo>();
            try
            {
                tipos = DalTipo.obtenerTiposVehiculo();
                if (DalTipo.Error)
                {
                    throw new Exception("Error al cargar los tipos de vehículos");
                }
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
        //Metodo valida los datos a buscar para cargar los tipos 
        //de vehículos similares con esos datos
        public List<ENT.TipoVehiculo> buscarStringTipo(string valor)
        {
            DAL.Tipo DalTipo = new DAL.Tipo();
            List<ENT.TipoVehiculo> tipos = new List<ENT.TipoVehiculo>();
            try
            {
                if (valor == string.Empty)
                {
                    throw new Exception("Debes ingresar un un valor a buscar");
                }
                tipos = DalTipo.buscarStringTipo(valor);
                if (DalTipo.Error)
                {
                    throw new Exception("Error al buscar el tipo de vehículo");
                }
                if (tipos.Count <= 0)
                {
                    throw new Exception("No hay tipos de vehículo registrados con el dato " + valor);
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
