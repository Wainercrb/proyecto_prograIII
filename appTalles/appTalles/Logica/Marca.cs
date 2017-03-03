using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MarcaVehiculo
    {
        private int id;
        private string marca;

        public MarcaVehiculo(int id, string marca)
        {
            this.id = id;
            this.marca = marca;
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

        public string Marca
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

        public override string ToString()
        {
            return this.id + " " + this.marca;
        }
    }
}
