using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Rrepuesto: RepuestoVehiculo
    {
        private int id;
        private int cantidad;
        private double totalRepuestos;
     

        public Rrepuesto(int id, int cantidad, double totalRepuestos)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.totalRepuestos = totalRepuestos;
        }

        public int Id1
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
        public override string ToString()
        {
            return base.ToString();

        }
    }
}
