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
    public class Modelo
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;
        public Modelo()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }
        //Metodo limpia las variables de error
        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        //Metodo inserta los valores que recibe por parametro
        public void agregarModelo(ENT.Modelo modelo)
        {
            this.limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@modelo", NpgsqlDbType.Varchar, modelo.pModelo);
            string sql = "INSERT INTO "+this.conexion.Schema+"modelo(modelo)VALUES(@modelo)";
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo edita el modelo
        //por los valores que ingresa por parametro
        public void editarModelo(ENT.Modelo modelo) {
            this.limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@modelo", NpgsqlDbType.Varchar, modelo.pModelo);
            prm.agregarParametro("@id_modelo", NpgsqlDbType.Integer, modelo.Id);
            string sql = "UPDATE "+this.conexion.Schema+"modelo SET  modelo = @modelo WHERE id_modelo = @id_modelo";   
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo elimina de la base de datos el 
        //valor que ingresa por parametro
        public void eliminarModelo(ENT.Modelo modelo)
        {
            this.limpiarError();
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_modelo", NpgsqlDbType.Integer, modelo.Id);
            string sql = "DELETE FROM "+this.conexion.Schema+"modelo WHERE id_modelo = @id_modelo";
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo carga un dataset con los modelos guardados en la
        //base de datos los recorre y guarda en la lista y los retorna
        public List<ENT.Modelo> obtenerModelo()
        {
            this.limpiarError();
            List<ENT.Modelo> modelos = new List<ENT.Modelo>();
            string sql = "SELECT * FROM " + this.conexion.Schema + "modelo";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql);
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        ENT.Modelo modelo = new ENT.Modelo(int.Parse(tupla["id_modelo"].ToString()), tupla["modelo"].ToString());
                        modelos.Add(modelo);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return modelos;
        }
        //Metodo carga un dataset con los modelos guardados en la
        //base de datos los recorre y guarda en la lista y los retorna
        public List<ENT.Modelo> obtenerModeloPorID(int valor)
        {
            this.limpiarError();
            List<ENT.Modelo> modelos = new List<ENT.Modelo>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_modelo", NpgsqlDbType.Integer, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "modelo  WHERE id_modelo = @id_modelo";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql,"modelo",prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        ENT.Modelo modelo = new ENT.Modelo(int.Parse(tupla["id_modelo"].ToString()), tupla["modelo"].ToString());
                        modelos.Add(modelo);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return modelos;
        }
        public List<ENT.Modelo> obtenerModeloPorModelo(string valor)
        {
            this.limpiarError();
            List<ENT.Modelo> modelos = new List<ENT.Modelo>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@modelo", NpgsqlDbType.Varchar, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "modelo  WHERE modelo = @modelo";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "modelo", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        ENT.Modelo modelo = new ENT.Modelo(int.Parse(tupla["id_modelo"].ToString()), tupla["modelo"].ToString());
                        modelos.Add(modelo);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return modelos;
        }
        public bool Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
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
