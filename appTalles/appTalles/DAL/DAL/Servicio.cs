using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace DAL
{
    public class Servicio
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;
        public Servicio()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }
        //Metodo limpia los errores de las variables
        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        //Metodo inserta los valores que recibe por parametros a la base de datos
        public void agregarservicio(ENT.Servicio servicio)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "servicio (servcio, precio, impuesto, descripcion, horas_promedio) values(@servicio, @precio, @impuesto, @descripcion, @horas_promedio)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@servicio", NpgsqlDbType.Varchar, servicio.pServicio);
            prm.agregarParametro("@precio", NpgsqlDbType.Double, servicio.Precio);
            prm.agregarParametro("@impuesto", NpgsqlDbType.Double, servicio.Impuesto);
            prm.agregarParametro("@descripcion", NpgsqlDbType.Varchar, servicio.Descripcion);
            prm.agregarParametro("@horas_promedio", NpgsqlDbType.Integer, servicio.DiasPromedio);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo carga todos los servicios a la lista
        //para retornarlos
        public List<ENT.Servicio> cargarServicios()
        {
            limpiarError();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            DataSet dsetEmpleados;
            string sql = "SELECT * FROM " + this.conexion.Schema + "servicio";
            dsetEmpleados = conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
            {
                ENT.Servicio pEmpleados = new ENT.Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                double.Parse(tupla["precio"].ToString()), double.Parse(tupla["impuesto"].ToString()), tupla["descripcion"].ToString(),Int32.Parse(tupla["horas_promedio"].ToString()));
                servicios.Add(pEmpleados);
            }
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
            return servicios;
        }
        //Metodo elimina al servicio que recibe por parametro
        public void borrarservicio(ENT.Servicio servicio)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "servicio where id_servicio = @id_servicio";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_servicio", NpgsqlDbType.Integer, servicio.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo actualiza el servicio por los datos que recibe por parametro
        public void actualizarServicio(ENT.Servicio servicio)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "servicio set servcio = @servicio ,precio = @precio, impuesto = @impuesto, descripcion = @descripcion, horas_promedio = @horas_promedio where id_servicio = @id_servicio";
            Parametro prm = new Parametro();
            prm.agregarParametro("@servicio", NpgsqlDbType.Varchar, servicio.pServicio);
            prm.agregarParametro("@precio", NpgsqlDbType.Double, servicio.Precio);
            prm.agregarParametro("@impuesto", NpgsqlDbType.Double, servicio.Impuesto);
            prm.agregarParametro("@id_servicio", NpgsqlDbType.Integer, servicio.Id);
            prm.agregarParametro("@descripcion", NpgsqlDbType.Varchar, servicio.Descripcion);
            prm.agregarParametro("@horas_promedio", NpgsqlDbType.Integer, servicio.DiasPromedio);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo busca un valor string que rebibe por parametro, tambien busca la columna 
        //que recibe por parametro
        public List<ENT.Servicio> buscarStringServicio(string cadena, string columna)
        {
            this.limpiarError();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@" + columna, NpgsqlDbType.Varchar, cadena);
            string sql = "SELECT * FROM " + this.conexion.Schema + "servicio WHERE " + columna + " = @" + columna;
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "servicio", oParametro.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        ENT.Servicio sr = new ENT.Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                        int.Parse(tupla["precio"].ToString()));
                        servicios.Add(sr);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return servicios;
        }
        //Metodo busca un valor int que rebibe por parametro, tambien busca la columna 
        //que recibe por parametro
        public List<ENT.Servicio> buscarIntServicio(int cadena, string columna)
        {
            this.limpiarError();
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@" + columna, NpgsqlDbType.Integer, cadena);
            string sql = "SELECT * FROM " + this.conexion.Schema + "servicio WHERE " + columna + " = @" + columna;
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "servicio", oParametro.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        ENT.Servicio sr = new ENT.Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                        int.Parse(tupla["precio"].ToString()));
                        servicios.Add(sr);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return servicios;
        }

        public DataTable cargarDataTableServicios(int id_empleado, DateTime fecha_uno, DateTime fecha_dos)
        {
            DataTable tabla = null;
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@id_empleado", NpgsqlDbType.Numeric, id_empleado);
            oParametro.agregarParametro("@fecha_ingreso_uno", NpgsqlDbType.Date, fecha_uno);
            oParametro.agregarParametro("@fecha_ingreso_dos", NpgsqlDbType.Date, fecha_dos);
            string sql = "select e.nombre, e.apellido, s.id_servicio, s.servcio, s.precio, s.impuesto, orse.cantidad, o.id_orden from empleado e, orden_servicio orse, servicio s, orden o where orse.fk_empleado = e.id_empleado " +
                    "and orse.fk_servicio = s.id_servicio and o.id_orden = orse.fk_orden and e.id_empleado = @id_empleado and cast(o.fecha_ingreso as date) between @fecha_ingreso_uno and @fecha_ingreso_dos";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "orden", oParametro.obtenerParametros());
            if (!conexion.IsError)
            {
                tabla = dset.Tables[0].Copy();
            }
            else
            {
                this.ErrorMsg = this.conexion.ErrorDescripcion;
                this.Error = true;
            }
            return tabla;
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


