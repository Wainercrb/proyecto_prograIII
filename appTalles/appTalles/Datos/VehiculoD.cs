using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using NpgsqlTypes;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class VehiculoD
    {

        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;
        public VehiculoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.ErrorMsg = "";
        }

        public List<Vehiculo> obtenerVehiculos()
        {
            this.limpiarError();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            DataSet dsetVehiculos;
            string sql = "select v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from vehiculo v, marca m, tipo t, cliente c " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente";

            dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                Cliente oCliente = new Cliente(Int32.Parse(tupla["id_cliente"].ToString()), tupla["nombre"].ToString(), tupla["cedula"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                Vehiculo oVehiculo = new Vehiculo(Int32.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), Int32.Parse(tupla["anno"].ToString()), Int32.Parse(tupla["cilindraje"].ToString()), Int32.Parse(tupla["numero_motor"].ToString()), Int32.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                vehiculos.Add(oVehiculo);
            }
            return vehiculos;
        }

        public bool agregarVehiculo(Vehiculo oVehiculo)
        {
            try
            {
                limpiarError();
                DataSet dsetVehiculo;

                string sql = "insert into vehiculo (placa, anno, cilindraje, numero_motor, numero_chazis, combustible, estado, fk_marca, fk_cliente, fk_tipo) " +
                             "values (@placa, @anno, @cilindraje, @numero_motor, @numero_chazis, @combustible, @estado, @fk_marca, @fk_cliente, @fk_tipo); ";

                NpgsqlParameter[] parametros = new NpgsqlParameter[10];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@placa";
                parametros[0].Value = oVehiculo.Placa;

                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@anno";
                parametros[1].Value = oVehiculo.Anno;

                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[2].ParameterName = "@cilindraje";
                parametros[2].Value = oVehiculo.Cilindraje;

                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[3].ParameterName = "@numero_motor";
                parametros[3].Value = oVehiculo.NumeroMotor;

                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[4].ParameterName = "@numero_chazis";
                parametros[4].Value = oVehiculo.NumeroChazis;

                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[5].ParameterName = "@combustible";
                parametros[5].Value = oVehiculo.TipoCombustible;

                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[6].ParameterName = "@estado";
                parametros[6].Value = oVehiculo.Estado;

                parametros[7] = new NpgsqlParameter();
                parametros[7].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[7].ParameterName = "@fk_marca";
                parametros[7].Value = oVehiculo.Marca.Id;

                parametros[8] = new NpgsqlParameter();
                parametros[8].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[8].ParameterName = "@fk_cliente";
                parametros[8].Value = oVehiculo.Cliente.Id;

                parametros[9] = new NpgsqlParameter();
                parametros[9].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[9].ParameterName = "@fk_tipo";
                parametros[9].Value = oVehiculo.Tipo.Id;

                dsetVehiculo = this.conexion.ejecutarDataSetSQL(sql, parametros);
            }
            catch (Exception e)
            {
                this.error = false;
                this.ErrorMsg = e.Message;
            }
            return this.error;
        }

        public bool editarVehiculo(Vehiculo vehiculo)
        {
            limpiarError();
            try
            {
                DataSet dsetVehiculo;
                string sql = "UPDATE vehiculo SET placa = @placa, anno = @anno ,cilindraje = @cilindraje, numero_motor = @numero_motor, numero_chazis = @numero_chazis, combustible = @combustible, estado = @estado, fk_marca = @fk_marca, fk_cliente = @fk_cliente, fk_tipo = @fk_tipo where id_vehiculo = @id_vehiculo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[11];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@placa";
                parametros[0].Value = vehiculo.Placa;

                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@anno";
                parametros[1].Value = vehiculo.Anno;

                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[2].ParameterName = "@cilindraje";
                parametros[2].Value = vehiculo.Cilindraje;

                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[3].ParameterName = "@numero_motor";
                parametros[3].Value = vehiculo.NumeroMotor;

                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[4].ParameterName = "@numero_chazis";
                parametros[4].Value = vehiculo.NumeroChazis;

                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[5].ParameterName = "@combustible";
                parametros[5].Value = vehiculo.TipoCombustible;

                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[6].ParameterName = "@estado";
                parametros[6].Value = vehiculo.Estado;

                parametros[7] = new NpgsqlParameter();
                parametros[7].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[7].ParameterName = "@fk_marca";
                parametros[7].Value = vehiculo.Marca.Id;

                parametros[8] = new NpgsqlParameter();
                parametros[8].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[8].ParameterName = "@fk_cliente";
                parametros[8].Value = vehiculo.Cliente.Id;

                parametros[9] = new NpgsqlParameter();
                parametros[9].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[9].ParameterName = "@fk_tipo";
                parametros[9].Value = vehiculo.Tipo.Id;

                parametros[10] = new NpgsqlParameter();
                parametros[10].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[10].ParameterName = "@id_vehiculo";
                parametros[10].Value = vehiculo.Id;

                dsetVehiculo = this.conexion.ejecutarDataSetSQL(sql, parametros);
            }
            catch (Exception e)
            {
                error = false;
                this.errorMsg = e.Message;
            }
            return error;
        }

        public bool borrarVehiculo(Vehiculo pVehiculo)
        {
            try
            {
                limpiarError();
                DataSet dsetMarca;
                string sql = "delete from vehiculo where id_vehiculo = @id_vehiculo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_vehiculo";
                parametros[0].Value = pVehiculo.Id;

                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.error = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }
            return this.error;
        }

        public List<Vehiculo> BuscarStringVehiculo(string valor, string columna)
        {
            this.limpiarError();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            DataSet dsetVehiculos;
            string sql = "select v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                       "m.id_marca as id_marca, m.marca as marca, " +
                       "t.id_tipo as id_tipo, t.tipo as tipo, " +
                       "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                       "from vehiculo v, marca m, tipo t, cliente c " +
                       "where (v.fk_marca = m.id_marca) and " +
                       "(v.fk_tipo = t.id_tipo) and (" + columna + " = " + "'" + valor + "'" + ") and " +
                       "(v.fk_cliente = c.id_cliente)";

            dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                Cliente oCliente = new Cliente(Int32.Parse(tupla["id_cliente"].ToString()), tupla["nombre"].ToString(), tupla["cedula"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                Vehiculo oVehiculo = new Vehiculo(Int32.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), Int32.Parse(tupla["anno"].ToString()), Int32.Parse(tupla["cilindraje"].ToString()), Int32.Parse(tupla["numero_motor"].ToString()), Int32.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                vehiculos.Add(oVehiculo);
            }
            return vehiculos;
        }

        public List<Vehiculo> BuscarIntVehiculo(int valor, string columna)
        {
            this.limpiarError();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            DataSet dsetVehiculos;
            string sql = "select v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                       "m.id_marca as id_marca, m.marca as marca, " +
                       "t.id_tipo as id_tipo, t.tipo as tipo, " +
                       "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                       "from vehiculo v, marca m, tipo t, cliente c " +
                       "where (v.fk_marca = m.id_marca) and " +
                       "(v.fk_tipo = t.id_tipo) and (" + columna + " = " + "'" + valor + "'" + ") and " +
                       "(v.fk_cliente = c.id_cliente)";

            dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                Cliente oCliente = new Cliente(Int32.Parse(tupla["id_cliente"].ToString()), tupla["nombre"].ToString(), tupla["cedula"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                Vehiculo oVehiculo = new Vehiculo(Int32.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), Int32.Parse(tupla["anno"].ToString()), Int32.Parse(tupla["cilindraje"].ToString()), Int32.Parse(tupla["numero_motor"].ToString()), Int32.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                vehiculos.Add(oVehiculo);
            }
            return vehiculos;
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
