using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using NpgsqlTypes;
using Npgsql;
using System.Data;

namespace DAL
{
    public class Vehiculo
    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;
        public Vehiculo()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }
        //Metodo limpia las variable de error
        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        //Metodo carga un dataset con los vehiculos registrados y los retorna en una lista
        public List<ENT.Vehiculo> obtenerVehiculos()
        {
            this.limpiarError();
            List<ENT.Vehiculo> vehiculos = new List<ENT.Vehiculo>();
            DataSet dsetVehiculos;
            string sql = "select v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                         "m.id_marca as id_marca, m.marca as marca, " +
                         "t.id_tipo as id_tipo, t.tipo as tipo, " +
                         "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                         "from " + this.conexion.Schema + "vehiculo v, " + this.conexion.Schema + " marca m, " + this.conexion.Schema + "tipo t, " + this.conexion.Schema + "cliente c " +
                         "where v.fk_marca = m.id_marca and " +
                         "v.fk_tipo = t.id_tipo and " +
                         "v.fk_cliente = c.id_cliente";
            dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);
            if (!this.conexion.IsError)
            {
                if (dsetVehiculos.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
                    {
                        MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new ENT.Modelo());
                        ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                        TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                        ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                        vehiculos.Add(oVehiculo);
                    }
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return vehiculos;
        }
        //Metodo agrega el vehículo que recibe por parametro
        //a la base de datos
        public void agregarVehiculo(ENT.Vehiculo vehiculo)
        {
            limpiarError();
            string sql = "insert into " + this.conexion.Schema + "vehiculo (placa, anno, cilindraje, numero_motor, numero_chazis, combustible, estado, fk_marca, fk_cliente, fk_tipo) " +
                         "values (@placa, @anno, @cilindraje, @numero_motor, @numero_chazis, @combustible, @estado, @fk_marca, @fk_cliente, @fk_tipo); ";
            Parametro prm = new Parametro();
            prm.agregarParametro("@placa", NpgsqlDbType.Varchar, vehiculo.Placa);
            prm.agregarParametro("@anno", NpgsqlDbType.Integer, vehiculo.Anno);
            prm.agregarParametro("@cilindraje", NpgsqlDbType.Integer, vehiculo.Cilindraje);
            prm.agregarParametro("@numero_motor", NpgsqlDbType.Integer, vehiculo.NumeroMotor);
            prm.agregarParametro("@numero_chazis", NpgsqlDbType.Integer, vehiculo.NumeroChazis);
            prm.agregarParametro("@combustible", NpgsqlDbType.Varchar, vehiculo.TipoCombustible);
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, vehiculo.Estado);
            prm.agregarParametro("@fk_marca", NpgsqlDbType.Integer, vehiculo.Marca.Id);
            prm.agregarParametro("@fk_cliente", NpgsqlDbType.Integer, vehiculo.Cliente.Id);
            prm.agregarParametro("fk_tipo", NpgsqlDbType.Integer, vehiculo.Tipo.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo edita el vehículo por los valores nuevos que le ingresan
        //por parametro 
        public void editarVehiculo(ENT.Vehiculo vehiculo)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "vehiculo SET placa = @placa, anno = @anno ,cilindraje = @cilindraje, numero_motor = @numero_motor, numero_chazis = @numero_chazis, combustible = @combustible, estado = @estado, fk_marca = @fk_marca, fk_cliente = @fk_cliente, fk_tipo = @fk_tipo where id_vehiculo = @id_vehiculo";
            Parametro prm = new Parametro();
            prm.agregarParametro("@placa", NpgsqlDbType.Varchar, vehiculo.Placa);
            prm.agregarParametro("@anno", NpgsqlDbType.Integer, vehiculo.Anno);
            prm.agregarParametro("@cilindraje", NpgsqlDbType.Integer, vehiculo.Cilindraje);
            prm.agregarParametro("@numero_motor", NpgsqlDbType.Integer, vehiculo.NumeroMotor);
            prm.agregarParametro("@numero_chazis", NpgsqlDbType.Integer, vehiculo.NumeroChazis);
            prm.agregarParametro("@combustible", NpgsqlDbType.Varchar, vehiculo.TipoCombustible);
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, vehiculo.Estado);
            prm.agregarParametro("@fk_marca", NpgsqlDbType.Integer, vehiculo.Marca.Id);
            prm.agregarParametro("@fk_cliente", NpgsqlDbType.Integer, vehiculo.Cliente.Id);
            prm.agregarParametro("fk_tipo", NpgsqlDbType.Integer, vehiculo.Tipo.Id);
            prm.agregarParametro("@id_vehiculo", NpgsqlDbType.Numeric, vehiculo.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo elimina de la db el valor que recibe por parametro
        public void borrarVehiculo(ENT.Vehiculo Vehiculo)
        {
            limpiarError();
            string sql = "DELETE FROM " + this.conexion.Schema + "vehiculo WHERE id_vehiculo = @id_vehiculo";
            Parametro prm = new Parametro();
            prm.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, Vehiculo.Id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo actualiza el estado del vehículo x por el valor
        //que recibe por parametro
        public void actualizarEstado(int id, string estado)
        {
            limpiarError();
            string sql = "UPDATE " + this.conexion.Schema + "vehiculo SET estado = @estado WHERE id_vehiculo = @id_vehiculo";
            Parametro prm = new Parametro();
            prm.agregarParametro("@estado", NpgsqlDbType.Varchar, estado);
            prm.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, id);
            this.conexion.ejecutarSQL(sql, prm.obtenerParametros());
            if (this.conexion.IsError)
            {
                this.Error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
        }
        //Metodo busca y carga un dataset con un valor especifico y lo retorna 
        //con una lista
        public List<ENT.Vehiculo> BuscarStringVehiculo(string valor, string columna)
        {
            limpiarError();
            List<ENT.Vehiculo> vehiculos = new List<ENT.Vehiculo>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@" + columna, NpgsqlDbType.Varchar, valor);
            string sql = "select v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                      "m.id_marca as id_marca, m.marca as marca, " +
                      "t.id_tipo as id_tipo, t.tipo as tipo, " +
                      "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                      "from " + this.conexion.Schema + "vehiculo v, " + this.conexion.Schema + "marca m, " + this.conexion.Schema + "tipo t, " + this.conexion.Schema + "cliente c " +
                      "where (v.fk_marca = m.id_marca) and " +
                      "(v.fk_tipo = t.id_tipo) and (v." + columna + " = " + "@" + columna + ") and " +
                      "(v.fk_cliente = c.id_cliente)";
            DataSet dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql, "vehiculo", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new ENT.Modelo());
                    ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["nombre"].ToString(), tupla["cedula"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                    TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                    ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                    vehiculos.Add(oVehiculo);
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return vehiculos;
        }
        //Metodo busca y carga un dataset con un valor especifico y lo retorna 
        //con una lista
        public List<ENT.Vehiculo> BuscarIntVehiculo(int valor, string columna)
        {
            limpiarError();
            List<ENT.Vehiculo> vehiculos = new List<ENT.Vehiculo>();
            Parametro prm = new Parametro();
            prm.agregarParametro("@" + columna, NpgsqlDbType.Integer, valor);
            string sql = "select v.id_vehiculo as id_vehiculo,v.anno as anno, v.placa as placa, v.cilindraje as cilindraje, v.numero_motor as numero_motor, v.numero_chazis as numero_chazis, v.combustible as combustible, v.estado as estado, v.fk_marca as fk_marca, v.fk_cliente as fk_cliente, fk_tipo as fk_tipo," +
                      "m.id_marca as id_marca, m.marca as marca, " +
                      "t.id_tipo as id_tipo, t.tipo as tipo, " +
                      "c.id_cliente as id_cliente, c.cedula as cedula, c.nombre as nombre, c.apellido as apellido, c.apellido2 as apellido2, c.telefono_casa as telefono_casa, c.telefono_oficina as telefono_oficina, c.telefono_celular as telefono_celular " +
                      "from " + this.conexion.Schema + "vehiculo v, " + this.conexion.Schema + "marca m, " + this.conexion.Schema + "tipo t, " + this.conexion.Schema + "cliente c " +
                      "where (v.fk_marca = m.id_marca) and " +
                      "(v.fk_tipo = t.id_tipo) and (v." + columna + " >= " + "@" + columna + ") and " +
                      "(v.fk_cliente = c.id_cliente)";
            DataSet dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql, "vehiculo", prm.obtenerParametros());
            if (!this.conexion.IsError)
            {
                foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
                {
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(tupla["id_marca"].ToString()), tupla["marca"].ToString(), new ENT.Modelo());
                    ENT.Cliente oCliente = new ENT.Cliente(int.Parse(tupla["id_cliente"].ToString()), tupla["nombre"].ToString(), tupla["cedula"].ToString(), tupla["apellido"].ToString(), tupla["apellido2"].ToString(), tupla["telefono_casa"].ToString(), tupla["telefono_celular"].ToString(), tupla["telefono_oficina"].ToString());
                    TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(tupla["id_tipo"].ToString()), tupla["tipo"].ToString());
                    ENT.Vehiculo oVehiculo = new ENT.Vehiculo(int.Parse(tupla["id_vehiculo"].ToString()), tupla["placa"].ToString(), int.Parse(tupla["anno"].ToString()), int.Parse(tupla["cilindraje"].ToString()), int.Parse(tupla["numero_motor"].ToString()), int.Parse(tupla["numero_chazis"].ToString()), tupla["combustible"].ToString(), tupla["estado"].ToString(), oMarca, oCliente, oTipo);
                    vehiculos.Add(oVehiculo);
                }
            }
            else
            {
                this.error = true;
                this.errorMsg = this.conexion.ErrorDescripcion;
            }
            return vehiculos;
        }
        public string ErrorMsg
        {
            get
            {
                return errorMsg;
            }

            set
            {
                errorMsg = value;
            }
        }
        public bool Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }
    }
}
