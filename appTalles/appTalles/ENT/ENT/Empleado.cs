using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefonoResidencia;
        private string telefonoCelular;
        private string puesto;
        private string permiso;
        private string usuario;
        private string contrasenna;

        public Empleado(int id, string nombre, string apellido, string direccion, string telefonoResidencia, string telefonoCelular, string puesto, string permiso, string usuario, string contrasenna)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefonoResidencia = telefonoResidencia;
            this.telefonoCelular = telefonoCelular;
            this.puesto = puesto;
            this.permiso = permiso;
            this.usuario = usuario;
            this.contrasenna = contrasenna;
        }

        public Empleado()
        {
        }

        public Empleado(string nombre, string apellido, string direccion, string telefonoResidencia, string telefonoCelular, string puesto, string permiso, string usuario, string contrasenna)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefonoResidencia = telefonoResidencia;
            this.telefonoCelular = telefonoCelular;
            this.puesto = puesto;
            this.permiso = permiso;
            this.usuario = usuario;
            this.contrasenna = contrasenna;
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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string TelefonoResidencia
        {
            get
            {
                return telefonoResidencia;
            }

            set
            {
                telefonoResidencia = value;
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

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public string Permiso
        {
            get
            {
                return permiso;
            }

            set
            {
                permiso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contrasenna
        {
            get
            {
                return contrasenna;
            }

            set
            {
                contrasenna = value;
            }
        }

        public override string ToString()
        {
            return  this.Nombre + " " + this.Apellido;
        }
    }
}
