using Datos;
using Logica;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Logica;
using NpgsqlTypes;
using Npgsql;
using System.Data;


namespace Datos
{
    public class EmpledoD

    {
        private AccesoDatosPostgre conexion;
        private bool error;
        private string errorMsg;

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

        public EmpledoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.Error = false;
            this.ErrorMsg = "";
        }
        public bool agregarEmpleado(Empleado pEmpleado)
        {
            limpiarError();

            try
            {
                DataSet dsetEmpleado;

                string sql = "insert into empleado (nombre, apellido, direccion, telefono1, telefono2, trabajo, permiso, contrasenna, usuario) values( @nombre, @apellido, @direccion, @telefono1, @telefono2, @trabajo, @permiso, @contrasenna, @usuario)";
                NpgsqlParameter[] parametros = new NpgsqlParameter[9];
                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@nombre";
                parametros[0].Value = pEmpleado.Nombre;

                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[1].ParameterName = "@apellido";
                parametros[1].Value = pEmpleado.Apellido;

                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[2].ParameterName = "@direccion";
                parametros[2].Value = pEmpleado.Direccion;

                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[3].ParameterName = "@telefono1";
                parametros[3].Value = pEmpleado.TelefonoResidencia;

                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[4].ParameterName = "@telefono2";
                parametros[4].Value = pEmpleado.TelefonoCelular;

                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[5].ParameterName = "@trabajo";
                parametros[5].Value = pEmpleado.Puesto;

                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[6].ParameterName = "@permiso";
                parametros[6].Value = pEmpleado.Permiso;

                parametros[7] = new NpgsqlParameter();
                parametros[7].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[7].ParameterName = "@contrasenna";
                parametros[7].Value = pEmpleado.Contrasenna;

                parametros[8] = new NpgsqlParameter();
                parametros[8].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[8].ParameterName = "@usuario";
                parametros[8].Value = pEmpleado.Usuario;

                dsetEmpleado = this.conexion.ejecutarDataSetSQL(sql, parametros);

                if (conexion.IsError)
                {
                    Error = false;
                    this.ErrorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                Error = false;
                ErrorMsg = e.Message;
            }
            return Error;
        }
        public Empleado buscarUser(Empleado empleado)
        {
            limpiarError();
            Empleado pEmpleados = new Empleado();
            try
            {

                DataSet dsetEmpleados;
                string sql = "select * from empleado where usuario= '" + empleado.Usuario + "' and contrasenna='" + empleado.Contrasenna + "'";

                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);
                foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                {
                    pEmpleados.Id = (Convert.ToInt32(tupla["id_empleado"].ToString()));
                    pEmpleados.Nombre = tupla["nombre"].ToString();
                    pEmpleados.Apellido = tupla["apellido"].ToString();
                    pEmpleados.Direccion = tupla["direccion"].ToString();
                    pEmpleados.TelefonoCelular = tupla["telefono1"].ToString();
                    pEmpleados.TelefonoCelular = tupla["telefono2"].ToString();
                    pEmpleados.Puesto = tupla["trabajo"].ToString();
                    pEmpleados.Permiso = tupla["permiso"].ToString();
                    pEmpleados.Contrasenna = tupla["contrasenna"].ToString();
                    pEmpleados.Usuario = tupla["usuario"].ToString();

                }
            }


            catch (Exception e)
            {
                Error = false;
                ErrorMsg = e.Message;
            }

            return pEmpleados;

        }

