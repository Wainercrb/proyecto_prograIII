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
    public class RepuestoD
    {

        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;


        public RepuestoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<RepuestoVehiculo> obtenerRepesto()
        {
            this.limpiarError();
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();

            DataSet dsetRepuesto;

            string sql = "select * from repuesto";
            try
            {
                dsetRepuesto = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
                {
                    RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()));
                    repuestos.Add(repuesto);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return repuestos;
        }


        public List<MarcaVehiculo> obtenerMarcaRepuesto(RepuestoVehiculo pRepuesto)
        {
            this.limpiarError();
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();

            DataSet dsetRepuesto;

            string sql = "select m.id_marca as id_marca, m.marca as marca from marca m, repuesto_marca mr, repuesto r where mr.fk_marca = m.id_marca and mr.fk_repuesto = r.id_repuesto and fk_repuesto = "+pRepuesto.Id;
            try
            {
                // NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                //parametros[0] = new NpgsqlParameter();
                //parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                //parametros[0].ParameterName = "@fk_repuesto";
                //parametros[0].Value = pRepuesto.Id;

                dsetRepuesto = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
                {
                    MarcaVehiculo marca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                    marcas.Add(marca);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return marcas;
        }

        public bool agregarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            DataSet dsetMarca;
            try
            {
                string sql = "insert into repuesto(repuesto, precio, impuesto) " +
                             "values(@repuesto, @precio, @impuesto)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[3];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@repuesto";
                parametros[0].Value = pRepuesto.Repuesto;

                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[1].ParameterName = "@precio";
                parametros[1].Value = pRepuesto.Precio;

                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[2].ParameterName = "@impuesto";
                parametros[2].Value = pRepuesto.Impuesto;

                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return this.error;

        }


        public bool agregarMarcasRepuesto(MarcaVehiculo pMarcas, RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            DataSet dsetMarca;
            try
            {
                string sql = "insert into repuesto_marca(fk_marca, fk_repuesto) " +
                             "values(@fk_marca, @fk_repuesto);";
                NpgsqlParameter[] parametros = new NpgsqlParameter[2];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@fk_marca";
                parametros[0].Value = pMarcas.Id;

                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@fk_repuesto";
                parametros[1].Value = pRepuesto.Id;

                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return this.error;

        }

        public bool borrarRepuestoMarca(MarcaVehiculo pMarca)
        {
            limpiarError();
            DataSet dsetMarca;
            try
            {
                string sql = "delete from repuesto_marca where fk_marca = @fk_marca";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@fk_marca";
                parametros[0].Value = pMarca.Id;

                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }
            return this.error;
        }


        public bool borrarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            DataSet dsetMarca;
            try
            {
                string sql = "delete from repuesto where id_repuesto = @id_repuesto";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_repuesto";
                parametros[0].Value = pRepuesto.Id;

                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }
            return this.error;
        }
        public bool editarRepuesto(RepuestoVehiculo pRepuesto)
        {

            limpiarError();

            DataSet dsetRepuesto;
            try
            {

                string sql = "UPDATE repuesto SET repuesto = @repuesto, precio = @precio, impuesto = @impuesto where id_repuesto = @id_repuesto";

                NpgsqlParameter[] parametros = new NpgsqlParameter[4];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@repuesto";
                parametros[0].Value = pRepuesto.Repuesto;

                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[1].ParameterName = "@precio";
                parametros[1].Value = pRepuesto.Precio;

                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[2].ParameterName = "@impuesto";
                parametros[2].Value = pRepuesto.Impuesto;

                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[3].ParameterName = "@id_repuesto";
                parametros[3].Value = pRepuesto.Id;

                dsetRepuesto = this.conexion.ejecutarDataSetSQL(sql, parametros);

            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return this.error;
        }

        public List<RepuestoVehiculo> buscarStringRepuesto(string valor, string columna)
        {
            this.limpiarError();
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            DataSet dsetMarcas;

            string sql = "select * from repuesto where "+columna+" = " + "'" + valor + "'";
            try
            {
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()));
                    repuestos.Add(repuesto);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return repuestos;
        }

        public List<RepuestoVehiculo> buscarDoublegRepuesto(double valor, string columna)
        {
            this.limpiarError();
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            DataSet dsetMarcas;

            string sql = "select * from repuesto where " + columna + " = " + valor;
            try
            {
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()));
                    repuestos.Add(repuesto);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return repuestos;
        }


        public List<RepuestoVehiculo> obtenerPorDataBUsqueda(string valor)
        {

            this.limpiarError();
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            DataSet dsetRepuesto;

            string sql = "select * from repuesto where id_repuesto = " + "'id_repuesto'";
            try
            {
                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@idRepuesto";
                parametros[0].Value = "'" + valor + "'";

                dsetRepuesto = this.conexion.ejecutarDataSetSQL(sql, parametros);
                foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
                {
                    //MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                    //repuestos.Add(oMarca);
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return repuestos;
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
