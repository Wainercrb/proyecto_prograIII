using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class OrdenRepuesto 
    {

        private int id;
        private int cantidad;
        private double totalRepuestos;
        private Orden orden;
        private Empleado empleado;
        private RepuestoVehiculo repuesto;


        public OrdenRepuesto(int id, int cantidad, double totalRepuestos, Orden orden, Empleado empleado, RepuestoVehiculo repuesto) 
        {
            this.id = id;
            this.cantidad = cantidad;
            this.totalRepuestos = totalRepuestos;
            this.Orden = orden;
            this.Empleado = empleado;
            this.Repuesto1 = repuesto;
        }
        public OrdenRepuesto()
        {
        }

        public OrdenRepuesto(int id)
        {
            this.Id = id;
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

        public double TotalRepuestos
        {
            get
            {
                return totalRepuestos;
            }

            set
            {
                totalRepuestos = value;
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

        public RepuestoVehiculo Repuesto1
        {
            get
            {
                return repuesto;
            }

            set
            {
                repuesto = value;
            }
        }

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

        public double totalRepuesto(OrdenRepuesto ordenRepuesto, int cantidad) {
                     
            return (((ordenRepuesto.Repuesto1.Precio * ordenRepuesto.Repuesto1.Impuesto / 100) + ordenRepuesto.Repuesto1.Precio)*cantidad);
        }

        public double quitarRepuestos(OrdenRepuesto ordenRepuesto, int cantidad) {
            double total = (((ordenRepuesto.Repuesto1.Precio * ordenRepuesto.Repuesto1.Impuesto/100) + (ordenRepuesto.Repuesto1.Precio)) * cantidad); 
            return ordenRepuesto.TotalRepuestos-total;

        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
