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
    public class Marca
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;


        public Marca()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public bool IsError
        {
            get { return error; }
        }
        //Metodo elimna los errores de las variables//
        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        //Metodo carga todas  las marca de la base de datos
        public List<MarcaVehiculo> obtenerMarcas()
        {
            this.limpiarError();
            List<MarcaVehiculo> marcas = new List<MarcaVehiculo>();
            DataSet dsetMarcas;

            string sql = "SELECT * FROM "+this.conexion.Schema+" marca";

            dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);

            if (!this.conexion.IsError)
            {
                foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()),
                    tupla["marca"].ToString());
                    marcas.Add(oMarca);
                }
            }
            else {

                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return marcas;
        }
    

        //Metodo inserta la marca que recibe por parametro//
        public void agregarMarca(MarcaVehiculo pMarca)
        {
            limpiarError();

            string sql = "INSERT INTO " + this.conexion.Schema + " marca(marca) " +
                         "values(@marca)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@marca", NpgsqlDbType.Varchar, pMarca.Marca);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        //Metodo elimina la marca por id
        public void borrarMarca(MarcaVehiculo pMarca)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + " marca WHERE id_marca = @id_marca";

            Parametro prm = new Parametro();
            prm.agregarParametro("@id_marca", NpgsqlDbType.Integer, pMarca.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        
        //Metodo elimina una marca por id, recibida por parametro
        public void editarMarca(MarcaVehiculo pMarca)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + " marca SET marca = @marca WHERE id_marca = @id_marca";

            Parametro prm = new Parametro();
            prm.agregarParametro("@marca", NpgsqlDbType.Varchar, pMarca.Marca);
            prm.agregarParametro("@id_marca", NpgsqlDbType.Integer, pMarca.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public List<MarcaVehiculo> buscarMarcas(ENT.MarcaVehiculo marca)
        {
            this.limpiarError();
            List<ENT.MarcaVehiculo> marcas = new List<ENT.MarcaVehiculo>();

            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@marca", NpgsqlDbType.Varchar, marca.Marca);

            string sql = "SELECT * FROM " + this.conexion.Schema + "marca " +
                         "WHERE marca = @marca";

            DataSet dset = this.conexion.ejecutarConsultaSQL(sql,
                                                        "marca",
                                                        oParametro.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()),
                     tupla["marca"].ToString());
                        marcas.Add(oMarca);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
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

