using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Modelo
    {
        public void agregarModelo(ENT.Modelo modelo) {
            DAL.Modelo DalModelo = new DAL.Modelo();
            try
            {
                if (modelo.pModelo == string.Empty)
                {
                    throw new Exception("Debes de agregar un modelo correcto");
                }
                if (modelo.Id <= 0)
                {
                    DalModelo.agregarModelo(modelo);
                    if (DalModelo.Error)
                    {
                        throw new Exception("Error al agregar el modelo, " + DalModelo.ErrorMsg);
                    }
                }
                else {
                    DalModelo.editarModelo(modelo);
                    if (DalModelo.Error)
                    {
                        throw new Exception("Error al editar el modelo, "+ DalModelo.ErrorMsg);
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void eliminarModelo(ENT.Modelo modelo) {

            DAL.Modelo DalModelo = new DAL.Modelo();
            try
            {
                DalModelo.eliminarModelo(modelo);
                if (DalModelo.Error)
                {
                    throw new Exception("Error al elimnar el modelo, "+DalModelo.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ENT.Modelo> cargarModelo() {
            DAL.Modelo DalModelo = new DAL.Modelo();
            List<ENT.Modelo> lista = new List<ENT.Modelo>();
            try
            {
                lista = DalModelo.obtenerModelo();
                if (DalModelo.Error)
                {
                    throw new Exception("Error al cargar los modelos," + DalModelo.ErrorMsg);
                }
                if (lista.Count<=0)
                {
                    throw new Exception("No hay repuestos registrados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }
        public List<ENT.Modelo> cargarModeloPorId(int valor)
        {
            DAL.Modelo DalModelo = new DAL.Modelo();
            List<ENT.Modelo> lista = new List<ENT.Modelo>();
            try
            {
                lista = DalModelo.obtenerModeloPorID(valor);
                if (DalModelo.Error)
                {
                    throw new Exception("Error al cargar los modelos," + DalModelo.ErrorMsg);
                }
                if (lista.Count <= 0)
                {
                    throw new Exception("No hay repuestos registrados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }
        public List<ENT.Modelo> cargarModeloPorModelo(string valor)
        {
            DAL.Modelo DalModelo = new DAL.Modelo();
            List<ENT.Modelo> lista = new List<ENT.Modelo>();
            try
            {
                lista = DalModelo.obtenerModeloPorModelo(valor);
                if (DalModelo.Error)
                {
                    throw new Exception("Error al cargar los modelos," + DalModelo.ErrorMsg);
                }
                if (lista.Count <= 0)
                {
                    throw new Exception("No hay repuestos registrados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }
    }
}
