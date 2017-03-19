using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using NpgsqlTypes;
using Npgsql;
using System.Data;

namespace Datos
{
    public class ClienteD
    {

        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;


        public ClienteD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<Cliente> obtenerClientes()
        {
            this.limpiarError();
            List<Cliente> clientes = new List<Cliente>();
            DataSet dsetCliente;

            string sql = "select * from cliente";
            try
            {
                dsetCliente = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetCliente.Tables[0].Rows)
                {
                    Cliente oCliente = new Cliente(Int32.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_oficina"].ToString(), tupla["telefono_celular"].ToString());
                    clientes.Add(oCliente);
                }
                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }

            return clientes;
        }

        public bool agregarCliente(Cliente pCliente)
        {
            limpiarError();
            DataSet dsetCliente;
            try
            {
                string sql = "insert into cliente(cedula, nombre, apellido, apellido2, telefono_casa, telefono_oficina, telefono_celular) " +
                             "values(@cedula, @nombre, @apellido, @apellido2, @telefono_casa, @telefono_oficina, @telefono_celular)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[7];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@cedula";
                parametros[0].Value = pCliente.Cedula;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[1].ParameterName = "@nombre";
                parametros[1].Value = pCliente.Nombre;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[2].ParameterName = "@apellido";
                parametros[2].Value = pCliente.ApellidoPaterno;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[3].ParameterName = "@apellido2";
                parametros[3].Value = pCliente.ApellidoMaterno;
                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[4].ParameterName = "@telefono_casa";
                parametros[4].Value = pCliente.TelefonoCasa;
                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[5].ParameterName = "@telefono_oficina";
                parametros[5].Value = pCliente.TelefonoOficina;
                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[6].ParameterName = "telefono_celular";
                parametros[6].Value = pCliente.TelefonoCelular;


                dsetCliente = this.conexion.ejecutarDataSetSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }
            return this.error;
        }
        public bool borrarCliente(Cliente pCliente)
        {
            try
            {
                limpiarError();
                DataSet dsetCliente;
                string sql = "delete from cliente where id_cliente = @id_cliente";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_cliente";
                parametros[0].Value = pCliente.Id;

                dsetCliente = this.conexion.ejecutarDataSetSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }
            return this.error;
        }

        public bool editarCliente(Cliente pCliente)
        {
            try
            {
                limpiarError();
                DataSet dsetCliente;
                string sql = "UPDATE cliente SET cedula = @cedula, nombre = @nombre, apellido = @apellido, apellido2 = @apellido2, telefono_casa = @telefono_casa, telefono_oficina = @telefono_oficina, telefono_celular = @telefono_celular where id_cliente = @id_cliente";
                NpgsqlParameter[] parametros = new NpgsqlParameter[8];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@cedula";
                parametros[0].Value = pCliente.Cedula;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[1].ParameterName = "@nombre";
                parametros[1].Value = pCliente.Nombre;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[2].ParameterName = "@apellido";
                parametros[2].Value = pCliente.ApellidoPaterno;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[3].ParameterName = "@apellido2";
                parametros[3].Value = pCliente.ApellidoMaterno;
                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[4].ParameterName = "@telefono_casa";
                parametros[4].Value = pCliente.TelefonoCasa;
                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[5].ParameterName = "@telefono_oficina";
                parametros[5].Value = pCliente.TelefonoOficina;
                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[6].ParameterName = "@telefono_celular";
                parametros[6].Value = pCliente.TelefonoCelular;
                parametros[7] = new NpgsqlParameter();
                parametros[7].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[7].ParameterName = "@id_cliente";
                parametros[7].Value = pCliente.Id;
                dsetCliente = this.conexion.ejecutarDataSetSQL(sql, parametros);

                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }


            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }

            return this.error;
        }


        public List<MarcaVehiculo> buscarMarcas(string valor)
        {
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            try
            {
                this.limpiarError();
                DataSet dsetMarcas;

                string sql = "select * from marca where marca = " + "'" + valor + "'";

                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                    marcas.Add(oMarca);
                }

                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }

            return marcas;
        }


        public List<MarcaVehiculo> obtenerPorDataBUsqueda(string valor)
        {

            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
          
            try
            {
                DataSet dsetMarcas;
                this.limpiarError();

                string sql = "select * from marca where marca = " + "'@marca'";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "'@marca'";
                parametros[0].Value = "'" + valor + "'";

                dsetMarcas = this.conexion.ejecutarDataSetSQL(sql, parametros);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                    marcas.Add(oMarca);
                }

                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
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
