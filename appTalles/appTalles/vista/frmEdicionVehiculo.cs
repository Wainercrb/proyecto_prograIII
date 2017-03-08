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
        private string vehiculoAntes;
        public frmEdicionVehiculo()
        {
            vehiculo = new Vehiculo();
            marca = new MarcaVehiculo();
            tipo = new TipoVehiculo();
            cliente = new Cliente();
            InitializeComponent();
            llenarComboMarca();
            llenarComboTipo();
            grbEstado.Enabled = false;
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
            string estado = "";

            try
            {
                VehiculoD oVehiculo = new VehiculoD();
                if (txtPlacaa.Text == "" || txtCombustible.Text == "")
                {
                    MessageBox.Show("¡Eror!", "No dejes espacios vacios como pueden ser:\n"
                        + " numero de placa ó combustible ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (rbDanado.Enabled == true)
                {
                    estado = "Dañado";
                }
                else if (rbPendiente.Enabled == true)
                {
                    estado = "Pendiente";
                }
                else
                {
                    estado = "Finalizado";
                }

                if (vehiculo.Id > 0)
                {
                    VehiculoD oVehiculoD = new VehiculoD();

                    oVehiculo.agregarVehiculo(vehiculo);

                    txtTarea.Text = "Vehiculo agreagado correctamente.";

                    cargarVehiculos();

                }
                else
                {
                    vehiculo = new Vehiculo();
                    oVehiculo.agregarVehiculo(vehiculo);
                    txtTarea.Text = "Vehiculo  agregada.";
                    cargarVehiculos();
                }



                txtAnno.Text = "";
                txtChazis.Text = "";
                txtCombustible.Text = "";
                txtPlaca.Text = "";
                txtMotor.Text = "";
                txtCombustible.Text = "";



            }
            catch (FormatException ex)
            {

                MessageBox.Show("¡Error!", "Verifique los compos de: cilindraje, año, numero de motor/n"
                    + "y numero de chazis ya que solo admite numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                TipoVehiculo selectedItem = (TipoVehiculo)cbMarca.SelectedItem;
                tipo = new TipoVehiculo();
                tipo = new TipoVehiculo(selectedItem.Id, selectedItem.Tipo);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string estado = "";
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

                    if (this.grdVehiculos[7, fila].Value.ToString() == "Dañado")
                    {
                        rbDanado.Checked = true;
                        estado = "Dañado";
                    }
                    else if (this.grdVehiculos[7, fila].Value.ToString() == "Pendiente")
                    {
                        rbPendiente.Checked = true;
                        estado = "Pendiente";
                    }
                    else
                    {
                        rbFinalizado.Checked = true;
                        estado = "Finalizado";
                    }
                    this.grdVehiculos[2, fila].Value.ToString();

                    vehiculo = new Vehiculo(Int32.Parse(grdVehiculos[0, fila].Value.ToString()), txtPlaca.Text, Int32.Parse(txtAnno.Text), Int32.Parse(txtCilindraje.Text), Int32.Parse(txtMotor.Text), Int32.Parse(txtChazis.Text), txtCombustible.Text, "", marca, cliente, tipo);

                    vehiculo = new Vehiculo(Int32.Parse(this.grdVehiculos[0, fila].Value.ToString()), txtPlacaa.Text, Int32.Parse(txtAnno.Text.ToString()), Int32.Parse(txtCilindraje.Text.ToString()), Int32.Parse(txtMotor.Text.ToString()), Int32.Parse(txtChazis.Text.ToString()), txtCombustible.Text, estado, marca, cliente, tipo);

                    //vehiculo = this.grdMarcas[1, fila].Value.ToString();


                }
            }
        }
    }
}
