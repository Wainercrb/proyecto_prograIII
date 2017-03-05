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
            this.errorMsg = "";
        }

        public List<TipoVehiculo> obtenerTipos()
        {
            this.limpiarError();
            List<TipoVehiculo> tipos = new List<TipoVehiculo>();
            DataSet dsetTipo;

            string sql = "select * from tipo";
            try
            {
                dsetTipo = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetTipo.Tables[0].Rows)
                {
                    TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                    tipos.Add(oTipo);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return tipos;
        }

        public bool agregarTipo(TipoVehiculo pTipo)
        {
            DataSet dsetTipo;
            try
            {
                string sql = "insert into tipo(tipo) " +
                             "values(@tipo)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@tipo";
                parametros[0].Value = pTipo.Tipo;
                dsetTipo = this.conexion.ejecutarDataSetSQL(sql, parametros);
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
        public bool borrarTipo(TipoVehiculo pTipo)
        {
            this.error = true;
            this.errorMsg = "";
            try
            {
                string sql = "delete from tipo where id_tipo = @id_tipo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_tipo";
                parametros[0].Value = pTipo.Id;
                DataSet dsetMarca;
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


        public bool Error
        {
            get { return error; }
        }

        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public bool editarTipos(TipoVehiculo pTipo)
        {

            this.error = true;
            this.errorMsg = "";
            try
            {
                string sql = "UPDATE tipo SET tipo = @tipo where id_tipo = @id_tipo";
                NpgsqlParameter[] parametros = new NpgsqlParameter[2];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@tipo";
                parametros[0].Value = pTipo.Tipo;


                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@id_tipo";
                parametros[1].Value = pTipo.Id;

                DataSet dsetMarca;
                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
                this.conexion.ejecutarSQL(sql, parametros);
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


        public List<TipoVehiculo> buscarTipos(string valor)
        {
            this.limpiarError();
            List<TipoVehiculo> tipos = new List<TipoVehiculo>();
            DataSet dsetTipos;

            string sql = "select * from tipo where tipo = " + "'" + valor + "'";
            try
            {
                dsetTipos = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetTipos.Tables[0].Rows)
                {
                    TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                    tipos.Add(oTipo);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return tipos;
        }


        public List<TipoVehiculo> obtenerPorDataBUsqueda(string valor)
        {
            this.limpiarError();
            List<TipoVehiculo> tipos = new List<TipoVehiculo>();
            DataSet dsetTipos;

            string sql = "select * from tipo where tipo = " + "'@tipo'";
            try
            {
                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "'@tipo'";
                parametros[0].Value = "'" + valor + "'";

                dsetTipos = this.conexion.ejecutarDataSetSQL(sql, parametros);
                foreach (DataRow tupla in dsetTipos.Tables[0].Rows)
                {
                    TipoVehiculo oMarca = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                    tipos.Add(oMarca);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return tipos;



        }
    }
}
