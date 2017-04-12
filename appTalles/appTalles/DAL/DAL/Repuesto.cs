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
    public class Repuesto
    {

        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;


        public Repuesto()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ENT.RepuestoVehiculo> obtenerRepesto()
        {
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            try
            {
                this.limpiarError();
                DataSet dsetRepuesto;
                string sql = "select * from repuesto";

                dsetRepuesto = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
                {
                    RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()));
                    repuestos.Add(repuesto);
                }
                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
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
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            this.limpiarError();
            DataSet dsetRepuesto;
            string sql = "select m.id_marca as id_marca, m.marca as marca from marca m, repuesto_marca mr, repuesto r where mr.fk_marca = m.id_marca and mr.fk_repuesto = r.id_repuesto and fk_repuesto = " + pRepuesto.Id;
            dsetRepuesto = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
            {
                MarcaVehiculo marca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                marcas.Add(marca);
            }
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }

            return marcas;
        }

        public void agregarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "INSER INTO " + this.conexion.Schema + "repuesto(repuesto, precio, impuesto) " +
                         "values(@repuesto, @precio, @impuesto)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@repuesto", NpgsqlDbType.Varchar, pRepuesto.Repuesto);
            prm.agregarParametro("@precio", NpgsqlDbType.Double, pRepuesto.Precio);
            prm.agregarParametro("@impuesto", NpgsqlDbType.Double, pRepuesto.Impuesto);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public void agregarMarcasRepuesto(MarcaVehiculo pMarcas, RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "repuesto_marca(fk_marca, fk_repuesto) " +
                         "values(@fk_marca, @fk_repuesto);";
            Parametro prm = new Parametro();
            prm.agregarParametro("@fk_marca", NpgsqlDbType.Integer, pMarcas.Id);
            prm.agregarParametro("@fk_repuesto", NpgsqlDbType.Integer, pRepuesto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public void borrarRepuestoMarca(MarcaVehiculo pMarca)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "repuesto_marca WHERE fk_marca = @fk_marca";
            Parametro prm = new Parametro();
            prm.agregarParametro("@fk_marca", NpgsqlDbType.Integer, pMarca.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        public void borrarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "repuesto where id_repuesto = @id_repuesto";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_parametro", NpgsqlDbType.Integer, pRepuesto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        public void editarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "repuesto SET repuesto = @repuesto, precio = @precio, impuesto = @impuesto where id_repuesto = @id_repuesto";
            Parametro prm = new Parametro();
            prm.agregarParametro("@repuesto", NpgsqlDbType.Varchar, pRepuesto.Repuesto);
            prm.agregarParametro("@precio", NpgsqlDbType.Double, pRepuesto.Precio);
            prm.agregarParametro("@impuesto", NpgsqlDbType.Double, pRepuesto.Impuesto);
            prm.agregarParametro("@id_repuesto", NpgsqlDbType.Integer, pRepuesto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public List<RepuestoVehiculo> buscarStringRepuesto(string valor, string columna)
        {
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            try
            {
                this.limpiarError();
                DataSet dsetMarcas;
                string sql = "select * from repuesto where " + columna + " = " + "'" + valor + "'";
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);

                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()));
                    repuestos.Add(repuesto);
                }

                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
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
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            try
            {
                this.limpiarError();
                DataSet dsetMarcas;
                string sql = "select * from repuesto where " + columna + " = " + valor;

                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()));
                    repuestos.Add(repuesto);
                }
                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
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

            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            //try
            //{
            //    DataSet dsetRepuesto;
            //    string sql = "select * from repuesto where id_repuesto = " + "'id_repuesto'";

            //    NpgsqlParameter[] parametros = new NpgsqlParameter[1];
            //    parametros[0] = new NpgsqlParameter();
            //    parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
            //    parametros[0].ParameterName = "@idRepuesto";
            //    parametros[0].Value = "'" + valor + "'";

            //    dsetRepuesto = this.conexion.ejecutarDataSetSQL(sql, parametros);
            //    foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
            //    {
            //        //MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
            //        //repuestos.Add(oMarca);
            //    }

            //    if (this.conexion.IsError)
            //    {
            //        this.error = true;
            //        this.errorMsg = this.conexion.ErrorDescripcion;
            //    }
            //}
            //catch (Exception e)
            //{
            //    this.error = false;
            //    this.errorMsg = e.Message;
            //}

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
