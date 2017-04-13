using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using DAL;
using BLL;

namespace Vista
{
    public partial class frmMarca : Form
    {
        private ENT.MarcaVehiculo EntMarca;
        private BLL.Marca BllMarca;
        private string marcaAntes;
        private List<ENT.MarcaVehiculo> marcas;
        public frmMarca()
        {
            EntMarca = new ENT.MarcaVehiculo();
            BllMarca = new BLL.Marca();
            InitializeComponent();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntMarca.Marca = txtMarca.Text;
                BllMarca.insertarMarca(EntMarca);
                limpiarDatos();
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BllMarca.eliminarMarca(EntMarca);
                limpiarDatos();
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            cargarMarcas();
        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        private void Editar(object sender, EventArgs e)
        {
            if (this.grdMarcas.Rows.Count > 0)
            {
                int fila = this.grdMarcas.CurrentRow.Index;
                EntMarca.Id = Int32.Parse(this.grdMarcas[0, fila].Value.ToString());
                txtMarca.Text = this.grdMarcas[1, fila].Value.ToString();
                marcaAntes = this.grdMarcas[1, fila].Value.ToString();
            }
        }
        private void seleccionMarca(object sender, MouseEventArgs e)
        {
            if (this.grdMarcas.Rows.Count > 0)
            {
                int fila = this.grdMarcas.CurrentRow.Index;
                EntMarca.Id = Int32.Parse(this.grdMarcas[0, fila].Value.ToString());
                txtMensaje.Text = this.grdMarcas[1, fila].Value.ToString();
            }
        }
        private void busquedaMarca(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    marcas = BllMarca.buscarMarca(txtBuscar.Text);
                    grdMarcas.DataSource = marcas;
                    txtCantidadRegistros.Text = "" + marcas.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void limpiarDatos()
        {
            txtBuscar.Text = "";
            txtMarca.Text = "";
            txtCantidadRegistros.Text = "";
            txtMensaje.Text = "";
            EntMarca = new ENT.MarcaVehiculo();
        }
        private void cargarMarcas()
        {
            try
            {
                marcas = BllMarca.cargarMarca();
                grdMarcas.DataSource = marcas;
                txtCantidadRegistros.Text = "" + marcas.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

