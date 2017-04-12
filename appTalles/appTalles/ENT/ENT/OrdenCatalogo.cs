using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class OrdenCatalogo:Catalogo
    {

        private Empleado empleado;
        private DateTime horaFinal;

        public OrdenCatalogo(int id, string descripcion, double cantidadHoras, double costo) : base(id, descripcion, cantidadHoras, costo)
        {
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

        public DateTime HoraFinal
        {
            get
            {
                return horaFinal;
            }

            set
            {
                horaFinal = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
