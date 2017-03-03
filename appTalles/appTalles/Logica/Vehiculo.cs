using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Vehiculo
    {

        private int id;
        private string placa;
        private string cilindraje;
        private double numeroMotor;
        private int numeroChazis;
        private string tipoCombustible;
        private Cliente cliente;
        private MarcaVehiculo marca;
        private TipoVehiculo tipo;

        public Vehiculo(int id, string placa, string cilindraje, double numeroMotor, int numeroChazis, string tipoCombustible, Cliente cliente, MarcaVehiculo marca, TipoVehiculo tipo)
        {
            this.id = id;
            this.placa = placa;
            this.cilindraje = cilindraje;
            this.numeroMotor = numeroMotor;
            this.numeroChazis = numeroChazis;
            this.tipoCombustible = tipoCombustible;
            this.cliente = cliente;
            this.marca = marca;
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

        public string Cilindraje
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

        public double NumeroMotor
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
            return this.id + " " + this.placa + " " + this.cilindraje + " " + this.NumeroMotor +" " + this.numeroChazis + " " + this.tipoCombustible +" "+ this.cliente + " " + this.marca + " " + this.tipo;
        }
    }
}
