using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Servicio
    {
        private int id;
        private string servicio;
        private double precio;
        private double impuesto;
        private string descripcion;
        private int diasPromedio;

        public Servicio(int id, string servicio,double precio)
        {
            this.id = id;
            this.servicio = servicio;
            this.Precio = precio;
        }
        public Servicio(int id, string servicio, double precio, double impuesto, string descripcion, int diasPromedio)
        {
            this.id = id;
            this.servicio = servicio;
            this.Precio = precio;
            this.Impuesto = impuesto;
            this.Descripcion = descripcion;
            this.DiasPromedio = diasPromedio;
        }


        public Servicio()
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

        public string pServicio
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

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public double Impuesto
        {
            get
            {
                return impuesto;
            }

            set
            {
                impuesto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int DiasPromedio
        {
            get
            {
                return diasPromedio;
            }

            set
            {
                diasPromedio = value;
            }
        }

        public override string ToString()
        {
            return Id + " " + pServicio + " " + Precio;
        }
    }
}
