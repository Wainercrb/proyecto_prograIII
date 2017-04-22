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
using ENT;

namespace Vista
{
    public partial class frmCliente : Form
    {
        private ENT.Cliente EntCliente;
        private BLL.Cliente BllCliente;
        private List<ENT.Cliente> clientes;

        public frmCliente()
        {
            InitializeComponent();
            EntCliente = new ENT.Cliente();
            BllCliente = new BLL.Cliente();
            clientes = new List<ENT.Cliente>();
        }
        private void Editar(object sender, MouseEventArgs e)
        {
            if (this.grdClientes.Rows.Count >= 0)
            {
                int fila = this.grdClientes.CurrentRow.Index;
                txtNombre.Text = grdClientes[2, fila].Value.ToString();
                txtCedula.Text = grdClientes[1, fila].Value.ToString();
                txtApellidoPaterno.Text = grdClientes[3, fila].Value.ToString();
                txtApellidoMaterno.Text = grdClientes[4, fila].Value.ToString();
                txtTelefono_casa.Text = grdClientes[5, fila].Value.ToString();
                txtTelefono_oficina.Text = grdClientes[6, fila].Value.ToString();
                txtTelefono_celular.Text = grdClientes[7, fila].Value.ToString();
                EntCliente.Id = Int32.Parse(grdClientes[0, fila].Value.ToString());
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntCliente.Cedula = txtNombre.Text;
                EntCliente.Nombre = txtCedula.Text;
                EntCliente.ApellidoPaterno = txtApellidoPaterno.Text;
                EntCliente.ApellidoMaterno = txtApellidoMaterno.Text;
                EntCliente.TelefonoCasa = txtTelefono_casa.Text;
                EntCliente.TelefonoCelular = txtTelefono_celular.Text;
                EntCliente.TelefonoOficina = txtTelefono_oficina.Text;
                BllCliente.insertarCliente(EntCliente);
                limpiarDatos();
                cargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                BllCliente.eliminarCliente(EntCliente);
                limpiarDatos();
                cargarClientes();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        private void BuscarEnter(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rbBuscarCedula.Checked)
                {
                    buscasCliente(txtBuscar.Text, "cedula");
                }
                if (rbBuscarNombre.Checked)
                {
                    buscasCliente(txtBuscar.Text, "nombre");
                }
                if (rbBuscaApellido.Checked)
                {
                    buscasCliente(txtBuscar.Text, "apellido");
                }
            }
        }
        private void seleccion(object sender, MouseEventArgs e)
        {
            if (this.grdClientes.Rows.Count >= 0)
            {
                int fila = this.grdClientes.CurrentRow.Index;
                EntCliente.Id = Int32.Parse(grdClientes[0, fila].Value.ToString());
                txtMensaje.Text = "Selecciono a: " + grdClientes[2, fila].Value.ToString() + " " + this.grdClientes[3, fila].Value.ToString();
            }
        }
        //Metodo carga los cliente desde la clase BLL.cliente
        //lo agrega a una lista y la lista lo agrega a datagriew
        private void cargarClientes()
        {
            try
            {
                clientes = BllCliente.cargarClientes();
                grdClientes.DataSource = clientes;
                txtCantidadRegistros.Text = "" + clientes.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Metodo limpia los componentes utilizados en el frame
        private void limpiarDatos()
        {
            EntCliente = new ENT.Cliente();
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono_casa.Text = "";
            txtTelefono_celular.Text = "";
            txtTelefono_oficina.Text = "";
            txtMensaje.Text = "";
            txtCantidadRegistros.Text = "";
        }
        //Metodo busca un cliente en determinada columna
        //y valor y lo agrega al datagriew
        private void buscasCliente(string valor, string valor2)
        {
            try
            {
                clientes = BllCliente.buscarCliente(valor, valor2);
                this.grdClientes.DataSource = clientes;
                txtCantidadRegistros.Text = "" + clientes.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
