using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class OrdenRepuesto:RepuestoVehiculo
    {

        private int cantidad;


        public OrdenRepuesto(int id, string repuesto, double precio, MarcaVehiculo marca, Parametro parametro) : base(id, repuesto, precio, marca, parametro)
        {
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

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
