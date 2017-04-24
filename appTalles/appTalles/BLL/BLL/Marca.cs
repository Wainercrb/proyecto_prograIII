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
        //Metodo agrega o actualiza una marca que ingresa
        //por parametros
        public void insertarMarca(ENT.MarcaVehiculo marca)
        {
            DAL.Marca DalMarca = new DAL.Marca();
            try
            {
                if (marca.Marca == string.Empty)
                {
                    throw new Exception("No agregado una marca");
                }
                if (marca.Modelo.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un modelo para esta marca");
                }
                if (marca.Id <= 0)
                {
                    DalMarca.agregarMarca(marca);
                    if (DalMarca.Error)
                    {
                        throw new Exception("Error al agregar la marca, " + DalMarca.ErrorMsg);
                    }
                }
                else
                {
                    if (marca.Id > 0)
                    {
                        DalMarca.editarMarca(marca);
                        if (DalMarca.Error)
                        {
                            throw new Exception("Error al editar la marca, " + DalMarca.ErrorMsg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo elimina la marca que ingresa por parametros
        public void eliminarMarca(ENT.MarcaVehiculo marca)
        {
            try
            {
                DAL.Marca DalMarca = new DAL.Marca();
                if (marca.Id <= 0)
                {
                    throw new Exception("Debes seleccionar una marca");
                }

                DalMarca.borrarMarca(marca);
                if (DalMarca.Error)
                {
                    throw new Exception("Error al elimar la marca " + DalMarca.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo carga todad las marcas y la agrega a la lista
        //para retornarlas
        public List<ENT.MarcaVehiculo> cargarMarca()
        {
            DAL.Marca DalMarca = new DAL.Marca();
            List<ENT.MarcaVehiculo> marcas = new List<ENT.MarcaVehiculo>();
            try
            {
                marcas = DalMarca.obtenerMarcas();
                if (DalMarca.Error)
                {
                    throw new Exception("Error al cargar las marcas, " + DalMarca.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return marcas;
        }
        //Metodo busca un valor de la marca para retornarla
        //en una lista
        public List<ENT.MarcaVehiculo> buscarMarca(string valor)
        {
            DAL.Marca DalMarca = new DAL.Marca();
            List<ENT.MarcaVehiculo> marcas = new List<ENT.MarcaVehiculo>();
            try
            {
                if (valor == string.Empty)
                {
                    throw new Exception("Debes ingresar un valor valido");
                }
                marcas = DalMarca.buscarMarcas(valor);
                if (DalMarca.Error)
                {
                    throw new Exception("Error al buscar las marcas");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return marcas;
        }
        //Metodo busca un valor de la marca para retornarla
        //en una lista
        public List<ENT.MarcaVehiculo> buscaIntrMarca(int valor)
        {
            DAL.Marca DalMarca = new DAL.Marca();
            List<ENT.MarcaVehiculo> marcas = new List<ENT.MarcaVehiculo>();
            try
            {
                if (valor <= 0)
                {
                    throw new Exception("Debes ingresar un valor valido");
                }
                marcas = DalMarca.buscarIntMarcas(valor);
                if (DalMarca.Error)
                {
                    throw new Exception("Error al buscar las marcas, " + DalMarca.ErrorMsg);
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
