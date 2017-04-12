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
            BllTipo = new BLL.Tipo();
            vehiculos = new List<ENT.Vehiculo>();
            marcas = new List<MarcaVehiculo>();
            tipos = new List<TipoVehiculo>();
            clientes = new List<ENT.Cliente>();
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
            try
            {
                vehiculos = BLLVehiculo.cargarVehiculos();
                grdVehiculos.DataSource = vehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Editar(object sender, MouseEventArgs e)
        {
            txtTarea.Text = "";
            if (this.grdVehiculos.Rows.Count > 0)
            {
                grbEstado.Enabled = true;
                int fila = this.grdVehiculos.CurrentRow.Index;
                EntVehiculo.Id = Int32.Parse(this.grdVehiculos[0, fila].Value.ToString());
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
                ENT.Cliente selectedItem = (ENT.Cliente)cbCliente.SelectedItem;
                EntCliente = new ENT.Cliente();
                EntCliente = new ENT.Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno, selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);

            }
        }
        private void seleccionCbMarca(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                EntMarca = new MarcaVehiculo();
                EntMarca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
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
                EntTipo = new TipoVehiculo();
                EntTipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
            }
        }
        private void limpiarDatos()
        {
            EntCliente = new ENT.Cliente();
            EntMarca = new MarcaVehiculo();
            EntTipo = new TipoVehiculo();
            EntVehiculo = new ENT.Vehiculo();
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
                ENT.Cliente selectedItem = (ENT.Cliente)cbCliente.SelectedItem;
                EntCliente = new ENT.Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno,
                selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);
            }

            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                EntMarca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }

            if (cbTipo.SelectedIndex != -1)
            {
                int selectedIndex = cbTipo.SelectedIndex;
                TipoVehiculo selectedItem = (TipoVehiculo)cbTipo.SelectedItem;
                EntTipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
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
            try
            {
                BLLVehiculo.eliminarVehiculo(EntVehiculo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void BusquedaVehiculo(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    txtTarea.Text = "";
            //    List<ENT.Vehiculo> lsVehiculos = new List<ENT.Vehiculo>();

            //    if ((int)e.KeyChar == (int)Keys.Enter)
            //    {
            //        if (rbBuscarAnno.Checked)
            //        {
            //            lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), "v.anno");

            //        }
            //        else if (rbBuscarCilindraje.Checked)
            //        {
            //            lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), "v.cilindraje");
            //        }
            //        else if (rbBuscarPlaca.Checked)
            //        {

            //            lsVehiculos = pVehiculoD.BuscarStringVehiculo(txtBuscar.Text, "v.placa");

            //        }
            //        else if (rbBuscarCombustible.Checked)
            //        {
            //            lsVehiculos = pVehiculoD.BuscarStringVehiculo(txtBuscar.Text, "v.combustible");
            //        }
            //        else if (rbBuscarMotor.Checked)
            //        {

            //            lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), " v.numero_motor");

            //        }
            //        else if (rbBuscarChazis.Checked)
            //        {
            //            lsVehiculos = pVehiculoD.BuscarIntVehiculo(Int32.Parse(txtBuscar.Text), "v.numero_chazis");
            //        }
            //        txtCantidad.Text = "" + lsVehiculos.Count();

            //        if (lsVehiculos.Count() <= 0)
            //        {
            //            txtTarea.Text = "No hay marcas registrados";
            //        }
            //        this.grdVehiculos.DataSource = lsVehiculos;
            //    }
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Tipo error: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //    throw;
            //}
        }
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
                MessageBox.Show(ex.Message);
            }
        }


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
                MessageBox.Show(ex.Message);
            }
        }

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
                MessageBox.Show(ex.Message);
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                seleccionCbs();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
