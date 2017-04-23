using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Modelo
    {

        private int id;
        private string modelo;

        public Modelo()
        {
        }

        public Modelo(int id, string modelo)
        {
            this.id = id;
            this.modelo = modelo;
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

        public string pModelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }
        public override string ToString()
        {
           return modelo;
        }

    }
  
}
