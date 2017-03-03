using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string cedula;
        private string telefonoOficina;
        private string telefonoCasa;
        private string telefonoCelular;
        public Cliente(int id, string nombre, string cedula, string telefonoOficina, string telefonoCasa, string telefonoCelular)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.TelefonoOficina = telefonoOficina;
            this.TelefonoCasa = telefonoCasa;
            this.TelefonoCelular = telefonoCelular;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string TelefonoOficina
        {
            get
            {
                return telefonoOficina;
            }

            set
            {
                telefonoOficina = value;
            }
        }

        public string TelefonoCasa
        {
            get
            {
                return telefonoCasa;
            }

            set
            {
                telefonoCasa = value;
            }
        }

        public string TelefonoCelular
        {
            get
            {
                return telefonoCelular;
            }

            set
            {
                telefonoCelular = value;
            }
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

        public override string ToString()
        {
            return this.id+" "+this.nombre + " " + this.Cedula + " " + this.telefonoCasa + " " + this.telefonoOficina + " " + this.telefonoCelular;

        }

    }
}
