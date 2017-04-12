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
            cargarDataGriew();
        }

        private void Editar(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdMarcas.Rows.Count > 0)
            {
                int fila = this.grdMarcas.CurrentRow.Index;
                EntMarca.Id = Int32.Parse(this.grdMarcas[0, fila].Value.ToString());
                txtMarca.Text = this.grdMarcas[1, fila].Value.ToString();
                marcaAntes = this.grdMarcas[1, fila].Value.ToString();
            }
        }    
        private void busquedaMarca(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    txtMensaje.Text = "";
                    marcas = BllMarca.buscarMarca(EntMarca);
                    grdMarcas.DataSource = marcas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }              
            }
        }


        private void limpiarDatos()
        {
            txtBuscar.Text = "";
            txtMarca.Text = "";
            txtCantidadRegistros.Text = "";
             EntMarca = new ENT.MarcaVehiculo();
        }
        private void cargarMarcas()
        {
            try
            {
                marcas = BllMarca.cargarMarca();
                grdMarcas.DataSource = marcas;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void cargarDataGriew()
        {
            this.grdMarcas.Columns["Id"].Width = 50;
            this.grdMarcas.Columns["MarcaVehiculo"].Width = 162;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            try
            {
                BllMarca.insertarMarca(EntMarca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            limpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtMensaje.Text = "";
                if (this.grdMarcas.Rows.Count > 0)
                {
                    int fila = this.grdMarcas.CurrentRow.Index;
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(this.grdMarcas[0, fila].Value.ToString()),
                   this.grdMarcas[1, fila].Value.ToString());
                    BllMarca.eliminarMarca(oMarca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}

