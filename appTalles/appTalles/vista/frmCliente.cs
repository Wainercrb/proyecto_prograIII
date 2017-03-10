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
        public frmCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ClienteD oCliente = new ClienteD();
            txtMensaje.Text = "";
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtApellidoPaterno.Text == "" || txtApellidoMaterno.Text == "" || txtTelefono_casa.Text == "" || txtTelefono_oficina.Text == "" || txtTelefono_celular.Text == "")
            {
                MessageBox.Show("Debes ingresar una marca", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cliente.Id > 0)
            {
                cliente.Cedula = txtCedula.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.ApellidoPaterno = txtApellidoPaterno.Text;
                cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                cliente.TelefonoCasa = txtTelefono_casa.Text;
                cliente.TelefonoCelular = txtTelefono_oficina.Text;
                cliente.TelefonoOficina = txtTelefono_oficina.Text;
                MessageBox.Show(cliente.ToString());
                oCliente.editarCliente(cliente);

                if (oCliente.ErrorMsg != "")
                {
                    txtMensaje.Text = oCliente.ErrorMsg;
                }
                else
                {
                    txtMensaje.Text = "cliente " + txtNombre.Text + " " + txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text + " editado correctamente.";
                    cargarClientes();
                }

            }
            else
            {
                Cliente cliente = new Cliente(0, txtCedula.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtTelefono_casa.Text, txtTelefono_oficina.Text, txtTelefono_celular.Text);
                oCliente.agregarCliente(cliente);
                if (oCliente.ErrorMsg != "")
                {
                    txtMensaje.Text = oCliente.ErrorMsg;
                }
                else
                {
                    txtMensaje.Text = "cliente " + txtNombre.Text + " " + txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text + " " + "agregado.";
                    cargarClientes();
                }
            }

            cliente = new Cliente();
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono_casa.Text = "";
            txtTelefono_celular.Text = "";
            txtTelefono_oficina.Text = "";
        }

        private void cargarClientes()
        {


            ClienteD oclienteD = new ClienteD();

            List<Cliente> lsCliente = oclienteD.obtenerClientes();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdClientes.Rows.Count > 0)
            {
                cliente = new Cliente();
                DialogResult respuesta = MessageBox.Show("¿Está seguro de editar esta marca?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.grdClientes.CurrentRow.Index;
                    cliente = new Cliente();
                    cliente = new Cliente(Int32.Parse(this.grdClientes[0, fila].Value.ToString()), grdClientes[1, fila].Value.ToString(), grdClientes[2, fila].Value.ToString(), grdClientes[3, fila].Value.ToString(), grdClientes[4, fila].Value.ToString(), grdClientes[5, fila].Value.ToString(), grdClientes[6, fila].Value.ToString(), grdClientes[7, fila].Value.ToString());

                    txtCedula.Text = cliente.Cedula;
                    txtNombre.Text = cliente.Nombre;
                    txtApellidoPaterno.Text = cliente.ApellidoPaterno;
                    txtApellidoMaterno.Text = cliente.ApellidoMaterno;
                    txtTelefono_casa.Text = cliente.TelefonoCasa;
                    txtTelefono_celular.Text = cliente.TelefonoCelular;
                    txtTelefono_oficina.Text = cliente.TelefonoOficina;


                }
            }
        }
    }
}
