using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ENT;
using Npgsql;
namespace DAL
{
    public class Empleado
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;
        public Empleado()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        //Metodo limpoar las variable de error
        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        //Metodo agrega el empleado que recibe por parametro
        public void agregarEmpleado(ENT.Empleado empleado)
        {
            limpiarError();
            string sql = "insert into " + this.conexion.Schema + "empleado (nombre, apellido, direccion, telefono1, telefono2, trabajo, permiso, contrasenna, usuario) values( @nombre, @apellido, @direccion, @telefono1, @telefono2, @trabajo, @permiso, @contrasenna, @usuario)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@nombre", NpgsqlDbType.Varchar, empleado.Nombre);
            prm.agregarParametro("@apellido", NpgsqlDbType.Varchar, empleado.Apellido);
            prm.agregarParametro("@direccion", NpgsqlDbType.Varchar, empleado.Direccion);
            prm.agregarParametro("@telefono1", NpgsqlDbType.Varchar, empleado.TelefonoResidencia);
            prm.agregarParametro("@telefono2", NpgsqlDbType.Varchar, empleado.TelefonoCelular);
            prm.agregarParametro("@trabajo", NpgsqlDbType.Varchar, empleado.Puesto);
            prm.agregarParametro("@permiso", NpgsqlDbType.Varchar, empleado.Permiso);
            prm.agregarParametro("@contrasenna", NpgsqlDbType.Varchar, empleado.Contrasenna);
            prm.agregarParametro("@usuario", NpgsqlDbType.Varchar, empleado.Usuario);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (conexion.IsError)
            {
                Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo carga a todos los data set de empleados
        //los recorre y los agrega a la lista
        public List<ENT.Empleado> ObtenerEmpleados()
        {
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            DataSet dsetEmpleados;
            string sql = "SELECT * FROM " + this.conexion.Schema + "empleado";
            dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);
            if (!this.conexion.IsError)
            {
                if (dsetEmpleados.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                    {
                        ENT.Empleado pEmpleados = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre"].ToString(),
                        tupla["apellido"].ToString(), tupla["direccion"].ToString(), tupla["telefono1"].ToString(),
                        tupla["telefono2"].ToString(), tupla["trabajo"].ToString(), tupla["permiso"].ToString(),
                        tupla["usuario"].ToString(), tupla["contrasenna"].ToString());
                        empleados.Add(pEmpleados);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return empleados;
        }
        //Metodo elimina el empleado que recibe por parametro
        public void borrarEmpleado(ENT.Empleado empleado)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "empleado WHERE id_empleado = @id_empleado";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_empleado", NpgsqlDbType.Integer, empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (conexion.IsError)
            {
                errorMsg = this.conexion.ErrorDescripcion;
                Error = true;
            }
        }
        //Metodo actuzaliza al empleado por los valores del nuevo
        //empleado que recibe por parametro 
        public void actualizar(ENT.Empleado empleado)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "empleado SET nombre = @nombre ,apellido = @apellido , direccion = @direccion, telefono1 = @telefono1, telefono2 = @telefono2 , trabajo = @trabajo ,permiso = @permiso, contrasenna = @contrasenna , usuario = @usuario where id_empleado = @id_empleado";
            Parametro prm = new Parametro();
            prm.agregarParametro("@nombre", NpgsqlDbType.Varchar, empleado.Nombre);
            prm.agregarParametro("@apellido", NpgsqlDbType.Varchar, empleado.Apellido);
            prm.agregarParametro("@direccion", NpgsqlDbType.Varchar, empleado.Direccion);
            prm.agregarParametro("@telefono1", NpgsqlDbType.Varchar, empleado.TelefonoResidencia);
            prm.agregarParametro("@telefono2", NpgsqlDbType.Varchar, empleado.TelefonoCelular);
            prm.agregarParametro("@trabajo", NpgsqlDbType.Varchar, empleado.Puesto);
            prm.agregarParametro("@permiso", NpgsqlDbType.Varchar, empleado.Permiso);
            prm.agregarParametro("@contrasenna", NpgsqlDbType.Varchar, empleado.Contrasenna);
            prm.agregarParametro("@usuario", NpgsqlDbType.Varchar, empleado.Usuario);
            prm.agregarParametro("@id_empleado", NpgsqlDbType.Integer, empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (conexion.IsError)
            {
                errorMsg = this.conexion.ErrorDescripcion;
                Error = true;
            }
        }
        //Metodo buscar un valor string en la base de datos
        public List<ENT.Empleado> buscarStringEmpleado(string valor, string columna)
        {
            limpiarError();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@" + columna + "", NpgsqlDbType.Varchar, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "empleado WHERE " + columna + " LIKE @" + columna + "";
            DataSet dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql, "empleado", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dsetEmpleados.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                    {
                        ENT.Empleado pEmpleados = new ENT.Empleado(Convert.ToInt32(tupla["id_empleado"].ToString()), tupla["nombre"].ToString(),
                        tupla["apellido"].ToString(), tupla["direccion"].ToString(), tupla["telefono1"].ToString(),
                        tupla["telefono2"].ToString(), tupla["trabajo"].ToString(), tupla["permiso"].ToString(),
                        tupla["usuario"].ToString(), tupla["contrasenna"].ToString());
                        empleados.Add(pEmpleados);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return empleados;
        }
        //Metodo buscar un valor int en la base de datos
        public List<ENT.Empleado> buscarIntEmpleado(int valor, string columna)
        {
            limpiarError();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@" + columna + "", NpgsqlDbType.Integer, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "empleado WHERE " + columna + " LIKE @nombre";
            DataSet dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql, "empleado", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dsetEmpleados.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                    {
                        ENT.Empleado pEmpleados = new ENT.Empleado(Convert.ToInt32(tupla["id_empleado"].ToString()), tupla["nombre"].ToString(),
                        tupla["apellido"].ToString(), tupla["direccion"].ToString(), tupla["telefono1"].ToString(),
                        tupla["telefono2"].ToString(), tupla["trabajo"].ToString(), tupla["permiso"].ToString(),
                        tupla["usuario"].ToString(), tupla["contrasenna"].ToString());
                        empleados.Add(pEmpleados);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return empleados;
        }
        //Metodo actualiza la contrasena del empleado
        public void cambioContrasenna(ENT.Empleado empleado, string nueva)
        {
            limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@contrasenna", NpgsqlDbType.Text, nueva);
            prm.agregarParametro("@id_empleado", NpgsqlDbType.Integer, empleado.Id);
            string sql = "UPDATE " + this.conexion.Schema + "empleado SET contrasenna = @contrasenna WHERE id_empleado = @id_empleado";
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
       
        public bool Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public string ErrorMsg
        {
            get
            {
                return errorMsg;
            }

            set
            {
                errorMsg = value;
            }
        }
    }
}



