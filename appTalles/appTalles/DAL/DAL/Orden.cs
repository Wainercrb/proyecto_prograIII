using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using ENT;
using System.Data;
using System.Windows.Forms;

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
        //Metodo agrega los valores que recibe por parametro y retorna
        //y id_de esa orden
        public int agregarOrden(ENT.Orden orden)
        {
            limpiarError();
            string id_orden = "0";
            string sql = "INSERT INTO " + this.conexion.Schema + "orden(fecha_ingreso, fecha_salida, fecha_facturacion, estado, costo_total, fk_vehiculo, pk_empleado) "
                       + "VALUES (@fecha_ingreso, @fecha_salida, @fecha_facturacion, @estado, @costo_total, @fk_vehiculo, @pk_empleado) returning id_orden";
            Parametro prm = new Parametro();
            prm.agregarParametro("@fecha_ingreso", NpgsqlDbType.Date, orden.FechaIngreso);
            prm.agregarParametro("@fecha_salida", NpgsqlDbType.Date, orden.FechaSalida);
            prm.agregarParametro("@fecha_facturacion", NpgsqlDbType.Date, orden.FechaFacturacion);
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, orden.Estado);
            prm.agregarParametro("@costo_total", NpgsqlDbType.Double, orden.CostoTotal);
            prm.agregarParametro("@fk_vehiculo", NpgsqlDbType.Integer, orden.Vehiculo.Id);
            prm.agregarParametro("@pk_empleado", NpgsqlDbType.Integer, orden.Empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros(), ref id_orden);
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return Int32.Parse(id_orden);
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
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(),new ENT.Modelo());
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
        //Metodo busca por id una orden y lo retorna en un dataset
        //lo recorre y lo convierte en una lista
        public ENT.Orden obtenerOrdenConsecutivo(int consecutivo)
        {
            this.limpiarError();
            ENT.Orden orden = new ENT.Orden();
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_orden", NpgsqlDbType.Integer, consecutivo);
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
            dsetOrden = this.conexion.ejecutarConsultaSQL(sql, "orden", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dsetOrden.Tables[0].Rows.Count > 0)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(dsetOrden.Tables["id_marca"].ToString()), dsetOrden.Tables["marca"].ToString(), new ENT.Modelo());
                    ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(dsetOrden.Tables["id_empleado"].ToString()), dsetOrden.Tables["nombre_empleado"].ToString(), dsetOrden.Tables["apellido_empleado"].ToString(), dsetOrden.Tables["direccion_empleado"].ToString(), dsetOrden.Tables["telefono1_empleado"].ToString(), dsetOrden.Tables["telefono2_empleado"].ToString(), dsetOrden.Tables["trabajo_empleado"].ToString(), dsetOrden.Tables["permiso_empleado"].ToString(), dsetOrden.Tables["usuario_empleado"].ToString(), dsetOrden.Tables["contrasenna_empleado"].ToString());
                    ENT.Cliente oCliente = new ENT.Cliente(int.Parse(dsetOrden.Tables["id_cliente"].ToString()), dsetOrden.Tables["cedula"].ToString(), dsetOrden.Tables["nombre"].ToString(), dsetOrden.Tables["apellido"].ToString(), dsetOrden.Tables["apellido2"].ToString(), dsetOrden.Tables["telefono_casa"].ToString(), dsetOrden.Tables["telefono_celular"].ToString(), dsetOrden.Tables["telefono_oficina"].ToString());
                    TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(dsetOrden.Tables["id_tipo"].ToString()), dsetOrden.Tables["tipo"].ToString());
                    ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(dsetOrden.Tables["id_vehiculo"].ToString()), dsetOrden.Tables["placa"].ToString(), int.Parse(dsetOrden.Tables["anno"].ToString()), int.Parse(dsetOrden.Tables["cilindraje"].ToString()), int.Parse(dsetOrden.Tables["numero_motor"].ToString()), int.Parse(dsetOrden.Tables["numero_chazis"].ToString()), dsetOrden.Tables["combustible"].ToString(), dsetOrden.Tables["estado"].ToString(), oMarca, oCliente, oTipo);
                    ENT.Orden oOrden = new ENT.Orden(int.Parse(dsetOrden.Tables["id_orden"].ToString()), DateTime.Parse(dsetOrden.Tables["fecha_ingreso"].ToString()), DateTime.Parse(dsetOrden.Tables["fecha_salida"].ToString()), DateTime.Parse(dsetOrden.Tables["fecha_facturacion"].ToString()), dsetOrden.Tables["estado"].ToString(), double.Parse(dsetOrden.Tables["costo_total"].ToString()), oVehiculo, OEmpleado);
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return orden;
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
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo carga un dataset y lo recorre y lo retorna en una
        //lista
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
                MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new ENT.Modelo());
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
        //Metodo actualiza el estado de una orden
        //por los valores que recibe por parametro
        public void actualizarEstadoOrden(ENT.Orden orden, DateTime date)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "orden SET estado = @estado, fecha_facturacion = @fecha_facturacion WHERE  id_orden = @id_orden";
            Parametro prm = new Parametro();
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, orden.Estado);
            prm.agregarParametro("@id_orden", NpgsqlDbType.Integer, orden.Id);
            prm.agregarParametro("@fecha_facturacion", NpgsqlDbType.Date,date);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (conexion.IsError)
            {
                this.errorMsg = this.conexion.ErrorDescripcion;
                this.error = true;
            }
        }
        //Metodo elimina la orden que recibe por parametro
        public void eliminarOrden(int valor)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "orden WHERE id_orden = @id_orden";
            Parametro prm = new Parametro();
            prm.agregarParametro("id_orden", NpgsqlDbType.Numeric, valor);
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
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and " + columna + "= @" + columna;
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "orden", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new  ENT.Modelo());
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
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new ENT.Modelo());
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
        public List<ENT.Orden> obtenerFechaOrden(DateTime fecha_uno, DateTime fecha_dos)
        {
            limpiarError();
            List<ENT.Empleado> empleados = new List<ENT.Empleado>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@fecha_ingreso_uno", NpgsqlDbType.Date, fecha_uno);
            prm.agregarParametro("@fecha_ingreso_dos", NpgsqlDbType.Date, fecha_dos); ;
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
                         "v.fk_cliente = c.id_cliente and o.fk_vehiculo = v.id_vehiculo and o.pk_empleado = e.id_empleado and cast(o.fecha_ingreso as date) between @fecha_ingreso_uno and @fecha_ingreso_dos";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql, "empleado", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                if (dset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dset.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new ENT.Modelo());
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

        //Metodo carga un datatable por id y lo retorna a bll.orden
        public DataTable cargarReporteOrdenPorId(int valor)
        {
            DataTable tabla = null;
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@consecutivo", NpgsqlDbType.Numeric, valor);
            string sql = "select * from "+this.conexion.Schema+"orden WHERE id_orden = @consecutivo;";
            DataSet dset = this.conexion.ejecutarConsultaSQL(sql,"orden", oParametro.obtenerParametros());
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

        public DataTable cargarReporteOrdenPendiente(DateTime valor)
        {
            DataTable tabla = null;
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@estado", NpgsqlDbType.Varchar, "Pendiente");
            oParametro.agregarParametro("@fecha_facturacion", NpgsqlDbType.Date, valor);
            string sql = "select o.id_orden, o.fecha_ingreso, o.fecha_salida, o.fecha_facturacion, o.estado, o.costo_total, v.placa "+
                          "from orden o, vehiculo v where o.fk_vehiculo = v.id_vehiculo and (o.estado = @estado) and cast(o.fecha_ingreso as date) = @fecha_facturacion;";
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
        public DataTable cargarReporteOrdenFinalizada(DateTime valor)
        {
            DataTable tabla = null;
            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@estadoUno", NpgsqlDbType.Varchar, "Pendiente");
            oParametro.agregarParametro("@estadoDos", NpgsqlDbType.Varchar, "Finalizado");
            oParametro.agregarParametro("@fecha_facturacion", NpgsqlDbType.Date, valor);
            string sql = "select o.id_orden, o.fecha_ingreso, o.fecha_salida, o.fecha_facturacion, o.estado, o.costo_total, v.placa " +
                          "from orden o, vehiculo v where o.fk_vehiculo = v.id_vehiculo and (o.estado = @estadoUno or o.estado = @estadoDos) AND cast(o.fecha_facturacion as date) = @fecha_facturacion"; 
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
