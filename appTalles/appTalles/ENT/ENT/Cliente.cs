using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ENT
{
    public class Cliente
    {
        private int id;
        private string cedula;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string telefonoCasa;
        private string telefonoOficina;
        private string telefonoCelular;

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

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }

            set
            {
                apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }

            set
            {
                apellidoMaterno = value;
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

        public Cliente(int id, string nombre, string cedula, string apellidoPaterno, string apellidoMaterno, string telefonoCasa, string telefonoOficina, string telefonoCelular)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.TelefonoCasa = telefonoCasa;
            this.TelefonoOficina = telefonoOficina;
            this.TelefonoCelular = telefonoCelular;
        }

        public Cliente()
        {
        }

        public override string ToString()
        {
            return this.cedula + " " + this.Nombre + " " + this.ApellidoPaterno + " " + this.ApellidoMaterno;

        }

    }
}
