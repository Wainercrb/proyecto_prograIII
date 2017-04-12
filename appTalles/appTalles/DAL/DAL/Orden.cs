using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using ENT;
using System.Data;

namespace DAL
{
    public class Orden
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

        public Orden()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        public void agregarOrden(ENT.Orden orden)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "orden(fecha_ingreso, fecha_salida, fecha_facturacion, estado, costo_total, fk_vehiculo, pk_empleado)"
                       + "VALUES(@fecha_ingreso, @fecha_salida, @fecha_facturacion, @estado, @costo_total, @fk_vehiculo, @pk_empleado); ";
            Parametro prm = new Parametro();
            prm.agregarParametro("@fecha_ingreso", NpgsqlDbType.Date, orden.FechaIngreso);
            prm.agregarParametro("@fecha_salida", NpgsqlDbType.Date, orden.FechaSalida);
            prm.agregarParametro("@fecha_facturacion", NpgsqlDbType.Date, orden.FechaFacturacion);
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, orden.Estado);
            prm.agregarParametro("@costo_total", NpgsqlDbType.Double, orden.CostoTotal);
            prm.agregarParametro("@fk_vehiculo", NpgsqlDbType.Integer, orden.Vehiculo.Id);
            prm.agregarParametro("@pk_empleado", NpgsqlDbType.Integer, orden.Empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public List<ENT.Orden> obtenerOrden()
        {
            this.limpiarError();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            DataSet dsetOrden;
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado ";

            dsetOrden = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOrden.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);

                ordenes.Add(oOrden);
            }
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
        }

        public void actualizarTotal(ENT.Orden orden)
        {
            limpiarError();
            string sql = "UPDATE public.orden SET costo_total = @costo_total WHERE id_orden = @id_orden;";
            Parametro prm = new Parametro();
            prm.agregarParametro("@costo_total", NpgsqlDbType.Double, orden.CostoTotal);
            prm.agregarParametro("@id_orden", NpgsqlDbType.Integer, orden.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = false;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public List<ENT.Orden> obtenerOrdenId(ENT.Orden orden)
        {
            this.limpiarError();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            DataSet dsetOrden;
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and id_orden = " + orden.Id;

            dsetOrden = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOrden.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);
                ordenes.Add(oOrden);

            }
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
        }


        public bool actualizarOrden(ENT.Orden orden)
        {
            limpiarError();

            try
            {
                string sql = "UPDATE public.orden SET fecha_ingreso = @fecha_ingreso, fecha_salida = @fecha_salida, fecha_facturacion = @fecha_facturacion, estado = @estado, costo_total = @costo_total, fk_vehiculo = @fk_vehiculo, pk_empleado = @pk_empleado WHERE  id_orden = " + orden.Id;
                NpgsqlParameter[] parametros = new NpgsqlParameter[8];

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
                parametros[2].ParameterName = "@fecha_facturacion";
                parametros[2].Value = orden.FechaFacturacion;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Text;
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
                parametros[6].ParameterName = "@pk_emplead";
                parametros[6].Value = orden.Empleado.Id;
                parametros[7] = new NpgsqlParameter();
                parametros[7].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[7].ParameterName = "@id_orden";
                parametros[7].Value = orden.Id;


                this.conexion.ejecutarSQL(sql, parametros);
                if (conexion.IsError)
                {
                    errorMsg = this.conexion.ErrorDescripcion;
                    return true;
                }

            }
            catch (Exception e)
            {
                Error = true;
                ErrorMsg = e.Message;
            }

            return Error;
        }

        public List<ENT.Orden> obtenerOrdenString(int valor, string columna)
        {
            this.limpiarError();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            DataSet dsetOrden;
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and " + columna + " = " + valor;

            dsetOrden = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOrden.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);
                ordenes.Add(oOrden);

            }
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
        }


        public List<ENT.Orden> obtenerOrdenFecha(DateTime fechaUno, DateTime fechaDos, string valor1, string valor2)
        {
            this.limpiarError();
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            DataSet dsetOrden;
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and (+" + valor1 + " > " + fechaUno + " and " + valor2 + " < " + fechaDos + ")";

            dsetOrden = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOrden.Tables[0].Rows)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);
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
