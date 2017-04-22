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
        //Metodo limpia el error de las varibles error y errrMsg
        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        //Metodo cargar el dataset con los tipos de vehículos
        //y los agrega a la lista para retornarlos
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
        //Metodo agrega a la base de datos el valor que recibe por parametro
        public void agregarTipo(TipoVehiculo pTipo)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "tipo(tipo)VALUES(@tipo)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@tipo", NpgsqlDbType.Varchar, pTipo.Tipo);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;
            }
        }
        //Metodo elimina el tipo de vehículo que recibe
        //por la base de datos
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
        //Metodo actualiza los valores de la base de datos
        //por los nuevos que recibe por parametro
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
        //Metodo busca un valor que recibel por parametro
        //y carga los tipos de vehículo similar con ese valor
        public List<ENT.TipoVehiculo> buscarStringTipo(string valor)
        {
            this.limpiarError();
            List<ENT.TipoVehiculo> tipos= new List<ENT.TipoVehiculo>();
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@tipo", NpgsqlDbType.Varchar, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "tipo WHERE tipo = @tipo";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "tipo", oParametro.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
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
