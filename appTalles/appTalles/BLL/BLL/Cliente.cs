using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;

namespace BLL
{
    public class Cliente
    {

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
                if (cli.Id < 0)
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
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ENT.Cliente> cargarClientes()
        {
            DAL.Cliente DalCliente = new DAL.Cliente();
            List<ENT.Cliente> clientes = new List<ENT.Cliente>();
            try
            {
                clientes = DalCliente.obtenerClientes();
                if (clientes.Count <= 0)
                {
                    throw new Exception("No hay quientes registrados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clientes;
        }
    }
}
