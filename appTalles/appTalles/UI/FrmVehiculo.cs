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
    public partial class frmEdicionVehiculo : Form
    {
        private ENT.Vehiculo EntVehiculo;
        private ENT.MarcaVehiculo EntMarca;
        private ENT.TipoVehiculo EntTipo;
        private ENT.Cliente EntCliente;
        private BLL.Vehiculo BLLVehiculo;
        private BLL.Marca BllMarca;
        private BLL.Cliente BllClinete;
        private BLL.Tipo BllTipo;
        private List<ENT.Vehiculo> vehiculos;
        private List<ENT.MarcaVehiculo> marcas;
        private List<ENT.TipoVehiculo> tipos;
        private List<ENT.Cliente> clientes;
        public frmEdicionVehiculo()
        {
            EntVehiculo = new ENT.Vehiculo();
            EntMarca = new ENT.MarcaVehiculo();
            EntTipo = new ENT.TipoVehiculo();
            EntCliente = new ENT.Cliente();
            BLLVehiculo = new BLL.Vehiculo();
            BllMarca = new BLL.Marca();
            BllClinete = new BLL.Cliente();
            BllTipo = new BLL.Tipo();
            vehiculos = new List<ENT.Vehiculo>();
            marcas = new List<MarcaVehiculo>();
            tipos = new List<TipoVehiculo>();
            clientes = new List<ENT.Cliente>();
            InitializeComponent();
            llenarComboMarca();
            llenarComboTipo();
            llenarComboCliente();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                seleccionComboMarca();
                seleccionComboTipo();
                seleccionComboCliente();
                EntVehiculo.NumeroChazis = Int32.Parse(nubChazis.Value.ToString());
                EntVehiculo.NumeroMotor = Int32.Parse(nubMotor.Value.ToString());
                EntVehiculo.Placa = txtPlacaa.Text;
                EntVehiculo.Cilindraje = Int32.Parse(nudCilindraje.Value.ToString());
                EntVehiculo.Anno = Int32.Parse(nubAnno.Value.ToString());
                EntVehiculo.Cliente = EntCliente;
                EntVehiculo.Marca = EntMarca;
                EntVehiculo.Tipo = EntTipo;
                EntVehiculo.TipoCombustible = seleccionCombustible();
                EntVehiculo.Estado = seleccionEstado();
                BLLVehiculo.agregarVehiculo(EntVehiculo);
                limpiarDatos();
                cargarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                BLLVehiculo.eliminarVehiculo(EntVehiculo);
                limpiarDatos();
                cargarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void btnRefrecar_Click(object sender, EventArgs e)
        {
            cargarVehiculos();
        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        private void Editar(object sender, MouseEventArgs e)
        {
            txtTarea.Text = "";
            if (this.grdVehiculos.Rows.Count >= 0)
            {
                int fila = this.grdVehiculos.CurrentRow.Index;
                EntVehiculo.Id = Int32.Parse(this.grdVehiculos[0, fila].Value.ToString());
                txtPlacaa.Text = this.grdVehiculos[1, fila].Value.ToString();
                nubAnno.Value = Int32.Parse(this.grdVehiculos[2, fila].Value.ToString());
                nudCilindraje.Value = Int32.Parse(this.grdVehiculos[3, fila].Value.ToString());
                nubMotor.Value = Int32.Parse(this.grdVehiculos[4, fila].Value.ToString());
                nubChazis.Value = Int32.Parse(this.grdVehiculos[5, fila].Value.ToString());

                if (this.grdVehiculos[7, fila].Value.ToString() == "Pendiente")
                {
                    this.rbPendiente.Checked = true;
                }
                else if (this.grdVehiculos[7, fila].Value.ToString() == "Finalizado")
                {
                    this.rbFinalizado.Checked = true;
                }

                for (int i = 0; i < cbMarca.Items.Count; i++)
                {
                    if (cbMarca.Items[i] + "" == grdVehiculos[8, fila].Value.ToString() + "")
                    {
                        cbMarca.SelectedIndex = i;
                        break;

                    }
                }

                for (int j = 0; j < cbTipo.Items.Count; j++)
                {
                    if (cbTipo.Items[j] + "" == grdVehiculos[10, fila].Value.ToString() + "")
                    {
                        cbTipo.SelectedIndex = j;
                        break;
                    }
                }

                for (int i = 0; i < cbCliente.Items.Count; i++)
                {
                    if (grdVehiculos[9, fila].Value.ToString() == cbCliente.Items[i].ToString())
                    {
                        cbCliente.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cbTipoCombustible.Items.Count; i++)
                {
                    if (grdVehiculos[6, fila].Value.ToString() == cbTipoCombustible.Items[i].ToString())
                    {
                        cbTipoCombustible.SelectedIndex = i;
                        break;
                    }
                }
                seleccionEstado();
            }
        }
        private void seleccionVehiculo(object sender, MouseEventArgs e)
        {
            if (this.grdVehiculos.Rows.Count >= 0)
            {
                int fila = this.grdVehiculos.CurrentRow.Index;
                EntVehiculo.Id = Int32.Parse(this.grdVehiculos[0, fila].Value.ToString());
                txtTarea.Text = "Placa: " + this.grdVehiculos[1, fila].Value.ToString();
            }
        }
        //Metodo seleccion en los radio button 
        private string seleccionEstado()
        {
            string estado = "";
            if (this.rbPendiente.Checked)
            {
                estado = "Pendiente";
            }
            else
            {
                estado = "Finalizado";
            }
            return estado;
        }
        private void BusquedaVehiculo(object sender, KeyPressEventArgs e)
        {

            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (rbBuscarPlaca.Checked)
                    {
                        buscar(txtBuscar.Text, 0, "placa");
                    }
                    if (rbBuscarChazis.Checked)
                    {
                        buscar("", Int32.Parse(txtBuscar.Text), "numero_chazis");
                    }
                    if (rbBuscarAnno.Checked)
                    {
                        buscar("", Int32.Parse(txtBuscar.Text), "anno");
                    }
                    if (rbBuscarMotor.Checked)
                    {
                        buscar("", Int32.Parse(txtBuscar.Text), "numero_motor");
                    }
                    if (rbBuscarCilindraje.Checked)
                    {
                        buscar("", Int32.Parse(txtBuscar.Text), "cilindraje");
                    }
                    if (rbBuscarCombustible.Checked)
                    {
                        buscar(txtBuscar.Text, 0, "combustible");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo limpia todos los datos de las variables
        //utilizadas 
        private void limpiarDatos()
        {
            EntCliente = new ENT.Cliente();
            EntMarca = new ENT.MarcaVehiculo();
            EntTipo = new ENT.TipoVehiculo();
            EntVehiculo = new ENT.Vehiculo();
            txtPlacaa.Text = "";
            nubAnno.Value = 0;
            nubMotor.Value = 0;
            nudCilindraje.Value = 0;
            nubChazis.Value = 0;
            cbCliente.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            cbTipoCombustible.SelectedIndex = -1;
            txtTarea.Text = "";
            txtCantidad.Text = "";
            txtBuscar.Text = "";
            txtPlacaa.Text = "";
            vehiculos.Clear();
            this.grdVehiculos.DataSource = null;
        }
        //Metodo busca un valor por columna y los carga al data griew
        private void buscar(string valor, int numero, string columna)
        {
            try
            {
                if (valor == "")
                {
                    vehiculos = BLLVehiculo.buscarIntVehiculos(numero, columna);
                }
                if (valor != "")
                {
                    vehiculos = BLLVehiculo.buscarStringVehiculos(valor, columna);
                }
                this.grdVehiculos.DataSource = vehiculos;
                txtCantidad.Text = "" + vehiculos.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo selecciona en los combo de marca
        private void seleccionComboMarca()
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                EntMarca = new MarcaVehiculo();
                EntMarca.Id = selectedItem.Id;
                EntMarca.Marca = selectedItem.Marca;
            }
        }
        //Metodo selecciona el combo tipo de vehículo
        private void seleccionComboTipo()
        {
            if (cbTipo.SelectedIndex != -1)
            {
                int selectedIndex = cbTipo.SelectedIndex;
                TipoVehiculo selectedItem = (TipoVehiculo)cbTipo.SelectedItem;
                EntTipo = new TipoVehiculo();
                EntTipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
            }
        }
        //Metodo selecciona el combo de cliente
        private void seleccionComboCliente()
        {

            if (cbCliente.SelectedIndex != -1)
            {
                int selectedIndex = cbCliente.SelectedIndex;
                ENT.Cliente selectedItem = (ENT.Cliente)cbCliente.SelectedItem;
                EntCliente = new ENT.Cliente();
                EntCliente = new ENT.Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno, selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);
            }
        }
        //Metodo selecciona el combo de combustible
        private string seleccionCombustible()
        {
            string combustible = "";
            if (cbTipoCombustible.SelectedIndex != -1)
            {
                int selectedIndex = -1;
                selectedIndex = cbTipoCombustible.SelectedIndex;
                combustible = cbTipoCombustible.Items[selectedIndex].ToString();
            }
            return combustible;
        }

        //Metodo carga los vehículos en una lista  y los agrega
        //al data griew
        private void cargarVehiculos()
        {
            try
            {
                vehiculos = BLLVehiculo.cargarVehiculos();
                grdVehiculos.DataSource = vehiculos;
                txtCantidad.Text = vehiculos.Count + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo carga en un lista las marcas de la base de 
        //datos y los agrega al combo box
        public void llenarComboMarca()
        {
            try
            {
                this.cbMarca.Items.Clear();
                marcas = BllMarca.cargarMarca();
                foreach (MarcaVehiculo oMarcaL in marcas)
                {
                    this.cbMarca.Items.Add(oMarcaL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo carga en un lista los tipos devehiculos, de la base de 
        //datos y los agrega al combo box
        public void llenarComboTipo()
        {
            try
            {
                this.cbTipo.Items.Clear();
                tipos = BllTipo.cargarTiposVehiculos();
                foreach (TipoVehiculo oTipoL in tipos)
                {
                    this.cbTipo.Items.Add(oTipoL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information); ;
            }
        }
        //Metodo carga en un lista los clientes de la base de 
        //datos y los agrega al combo box
        private void llenarComboCliente()
        {
            try
            {
                this.cbCliente.Items.Clear();
                clientes = BllClinete.cargarClientes();
                foreach (ENT.Cliente oClienteL in clientes)
                {
                    this.cbCliente.Items.Add(oClienteL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
