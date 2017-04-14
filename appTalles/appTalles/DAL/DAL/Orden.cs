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
        public Orden()
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
        //Metodo agrega los valores que recibe por parametro 
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
        //Metodo carga un dataset con las ordenes y los retorna en una lista
        //de ordenes
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
                         "from " + this.conexion.Schema + "vehiculo v, " + this.conexion.Schema + "marca m, " + this.conexion.Schema + "tipo t, " + this.conexion.Schema + "cliente c, " + this.conexion.Schema + "empleado e, " + this.conexion.Schema + "orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado ";
            dsetOrden = this.conexion.ejecutarConsultaSQL(sql);
            if (!this.conexion.IsError)
            {
                if (dsetOrden.Tables[0].Rows.Count > 0)
                {
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
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
        }
        //Metodo actualiza las ordenes por los nuevos
        //parametros que recibe por parametro
        public void actualizarTotal(ENT.Orden orden)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "orden SET costo_total = @costo_total WHERE id_orden = @id_orden;";
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
        //Metodo actualiza la orden por los nuevos valores que recibe
        //por parametro
        public void actualizarOrden(ENT.Orden orden)
        {
            limpiarError();
            string sql = "UPDATE public.orden SET fecha_ingreso = @fecha_ingreso, fecha_salida = @fecha_salida, fecha_facturacion = @fecha_facturacion, estado = @estado, costo_total = @costo_total, fk_vehiculo = @fk_vehiculo, pk_empleado = @pk_empleado WHERE  id_orden = " + orden.Id;
            Parametro prm = new Parametro();
            prm.agregarParametro("@fecha_ingreso", NpgsqlDbType.Date, orden.FechaIngreso);
            prm.agregarParametro("@fecha_salida", NpgsqlDbType.Date, orden.FechaSalida);
            prm.agregarParametro("@fecha_facturacion", NpgsqlDbType.Date, orden.FechaFacturacion);
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, orden.Estado);
            prm.agregarParametro("@costo_total", NpgsqlDbType.Double, orden.CostoTotal);
            prm.agregarParametro("@fk_vehiculo", NpgsqlDbType.Integer, orden.Vehiculo.Id);
            prm.agregarParametro("@pk_empleado", NpgsqlDbType.Integer, orden.Empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (conexion.IsError)
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;
            }
        }
        //Metodo busca por un valor int y lo agrega a un dataset para 
        //retorna en una lista
        public List<ENT.Orden> obtenerIntOrden(int valor, string columna)
        {
            limpiarError();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@" + columna + "", NpgsqlDbType.Integer, valor);           
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and "+columna +"= @"+columna;

            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "empleado", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                        ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                        ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                        TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                        ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                        ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);
                        ordenes.Add(oOrden);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
                return ordenes;
        }

        //Metodo busca por un valor string y lo agrega a un dataset para 
        //retorna en una lista
        public List<ENT.Orden> obtenerStringOrden(string valor, string columna)
        {
            limpiarError();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@" + columna + "", NpgsqlDbType.Varchar, valor);
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and o." + columna + "= @" + columna;

            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "empleado", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                        ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                        ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                        TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                        ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                        ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);
                        ordenes.Add(oOrden);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
        }
        //Metodo busca por un valor datatime y lo agrega a un dataset para 
        //retorna en una lista
        public List<ENT.Orden> obtenerFechaOrden(DateTime ingreso, DateTime salida)
        {
            limpiarError();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@ingreso", NpgsqlDbType.Date, ingreso);
            prm.agregarParametro("@salida", NpgsqlDbType.Date, salida);
            List<ENT.Orden> ordenes = new List<ENT.Orden>();
            string sql = "SELECT o.id_orden as id_orden, o.fecha_ingreso as fecha_ingreso, o.fecha_salida as fecha_salida, o.fecha_facturacion as fecha_facturacion, o.estado as estado, o.costo_total as costo_total, o.fk_vehiculo as fk_vehiculo, o.pk_empleado as pk_empleado," +
                         "v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "e.id_empleado as id_empleado, e.nombre as nombre_empleado, e.apellido as apellido_empleado, e.direccion as direccion_empleado, e.telefono1 as telefono1_empleado, e.telefono2 as telefono2_empleado, e.trabajo as trabajo_empleado, e.permiso as permiso_empleado, e.contrasenna as contrasenna_empleado, e.usuario as usuario_empleado, " +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from public.vehiculo v, public.marca m, public.tipo t, public.cliente c, public.empleado e, public.orden o " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and o.fecha_ingreso >= @ingreso al @salida";

            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "empleado", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString());
                        ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                        ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                        TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                        ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                        ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), oVehiculo, OEmpleado);
                        ordenes.Add(oOrden);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return ordenes;
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
