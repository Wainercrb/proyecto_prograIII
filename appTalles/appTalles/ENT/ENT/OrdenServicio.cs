using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
     public class OrdenServicio
    {

        private int id;
        private int cantidad;
        private double costo;
        private Empleado empleado;
        private Servicio servicio;
        private Orden orden;
        

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public Empleado Empleado
        {
            get
            {
                return empleado;
            }

            set
            {
                empleado = value;
            }
        }

        public Servicio Servicio
        {
            get
            {
                return servicio;
            }

            set
            {
                servicio = value;
            }
        }

        public Orden Orden
        {
            get
            {
                return orden;
            }

            set
            {
                orden = value;
            }
        }

        public OrdenServicio(int id, int cantidad, double costo, Empleado empleado, Servicio servicio, Orden orden)
        {
            this.Id = id;
            this.Cantidad = cantidad;
            this.Costo = costo;
            this.Empleado = empleado;
            this.Servicio = servicio;
            this.Orden = orden;
        }

        public OrdenServicio()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public double totalServicio(OrdenServicio ordenServicio, int cantidad)
        {

            return (((ordenServicio.servicio.Precio * ordenServicio.servicio.Impuesto / 100) + ordenServicio.servicio.Precio) * cantidad);
        }

        public double quitarServicio(OrdenServicio ordenServicio, int cantidad)
        {

            double total = (((ordenServicio.servicio.Precio * ordenServicio.servicio.Impuesto / 100) + (ordenServicio.servicio.Precio)) * cantidad);
            return ordenServicio.costo - total;

        }
    }
}
