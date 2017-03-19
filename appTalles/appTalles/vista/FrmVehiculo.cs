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
using Logica;

namespace Vista
{
    public partial class frmEdicionVehiculo : Form
    {
        private Vehiculo vehiculo;
        private MarcaVehiculo marca;
        private TipoVehiculo tipo;
        private Cliente cliente;
        private VehiculoD pVehiculoD;
        private MarcaD oMarcaD;
        private ClienteD oClienteD;
        private TipoD oTipoD;
        public frmEdicionVehiculo()
        {
            vehiculo = new Vehiculo();
            marca = new MarcaVehiculo();
            tipo = new TipoVehiculo();
            cliente = new Cliente();
            pVehiculoD = new VehiculoD();
            oMarcaD = new MarcaD();
            oClienteD = new ClienteD();
            oTipoD = new TipoD();
            InitializeComponent();
            llenarComboMarca();
            llenarComboTipo();
            llenarComboCliente();
            cargarDataGriew();
            grbEstado.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarVehiculos();
        }

        private void cargarVehiculos()
        {
            List<Vehiculo> lsVehiculos = pVehiculoD.obtenerVehiculos();
            txtCantidad.Text = "" + lsVehiculos.Count();
            if (lsVehiculos.Count <= 0)
            {
                txtTarea.Text = "No hay Vehiculos registrados.";
            }
            else if (!pVehiculoD.ErrorMsg.Equals(""))
            {
                txtTarea.Text = "Error al cargar los vehículos, " + pVehiculoD.ErrorMsg;
            }
            this.grdVehiculos.DataSource = lsVehiculos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!verificarDatos())
            {
                return;
            }

            seleccionEstado();
            seleccionCbs();
            vehiculo.NumeroChazis = Int32.Parse(nubChazis.Value.ToString());
            vehiculo.NumeroMotor = Int32.Parse(nubMotor.Value.ToString());
            vehiculo.Placa = txtPlacaa.Text;
            vehiculo.Cilindraje = Int32.Parse(nudCilindraje.Value.ToString());
            vehiculo.Anno = Int32.Parse(nubAnno.Value.ToString());
            vehiculo.Cliente = cliente;
            vehiculo.Marca = marca;
            vehiculo.Tipo = tipo;
            vehiculo.TipoCombustible = seleccionCombustible();
            vehiculo.Estado = seleccionEstado();

