using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class RepuestoVehiculo
    {
        private int id;
        private string repuesto;
        private double precio;
        private double impuesto;
        private int anno;
        private List<MarcaVehiculo> marcas;



        public RepuestoVehiculo(int id, string repuesto, double precio, double impuesto, List<MarcaVehiculo> marcas)
        {
            this.id = id;
            this.repuesto = repuesto;
            this.precio = precio;
            this.impuesto = impuesto;
            this.marcas = marcas;


        }



        public RepuestoVehiculo(int id, string repuesto, double precio, double impuesto, int anno)
        {
            this.id = id;
            this.repuesto = repuesto;
            this.precio = precio;
            this.impuesto = impuesto;
            this.Anno = anno;
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

        public List<MarcaVehiculo> Marcas
        {
            get
            {
                return marcas;
            }

            set
            {
                marcas = value;
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

        public int Anno
        {
            get
            {
                return anno;
            }

            set
            {
                anno = value;
            }
        }

        public RepuestoVehiculo()
        {
        }
        public override string ToString()
        {
            return this.Id + " " + this.Repuesto + " " + this.Precio + " " + "" + impuesto + " " + marcas;
        }


    }
}
