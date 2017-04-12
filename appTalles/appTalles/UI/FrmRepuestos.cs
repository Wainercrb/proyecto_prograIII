using DAL;
using ENT;
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
        private ENT.RepuestoVehiculo EntRepuesto;
        private ENT.MarcaVehiculo EntMarca;
        private BLL.Marca BllMarca;
        private BLL.Repuesto BllRepuesto;
        private List<MarcaVehiculo> marcas;
        private List<ENT.RepuestoVehiculo> repuestos;
        public FrmRepuestos()
        {
            InitializeComponent();        
            marcas = new List<ENT.MarcaVehiculo>();
            repuestos = new List<ENT.RepuestoVehiculo>();
            EntRepuesto = new ENT.RepuestoVehiculo();
            EntMarca = new ENT.MarcaVehiculo();
            BllRepuesto = new BLL.Repuesto();
            BllMarca = new BLL.Marca();
            cargarDataGriew();
            llenarComboMarca();
        }

        private void obtenerMarcas(object sender, MouseEventArgs e)
        {
            cargarMarcas();
        }
        private void limpiarDatos()
        {
            txtPrecio.Text = "";
            txtImpuesto.Value = 0;
            txtPrecio.Text = "";
            txtRepuesto.Text = "";
            EntRepuesto = new RepuestoVehiculo();
            EntMarca = new MarcaVehiculo();
            marcas.Clear();
            repuestos.Clear();
        }

        private void cargarRepuestos()
        {
            try
            {
                repuestos = BllRepuesto.cargarRepuestos();
                this.grdRepuesto.DataSource = repuestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void cargarMarcas()
        {
            try
            {
                marcas = BllMarca.cargarMarca();
                grdMarca.DataSource = marcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarComboMarca()
        {
            this.cbMarca.Items.Clear();
            marcas = BllMarca.cargarMarca();
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
                EntMarca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }
        }

        private void btnTipoMarca_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionDataRepuesto();
                seleccionCbMarcas();
                cargarMarcas();
                limpiarDatos();
                BllRepuesto.agregarRepuestoMarca(EntMarca, EntRepuesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void seleccionCbMarcas()
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                EntMarca = new MarcaVehiculo(selectedItem.Id, selectedItem.Marca);
            }
        }

        private void seleccionDataRepuesto()
        {
            if (this.grdRepuesto.Rows.Count < 0)
            {
                return;
            }
            int fila = this.grdRepuesto.CurrentRow.Index;
            EntRepuesto = new RepuestoVehiculo(Int32.Parse(this.grdRepuesto[0, fila].Value.ToString()), this.grdRepuesto[1, fila].Value.ToString(), Double.Parse(this.grdRepuesto[2, fila].Value.ToString()), Double.Parse(this.grdRepuesto[3, fila].Value.ToString()));

        }

        private void seleccionDataMarcas()
        {
            if (this.grdMarca.Rows.Count > 0)
            {
                int fila = this.grdMarca.CurrentRow.Index;
                EntMarca = new MarcaVehiculo(Int32.Parse(this.grdMarca[0, fila].Value.ToString()), this.grdMarca[1, fila].Value.ToString());
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdMarca.Rows.Count > 0)
                {
                    BllRepuesto.borrarRepuestoMarca(EntMarca);
                }
                cargarMarcas();
                limpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void BuscarRepuesto(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //txtMensaje.Text = "";

            //List<RepuestoVehiculo> lsRepuesto = new List<RepuestoVehiculo>();

            //if ((int)e.KeyChar == (int)Keys.Enter)
            //{
            //    if (rbRepuesto.Checked)
            //    {
            //        lsRepuesto = oRepuestoD.buscarStringRepuesto(txtBuscar.Text, "repuesto");

            //    }
            //    else if (rbPrecio.Checked)
            //    {
            //        lsRepuesto = oRepuestoD.buscarDoublegRepuesto(Double.Parse(txtBuscar.Text), "precio");
            //    }
            //    else if (rbImpuesto.Checked)
            //    {

            //        lsRepuesto = oRepuestoD.buscarDoublegRepuesto(Double.Parse(txtBuscar.Text), "impuesto");

            //    }

            //    txtCantidadRepuesto.Text = "" + lsRepuesto.Count();

            //    if (lsRepuesto.Count() <= 0)
            //    {
            //        txtMensaje.Text = "No hay marcas registrados";
            //    }
            //    this.grdRepuesto.DataSource = lsRepuesto;
            //    }
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Tipo error" + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw;
            //}
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
                EntRepuesto.Id = Int32.Parse(grdRepuesto[0, fila].Value.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntRepuesto.Repuesto = txtRepuesto.Text;
                EntRepuesto.Precio = Int32.Parse(txtPrecio.Text);
                EntRepuesto.Impuesto = Double.Parse(txtImpuesto.Value.ToString());
                BllRepuesto.agregarRepuesto(EntRepuesto);
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
                BllRepuesto.eliminarRepuesto(EntRepuesto);
                limpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarRepuestos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}
