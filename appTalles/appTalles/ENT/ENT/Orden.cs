using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Orden

    {

        private int id;
        private DateTime fechaIngreso;
        private DateTime fechaSalida;
        private DateTime fechaFacturacion = DateTime.Parse("01/01/0001");
        private string estado;
        private double costoTotal;
        private Vehiculo vehiculo;
        private Empleado empleado;
        private List<OrdenCatalogo> ordenCatalogo;
        private List<OrdenRepuesto> ordenRepesto;

        public Orden(int id, DateTime fechaIngreso, DateTime fechaSalida, DateTime fechaFacturacion, string estado, double costoTotal, Vehiculo vehiculo, Empleado empleado, List<OrdenCatalogo> ordenCatalogo, List<OrdenRepuesto> ordenRepesto)
        {
            this.id = id;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.fechaFacturacion = fechaFacturacion;
            this.estado = estado;
            this.costoTotal = costoTotal;
            this.vehiculo = vehiculo;
            this.empleado = empleado;
            this.ordenCatalogo = ordenCatalogo;
            this.ordenRepesto = ordenRepesto;
        }
        public Orden(int id, DateTime fechaIngreso, DateTime fechaSalida, DateTime fechaFacturacion, string estado, double costoTotal, Vehiculo vehiculo, Empleado empleado)
        {
            this.id = id;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.fechaFacturacion = fechaFacturacion;
            this.estado = estado;
            this.costoTotal = costoTotal;
            this.vehiculo = vehiculo;
            this.empleado = empleado;
        }

        public Orden(DateTime fechaIngreso, DateTime fechaSalida, DateTime fechaFacturacion, string estado, double costoTotal, Vehiculo vehiculo, Empleado empleado, List<OrdenCatalogo> ordenCatalogo, List<OrdenRepuesto> ordenRepesto)
        {
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.fechaFacturacion = fechaFacturacion;
            this.estado = estado;
            this.costoTotal = costoTotal;
            this.vehiculo = vehiculo;
            this.empleado = empleado;
            this.ordenCatalogo = ordenCatalogo;
            this.ordenRepesto = ordenRepesto;
        }

        public Orden()
        {
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

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public DateTime FechaSalida
        {
            get
            {
                return fechaSalida;
            }

            set
            {
                fechaSalida = value;
            }
        }

        public DateTime FechaFacturacion
        {
            get
            {
                return fechaFacturacion;
            }

            set
            {
                fechaFacturacion = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public double CostoTotal
        {
            get
            {
                return costoTotal;
            }

            set
            {
                costoTotal = value;
            }
        }

        public Vehiculo Vehiculo
        {
            get
            {
                return vehiculo;
            }

            set
            {
                vehiculo = value;
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

        public List<OrdenCatalogo> OrdenCatalogo
        {
            get
            {
                return ordenCatalogo;
            }

            set
            {
                ordenCatalogo = value;
            }
        }

        public List<OrdenRepuesto> OrdenRepesto
        {
            get
            {
                return ordenRepesto;
            }

            set
            {
                ordenRepesto = value;
            }
        }

        public override string ToString()
        {
            return this.Id +" "+ this.empleado  +" "+ this.vehiculo;
        }
    }
}
