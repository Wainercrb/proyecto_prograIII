﻿using System;
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
    public class ordenRepuesto
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

        public ordenRepuesto()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }

        public void agregarOrdenRepuesto(ENT.OrdenRepuesto ordenRepuesto)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "orden_repuesto(fk_orden, fk_repuesto, costo, cantidad, pk_empleado) "
                       + "VALUES(@fk_orden, @fk_repuesto, @costo, @cantidad, @pk_empleado)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@fk_orden", NpgsqlDbType.Integer, ordenRepuesto.Orden.Id);
            prm.agregarParametro("@fk_repuesto", NpgsqlDbType.Integer, ordenRepuesto.Repuesto1.Id);
            prm.agregarParametro("@costo", NpgsqlDbType.Double, ordenRepuesto.TotalRepuestos);
            prm.agregarParametro("@cantidad", NpgsqlDbType.Integer, ordenRepuesto.Cantidad);
            prm.agregarParametro("@pk_empleado", NpgsqlDbType.Integer, ordenRepuesto.Empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }
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
                    ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), new ENT.Vehiculo(), new ENT.Empleado());
                    ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
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


        public void editarOrdenRepuesto(ENT.OrdenRepuesto ordenRepuesto)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "orden_repuesto SET costo = @costo, cantidad = @cantidad  WHERE id_orden_repuesto = @id_orden_repuesto;";
            Parametro prm = new Parametro();
            prm.agregarParametro("@costo", NpgsqlDbType.Double, ordenRepuesto.TotalRepuestos);
            prm.agregarParametro("@cantidad", NpgsqlDbType.Integer, ordenRepuesto.Cantidad);
            prm.agregarParametro("@id_orden_repuesto", NpgsqlDbType.Integer, ordenRepuesto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = false;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public void borraOrdenRepuesto(ENT.OrdenRepuesto ordenRepusto)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "orden_repuesto WHERE id_orden_repuesto = @id_orden_repuesto";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_orden_repuesto", NpgsqlDbType.Integer, ordenRepusto.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
    }
}
