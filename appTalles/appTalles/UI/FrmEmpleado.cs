using ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Vista
{
    public partial class FrmEmpleado : Form
    {
        private ENT.Empleado EntEmpleado;
        private BLL.Empleado BllEmpledo;
        private List<ENT.Empleado> empleados;
        public FrmEmpleado()
        {
            EntEmpleado = new ENT.Empleado();
            BllEmpledo = new BLL.Empleado();
            empleados = new List<ENT.Empleado>();
            InitializeComponent();
        }


        private void grdEmpleado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int fila = this.grdEmpleado.CurrentRow.Index;
            if (grdEmpleado.RowCount > 0)
            {
                EntEmpleado.Id = Int32.Parse(grdEmpleado[0, fila].Value.ToString());
                txtnombre.Text = (grdEmpleado[1, fila].Value.ToString());
                txtApellido.Text = (grdEmpleado[2, fila].Value.ToString());
                txtDireccion.Text = (grdEmpleado[3, fila].Value.ToString());
                txtTelefonoResodencia.Text = (grdEmpleado[4, fila].Value.ToString());
                txtTelefonoCelular.Text = (grdEmpleado[5, fila].Value.ToString());
                string puesto = (grdEmpleado[6, fila].Value.ToString());
                string permiso = (grdEmpleado[7, fila].Value.ToString());
                string usuario = (grdEmpleado[8, fila].Value.ToString());
                string contraseña = (grdEmpleado[9, fila].Value.ToString());
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
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (rbBuscarNombre.Checked)
                    {
                        buscar(txtBuscar.Text, "nombre");
                    }
                    if (rbBuscarPermiso.Checked)
                    {
                        buscar(txtBuscar.Text,"permiso");
                    }
                    if (rbBuscarPuesto.Checked)
                    {
                        buscar(txtBuscar.Text,"trabajo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscar(string valor, string columna)
        {
            try
            {
                empleados.Clear();
                empleados = BllEmpledo.buscarStringEmpleado(valor, columna);
                this.grdEmpleado.DataSource = empleados;
                txtCantidadRegistros.Text = "" + empleados.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            txtSeleccion.Text = "";
            EntEmpleado = new ENT.Empleado();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                getEmpleado();
                BllEmpledo.insertarEmpledo(EntEmpleado);
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRegrescar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void brnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdEmpleado.Rows.Count > 0)
                {
                    int fila = this.grdEmpleado.CurrentRow.Index;
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar a " + this.grdEmpleado[1, fila].Value.ToString() + " " + this.grdEmpleado[2, fila].Value.ToString(), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        BllEmpledo.eliminarEmpleado(EntEmpleado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarDatos();
            cargar();
        }
        private void seleccionEmpleado(object sender, MouseEventArgs e)
        {
            if (this.grdEmpleado.Rows.Count > 0)
            {
                int fila = this.grdEmpleado.CurrentRow.Index;
                EntEmpleado.Id = (Int32.Parse(this.grdEmpleado[0, fila].Value.ToString()));
                txtSeleccion.Text = this.grdEmpleado[1, fila].Value.ToString() + " " + this.grdEmpleado[2, fila].Value.ToString();
            }
        }
        public void cargar()
        {
            try
            {
                empleados = BllEmpledo.cargarEmpleados();
                grdEmpleado.DataSource = empleados;
                txtCantidadRegistros.Text = "" + empleados.Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ENT.Empleado getEmpleado()
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
            EntEmpleado.Nombre = txtnombre.Text;
            EntEmpleado.Apellido = txtApellido.Text;
            EntEmpleado.Direccion = txtDireccion.Text;
            EntEmpleado.TelefonoResidencia = txtTelefonoResodencia.Text;
            EntEmpleado.TelefonoCelular = txtTelefonoCelular.Text;
            EntEmpleado.Puesto = puesto;
            string temp = PermisoNuevo();
            EntEmpleado.Permiso = temp;
            EntEmpleado.Usuario = txtusuario.Text;
            EntEmpleado.Contrasenna = txtcontraseña.Text;
            return EntEmpleado;
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
    }
}

