using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using NpgsqlTypes;
using Npgsql;
using System.Data;

namespace DAL
{
    public class Tipo
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;


        public Tipo()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<TipoVehiculo> obtenerTiposVehiculo()
        {
            this.limpiarError();
            List<TipoVehiculo> tipos = new List<TipoVehiculo>();
            string sql = "SELECT * FROM " + this.conexion.Schema + "tipo";
            DataSet dsetTipo = this.conexion.ejecutarConsultaSQL(sql);
            if (!this.conexion.IsError)
            {
                if (dsetTipo.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetTipo.Tables[0].Rows)
                    {
                        TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                        tipos.Add(oTipo);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return tipos;
        }

        public void agregarTipo(TipoVehiculo pTipo)
        {
            limpiarError();
            string sql = "INSERT " + this.conexion.Schema + "INTO tipo(tipo) VALUES(@tipo)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@tipo", NpgsqlDbType.Varchar, pTipo.Tipo);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;
            }
        }
        public void borrarTipo(TipoVehiculo pTipo)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "tipo WHERE id_tipo = @id_tipo";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_tipo", NpgsqlDbType.Integer, pTipo.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;
            }
        }

        public void editarTipos(TipoVehiculo pTipo)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "tipo SET tipo = @tipo where id_tipo = @id_tipo";
            Parametro prm = new Parametro();
            prm.agregarParametro("@tipo", NpgsqlDbType.Varchar, pTipo.Tipo);
            prm.agregarParametro("@id_tipo", NpgsqlDbType.Integer, pTipo.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
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
                if (this.conexion.IsError)
                {
                    this.errorMsg = this.conexion.ErrorDescripcion;
                    this.error = true;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }

            return tipos;
        }


        public List<TipoVehiculo> obtenerPorDataBUsqueda(string valor)
        {
            //this.limpiarError();
            List<TipoVehiculo> tipos = new List<TipoVehiculo>();
            //DataSet dsetTipos;

            //string sql = "select * from tipo where tipo = " + "'@tipo'";
            //try
            //{
            //    NpgsqlParameter[] parametros = new NpgsqlParameter[1];
            //    parametros[0] = new NpgsqlParameter();
            //    parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
            //    parametros[0].ParameterName = "'@tipo'";
            //    parametros[0].Value = "'" + valor + "'";
            //    dsetTipos = this.conexion.ejecutarDataSetSQL(sql, parametros);

            //    foreach (DataRow tupla in dsetTipos.Tables[0].Rows)
            //    {
            //        TipoVehiculo oMarca = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
            //        tipos.Add(oMarca);
            //    }
            //    if (this.conexion.IsError)
            //    {
            //        this.errorMsg = this.conexion.ErrorDescripcion;
            //        this.error = true;
            //    }
            //}
            //catch (Exception e)
            //{
            //    this.error = true;
            //    this.errorMsg = e.Message;
            //}

            return tipos;

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
