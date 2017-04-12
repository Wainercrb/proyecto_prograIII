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
            cargarDataGriew();
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
                EntCliente.Id = Int32.Parse(grdClientes[0, fila].Value.ToString());
            }
        }
        private void cargarClientes()
        {
            try
            {
                clientes = BllCliente.cargarClientes();
                grdClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            EntCliente = new ENT.Cliente();
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono_casa.Text = "";
            txtTelefono_celular.Text = "";
            txtTelefono_oficina.Text = "";
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtMensaje.Text = "";
                EntCliente.Cedula = txtNombre.Text;
                EntCliente.Nombre = txtCedula.Text;
                EntCliente.ApellidoPaterno = txtApellidoPaterno.Text;
                EntCliente.ApellidoMaterno = txtApellidoMaterno.Text;
                EntCliente.TelefonoCasa = txtTelefono_casa.Text;
                EntCliente.TelefonoCelular = txtTelefono_celular.Text;
                EntCliente.TelefonoOficina = txtTelefono_oficina.Text;
                BllCliente.insertarCliente(EntCliente);
                limpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                BllCliente.eliminarCliente(EntCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
