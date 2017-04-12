using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;

namespace BLL
{
    public class Marca
    {
        public void insertarMarca(ENT.MarcaVehiculo marca)
        {
            DAL.Marca DalMarca = new DAL.Marca();
            try
            {
                if (marca.Marca == string.Empty)
                {
                    throw new Exception("No agregado una marca");
                }
                if (marca.Id < 0)
                {
                    DalMarca.agregarMarca(marca);
                    if (DalMarca.IsError)
                    {
                        throw new Exception("Error al agregar " + DalMarca.ErrorMsg);
                    }

                }
                else
                {
                    if (marca.Id > 0)
                    {
                        DalMarca.editarMarca(marca);
                        if (DalMarca.IsError)
                        {
                            throw new Exception("Error al editar " + DalMarca.ErrorMsg);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void eliminarMarca(ENT.MarcaVehiculo marca)
        {
            DAL.Marca DalMarca = new DAL.Marca();

            try
            {
                if (marca.Marca == string.Empty)
                {
                    throw new Exception("No se ha ingresado una marca");
                }

                DalMarca.borrarMarca(marca);
                if (DalMarca.IsError)
                {
                    throw new Exception("Error al editar " + DalMarca.ErrorMsg);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ENT.MarcaVehiculo> cargarMarca()
        {
            DAL.Marca DalMarca = new DAL.Marca();
            List<ENT.MarcaVehiculo> marcas = new List<ENT.MarcaVehiculo>();
            try
            {
                marcas = DalMarca.obtenerMarcas();
                if (marcas.Count <= 0)
                {
                    throw new Exception("No hay marcas registradas");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return marcas;

        }

        public List<ENT.MarcaVehiculo> buscarMarca(ENT.MarcaVehiculo marca) {

            DAL.Marca DalMarca = new DAL.Marca();
            List<ENT.MarcaVehiculo> marcas = new List<ENT.MarcaVehiculo>();
            try
            {
                marcas = DalMarca.buscarMarcas(marca);
                if (marcas.Count <= 0)
                {
                    throw new Exception("No hay marcas registradas");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return marcas;


        }
    }
}
