using Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmRepuestos : Form
    {
        private RepuestoVehiculo repuesto;
        private MarcaVehiculo marca;
        private MarcaD oMarcaD;
        private RepuestoD oRepuestoD;
        private List<MarcaVehiculo> marcas;
        public FrmRepuestos()
        {
            InitializeComponent();
            cargarDataGriew();
            repuesto = new RepuestoVehiculo();
            marca = new MarcaVehiculo();
            oMarcaD = new MarcaD();
            oRepuestoD = new RepuestoD();
            marcas = new List<MarcaVehiculo>();
            llenarComboMarca();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            txtMensaje.Text = "";
            if (!verificarDatos())
            {
                return;
            }

            repuesto.Repuesto = txtRepuesto.Text;
            repuesto.Precio = Int32.Parse(txtPrecio.Text);
            repuesto.Impuesto = Double.Parse(txtImpuesto.Value.ToString());

            if (repuesto.Id > 0)
            {
                if (!oRepuestoD.editarRepuesto(repuesto))
                {
                    txtMensaje.Text = "Repuesto editado correctamente.";
                    cargarRepuestos();
                }
                else
                {
                    txtMensaje.Text = "Error al editar la marca" + oRepuestoD.ErrorMsg;
                }
            }
            else
            {
                if (!oRepuestoD.agregarRepuesto(repuesto))
                {
                    txtMensaje.Text = "Marca " + txtRepuesto.Text + " agregado.";
                    cargarRepuestos();
                }
                else
                {
                    txtMensaje.Text = "Error al agregar la marca, " + oRepuestoD.ErrorMsg;
                }
            }

            limpiarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRepuestos();
        }

        private void obtenerMarcas(object sender, MouseEventArgs e)
        {
            seleccioFilaDataDriew();
        }
        private bool verificarDatos()
        {

            try
            {
                if (txtRepuesto.Text == "")
                {

                    MessageBox.Show("Debes ingresar un repuesto", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (Double.Parse(txtPrecio.Text) < 0)
                {
                    MessageBox.Show("Desbres ingresar un procio corrcto", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Precio incorrecto, este campo solo admite numeros", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
                throw;
            }

            return true;


        }

        private void limpiarDatos()
        {

            txtPrecio.Text = "";
            txtImpuesto.Value = 0;
            txtPrecio.Text = "";
            txtRepuesto.Text = "";
            repuesto.Id = 0;
            repuesto = new RepuestoVehiculo();
            marca = new MarcaVehiculo();


        }

        private void cargarRepuestos()
        {

            List<RepuestoVehiculo> lsRepuesto = oRepuestoD.obtenerRepesto();
            txtCantidadRepuesto.Text = "" + lsRepuesto.Count();
            if (lsRepuesto.Count <= 0)
            {
                txtMensaje.Text = "No hay repuestos registrados.";
            }
            else if (!oRepuestoD.ErrorMsg.Equals(""))
            {
                txtMensaje.Text = "Error al cargar repuestos, " + oRepuestoD.ErrorMsg;
            }
            this.grdRepuesto.DataSource = lsRepuesto;
        }

        private void seleccioFilaDataDriew()
        {
            txtMensaje.Text = "";
            seleccionDataRepuesto();
            List<MarcaVehiculo> lsMarcas = oRepuestoD.obtenerMarcaRepuesto(repuesto);
            txtMarcas.Text = lsMarcas.Count + "";
            if (lsMarcas.Count < 0)
            {
                txtMensaje.Text = "No hay repuestos registrados.";
            }
            else if (!oRepuestoD.ErrorMsg.Equals(""))
            {
                txtMensaje.Text = "Error al cargar repuestos, " + oRepuestoD.ErrorMsg;
            }
            this.grdMarca.DataSource = lsMarcas;
            limpiarDatos();
        }

        public void llenarComboMarca()
        {
            this.cbMarca.Items.Clear();
            marcas = oMarcaD.obtenerMarcas();
            foreach (MarcaVehiculo oMarcaL in marcas)
            {
                this.cbMarca.Items.Add(oMarcaL);
            }
        }

        private void selecionMarca(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                marca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }
        }

        private void btnTipoMarca_Click(object sender, EventArgs e)
        {
            seleccionDataRepuesto();
            seleccionCbMarcas();

            if (repuesto.Id <= 0 || marca.Id <= 0)
            {
                MessageBox.Show("Asegurate de selecionar un repusto y la marca agreagar", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!oRepuestoD.agregarMarcasRepuesto(marca, repuesto))
            {
                txtMensaje.Text = "Se agrego la marca correctamente";
            }
            else
            {
                MessageBox.Show("No puede agregar esta marca ya que ya existe " + oRepuestoD.ErrorMsg, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            seleccioFilaDataDriew();
            limpiarDatos();
        }

        private void seleccionCbMarcas()
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                marca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }
        }

        private void seleccionDataRepuesto()
        {
            if (this.grdRepuesto.Rows.Count < 0)
            {
                return;
            }
            int fila = this.grdRepuesto.CurrentRow.Index;
            repuesto = new RepuestoVehiculo(Int32.Parse(this.grdRepuesto[0, fila].Value.ToString()), this.grdRepuesto[1, fila].Value.ToString(), Double.Parse(this.grdRepuesto[2, fila].Value.ToString()), Double.Parse(this.grdRepuesto[3, fila].Value.ToString()));

        }

        private void seleccionDataMarcas()
        {
            if (this.grdMarca.Rows.Count > 0)
            {
                int fila = this.grdMarca.CurrentRow.Index;
                marca = new MarcaVehiculo(Int32.Parse(this.grdMarca[0, fila].Value.ToString()), this.grdMarca[1, fila].Value.ToString());
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.grdMarca.Rows.Count > 0)
            {
                seleccionDataMarcas();

                if (marca.Id <= 0)
                {
                    MessageBox.Show("Debes seleccionar una marca para borrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!oRepuestoD.borrarRepuestoMarca(marca))
                {
                    txtMensaje.Text = "Marca eliminada al repuesto";
                }
                else
                {
                    MessageBox.Show("No se puedo eliminar esta marca " + oRepuestoD.ErrorMsg, "!Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            seleccioFilaDataDriew();
            limpiarDatos();
        }


        private void cargarDataGriew()
        {
            this.grdRepuesto.Columns["id_repuesto"].Visible = false;
            this.grdRepuesto.Columns["RepuestoVehiculo"].Width = 65;
            this.grdRepuesto.Columns["PrecioVehiculo"].Width = 65;
            this.grdRepuesto.Columns["ImpuestoVehiculo"].Width = 65;
            this.grdMarca.Columns["IdMarca"].Width = 20;
            this.grdMarca.Columns["marcaVehiculo"].Width = 85;
           


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (repuesto.Id <= 0)
            {
                MessageBox.Show("Debes seleccinar un repuesto", "!Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!oRepuestoD.borrarRepuesto(repuesto)))
            {
                txtMensaje.Text = "repuesto eliminado correctamente";
            }
            else
            {
                MessageBox.Show(oRepuestoD.ErrorMsg + " debes quitar las marcas al repuesto y luego elimina", "!Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BuscarRepuesto(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtMensaje.Text = "";

                List<RepuestoVehiculo> lsRepuesto = new List<RepuestoVehiculo>();

                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (rbRepuesto.Checked)
                    {
                        lsRepuesto = oRepuestoD.buscarStringRepuesto(txtBuscar.Text, "repuesto");

                    }
                    else if (rbPrecio.Checked)
                    {
                        lsRepuesto = oRepuestoD.buscarDoublegRepuesto(Double.Parse(txtBuscar.Text), "precio");
                    }
                    else if (rbImpuesto.Checked)
                    {

                        lsRepuesto = oRepuestoD.buscarDoublegRepuesto(Double.Parse(txtBuscar.Text), "impuesto");

                    }

                    txtCantidadRepuesto.Text = "" + lsRepuesto.Count();

                    if (lsRepuesto.Count() <= 0)
                    {
                        txtMensaje.Text = "No hay marcas registrados";
                    }
                    this.grdRepuesto.DataSource = lsRepuesto;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tipo error" + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void editarRepuesto(object sender, EventArgs e)
        {
            if (this.grdRepuesto.Rows.Count > 0)
            {
                int fila = this.grdRepuesto.CurrentRow.Index;
                seleccionDataRepuesto();
                txtRepuesto.Text = grdRepuesto[1, fila].Value.ToString();
                txtPrecio.Text = grdRepuesto[2, fila].Value.ToString();
                txtImpuesto.Value = Int32.Parse(grdRepuesto[3, fila].Value.ToString());
                repuesto.Id = Int32.Parse(grdRepuesto[0, fila].Value.ToString());
            }
        }

    }
}