        public List<Empleado> ObtenerEmpleados(ref bool estado)
        {
            estado = true;
            List<Empleado> empleados = new List<Empleado>();
            DataSet dsetEmpleados;
            string sql = "select * from empleado";

            dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
            {
                Empleado pEmpleados = new Empleado(Int32.Parse(tupla["id_empleado"].ToString()), tupla["nombre"].ToString(),
                    tupla["apellido"].ToString(), tupla["direccion"].ToString(), tupla["telefono1"].ToString(),
                     tupla["telefono2"].ToString(), tupla["trabajo"].ToString(), tupla["permiso"].ToString(),
                     tupla["usuario"].ToString(), tupla["contrasenna"].ToString());
                empleados.Add(pEmpleados);

            }
            return empleados;
        }
        public bool borrarEmpleado(Empleado pEmpleado)
        {
            limpiarError();
            try
            {
                string sql = "delete from empleado where id_empleado = @id_empleado";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_empleado";
                parametros[0].Value = pEmpleado.Id;

                this.conexion.ejecutarSQL(sql, parametros);
                if (conexion.IsError)
                {
                    errorMsg = this.conexion.ErrorDescripcion;
                    return false;
                }

            }
            catch (Exception e)
            {
                Error = false;
                this.ErrorMsg = e.Message;
            }
            return Error;
        }
        public bool actualizar(Empleado pEmpleado)
        {
            limpiarError();

            try
            {
                string sql = "update empleado set nombre = @nombre ,apellido = @apellido , direccion = @direccion, telefono1 = @telefono1, telefono2 = @telefono2 , trabajo = @trabajo ,permiso = @permiso, contrasenna = @contrasenna , usuario = @usuario where id_empleado = @id_empleado";
                NpgsqlParameter[] parametros = new NpgsqlParameter[10];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[0].ParameterName = "@nombre";
                parametros[0].Value = pEmpleado.Nombre;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[1].ParameterName = "@apellido";
                parametros[1].Value = pEmpleado.Apellido;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[2].ParameterName = "@direccion";
                parametros[2].Value = pEmpleado.Direccion;
                parametros[3] = new NpgsqlParameter();
                parametros[3].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[3].ParameterName = "@telefono1";
                parametros[3].Value = pEmpleado.TelefonoResidencia;
                parametros[4] = new NpgsqlParameter();
                parametros[4].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[4].ParameterName = "@telefono2";
                parametros[4].Value = pEmpleado.TelefonoCelular;
                parametros[5] = new NpgsqlParameter();
                parametros[5].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[5].ParameterName = "@trabajo";
                parametros[5].Value = pEmpleado.Puesto;
                parametros[6] = new NpgsqlParameter();
                parametros[6].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[6].ParameterName = "@permiso";
                parametros[6].Value = pEmpleado.Permiso;
                parametros[7] = new NpgsqlParameter();
                parametros[7].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[7].ParameterName = "@contrasenna";
                parametros[7].Value = pEmpleado.Contrasenna;
                parametros[8] = new NpgsqlParameter();
                parametros[8].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[8].ParameterName = "@usuario";
                parametros[8].Value = pEmpleado.Usuario;
                parametros[9] = new NpgsqlParameter();
                parametros[9].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[9].ParameterName = "@id_empleado";
                parametros[9].Value = pEmpleado.Id;


                this.conexion.ejecutarSQL(sql, parametros);
                if (conexion.IsError)
                {
                    errorMsg = this.conexion.ErrorDescripcion;
                    return false;
                }

            }
            catch (Exception e)
            {
                Error = false;
                ErrorMsg = e.Message;
            }

            return Error;
        }
        public List<Empleado> buscarEmpleadoss(string valor1)
        {
            limpiarError();
            List<Empleado> empleados = new List<Empleado>();
            DataSet dsetEmpleados;
            string sql = "select * from empleado where nombre =  '" + valor1 + "'";
            try
            {

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@nombre";
                parametros[0].Value = valor1;

                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);



                foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
                {
                    Empleado pEmpleados = new Empleado(Convert.ToInt32(tupla["id_empleado"].ToString()), tupla["nombre"].ToString(),
                        tupla["apellido"].ToString(), tupla["direccion"].ToString(), tupla["telefono1"].ToString(),
                         tupla["telefono2"].ToString(), tupla["trabajo"].ToString(), tupla["permiso"].ToString(),
                        tupla["usuario"].ToString(), tupla["contrasenna"].ToString());
                    empleados.Add(pEmpleados);
                }

                if (conexion.IsError)
                {
                    ErrorMsg = this.conexion.ErrorDescripcion;
                    Error = false;
                }
            }



            catch (Exception e)
            {
                Error = false;
                ErrorMsg = e.Message;
            }

            return empleados;
        }



        public bool cambioContrasenna(Empleado empleado, string nueva)
        {
            limpiarError();

            try
            {
                string sql = " update empleado set  contrasenna = @contra  where  usuario = @usuario and contrasenna = @contrasenna";
                NpgsqlParameter[] parametros = new NpgsqlParameter[3];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[0].ParameterName = "@contrasenna";
                parametros[0].Value = empleado.Contrasenna;
                parametros[1] = new NpgsqlParameter();
                parametros[1].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[1].ParameterName = "@usuario";
                parametros[1].Value = empleado.Usuario;
                parametros[2] = new NpgsqlParameter();
                parametros[2].NpgsqlDbType = NpgsqlDbType.Text;
                parametros[2].ParameterName = "@contra";
                parametros[2].Value = nueva;


                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    Error = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                error = false;
                errorMsg = e.Message;
            }

            return error;
        }
    }
}

