using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using System.Data;
using Logica;

namespace Datos
{
    public class ClienteD
    {

        private AccesoDatosPostgre conexion;

        private bool error;
        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

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

        public List<Cliente> obtenerCliente()
        {
            this.limpiarError();
            List<Cliente> clientes = new List<Cliente>();
            DataSet dsetClientes;
            string sql = "select c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_oficina as telefono_oficina, c.telefono_casa as telefono_casa, c.telefono_celular as telefono_celular " +
                         "from cliente c";

            dsetClientes = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetClientes.Tables[0].Rows)
            {
                Cliente oCliente= new Cliente(Int32.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(),tupla["apellido2"].ToString(), tupla["telefono_oficina"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString());
                clientes.Add(oCliente);
            }
            return clientes;
        }

    }
}
