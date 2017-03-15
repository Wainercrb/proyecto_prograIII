using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Vista
{
    public partial class FrmEmpleado : Form
    {

        private Empleado empleado;
        private EmpledoD oEmpledoD;
        public FrmEmpleado()
        {
            empleado = new Empleado();
            oEmpledoD = new EmpledoD();
            InitializeComponent();
            cargarDataGriew();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text == "") || (txtApellido.Text == "") || (txtDireccion.Text == "")
             || (txtTelefonoResodencia.Text == "") || (txtTelefonoCelular.Text == "")
               || (txtcontraseña.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (empleado.Id > 0)
            {
                if (!oEmpledoD.actualizar(getEmpleado()))
                {
                    cargar();
                    MessageBox.Show("Marca Actualizada");
                }
                else
                {
                    MessageBox.Show("Error Actualizando el empleado: " +
                                   oEmpledoD.ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }

            else
            {
                EmpledoD UD = new EmpledoD();
                if (!UD.agregarEmpleado(getEmpleado()))
                {
                    MessageBox.Show("Empleado Agregado Correctamente");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Error agregando el Empleado: " +
                                        UD.ErrorMsg, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            limpiarDatos();
        }
        public Empleado getEmpleado()
        {
            string puesto = "";

            if (rbmecanico.Checked)
            {
                puesto = "Mecanico";
            }
            if (rbCajero.Checked)
            {
                puesto = "cajero";
            }
            if (rbjefe.Checked)
            {
                puesto = "Jefe";
            }
            empleado.Nombre = txtnombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Direccion = txtDireccion.Text;
            empleado.TelefonoResidencia = txtTelefonoResodencia.Text;
            empleado.TelefonoCelular = txtTelefonoCelular.Text;
            empleado.Puesto= puesto;
            string temp = PermisoNuevo();
            empleado.Permiso = temp;
            empleado.Usuario = txtusuario.Text;
            empleado.Contrasenna = txtcontraseña.Text;
            return empleado;
        }
        private string PermisoNuevo()
        {
            string permiso = "";
            if (rbAdministrador.Checked)
            {
                permiso = "Administrador";
            }
            if (rbempleado.Checked)
            {
                permiso = "Empleado";
            }
            return permiso;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void cargar()
        {
            bool estado = true;
            EmpledoD pEmpleado = new EmpledoD();
            //DataSet dsetMarcas = oMarcaD.obtenerDataSetMarcas(ref estado);
            List<Empleado> lsMarcas = pEmpleado.ObtenerEmpleados(ref estado);
            //object[] empleados = pEmpleado.ObtenerEmpleados(ref estado);
            if (estado)
            {
                //this.grdMarcas.DataSource = dsetMarcas.Tables[0];
                this.grdEmpleado.DataSource = lsMarcas;
                txtCantidadRegistros.Text = "" + lsMarcas.Count();
            }
        }

        private void btnElininar_Click(object sender, EventArgs e)
        {

            int fila = this.grdEmpleado.CurrentRow.Index;
            if (this.grdEmpleado.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    fila = this.grdEmpleado.CurrentRow.Index;

                    Empleado pEmpleado = new Empleado(Int32.Parse(this.grdEmpleado[0, fila].Value.ToString()),
                       this.grdEmpleado[1, fila].Value.ToString(), this.grdEmpleado[2, fila].Value.ToString(), this.grdEmpleado[3, fila].Value.ToString(),
                       this.grdEmpleado[4, fila].Value.ToString(), this.grdEmpleado[5, fila].Value.ToString(), this.grdEmpleado[6, fila].Value.ToString(),
                       this.grdEmpleado[7, fila].Value.ToString(), this.grdEmpleado[8, fila].Value.ToString(), this.grdEmpleado[9, fila].Value.ToString());
     
                    if (!oEmpledoD.borrarEmpleado(pEmpleado))
                    {
                        txtMensaje.Text = "Se elimino el empleado correctamente";
                        cargar();
                    }
                    else
                    {
                        MessageBox.Show("Error borrando Empleado: " +
                                   oEmpledoD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            limpiarDatos();
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            cargar();
        }

        private void grdEmpleado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int fila = this.grdEmpleado.CurrentRow.Index;

            if (grdEmpleado.RowCount > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de Actualizar?",
                                                           "Error",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    empleado.Id = Int32.Parse(grdEmpleado[0, fila].Value.ToString());
                    txtnombre.Text = (grdEmpleado[1, fila].Value.ToString());
                    txtApellido.Text = (grdEmpleado[2, fila].Value.ToString());
                    txtDireccion.Text = (grdEmpleado[3, fila].Value.ToString());
                    txtTelefonoResodencia.Text = (grdEmpleado[4, fila].Value.ToString());
                    txtTelefonoCelular.Text = (grdEmpleado[5, fila].Value.ToString());
                    string puesto = (grdEmpleado[6, fila].Value.ToString());
                    string permiso = (grdEmpleado[7, fila].Value.ToString());
                    string usuario = (grdEmpleado[8, fila].Value.ToString());
                    string contraseña = (grdEmpleado[9, fila].Value.ToString());
                    MessageBox.Show("id" + empleado.Id);

                    if (puesto.Equals("Mecanico"))
                    {
                        rbmecanico.Checked = true;

                    }
                    if (puesto.Equals("cajero"))
                    {
                        rbCajero.Checked = true;

                    }
                    if (puesto.Equals("Jefe"))
                    {
                        rbjefe.Checked = true;
                    }
                    if (permiso == "Administrador")
                    {
                        rbAdministrador.Checked = true;
                    }
                    if (permiso.Equals("Empleado"))
                    {
                        rbempleado.Checked = true;
                    }
                    txtusuario.Text = usuario;
                    txtcontraseña.Text = contraseña;

                }


            }
        }


        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtMensaje.Text = "";
                EmpledoD oMarca = new EmpledoD();
                List<Empleado> lsMarcas = oMarca.buscarEmpleadoss(txtBuscar.Text);

                txtCantidadRegistros.Text = "" + lsMarcas.Count();
                if (lsMarcas.Count() <= 0)
                {
                    txtMensaje.Text = "No hay marcas registrados";
                }
                if (oEmpledoD.ErrorMsg != "")
                {
                    MessageBox.Show("Error al buscar" + oEmpledoD.ErrorMsg);
                }
                this.grdEmpleado.DataSource = lsMarcas;

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void limpiarDatos()
        {

            txtnombre.Text = "";
            txtApellido.Text = "";
            txtcontraseña.Text = "";
            txtDireccion.Text = "";
            txtTelefonoCelular.Text = "";
            txtTelefonoResodencia.Text = "";
            txtusuario.Text = "";
            rbmecanico.Checked = true;
            rbAdministrador.Checked = true;
            empleado = new Empleado();


        }

        private void cargarDataGriew() {

            this.grdEmpleado.Columns["Id"].Visible = false;
            this.grdEmpleado.Columns["Nombre"].Width = 60;
            this.grdEmpleado.Columns["Apellido"].Width = 60;
            this.grdEmpleado.Columns["Direccion"].Width = 130;
            this.grdEmpleado.Columns["TelefonoResidencia"].Width = 80;
            this.grdEmpleado.Columns["TelefonoCelular"].Width = 80;
            this.grdEmpleado.Columns["Puesto"].Width = 60;
            this.grdEmpleado.Columns["Permiso"].Width = 60;
            this.grdEmpleado.Columns["Usuario"].Width = 58;
            this.grdEmpleado.Columns["Contrasenna"].Width = 69;
        }
    }
}

