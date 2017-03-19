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
        private string detalle;

        public Servicio(int id, string servicio, string detalle)
        {
            this.id = id;
            this.servicio = servicio;
            this.detalle = detalle;
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

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }


        public override string ToString()
        {
            return Id + " " + pServicio + " " + Detalle;
        }
    }
}
