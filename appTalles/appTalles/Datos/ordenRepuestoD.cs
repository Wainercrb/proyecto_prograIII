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
    public class ordenRepuestoD
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

        public ordenRepuestoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }

        public bool agregarOrdenRepuesto(OrdenRepuesto OrdenRepuesto)
        {
            try
            {
                limpiarError();
                DataSet dsetVehiculo;

                string sql = "INSERT INTO public.orden_repuesto(fk_orden, fk_repuesto, costo, cantidad, pk_empleado) "
                           + "VALUES(@fk_orden, @fk_repuesto, @costo, @cantidad, @pk_empleado)";

                NpgsqlParameter[] parametros = new NpgsqlParameter[5];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@fk_orden";
                parametros[0].Value = OrdenRepuesto.Orden.Id;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@fk_repuesto";
                parametros[1].Value = OrdenRepuesto.Repuesto1.Id;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[2].ParameterName = "@costo";
                parametros[2].Value = OrdenRepuesto.TotalRepuestos;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[3].ParameterName = "@cantidad";
                parametros[3].Value = OrdenRepuesto.Cantidad;
                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[4].ParameterName = "@pk_empleado";
                parametros[4].Value = OrdenRepuesto.Empleado.Id;

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
        public List<OrdenRepuesto> buscarOrdenRepuestoPorID(int valor)
        {
            this.limpiarError();
            List<OrdenRepuesto> ordenRepuestos = new List<OrdenRepuesto>();
            DataSet dsetOrdenRepuesto;

            string sql = "SELECT orp.id_orden_repuesto AS id_orden_repuesto, orp.cantidad AS cantidad, orp.costo AS costo," +
       "e.id_empleado AS id_empleado, e.nombre AS nombre_empleado, e.apellido AS apellido_empleado, e.direccion AS direccion_empleado, e.telefono1 AS telefono1_empleado, e.telefono2 AS telefono2_empleado, e.trabajo AS trabajo_empleado, e.permiso AS permiso_empleado, " +
       "e.contrasenna AS contrasenna_empleado, e.usuario AS usuario_empleado, o.id_orden AS id_orden, o.fecha_ingreso AS fecha_ingreso, o.fecha_salida AS fecha_salida, o.fecha_facturacion AS fecha_facturacion, " +
       "o.estado AS estado, o.costo_total AS costo_total, o.fk_vehiculo AS fk_vehiculo, o.pk_empleado AS pk_empleado, r.id_repuesto AS id_repuestoR, r.repuesto AS repuestoR, " +
       "r.precio AS precioR, r.impuesto AS impuestoR " +
       "FROM   PUBLIC.orden_repuesto orp, PUBLIC.empleado e, PUBLIC.orden o,PUBLIC. repuesto r " +
       "WHERE  orp.pk_empleado = e.id_empleado AND orp.fk_orden = o.id_orden AND orp.fk_repuesto = r.id_repuesto AND fk_orden = " + valor;
            try
            {
                dsetOrdenRepuesto = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetOrdenRepuesto.Tables[0].Rows)
                {
                    RepuestoVehiculo Orepuesto = new RepuestoVehiculo(Int32.Parse(tupla["id_repuestor"].ToString()), tupla["repuestor"].ToString(), Double.Parse(tupla["precior"].ToString()), Double.Parse(tupla["impuestor"].ToString()));
                    Orden oOrden = new Orden(Int32.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), Double.Parse(tupla["costo_total"].ToString()), new Vehiculo(), new Empleado());
                    Empleado OEmpleado = new Empleado(Int32.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                    OrdenRepuesto ordenRepuesto = new OrdenRepuesto(Int32.Parse(tupla["id_orden_repuesto"].ToString()), Int32.Parse(tupla["cantidad"].ToString()), Double.Parse(tupla["costo"].ToString()), oOrden, OEmpleado, Orepuesto);
                    ordenRepuestos.Add(ordenRepuesto);
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

            return ordenRepuestos;
        }


        public bool editarOrdenRepuesto(OrdenRepuesto ordenRepuesto)
        {
            try
            {
                limpiarError();
                DataSet dsetRepuesto;
                string sql = "UPDATE public.orden_repuesto SET costo = @costo, cantidad = @cantidad  WHERE id_orden_repuesto = @id_orden_repuesto;";
                NpgsqlParameter[] parametros = new NpgsqlParameter[3];
          
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[0].ParameterName = "@costo";
                parametros[0].Value = ordenRepuesto.TotalRepuestos;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[1].ParameterName = "@cantidad";
                parametros[1].Value = ordenRepuesto.Cantidad;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[2].ParameterName = "@id_orden_repuesto";
                parametros[2].Value = ordenRepuesto.Id;
                dsetRepuesto = this.conexion.ejecutarDataSetSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.error = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = false;
                this.errorMsg = e.Message;
            }

            return this.error;
        }

        public bool borraOrdenRepuesto(OrdenRepuesto ordenRepusto)
        {
            limpiarError();
            try
            {
                string sql = "DELETE FROM public.orden_repuesto WHERE id_orden_repuesto = @id_orden_repuesto";
                NpgsqlParameter[] parametros = new NpgsqlParameter[1];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_orden_repuesto";
                parametros[0].Value = ordenRepusto.Id;
                DataSet dsetMarca;
                dsetMarca = this.conexion.ejecutarDataSetSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    this.error = true;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorMsg = e.Message;
            }
            return this.error;
        }
    }
}
