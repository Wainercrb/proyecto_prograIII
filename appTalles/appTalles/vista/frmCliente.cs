using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;

namespace Vista


{
    public partial class frmCliente : Form
    {

        private Cliente cliente;
        private ClienteD oClienteD;

        public frmCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            oClienteD = new ClienteD();
            cargarDataGriew();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtApellidoPaterno.Text == "" || txtApellidoMaterno.Text == "" || txtTelefono_casa.Text == "" || txtTelefono_oficina.Text == "" || txtTelefono_celular.Text == "")
            {
                MessageBox.Show("Debes ingresar una marca", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cliente.Id > 0)
            {
                cliente.Cedula = txtNombre.Text;
                cliente.Nombre = txtCedula.Text;
                cliente.ApellidoPaterno = txtApellidoPaterno.Text;
                cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                cliente.TelefonoCasa = txtTelefono_casa.Text;
                cliente.TelefonoCelular = txtTelefono_celular.Text;
                cliente.TelefonoOficina = txtTelefono_oficina.Text;

                if (!oClienteD.editarCliente(cliente))
                {
                    txtMensaje.Text = "cliente " + txtNombre.Text + " " + txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text + " editado correctamente.";
                    cargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al acualizar el cliente " + oClienteD.ErrorMsg, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                Cliente cliente = new Cliente(0, txtCedula.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtTelefono_casa.Text, txtTelefono_oficina.Text, txtTelefono_celular.Text);

                if (!oClienteD.agregarCliente(cliente))
                {
                    txtMensaje.Text = "cliente " + txtNombre.Text + " " + txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text + " " + "agregado.";
                    cargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente " + oClienteD.ErrorMsg, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            limpiarDatos();
        }

        private void Editar(object sender, MouseEventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdClientes.Rows.Count > 0)
            {
                int fila = this.grdClientes.CurrentRow.Index;
                txtNombre.Text = grdClientes[2, fila].Value.ToString();
                txtCedula.Text = grdClientes[1, fila].Value.ToString();
                txtApellidoPaterno.Text = grdClientes[3, fila].Value.ToString();
                txtApellidoMaterno.Text = grdClientes[4, fila].Value.ToString();
                txtTelefono_casa.Text = grdClientes[5, fila].Value.ToString();
                txtTelefono_oficina.Text = grdClientes[6, fila].Value.ToString();
                txtTelefono_celular.Text = grdClientes[7, fila].Value.ToString();
                cliente.Id = Int32.Parse(grdClientes[0, fila].Value.ToString());
            }
        }
        private void cargarClientes()
        {
            List<Cliente> lsCliente = oClienteD.obtenerClientes();
            txtCantidadRegistros.Text = "" + lsCliente.Count();
            if (lsCliente.ToString() == "")
            {
                txtMensaje.Text = "No hay marcas registrados";
            }
            this.grdClientes.DataSource = lsCliente;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdClientes.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    int fila = this.grdClientes.CurrentRow.Index;
                    cliente = new Cliente();
                    cliente = new Cliente(Int32.Parse(this.grdClientes[0, fila].Value.ToString()), grdClientes[2, fila].Value.ToString(), grdClientes[1, fila].Value.ToString(), grdClientes[3, fila].Value.ToString(), grdClientes[4, fila].Value.ToString(), grdClientes[5, fila].Value.ToString(), grdClientes[6, fila].Value.ToString(), grdClientes[7, fila].Value.ToString());
                    if (!oClienteD.borrarCliente(cliente))
                    {
                        txtMensaje.Text = " cliente  eliminada correctamente";
                        cargarClientes();
                    }
                    else
                    {

                        MessageBox.Show("Error al eliminar el cliente " + oClienteD.ErrorMsg, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            limpiarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDataGriew()
        {
            this.grdClientes.Columns["Id"].Visible = false;
            this.grdClientes.Columns["Cedula"].Width = 65;
            this.grdClientes.Columns["Nombre"].Width = 65;
            this.grdClientes.Columns["ApellidoPaterno"].Width = 60;
            this.grdClientes.Columns["ApellidoMaterno"].Width = 60;
            this.grdClientes.Columns["TelefonoCasa"].Width = 60;
            this.grdClientes.Columns["TelefonoOficina"].Width = 60;
            this.grdClientes.Columns["TelefonoCelular"].Width = 60;
        }

        private void limpiarDatos()
        {
            cliente = new Cliente();
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono_casa.Text = "";
            txtTelefono_celular.Text = "";
            txtTelefono_oficina.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}