            if (vehiculo.Id > 0)
            {
                if (!pVehiculoD.editarVehiculo(vehiculo))
                {
                    cargarVehiculos();
                    limpiarDatos();
                    txtTarea.Text = "Vehiculo editado correctamente.";
                }
                else
                {
                    MessageBox.Show("Detalles " + pVehiculoD.ErrorMsg, "!Error al editar el vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!pVehiculoD.agregarVehiculo(vehiculo))
                {
                    cargarVehiculos();
                    limpiarDatos();
                    txtTarea.Text = "Vehiculo  agregada.";
                }
                else
                {
                    MessageBox.Show("Error al agregar el vehículo, " + pVehiculoD.ErrorMsg, "!Error al agregar el vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Editar(object sender, MouseEventArgs e)
        {
            txtTarea.Text = "";
            if (this.grdVehiculos.Rows.Count > 0)
            {
                grbEstado.Enabled = true;
                int fila = this.grdVehiculos.CurrentRow.Index;
                vehiculo.Id = Int32.Parse(this.grdVehiculos[0, fila].Value.ToString());
                txtPlacaa.Text = this.grdVehiculos[1, fila].Value.ToString();
                nubAnno.Value = Int32.Parse(this.grdVehiculos[2, fila].Value.ToString());
                nudCilindraje.Value = Int32.Parse(this.grdVehiculos[3, fila].Value.ToString());
                nubMotor.Value = Int32.Parse(this.grdVehiculos[4, fila].Value.ToString());
                nubChazis.Value = Int32.Parse(this.grdVehiculos[5, fila].Value.ToString());

                if (this.grdVehiculos[7, fila].Value.ToString() == "Dañado")
                {
                    this.rbDanado.Checked = true;
                }
                else if (this.grdVehiculos[7, fila].Value.ToString() == "Pendiente")
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
        private void cbClienteSeleccion(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex != -1)
            {
                int selectedIndex = cbCliente.SelectedIndex;
                Cliente selectedItem = (Cliente)cbCliente.SelectedItem;
                cliente = new Cliente();
                cliente = new Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno, selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);

            }
        }
        private void seleccionCbMarca(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                marca = new MarcaVehiculo();
                marca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccionCbTipo(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex != -1)
            {
                int selectedIndex = cbTipo.SelectedIndex;
                TipoVehiculo selectedItem = (TipoVehiculo)cbTipo.SelectedItem;
                tipo = new TipoVehiculo();
                tipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
            }
        }
        private void limpiarDatos()
        {
            cliente = new Cliente();
            marca = new MarcaVehiculo();
            tipo = new TipoVehiculo();
            vehiculo = new Vehiculo();
            grbEstado.Enabled = false;
            txtPlacaa.Text = "";
            nubAnno.Value = 0;
            nubMotor.Value = 0;
            nudCilindraje.Value = 0;
            nubChazis.Value = 0;
            cbCliente.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            cbTipoCombustible.SelectedIndex = -1;
        }

        private void seleccionCbs()
        {
            if (cbCliente.SelectedIndex != -1)
            {
                int selectedIndex = cbCliente.SelectedIndex;
                Cliente selectedItem = (Cliente)cbCliente.SelectedItem;
                cliente = new Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno,
                selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);
            }

            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                marca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }

            if (cbTipo.SelectedIndex != -1)
            {
                int selectedIndex = cbTipo.SelectedIndex;
                TipoVehiculo selectedItem = (TipoVehiculo)cbTipo.SelectedItem;
                tipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
            }
        }

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

        private string seleccionEstado()
        {
            string estado = "";
            if (this.rbDanado.Checked)
            {
                estado = "Dañado";
            }
            else if (this.rbPendiente.Checked)
            {
                estado = "Pendiente";
            }
            else
            {
                estado = "Finalizado";
            }

            return estado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtTarea.Text = "";
            if (this.grdVehiculos.Rows.Count > 0)
            {
                int fila = this.grdVehiculos.CurrentRow.Index;
                vehiculo.Id = Int32.Parse(grdVehiculos[0, fila].Value.ToString());
                if (!pVehiculoD.borrarVehiculo(vehiculo))
                {
                    txtTarea.Text = "Vehiculo eliminada correctamente";
                    cargarVehiculos();
                }
                else
                {
                    txtTarea.Text = "Error al eliminar el vehículo, " + pVehiculoD.ErrorMsg;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void BusquedaVehiculo(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtTarea.Text = "";
                List<Vehiculo> lsVehiculos = new List<Vehiculo>();

                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (rbBuscarAnno.Checked)
                    {
                        lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), "v.anno");

                    }
                    else if (rbBuscarCilindraje.Checked)
                    {
                        lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), "v.cilindraje");
                    }
                    else if (rbBuscarPlaca.Checked)
                    {

                        lsVehiculos = pVehiculoD.BuscarStringVehiculo(txtBuscar.Text, "v.placa");

                    }
                    else if (rbBuscarCombustible.Checked)
                    {
                        lsVehiculos = pVehiculoD.BuscarStringVehiculo(txtBuscar.Text, "v.combustible");
                    }
                    else if (rbBuscarMotor.Checked)
                    {

                        lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), " v.numero_motor");

                    }
                    else if (rbBuscarChazis.Checked)
                    {
                        lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), "v.numero_chazis");
                    }
                    txtCantidad.Text = "" + lsVehiculos.Count();

                    if (lsVehiculos.Count() <= 0)
                    {
                        txtTarea.Text = "No hay marcas registrados";
                    }
                    this.grdVehiculos.DataSource = lsVehiculos;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tipo error: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                throw;
            }
        }

        private bool verificarDatos()
        {

            if (cbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar el dueño del vehículo", " !Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (cbMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Debes selecionar la marca del vehiculo", " !Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar el tipo de vehiculo", " !Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public void llenarComboMarca()
        {
            this.cbMarca.Items.Clear();
            List<MarcaVehiculo> marcas = oMarcaD.obtenerMarcas();

            foreach (MarcaVehiculo oMarcaL in marcas)
            {
                this.cbMarca.Items.Add(oMarcaL);
            }
        }


        public void llenarComboTipo()
        {
            this.cbTipo.Items.Clear();
            List<TipoVehiculo> tipos = oTipoD.obtenerTipos();

            foreach (TipoVehiculo oTipoL in tipos)
            {
                this.cbTipo.Items.Add(oTipoL);
            }
        }

        private void llenarComboCliente()
        {
            this.cbCliente.Items.Clear();
            List<Cliente> clientes = oClienteD.obtenerClientes();
            foreach (Cliente oClienteL in clientes)
            {
                this.cbCliente.Items.Add(oClienteL);
            }
        }
        private void cargarDataGriew()
        {
            this.grdVehiculos.Columns["Id"].Visible = false;
            this.grdVehiculos.Columns["Placa"].Width = 45;
            this.grdVehiculos.Columns["Año"].Width = 40;
            this.grdVehiculos.Columns["Cilindraje"].Width = 60;
            this.grdVehiculos.Columns["Motor"].Width = 50;
            this.grdVehiculos.Columns["Chazis"].Width = 40;
            this.grdVehiculos.Columns["Combustible"].Width = 70;
            this.grdVehiculos.Columns["Estado"].Width = 65;
            this.grdVehiculos.Columns["Marca_Vehiculo"].Width = 70;
            this.grdVehiculos.Columns["Tipo_"].Width = 70;
            this.grdVehiculos.Columns["Cliente_"].Width = 200;

        }
    }
}
