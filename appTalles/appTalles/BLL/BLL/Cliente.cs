using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;
using System.Data;

namespace BLL
{
    public class Cliente
    {
        //Metodo verifica que los datos que recibe esten correctos
        //para pasarlo a dal y insetarlos
        public void insertarCliente(ENT.Cliente cli)
        {
            DAL.Cliente DalCliente = new DAL.Cliente();
            try
            {
                if (cli.Cedula == String.Empty)
                {
                    throw new Exception("Se debe ingresar la Cedula");
                }
                if (cli.Nombre == String.Empty)
                {
                    throw new Exception("Se debe ingresar su Nombre");
                }
                if (cli.ApellidoPaterno == String.Empty)
                {
                    throw new Exception("Se debe ingresar el Apellido Paterno");
                }
                if (cli.ApellidoMaterno == String.Empty)
                {
                    throw new Exception("Se debe ingresar el Apellifdo Materno");
                }
                if (cli.TelefonoCasa == String.Empty)
                {
                    throw new Exception("Se debe ingresar el Telefono de casa");
                }

                if (cli.TelefonoOficina == String.Empty)
                {
                    throw new Exception("Se debe ingrese el Telefono de oficina ");
                }

                if (cli.TelefonoCelular == String.Empty)
                {
                    throw new Exception("Se debe ingresar el Telefono cedular");
                }
                if (cli.Id <= 0)
                {
                    DalCliente.agregarCliente(cli);
                    if (DalCliente.IsError)
                    {
                        throw new Exception("Error al agregar el cliente" + DalCliente.ErrorMsg);
                    }
                }
                else
                {
                    DalCliente.editarCliente(cli);
                    if (DalCliente.IsError)
                    {
                        throw new Exception("Error al editar el cliente" + DalCliente.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo vefica que la entidad cliente este correcta y poder eliminarlo
        //si hay error mostrarlo en interfaz
        public void eliminarCliente(ENT.Cliente cliente)
        {
            try
            {
                DAL.Cliente DalCliente = new DAL.Cliente();
                if (cliente.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un cliente valido");
                }
                DalCliente.borrarCliente(cliente);
                if (DalCliente.Error)
                {
                    throw new Exception("Error al eliminar el vehíclo, " + DalCliente.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica errores, cuando se cargqa los cliente
        //si los hay monstrarlos en interfaz 
        public List<ENT.Cliente> cargarClientes()
        {
            DAL.Cliente DalCliente = new DAL.Cliente();
            List<ENT.Cliente> clientes = new List<ENT.Cliente>();
            try
            {
                clientes = DalCliente.obtenerClientes();
                if (DalCliente.Error)
                {
                    throw new Exception("Error al cargar los clientes, " + DalCliente.ErrorMsg);
                }
                if (clientes.Count <= 0)
                {
                    throw new Exception("No hay clientes registrados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clientes;
        }
        //Metodo verifica errores, cuando se cargqa los clientes
        //Si los hay mostrarlos en interfaz 
        public List<ENT.Cliente> buscarCliente(string valor, string columna)
        {
            DAL.Cliente DalCliente = new DAL.Cliente();
            List<ENT.Cliente> clientes = new List<ENT.Cliente>();
            try
            {
                clientes = DalCliente.buscarClientes(valor, columna);
                if (DalCliente.Error)
                {
                    throw new Exception("Error al buscar los clientes, " + DalCliente.ErrorMsg);
                }
                if (clientes.Count <= 0)
                {
                    throw new Exception("No hay clientes registrados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clientes;
        }
        public DataTable cargarInformeClientePorIdOrden(int valor)
        {
            DataTable tabla = null;
            DAL.Cliente DalCliente = new DAL.Cliente();
            try
            {
                tabla = DalCliente.cargarInformeClientePorIdOrden(valor);
                if (DalCliente.Error)
                {
                    throw new Exception("Erro al cargar los datos del cliente, en este informe " + DalCliente.ErrorMsg);
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
