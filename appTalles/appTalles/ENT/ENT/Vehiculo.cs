using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Vehiculo
    {

        private int id;
        private string placa;
        private int anno;
        private int cilindraje;
        private int numeroMotor;
        private int numeroChazis;
        private string tipoCombustible;
        private string  estado;
        private MarcaVehiculo marca;
        private Cliente cliente;
        private TipoVehiculo tipo;

        public Vehiculo(int id, string placa, int anno, int cilindraje, int numeroMotor, int numeroChazis, string tipoCombustible, string estado, MarcaVehiculo marca, Cliente cliente, TipoVehiculo tipo)
        {
            this.id = id;
            this.placa = placa;
            this.anno = anno;
            this.cilindraje = cilindraje;
            this.numeroMotor = numeroMotor;
            this.numeroChazis = numeroChazis;
            this.tipoCombustible = tipoCombustible;
            this.estado = estado;
            this.marca = marca;
            this.cliente = cliente;
            this.tipo = tipo;
        }

        public Vehiculo()
        {
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

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
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

        public int Cilindraje
        {
            get
            {
                return cilindraje;
            }

            set
            {
                cilindraje = value;
            }
        }

        public int NumeroMotor
        {
            get
            {
                return numeroMotor;
            }

            set
            {
                numeroMotor = value;
            }
        }

        public int NumeroChazis
        {
            get
            {
                return numeroChazis;
            }

            set
            {
                numeroChazis = value;
            }
        }

        public string TipoCombustible
        {
            get
            {
                return tipoCombustible;
            }

            set
            {
                tipoCombustible = value;
            }
        }

        public string  Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public MarcaVehiculo Marca
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

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public TipoVehiculo Tipo
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
            return "Placa"+ this.placa + " ,año" + this.anno + "." ;
        }
    }
}
 