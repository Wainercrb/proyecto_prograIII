using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Logica;
using System.Data;

namespace Datos
{
    public class OrdenServicioD
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;

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

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }

        public OrdenServicioD()
        {
            this.conexion = AccesoDatosPostgre.Instance;

        }

        public bool agregarOrdenServicio(OrdenServicio ordenServicio)
        {
            try
            {  
                limpiarError();
                DataSet dsetVehiculo;

                string sql = "INSERT INTO public.orden_servicio(fk_orden, fk_servicio, costo, cantidad, fk_empleado) "
                           + "VALUES(@fk_orden, @fk_servicio, @costo, @cantidad, @fk_empleado)";

                NpgsqlParameter[] parametros = new NpgsqlParameter[5];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@fk_orden";
                parametros[0].Value = ordenServicio.Orden.Id;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@fk_servicio";
                parametros[1].Value = ordenServicio.Servicio.Id;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[2].ParameterName = "@costo";
                parametros[2].Value = ordenServicio.Costo;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[3].ParameterName = "@cantidad";
                parametros[3].Value = ordenServicio.Cantidad;
                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[4].ParameterName = "@fk_empleado";
                parametros[4].Value = ordenServicio.Empleado.Id;

                dsetVehiculo = this.conexion.ejecutarDataSetSQL(sql, parametros);

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


        public List<OrdenServicio> buscarOrdenServicioPorID(int valor)
        {
            this.limpiarError();
            List<OrdenServicio> ordenServicios = new List<OrdenServicio>();
            DataSet dsetOrdenRepuesto;

            string sql = "SELECT orp.id_orden_servicio AS id_orden_servicio, orp.cantidad AS cantidad, orp.costo AS costo, " +
       "e.id_empleado AS id_empleado, e.nombre AS nombre_empleado, e.apellido AS apellido_empleado, e.direccion AS direccion_empleado, e.telefono1 AS telefono1_empleado, e.telefono2 AS telefono2_empleado, e.trabajo AS trabajo_empleado, e.permiso AS permiso_empleado, " +
       "e.contrasenna AS contrasenna_empleado, e.usuario AS usuario_empleado, o.id_orden AS id_orden, o.fecha_ingreso AS fecha_ingreso, o.fecha_salida AS fecha_salida, o.fecha_facturacion AS fecha_facturacion, " +
       "o.estado AS estado, o.costo_total AS costo_total, o.fk_vehiculo AS fk_vehiculo, o.pk_empleado AS pk_empleado, s.id_servicio AS id_servicioS, s.servcio AS servicioS, " +
       "s.precio AS precioS, s.impuesto AS impuestoS " +
      " FROM   PUBLIC.orden_servicio orp, PUBLIC.empleado e, PUBLIC.orden o, PUBLIC.servicio s " +
       "WHERE orp.fk_empleado = e.id_empleado AND orp.fk_orden = o.id_orden AND orp.fk_Servicio = s.id_servicio AND fk_orden = " + valor;
            try
            {
                dsetOrdenRepuesto = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetOrdenRepuesto.Tables[0].Rows)
                {
                    Servicio Oservicio = new Servicio(Int32.Parse(tupla["id_servicioS"].ToString()), tupla["servicioS"].ToString(), Double.Parse(tupla["precioS"].ToString()), Double.Parse(tupla["impuestoS"].ToString()));
                    Orden oOrden = new Orden(Int32.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), Double.Parse(tupla["costo_total"].ToString()), new Vehiculo(), new Empleado());
                    Empleado OEmpleado = new Empleado(Int32.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                    OrdenServicio ordenServicio = new OrdenServicio(Int32.Parse(tupla["id_orden_servicio"].ToString()), Int32.Parse(tupla["cantidad"].ToString()), Double.Parse(tupla["costo"].ToString()), OEmpleado,  Oservicio,oOrden);
                    ordenServicios.Add(ordenServicio);
                }
                if (this.conexion.IsError)
                {
                    this.errorMsg = this.conexion.ErrorDescripcion;
                    this.error = true;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }

            return ordenServicios;
        }
    }
}
