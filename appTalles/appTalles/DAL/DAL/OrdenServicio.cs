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
    public class OrdenServicio
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

        public OrdenServicio()
        {
            this.conexion = AccesoDatosPostgre.Instance;

        }

        public void agregarOrdenServicio(ENT.OrdenServicio ordenServicio)
        {
            limpiarError();
            string sql = "INSERT INTO " + this.conexion.Schema + "orden_servicio(fk_orden, fk_servicio, costo, cantidad, fk_empleado) "
                       + "VALUES(@fk_orden, @fk_servicio, @costo, @cantidad, @fk_empleado)";
            Parametro prm = new Parametro();
            prm.agregarParametro("@fK_orden", NpgsqlDbType.Integer, ordenServicio.Orden.Id);
            prm.agregarParametro("@fk_servicio", NpgsqlDbType.Integer, ordenServicio.Servicio.Id);
            prm.agregarParametro("@costo", NpgsqlDbType.Double, ordenServicio.Costo);
            prm.agregarParametro("@cantidad", NpgsqlDbType.Integer, ordenServicio.Cantidad);
            prm.agregarParametro("@fk_empleado", NpgsqlDbType.Integer, ordenServicio.Empleado.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.ErrorMsg = this.conexion.ErrorDescripcion;
            }


        }


        public List<ENT.OrdenServicio> buscarOrdenServicioPorID(int valor)
        {
            this.limpiarError();
            List<ENT.OrdenServicio> ordenServicios = new List<ENT.OrdenServicio>();
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
                    ENT.Servicio Oservicio = new ENT.Servicio(int.Parse(tupla["id_servicioS"].ToString()), tupla["servicioS"].ToString(), double.Parse(tupla["precioS"].ToString()), double.Parse(tupla["impuestoS"].ToString()));
                    ENT.Orden oOrden = new ENT.Orden(int.Parse(tupla["id_orden"].ToString()), DateTime.Parse(tupla["fecha_ingreso"].ToString()), DateTime.Parse(tupla["fecha_salida"].ToString()), DateTime.Parse(tupla["fecha_facturacion"].ToString()), tupla["estado"].ToString(), double.Parse(tupla["costo_total"].ToString()), new ENT.Vehiculo(), new ENT.Empleado());
                    ENT.Empleado OEmpleado = new ENT.Empleado(int.Parse(tupla["id_empleado"].ToString()), tupla["nombre_empleado"].ToString(), tupla["apellido_empleado"].ToString(), tupla["direccion_empleado"].ToString(), tupla["telefono1_empleado"].ToString(), tupla["telefono2_empleado"].ToString(), tupla["trabajo_empleado"].ToString(), tupla["permiso_empleado"].ToString(), tupla["usuario_empleado"].ToString(), tupla["contrasenna_empleado"].ToString());
                    ENT.OrdenServicio ordenServicio = new ENT.OrdenServicio(int.Parse(tupla["id_orden_servicio"].ToString()), int.Parse(tupla["cantidad"].ToString()), double.Parse(tupla["costo"].ToString()), OEmpleado, Oservicio, oOrden);
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
        public void editarOrdenServicio(ENT.OrdenServicio ordenServicio)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "orden_servicio SET costo = @costo, cantidad = @cantidad  WHERE id_orden_servicio = @id_orden_servicio;";
            NpgsqlParameter[] parametros = new NpgsqlParameter[3];

            Parametro prm = new Parametro();
            prm.agregarParametro("@costo", NpgsqlDbType.Double, ordenServicio.Costo);
            prm.agregarParametro("@cantidad", NpgsqlDbType.Integer, ordenServicio.Cantidad);
            prm.agregarParametro("@id_orden_servicio", NpgsqlDbType.Integer, ordenServicio.Id);
            this.conexion.ejecutarSQL(sql, parametros);
            if (this.conexion.IsError)
            {
                this.error = false;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }

        public void borraOrdenServicio(ENT.OrdenServicio ordenServicio)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "orden_servicio WHERE id_orden_servicio = @id_orden_servicio";
            Parametro prm = new Parametro();
            prm.agregarParametro("id_orden_servicio", NpgsqlDbType.Integer, ordenServicio.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
    }
}