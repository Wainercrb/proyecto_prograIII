using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vehiculo
    {
        //Metodo verica que los datos que recibe por parametro
        //esten correctos para pasarlos a DAL y insertarlos
        public void agregarVehiculo(ENT.Vehiculo vehiculo)
        {
            DAL.Vehiculo DalVehiculo = new DAL.Vehiculo();
            try
            {
                if (vehiculo.Anno <= 0)
                {
                    throw new Exception("Año de vehículo requerido");
                }
                if (vehiculo.Cilindraje <= 0)
                {
                    throw new Exception("Cilindraje del vihículo requerido");
                }
                if (vehiculo.NumeroChazis <= 0)
                {
                    throw new Exception("Numero de chazis del vehículo requerido");
                }
                if (vehiculo.Placa == string.Empty)
                {
                    throw new Exception("Placa del vehículo requerida");
                }
                if (vehiculo.TipoCombustible == string.Empty)
                {
                    throw new Exception("Tipo de combustible del vehículo invalido");
                }
                if (vehiculo.NumeroMotor <= 0)
                {
                    throw new Exception("Error numero de motor del vehículo requerido");
                }
                if (vehiculo.Estado == string.Empty)
                {
                    throw new Exception("Estado del vehículo requerido");
                }
                if (vehiculo.Cliente.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un cliente para guardar el vehículo");
                }
                if (vehiculo.Marca.Id <= 0)
                {
                    throw new Exception("Debes seleccionar una marca para guardar este vehiculo");
                }
                if (vehiculo.Tipo.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un tipo de vehículo");
                }
                if (vehiculo.Id <= 0)
                {
                    DalVehiculo.agregarVehiculo(vehiculo);
                    if (DalVehiculo.Error)
                    {
                        throw new Exception("Error al guardar el vehículo " + DalVehiculo.ErrorMsg);
                    }
                }
                else
                {
                    DalVehiculo.editarVehiculo(vehiculo);
                    if (DalVehiculo.Error)
                    {
                        throw new Exception("Error al editar el vehículo " + DalVehiculo.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica la entidad vehículo que este correcta,
        //que para cuando se elimine no cause error
        public void eliminarVehiculo(ENT.Vehiculo vehiculo)
        {
            DAL.Vehiculo DalVehiculo = new DAL.Vehiculo();
            try
            {
                if (vehiculo.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un vehículo, para eliminarlo");
                }
                DalVehiculo.borrarVehiculo(vehiculo);
                if (DalVehiculo.Error)
                {
                    throw new Exception("Error al eliminar el vehículo " + DalVehiculo.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica, que la carga de los vehículos sea correcta
        //si hay error que los muestre en interfaz
        public List<ENT.Vehiculo> cargarVehiculos()
        {
            DAL.Vehiculo DalVehiculo = new DAL.Vehiculo();
            List<ENT.Vehiculo> vehiculos = new List<ENT.Vehiculo>();
            try
            {
                vehiculos = DalVehiculo.obtenerVehiculos();
                if (DalVehiculo.Error)
                {
                    throw new Exception("Error al cargar los vehiculos " + DalVehiculo.ErrorMsg);
                }
                if (vehiculos.Count <= 0)
                {
                    throw new Exception("No hay vehículos registrados en la base de datos");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return vehiculos;
        }
        //Metodo verifica la busqueda de una valor, para que sea exitosa
        //si hay error que los muestre en interfaz
        public List<ENT.Vehiculo> buscarStringVehiculos(string valor, string columna)
        {
            DAL.Vehiculo DalVehiculo = new DAL.Vehiculo();
            List<ENT.Vehiculo> vehiculos = new List<ENT.Vehiculo>();
            try
            {
                vehiculos = DalVehiculo.BuscarStringVehiculo(valor, columna);
                if (DalVehiculo.Error)
                {
                    throw new Exception("Error al cargar los vehiculos " + DalVehiculo.ErrorMsg);
                }
                if (vehiculos.Count <= 0)
                {
                    throw new Exception("No hay vehículos registrados en la base de datos");
                }
            }
            catch (Exception ex)
            {           
                throw ex;
            }
            return vehiculos;
        }
        //Metodo verifica la busqueda de una valor, para que sea exitosa
        //si hay error que los muestre en interfaz
        public List<ENT.Vehiculo> buscarIntVehiculos(int valor, string columna)
        {
            DAL.Vehiculo DalVehiculo = new DAL.Vehiculo();
            List<ENT.Vehiculo> vehiculos = new List<ENT.Vehiculo>();
            try
            {
                vehiculos = DalVehiculo.BuscarIntVehiculo(valor, columna);
                if (DalVehiculo.Error)
                {
                    throw new Exception("Error al cargar los vehiculos " + DalVehiculo.ErrorMsg);
                }
                if (vehiculos.Count <= 0)
                {
                    throw new Exception("No hay vehículos registrados en la base de datos");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return vehiculos;
        }
        public void actualizarEstado(int id, string estado) {

            try
            {
                DAL.Vehiculo DalVehiculo = new DAL.Vehiculo();
                if (id<= 0)
                {
                    throw new Exception("Debes seleccionar una orden para actualizar el estado del vehículo");
                }
                if (estado == string.Empty)
                {
                    throw new Exception("No se encontro el estado del vehículo");
                }
                DalVehiculo.actualizarEstado(id, estado);
                if (DalVehiculo.Error)
                {
                    throw new Exception("Error al actualizar el estado del vehículo");
                }

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
