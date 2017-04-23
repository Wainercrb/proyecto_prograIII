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
        private List<MarcaVehiculo> marcasTemp;
        private List<ENT.RepuestoVehiculo> repuestos;
        public FrmRepuestos()
        {
            InitializeComponent();
            marcas = new List<ENT.MarcaVehiculo>();
            repuestos = new List<ENT.RepuestoVehiculo>();
            marcasTemp = new List<MarcaVehiculo>();
            EntRepuesto = new ENT.RepuestoVehiculo();
            EntMarca = new ENT.MarcaVehiculo();
            BllRepuesto = new BLL.Repuesto();
            BllMarca = new BLL.Marca();
            llenarComboMarca();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntRepuesto.Repuesto = txtRepuesto.Text;
                EntRepuesto.Precio = Double.Parse(txtPrecio.Text);
                EntRepuesto.Impuesto = Double.Parse(txtImpuesto.Text);
                EntRepuesto.Anno = Int32.Parse(npAnno.Value.ToString());
                BllRepuesto.agregarRepuesto(EntRepuesto);
                cargarRepuestos();
                limpiarDatos();

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
                BllRepuesto.eliminarRepuesto(EntRepuesto);
                limpiarDatos();
                cargarRepuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarRepuestos();
            limpiarDatos();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        private void btnTipoMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdRepuesto.Rows.Count > 0)
                {
                    int fila = this.grdRepuesto.CurrentRow.Index;
                    EntRepuesto.Id = Int32.Parse(this.grdRepuesto[0, fila].Value.ToString());
                    if (verificarMarcasAdd())
                    {
                        MessageBox.Show("Esta marca ya se encuentra agregada");
                        return;
                    }
                    BllRepuesto.agregarRepuestoMarca(EntMarca, EntRepuesto);
                    cargarIntMarcas(Int32.Parse(this.grdRepuesto[0, fila].Value.ToString()));
                    limpiarDatos();
                    cargarRepuestos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grdMarca.Rows.Count >= 0)
                {
                    int fila = this.grdMarca.CurrentRow.Index;
                    int fila2 = this.grdRepuesto.CurrentRow.Index;
                    EntMarca.Id = Int32.Parse(this.grdMarca[0, fila].Value.ToString());
                    BllRepuesto.borrarRepuestoMarca(EntMarca);
                    limpiarDatos();
                    cargarIntMarcas(Int32.Parse(this.grdRepuesto[0, fila2].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void seleccionRepuesto(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.grdRepuesto.Rows.Count > 0)
                {
                    int fila = this.grdRepuesto.CurrentRow.Index;
                    txtMensaje.Text = "Repuesto: " + this.grdRepuesto[1, fila].Value.ToString();
                    cargarIntMarcas(Int32.Parse(this.grdRepuesto[0, fila].Value.ToString()));
                    limpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }
        private void editarRepuesto(object sender, EventArgs e)
        {
            if (this.grdRepuesto.Rows.Count > 0)
            {
                int fila = this.grdRepuesto.CurrentRow.Index;
                txtRepuesto.Text = grdRepuesto[1, fila].Value.ToString();
                txtPrecio.Text = grdRepuesto[2, fila].Value.ToString();
                txtImpuesto.Text = (grdRepuesto[3, fila].Value.ToString());
                EntRepuesto.Id = Int32.Parse(grdRepuesto[0, fila].Value.ToString());
            }
        }

        //Metodo limpia todos los componetes
        //y variables utilizados
        private void limpiarDatos()
        {
            txtPrecio.Text = "";
            txtImpuesto.Text = "";
            txtPrecio.Text = "";
            txtRepuesto.Text = "";
            txtMensaje.Text = "";
            txtMarca.Text = "";
            npAnno.Value = 2000;
            EntRepuesto = new RepuestoVehiculo();
            EntMarca = new MarcaVehiculo();
        }
        //Metodo carga los repuestos a la lista
        //y los agrega al DataGriew
        private void cargarRepuestos()
        {
            try
            {
                repuestos = BllRepuesto.cargarRepuestos();
                this.grdRepuesto.DataSource = repuestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo carga las marcas a la lista
        //y los agrega al DataGriew
        private void cargarMarcas()
        {
            try
            {
                marcas = BllMarca.cargarMarca();
                grdMarca.DataSource = marcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo carga las marcas a la lista
        //y los agrega al DataGriew
        private void cargarIntMarcas(int valor)
        {
            try
            {
                marcasTemp = BllMarca.buscaIntrMarca(valor);
                grdMarca.DataSource = marcasTemp;
                txtMarcasM.Text = "" + marcasTemp.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo llena el combo marca
        //con los  con las marca de la db
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
        //Metodo selecciona los un datos del cb marca
        private void seleccionCbMarcas()
        {
            if (cbMarca.SelectedIndex != -1)
            {
                int selectedIndex = cbMarca.SelectedIndex;
                MarcaVehiculo selectedItem = (MarcaVehiculo)cbMarca.SelectedItem;
                EntMarca.Id = selectedItem.Id;
                EntMarca.Marca = selectedItem.Marca;
            }
        }
        private void BuscarRepuesto(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (rbBuscarPrecio.Checked)
                    {
                        buscar("", Double.Parse(txtBuscar.Text), "precio");
                    }
                    if (rbBuscarRepuesto.Checked)
                    {
                        buscar(txtBuscar.Text, 0, "repuesto");
                    }
                    if (rbBuscarImpuesto.Checked)
                    {
                        buscar("", Double.Parse(txtBuscar.Text), "impuesto");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo busca un valor string o int y se lo manda a bll
        //para retornar una lista con los valores y agregarlos al daragrew
        private void buscar(string valor, double numero, string columna)
        {
            try
            {
                if (valor == "")
                {
                    repuestos = BllRepuesto.buscarDoubleRepuesto(numero, columna);
                }
                if (valor != "")
                {
                    repuestos = BllRepuesto.buscarStringRepuesto(valor, columna);
                }
                this.grdRepuesto.DataSource = repuestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private bool verificarMarcasAdd() {

            seleccionCbMarcas();
            for (int i = 0; i < marcasTemp.Count; i++)
            {
                if (marcasTemp[i].Id == EntMarca.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private void validarDato(object sender, KeyPressEventArgs e)
        {
            if (txtImpuesto.Text.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void validarDouble(object sender, KeyPressEventArgs e)
        {
            if (txtImpuesto.Text.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
    }
}
