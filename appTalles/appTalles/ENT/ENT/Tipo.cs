using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class TipoVehiculo
    {
        private int id;
        private string tipo;

        public TipoVehiculo()
        {
        }

        public TipoVehiculo(int id, string tipo)
        {
            this.Id = id;
            this.tipo = tipo;
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

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }

        }

        public override string ToString()
        {
            return this.tipo;
        }
    }




}
