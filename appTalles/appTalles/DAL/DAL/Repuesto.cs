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
        //Metodo limpia las variables de error
        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        //Metodo carga un dataset con los repuesto y los agrega
        //a la lista para luego retornarlos
        public List<ENT.RepuestoVehiculo> obtenerRepesto()
        {
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            this.limpiarError();
            DataSet dsetRepuesto;
            string sql = "select * from " + this.conexion.Schema + "repuesto";
            dsetRepuesto = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetRepuesto.Tables[0].Rows)
            {
                RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()), Int32.Parse(tupla["anno"].ToString()));
                repuestos.Add(repuesto);
            }
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return repuestos;
        }
        //Metodo agrega los la entidad que recibe por parametos
        //a la base de datos
        public void agregarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "repuesto(repuesto, precio, impuesto, anno) " + "values(@repuesto, @precio, @impuesto, @anno)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@repuesto", NpgsqlDbType.Varchar, pRepuesto.Repuesto);
            prm.agregarParametro("@precio", NpgsqlDbType.Double, pRepuesto.Precio);
            prm.agregarParametro("@impuesto", NpgsqlDbType.Double, pRepuesto.Impuesto);
            prm.agregarParametro("@anno", NpgsqlDbType.Integer, pRepuesto.Anno);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo agrega los varoles que recible por parametro a la db
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
        //Metodo borra la marca  que recibe por parametro
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
        //Metodo elimina el repuesto que recibe por parametro
        //de la base de datos
        public void borrarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "repuesto WHERE id_repuesto = @id_repuesto";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_repuesto", NpgsqlDbType.Integer, pRepuesto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo actualiza por los nuevos valores que recibe
        //por parametro
        public void editarRepuesto(RepuestoVehiculo pRepuesto)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "repuesto SET repuesto = @repuesto, precio = @precio, impuesto = @impuesto, anno = @anno where id_repuesto = @id_repuesto";
            Parametro prm = new Parametro();
            prm.agregarParametro("@repuesto", NpgsqlDbType.Varchar, pRepuesto.Repuesto);
            prm.agregarParametro("@precio", NpgsqlDbType.Double, pRepuesto.Precio);
            prm.agregarParametro("@impuesto", NpgsqlDbType.Double, pRepuesto.Impuesto);
            prm.agregarParametro("@anno", NpgsqlDbType.Integer, pRepuesto.Anno);
            prm.agregarParametro("@id_repuesto", NpgsqlDbType.Integer, pRepuesto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
      //Metodo busca el valor que recibe por parametro en la base de datos
        public List<RepuestoVehiculo> buscarStringRepuesto(string valor, string columna)
        {
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            this.limpiarError();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@" + columna, NpgsqlDbType.Varchar, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "repuesto WHERE " + columna + " = @" + columna;
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "repuesto", oParametro.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()), Int32.Parse(tupla["anno"].ToString()));
                        repuestos.Add(repuesto);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return repuestos;
        }
        //Metodo buscar los valores que recibe por parametro a la base de db
        public List<RepuestoVehiculo> buscarDoubleRepuesto(double valor, string columna)
        {
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            this.limpiarError();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@" + columna, NpgsqlDbType.Double, valor);
            string sql = "SELECT * FROM " + this.conexion.Schema + "repuesto WHERE " + columna + " = @" + columna;
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "repuesto", oParametro.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()), Int32.Parse(tupla["anno"].ToString()));
                        repuestos.Add(repuesto);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return repuestos;
        }
        //Metodo carga un vehiculo segun su el valor que recibe por 
        //parametro
        public List<ENT.RepuestoVehiculo> obtenerReporteRepuesto(int valor)
        {
            List<RepuestoVehiculo> repuestos = new List<RepuestoVehiculo>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@consecutivo", NpgsqlDbType.Numeric, valor);
            string sql = " select rp.id_repuesto as id_repuesto, rp.repuesto as repuesto, rp.precio as precio, rp.impuesto  as impuesto, rp.anno from repuesto rp, orden o, orden_repuesto ore where ore.fk_repuesto = rp.id_repuesto and ore.fk_orden = o.id_orden and o.id_orden = @consecutivo;";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "repuesto", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        RepuestoVehiculo repuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuesto"].ToString()), tupla["repuesto"].ToString(), Double.Parse(tupla["precio"].ToString()), Double.Parse(tupla["impuesto"].ToString()), Int32.Parse(tupla["anno"].ToString()));
                        repuestos.Add(repuesto);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return repuestos;
        }

        public DataTable cargarInformeRepuestoFrecuente()
        {
            DataTable tabla = null;
            Parametro oParametro = new Parametro();
            string sql = "select r.repuesto, orre.cantidad from  repuesto r, orden_repuesto orre where orre.fk_repuesto = r.id_repuesto; ";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "orden", oParametro.obtenerParametros());
            if (!conexion.IsError)
            {
                tabla = dset.Tables[0].Copy();
            }
            else
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;
            }
            return tabla;
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
