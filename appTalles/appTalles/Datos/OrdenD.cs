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
    public class OrdenD
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

        public OrdenD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        public bool agregarOrden(Orden orden)
        {
            try
            {
                limpiarError();
                DataSet dsetVehiculo;

                string sql = "INSERT INTO public.orden(fecha_ingreso, fecha_salida, fecha_facturacion, estado, costo_total, fk_vehiculo, pk_empleado)"
                           + "VALUES(@fecha_ingreso, @fecha_salida, @fecha_facturacion, @estado, @costo_total, @fk_vehiculo, @pk_empleado); ";

                NpgsqlParameter[] parametros = new NpgsqlParameter[7];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Date;
                parametros[0].ParameterName = "@fecha_ingreso";
                parametros[0].Value = orden.FechaIngreso;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Date;
                parametros[1].ParameterName = "@fecha_salida";
                parametros[1].Value = orden.FechaSalida;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Date;
                parametros[2].ParameterName = " @fecha_facturacion";
                parametros[2].Value = orden.FechaFacturacion;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[3].ParameterName = "@estado";
                parametros[3].Value = orden.Estado;
                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Double;
                parametros[4].ParameterName = "@costo_total";
                parametros[4].Value = orden.CostoTotal;
                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[5].ParameterName = "@fk_vehiculo";
                parametros[5].Value = orden.Vehiculo.Id;
                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[6].ParameterName = "@pk_empleado";
                parametros[6].Value = orden.Empleado.Id;


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

        public List<Orden> obtenerOrden()
        {
            this.limpiarError();
            List<Orden> ordenes = new List<Orden>();
            DataSet dsetOrden;
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado,"+
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo,"+
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, "+
                         "m.id_marca as id_marca, m.marca as marca, "+
                         "t.id_tipo as id_tipo, t.tipo as tipo, "+
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular "+
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o "+
                         "where v.fk_marca = m.id_marca and "+
                         "v.fk_tipo = t.id_tipo and "+
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado ";

            dsetOrden = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOrden.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                Empleado OEmpleado = new Empleado(Int32.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(),tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(),tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(),tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                Cliente oCliente = new Cliente(Int32.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                Vehiculo oVehiculo = new Vehiculo(Int32.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), Int32.Parse(tupla["anno"].ToString()), Int32.Parse(tupla["cilindraje"].ToString()), Int32.Parse(tupla["numero_motor"].ToString()), Int32.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                Orden oOrden = new Orden(Int32.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), Double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);

                ordenes.Add(oOrden);
            }
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
        }

    }
}
