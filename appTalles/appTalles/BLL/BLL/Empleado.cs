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
    public class Empleado
    {
        //Metodo valida los datos de la endidad para agregarlo o actualizarlos
        //y pasarlos a la clase DAL.empleado
        public void insertarEmpledo(ENT.Empleado empleado)
        {
            DAL.Empleado DalEmpleado = new DAL.Empleado();
            try
            {
                if (empleado.Nombre == String.Empty)
                {
                    throw new Exception("Se debe ingresar un Nombre");
                }
                if (empleado.Apellido == String.Empty)
                {
                    throw new Exception("Se debe ingresar un Apellido");
                }
                if (empleado.Direccion == String.Empty)
                {
                    throw new Exception("Se debe ingresar una Direccion");
                }
                if (empleado.TelefonoResidencia == String.Empty)
                {
                    throw new Exception("Se debe ingresar un Telefono Residencial");
                }
                if (empleado.TelefonoCelular == String.Empty)
                {
                    throw new Exception("Se debe ingresar un Numero de Telefono Celular");
                }
                if (empleado.Permiso == String.Empty)
                {
                    throw new Exception("Se debe Seleccionar un Permiso");
                }
                if (empleado.Puesto == String.Empty)
                {
                    throw new Exception("Se debe seleccionar un puesto");
                }
                if (empleado.Usuario == String.Empty)
                {
                    throw new Exception("Se debe ingresar un Usuario");
                }
                if (empleado.Contrasenna == String.Empty)
                {
                    throw new Exception("Se debe ingresar una contraseña");
                }
                if (empleado.Id <= 0)
                {
                    DalEmpleado.agregarEmpleado(empleado);
                    if (DalEmpleado.Error)
                    {
                        throw new Exception("Error al guardar el empleado, " + DalEmpleado.ErrorMsg);
                    }
                }
                else
                {
                    DalEmpleado.actualizar(empleado);
                    if (DalEmpleado.Error)
                    {
                        throw new Exception("Error al actualizar el empleado, " + DalEmpleado.ErrorMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo carga los empledos de la base de datos
        //y los agrega a la lista
        public List<ENT.Empleado> cargarEmpleados()
        {
            DAL.Empleado DalEmpleado = new DAL.Empleado();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();

            try
            {
                empleados = DalEmpleado.ObtenerEmpleados();
                if (DalEmpleado.Error)
                {
                    throw new Exception("Error al cargar los empleados " + DalEmpleado.ErrorMsg);
                }
                if (empleados.Count <= 0)
                {
                    throw new Exception("No hay empleados en los registros");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return empleados;
        }
        //Metodo verica la valides de los datos que ingresan
        //desde la interfaz para pasarlo a DAl.empleado
        public void eliminarEmpleado(ENT.Empleado empleado)
        {
            DAL.Empleado DalEmpleado = new DAL.Empleado();
            try
            {
                if (empleado.Id<= 0)
                {
                    throw new Exception("Debes de seleccionar un empleado para eliminarlo");
                }
                DalEmpleado.borrarEmpleado(empleado);
                if (DalEmpleado.Error)
                {
                    throw new Exception("Se produjo un error al eliminar el empleado, " + DalEmpleado.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Metodo verifica los datos a buscar, si estan
        //correntos pasarlos a DAL.empleado
        public List<ENT.Empleado> buscarStringEmpleado(string valor, string columna)
        {
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            DAL.Empleado DalEmpleado = new DAL.Empleado();
            empleados = DalEmpleado.buscarStringEmpleado(valor, columna);
            if (DalEmpleado.Error)
            {
                throw new Exception("Error al buscar el empleado, "+DalEmpleado.ErrorMsg);
            }
            if (empleados.Count <= 0)
            {
                throw new Exception("La busquesa no fue exitosa, no se encontro el empleado " + valor);
            }
            return empleados;
        }
        //Metodo verifica los datos a buscar, si estan
        //correntos pasarlos a DAL.empleado
        public List<ENT.Empleado> buscarIntEmpleado(int valor, string columna)
        {
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            DAL.Empleado DalEmpleado = new DAL.Empleado();
            empleados = DalEmpleado.buscarIntEmpleado(valor, columna);
            if (DalEmpleado.Error)
            {
                throw new Exception("Error al buscar el empleado, " + DalEmpleado.ErrorMsg);
            }
            if (empleados.Count <= 0)
            {
                throw new Exception("La busquesa no fue exitosa, no se encontro el empleado " + valor);
            }
            return empleados;
        }
        //Metodo valida los datos para cambiar la contrasenna
        //se estan correctos pasarlos a DAL.empleado
        public void cambioCantrasenna(ENT.Empleado empleado, string nueva)
        {
            DAL.Empleado DalEmpleado = new DAL.Empleado();
            try
            {
                if (empleado.Id <= 0)
                {
                    throw new Exception("Debes seleccionar un empleado para cambiar la contraseña");
                }
                if (nueva == string.Empty)
                {
                    throw new Exception("No se ha seleccionado la nueva contraseña");
                }
                DalEmpleado.cambioContrasenna(empleado, nueva);
                if (DalEmpleado.Error)
                {
                    throw new Exception("Error al cambiar la contraseña " + DalEmpleado.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
}
