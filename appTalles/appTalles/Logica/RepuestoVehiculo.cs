using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RepuestoVehiculo
    {
        private int id;
        private string repuesto;
        private double precio;
        private MarcaVehiculo marca;
        private Parametro parametro;

        public RepuestoVehiculo(int id, string repuesto, double precio, MarcaVehiculo marca, Parametro parametro)
        {
            this.id = id;
            this.repuesto = repuesto;
            this.precio = precio;
            this.marca = marca;
            this.parametro = parametro;
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

        public string Repuesto
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

        public MarcaVehiculo Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public Parametro Parametro
        {
            get
            {
                return parametro;
            }

            set
            {
                parametro = value;
            }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Repuesto + " " + this.Precio + " " + this.Marca + " " + this.Parametro;
        }


    }
}
