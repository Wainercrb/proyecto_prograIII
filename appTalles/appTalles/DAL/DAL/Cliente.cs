using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using NpgsqlTypes;
using Npgsql;
using System.Data;
using DAL;

namespace DAL
{
    public class Cliente
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;
        public Cliente()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }
        //Metodo limpia las variables de error
        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        public bool IsError
        {
            get { return error; }
        }
        //Metodo carga un dataset con los clientes guardados en la
        //base de datos los recorre y guarda en la lista y los retorna
        public List<ENT.Cliente> obtenerClientes()
        {
            this.limpiarError();
            List<ENT.Cliente> clientes = new List<ENT.Cliente>();
            string sql = "SELECT * FROM " + this.conexion.Schema + "cliente";
            DataSet dsetCliente = this.conexion.ejecutarConsultaSQL(sql);
            if (!this.conexion.IsError)
            {
                if (dsetCliente.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetCliente.Tables[0].Rows)
                    {
                        ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_oficina"].ToString(), tupla["telefono_celular"].ToString());
                        clientes.Add(oCliente);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return clientes;
        }
        //Metodo inserta en la base de datos la entidad
        //que recibe por parametro
        public void agregarCliente(ENT.Cliente pCliente)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "cliente(cedula, nombre, apellido, apellido2, telefono_casa, telefono_oficina, telefono_celular) " +
                         "values(@cedula, @nombre, @apellido, @apellido2, @telefono_casa, @telefono_oficina, @telefono_celular)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@cedula", NpgsqlDbType.Varchar, pCliente.Cedula);
            prm.agregarParametro("@nombre", NpgsqlDbType.Varchar, pCliente.Nombre);
            prm.agregarParametro("@apellido", NpgsqlDbType.Varchar, pCliente.ApellidoPaterno);
            prm.agregarParametro("@apellido2", NpgsqlDbType.Varchar, pCliente.ApellidoMaterno);
            prm.agregarParametro("@telefono_casa", NpgsqlDbType.Varchar, pCliente.TelefonoCasa);
            prm.agregarParametro("@telefono_oficina", NpgsqlDbType.Varchar, pCliente.TelefonoOficina);
            prm.agregarParametro("@telefono_celular", NpgsqlDbType.Varchar, pCliente.TelefonoCelular);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo elimina la un cliente el cual es
        //recibido por parametro
        public void borrarCliente(ENT.Cliente pCliente)
        {
            limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_cliente", NpgsqlDbType.Integer, pCliente.Id);
            string sql = "DELETE FROM " + this.conexion.Schema + "cliente WHERE id_cliente = @id_cliente";
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo actualiza los valored de una cliente en la bd
        //por los nuevos valores que recibe por parametro
        public void editarCliente(ENT.Cliente pCliente)
        {
            limpiarError();       
            string sql = "UPDATE " + this.conexion.Schema + "cliente SET cedula = @cedula, nombre = @nombre, apellido = @apellido, apellido2 = @apellido2, telefono_casa = @telefono_casa, telefono_oficina = @telefono_oficina, telefono_celular = @telefono_celular where id_cliente = @id_cliente";
            Parametro prm = new Parametro();
            prm.agregarParametro("id_cliente", NpgsqlDbType.Integer, pCliente.Id);
            prm.agregarParametro("@cedula", NpgsqlDbType.Varchar, pCliente.Cedula);
            prm.agregarParametro("@nombre", NpgsqlDbType.Varchar, pCliente.Nombre);
            prm.agregarParametro("@apellido", NpgsqlDbType.Varchar, pCliente.ApellidoPaterno);
            prm.agregarParametro("@apellido2", NpgsqlDbType.Varchar, pCliente.ApellidoMaterno);
            prm.agregarParametro("@telefono_casa", NpgsqlDbType.Varchar, pCliente.TelefonoCasa);
            prm.agregarParametro("@telefono_oficina", NpgsqlDbType.Varchar, pCliente.TelefonoOficina);
            prm.agregarParametro("@telefono_celular", NpgsqlDbType.Varchar, pCliente.TelefonoCelular);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo busca por columna y valor un datos de cliente
        //retorna un data set y se agrega a una columna de tipo cliente
        public List<ENT.Cliente> buscarClientes(string valor, string columna)
        {
            this.limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@"+columna, NpgsqlDbType.Varchar, valor);
            List<ENT.Cliente> clientes = new List<ENT.Cliente>();
            string sql = "SELECT * FROM " + this.conexion.Schema + "cliente where " + columna +" =  @"+columna ;
            DataSet dsetCliente = this.conexion.ejecutarConsultaSQL(sql, "cliente", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dsetCliente.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetCliente.Tables[0].Rows)
                    {
                        ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_oficina"].ToString(), tupla["telefono_celular"].ToString());
                        clientes.Add(oCliente);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return clientes;
        }
        public DataTable cargarInformeClientePorIdOrden(int valor)
        {
            DataTable tabla = null;
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@id_orden", NpgsqlDbType.Numeric, valor);
            string sql = "SELECT c.id_cliente, c.cedula, c.nombre, c.apellido, c.apellido2, c.telefono_casa, " +
            "c.telefono_oficina, c.telefono_celular " +
            "FROM " + this.conexion.Schema + "cliente c, " + this.conexion.Schema + "orden o, " + this.conexion.Schema + "vehiculo v WHERE o.fk_vehiculo = v.id_vehiculo AND v.fk_cliente = c.id_cliente AND id_orden = @id_orden;";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql,
                                                        "cliente",
                                                       oParametro.obtenerParametros());
            if (!conexion.IsError)
            {

                tabla = dset.Tables[0].Copy();
            }
            else
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;

            }

            return tabla;
        }
        public bool Error
        {
            get { return error; }
        }

        public string ErrorMsg
        {
            get { return errorMsg; }
        }
    }
}
