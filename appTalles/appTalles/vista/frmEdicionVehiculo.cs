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

        public frmEdicionVehiculo()
        {
            vehiculo = new Vehiculo();
            marca = new MarcaVehiculo();
            tipo = new TipoVehiculo();
            cliente = new Cliente();
            InitializeComponent();
            llenarComboMarca();
            llenarComboTipo();
            llenarComboCliente();
            cargarDataGriew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarVehiculos();
        }

        private void cargarVehiculos()
        {
            VehiculoD oVehiculoD = new VehiculoD();
            List<Vehiculo> lsVehiculos = oVehiculoD.obtenerVehiculos();
            txtCantidad.Text = "" + lsVehiculos.Count();
            if (lsVehiculos.ToString() == "")
            {
                txtTarea.Text = "No hay marcas registrados";
            }
            this.grdVehiculos.DataSource = lsVehiculos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VehiculoD oVehiculo = new VehiculoD();

            if (!verificarDatos())
            {
                return;
            }
            if (vehiculo.Id > 0)
            {
                VehiculoD oVehiculoD = new VehiculoD();
                if (!verificarDatos())
                {
                    return;
                }

                seleccionEstado();
                vehiculo.Placa = txtPlacaa.Text;
                vehiculo.Anno = Int32.Parse(txtAnno.Text);
                vehiculo.Cilindraje = Int32.Parse(txtCilindraje.Text);
                vehiculo.NumeroMotor = Int32.Parse(txtMotor.Text);
                vehiculo.NumeroChazis = Int32.Parse(txtChazis.Text);
                vehiculo.TipoCombustible = txtCombustible.Text;
                vehiculo.Estado = seleccionEstado();
                seleccionCbs();
                vehiculo.Cliente = cliente;
                vehiculo.Marca = marca;
                vehiculo.Tipo = tipo;
                oVehiculo.editarVehiculo(vehiculo);
                txtTarea.Text = "Vehiculo editado correctamente.";
                grbEstado.Enabled = false;
                limpiarDatos();
                cargarVehiculos();
            }
            else
            {
                vehiculo = new Vehiculo();
                vehiculo = new Vehiculo(0, txtPlaca.Text, Int32.Parse(txtAnno.Text), Int32.Parse(txtCilindraje.Text), Int32.Parse(txtMotor.Text), Int32.Parse(txtChazis.Text), txtCombustible.Text, seleccionEstado(), marca, cliente, tipo);
                oVehiculo.agregarVehiculo(vehiculo);
                txtTarea.Text = "Vehiculo  agregada.";
                cargarVehiculos();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtTarea.Text = "";
            if (this.grdVehiculos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de editar esta marca?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    grbEstado.Enabled = true;
                    int fila = this.grdVehiculos.CurrentRow.Index;
                    vehiculo = new Vehiculo();
                    txtPlacaa.Text = this.grdVehiculos[1, fila].Value.ToString();
                    txtAnno.Text = this.grdVehiculos[2, fila].Value.ToString();
                    txtCilindraje.Text = this.grdVehiculos[3, fila].Value.ToString();
                    txtMotor.Text = this.grdVehiculos[4, fila].Value.ToString();
                    txtChazis.Text = this.grdVehiculos[5, fila].Value.ToString();
                    txtCombustible.Text = this.grdVehiculos[6, fila].Value.ToString();
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
                    this.grdVehiculos[6, fila].Value.ToString();

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
                    seleccionEstado();
                    vehiculo = new Vehiculo(Int32.Parse(this.grdVehiculos[0, fila].Value.ToString()), txtPlacaa.Text, Int32.Parse(txtAnno.Text.ToString()), Int32.Parse(txtCilindraje.Text.ToString()), Int32.Parse(txtMotor.Text.ToString()), Int32.Parse(txtChazis.Text.ToString()), txtCombustible.Text, seleccionEstado(), marca, cliente, tipo);
                }
            }
        }


        private void limpiarDatos()
        {
            txtPlacaa.Text = "";
            txtAnno.Text = "";
            txtChazis.Text = "";
            txtMotor.Text = "";
            txtCilindraje.Text = "";
            txtChazis.Text = "";
            txtChazis.Text = "";
            txtCombustible.Text = "";
            cbCliente.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
        }

        private bool verificarDatos()
        {
            try
            {
                Int32.Parse(txtAnno.Text);
                Int32.Parse(txtChazis.Text);
                Int32.Parse(txtMotor.Text);
                Int32.Parse(txtCilindraje.Text);


                if (txtCombustible.Text.Equals("") || txtPlacaa.Text.Equals(""))
                {
                    MessageBox.Show("Verifique los campos de año o tipo de combustible que no esten en blanco", " !Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Verifique los campos de año, motor , cilindraje, y chazis ya que solo admiten numeros", " !Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
            }

            return true;
        }

        private void seleccionCbs()
        {
            if (cbCliente.SelectedIndex != -1)
            {
                int selectedIndex = cbCliente.SelectedIndex;
                Cliente selectedItem = (Cliente)cbCliente.SelectedItem;
                cliente = new Cliente();
                cliente = new Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno, selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);
            }

            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                marca = new MarcaVehiculo();
                marca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }

            if (cbTipo.SelectedIndex != -1)
            {
                int selectedIndex = cbTipo.SelectedIndex;
                TipoVehiculo selectedItem = (TipoVehiculo)cbTipo.SelectedItem;
                tipo = new TipoVehiculo();
                tipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
            }
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

        public void llenarComboMarca()
        {
            this.cbMarca.Items.Clear();
            MarcaD oMarcaD = new MarcaD();
            List<MarcaVehiculo> marcas = oMarcaD.obtenerMarcas();

            foreach (MarcaVehiculo oMarcaL in marcas)
            {
                this.cbMarca.Items.Add(oMarcaL);
            }
        }


        public void llenarComboTipo()
        {
            this.cbTipo.Items.Clear();
            TipoD oTipoD = new TipoD();
            List<TipoVehiculo> tipos = oTipoD.obtenerTipos();

            foreach (TipoVehiculo oTipoL in tipos)
            {
                this.cbTipo.Items.Add(oTipoL);
            }
        }

        private void llenarComboCliente()
        {
            this.cbCliente.Items.Clear();
            ClienteD oCienteD = new ClienteD();
            List<Cliente> clientes = oCienteD.obtenerClientes();

            foreach (Cliente oClienteL in clientes)
            {
                this.cbCliente.Items.Add(oClienteL);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtTarea.Text = "";
            if (this.grdVehiculos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    int fila = this.grdVehiculos.CurrentRow.Index;
                    vehiculo.Id = Int32.Parse(grdVehiculos[0, fila].Value.ToString());
                    VehiculoD pVehiculo = new VehiculoD();
                    MessageBox.Show(vehiculo.ToString());
                    pVehiculo.borrarVehiculo(vehiculo);
                    txtTarea.Text = "Marca eliminada correctamente";
                    cargarVehiculos();

                }
            }
        }
        private void cargarDataGriew()
        {
            this.grdVehiculos.Columns["Id"].Visible = false;
            this.grdVehiculos.Columns["Placa"].Width = 40;
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
