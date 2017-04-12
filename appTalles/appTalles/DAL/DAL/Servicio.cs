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

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }

        public bool agregarservicio(ENT.Servicio server)
        {
            limpiarError();
            try
            {

                string sql = "insert into servicio (servcio, precio) values(@servicio, @precio)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[2];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@servicio";
                parametros[0].Value = server.pServicio;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[1].ParameterName = "@precio";
                parametros[1].Value = server.Precio;

                this.conexion.ejecutarSQL(sql, parametros);

                if (conexion.IsError)
                {
                    this.Error = true;
                    this.ErrorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.Error = true;
                this.ErrorMsg = e.Message;
            }
            return this.Error;
        }


        public List<ENT.Servicio> Obtenerservicios(ref bool estado)
        {
            estado = true;
            List<ENT.Servicio> servicios = new List<ENT.Servicio>();
            DataSet dsetEmpleados;
            string sql = "select p.id_servicio as id_servicio, p.servcio as servcio ,p.precio as precio, p.impuesto as impuesto from servicio p";

            dsetEmpleados = conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
            {
                ENT.Servicio pEmpleados = new ENT.Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                    double.Parse(tupla["precio"].ToString()), double.Parse(tupla["impuesto"].ToString()));
                servicios.Add(pEmpleados);

            }
            return servicios;
        }
        public bool borrarservicio(ENT.Servicio server)
        {
            limpiarError();
            try
            {
                string sql = "delete from servicio where id_servicio = @id_servicio";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_servicio";
                parametros[0].Value = server.Id;

                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.Error = true;
                    this.ErrorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.Error = true;
                this.ErrorMsg = e.Message;
            }
            return this.Error;
        }
        public bool actualizarServicio(ENT.Servicio server)
        {
            limpiarError();

            try
            {
                string sql = " update  servicio set servcio = @servicio ,precio = @precio  where id_servicio = @id_servicio";
                NpgsqlParameter[] parametros = new NpgsqlParameter[3];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@servicio";
                parametros[0].Value = server.pServicio;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[1].ParameterName = "@precio";
                parametros[1].Value = server.Precio;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[2].ParameterName = "@id_servicio";
                parametros[2].Value = server.Id;

                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.Error = true;
                    this.ErrorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.Error = true;
                ErrorMsg = e.Message;
            }

            return this.Error;
        }
        public List<ENT.Servicio> buscarServicios(string valor1)
        {

            limpiarError();
            List<ENT.Servicio> empleados = new List<ENT.Servicio>();
            DataSet dsetEmpleados;
            string sql = "select * from servicio where servcio ='" + valor1 + "'";
            try
            {
                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);

                foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                {
                    ENT.Servicio pEmpleados = new ENT.Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                        int.Parse(tupla["precio"].ToString()));
                    empleados.Add(pEmpleados);
                }
            }

            catch (Exception e)
            {
                this.Error = false;
                this.ErrorMsg = e.Message;
            }

            return empleados;

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


