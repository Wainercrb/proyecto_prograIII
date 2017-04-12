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

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        public bool IsError
        {
            get { return error; }
        }

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
        public void borrarCliente(ENT.Cliente pCliente)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "cliente WHERE id_cliente = @id_cliente";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_cliente", NpgsqlDbType.Integer, pCliente.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public void editarCliente(ENT.Cliente pCliente)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "cliente SET cedula = @cedula, nombre = @nombre, apellido = @apellido, apellido2 = @apellido2, telefono_casa = @telefono_casa, telefono_oficina = @telefono_oficina, telefono_celular = @telefono_celular where id_cliente = @id_cliente";
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


        public List<MarcaVehiculo> buscarMarcas(string valor)
        {
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            this.limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@Nombre", NpgsqlDbType.Varchar, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "cliente WHERE nombre = @nombre";
            DataSet dsetCliente = this.conexion.ejecutarConsultaSQL(sql, "cliente", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dsetCliente.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetCliente.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()),
                        tupla["marca"].ToString());
                        marcas.Add(oMarca);
                    }
                    if (this.conexion.IsError)
                    {
                        this.error = true;
                        this.errorMsg = this.conexion.ErrorDescripcion;
                    }
                }
            }
            return marcas;
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
