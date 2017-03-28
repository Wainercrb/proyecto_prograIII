using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Servicio
    {
        private int id;
        private string servicio;
        private double precio;

        public Servicio(int id, string servicio,double precio)
        {
            this.id = id;
            this.servicio = servicio;
            this.Precio = precio;
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

        public override string ToString()
        {
            return Id + " " + pServicio + " " + Precio;
        }
    }
}
