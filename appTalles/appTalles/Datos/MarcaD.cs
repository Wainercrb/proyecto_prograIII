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
    public class MarcaD
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;


        public MarcaD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<MarcaVehiculo> obtenerMarcas()
        {
            this.limpiarError();
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            DataSet dsetMarcas;

            string sql = "select * from marca";
            try
            {
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                    marcas.Add(oMarca);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return marcas;
        }

        public bool agregarMarca(MarcaVehiculo pMarca)
        {
            DataSet dsetMarca;
            try
            {
                string sql = "insert into marca(marca) " +
                             "values(@marca)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@marca";
                parametros[0].Value = pMarca.Marca;
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
        public bool borrarMarca(MarcaVehiculo pMarca)
        {
            this.error = true;
            this.errorMsg = "";
            try
            {
                string sql = "delete from marca where marca = @id_marca";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_marca";
                parametros[0].Value = pMarca.Marca;
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

        public bool editarVehiculos(MarcaVehiculo pMarca)
        {

            this.error = true;
            this.errorMsg = "";
            try
            {
                string sql = "UPDATE marca SET marca = @marca where id_marca = @id_marca";
                NpgsqlParameter[] parametros = new NpgsqlParameter[2];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@marca";
                parametros[0].Value = pMarca.Marca;


                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@id_marca";
                parametros[1].Value = pMarca.Id;

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

        public List<MarcaVehiculo> buscarMarcas(string valor)
        {
            this.limpiarError();
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            DataSet dsetMarcas;

            string sql = "select * from marca where marca = " + "'" + valor + "'";
            try
            {
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                    marcas.Add(oMarca);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return marcas;
        }


        public List<MarcaVehiculo> obtenerPorDataBUsqueda(string valor)
        {



            this.limpiarError();
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            DataSet dsetMarcas;

            string sql = "select * from marca where marca = " + "'@marca'";
            try
            {
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
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return marcas;



        }
    }

}

