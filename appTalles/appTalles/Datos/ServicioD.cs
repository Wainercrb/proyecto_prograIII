using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Logica;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Datos
{
   public class ServicioD
    {
        private AccesoDatosPostgre conexion;
        private string error;
        private string errorMsg;

        public string Error
        {
            get { return error; }
        }


        public ServicioD(AccesoDatosPostgre pConexion)
        {
            this.conexion = pConexion;
            this.error = "";
        }

        public bool agregarservicio(Servicio server)
        {
            bool estado = true;
            this.error = "";
            try
            {

                string sql = "insert into servicio (servcio,detalles) values(@servicio,@detalles)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[2];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@servicio";
                parametros[0].Value = server.pServicio;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[1].ParameterName = "@detalles";
                parametros[1].Value = server.Detalle;

                this.conexion.ejecutarSQL(sql, parametros);

                if (conexion.IsError)
                {
                    estado = false;
                    this.error = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                estado = false;
                error = e.Message;
            }
            return estado;
        }


        public List<Servicio> Obtenerservicios(ref bool estado)
        {
            estado = true;
            List<Servicio> servicios = new List<Servicio>();
            DataSet dsetEmpleados;
            string sql = "select p.id_servicio as id_servicio, p.servcio as servcio ,p.detalles as detalles from servicio p";

            dsetEmpleados = conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
            {
                Servicio pEmpleados = new Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                    tupla["detalles"].ToString());
                servicios.Add(pEmpleados);

            }
            return servicios;
        }
        public bool borrarservicio(Servicio server)
        {
            bool estado = true;
            this.error = "";
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
                    estado = false;
                    this.error = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                estado = false;
                this.error = e.Message;
            }
            return estado;
        }
        public bool actualizarServicio(Servicio server)
        {
            bool estado = true;
            this.error = "";

            try
            {
                string sql = " update  servicio set servcio = @servicio ,detalles = @detalles  where id_servicio = @id_servicio";
                NpgsqlParameter[] parametros = new NpgsqlParameter[3];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@servicio";
                parametros[0].Value = server.pServicio;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[1].ParameterName = "@detalles";
                parametros[1].Value = server.Detalle;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[2].ParameterName = "@id_servicio";
                parametros[2].Value = server.Detalle;

                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    estado = false;
                    this.error = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                estado = false;
                error = e.Message;
            }

            return estado;
        }
        public List<Servicio> buscarServicios(string valor1)
        {

            bool estado = true;
            List<Servicio> empleados = new List<Servicio>();
            DataSet dsetEmpleados;
            string sql = "select * from servicio where servcio ='" + valor1 + "'";
            try
            {
                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);

                foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                {
                    Servicio pEmpleados = new Servicio(Convert.ToInt32(tupla["id_servicio"].ToString()), tupla["servcio"].ToString(),
                        tupla["detalles"].ToString());
                    empleados.Add(pEmpleados);
                }
            }

            catch (Exception e)
            {
                estado = false;
                error = e.Message;
            }

            return empleados;

        }
    }
}


