using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;

namespace Vista
{
    public partial class frmMarca : Form
    {

        private MarcaVehiculo marca;
        private string marcaAntes;


        public frmMarca()
        {
            this.marca = new MarcaVehiculo();
            InitializeComponent();
            cargarDataGriew();
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaD oMarca = new MarcaD();
            txtMensaje.Text = "";    
            if (marca.Id > 0)
            {
                if (!verificarDatos())
                {
                    return;
                }
                marca.Marca = txtMarca.Text;
                if (oMarca.editarMarca(marca))
                {
                    txtMensaje.Text = "Marca " + marcaAntes + " editada a (" + txtMarca.Text + ") correctamente.";
                    cargarMarcas();

                }
                else
                {
                    txtMensaje.Text = "Error al editar la marca" + oMarca.ErrorMsg;
                }

            }
            else
            {
                MarcaVehiculo marca = new MarcaVehiculo(0, txtMarca.Text);
                if (!verificarDatos()) {
                    return;
                }

                if (oMarca.agregarMarca(marca))
                {
                    txtMensaje.Text = "Marca " + txtMarca.Text + " agregada.";
                    cargarMarcas();
                }else {

                    txtMensaje.Text = "Error al agregar la marca, " + oMarca.ErrorMsg;
                }               
            }

            marca = new MarcaVehiculo();
            txtMarca.Text = "";
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void btnElininar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            MarcaD pMarca = new MarcaD();
            if (this.grdMarcas.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    int fila = this.grdMarcas.CurrentRow.Index;
                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(this.grdMarcas[0, fila].Value.ToString()), this.grdMarcas[1, fila].Value.ToString());


                    if (pMarca.borrarMarca(oMarca))
                    {
                        txtMensaje.Text = "Marca eliminada correctamente";
                        cargarMarcas();
                    }
                    else {

                        txtMensaje.Text = "Error al eliminar la marca, " + pMarca.ErrorMsg;

                    }                 
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdMarcas.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de editar esta marca?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    marca = new MarcaVehiculo();
                    int fila = this.grdMarcas.CurrentRow.Index;
                    marca = new MarcaVehiculo(Int32.Parse(this.grdMarcas[0, fila].Value.ToString()), txtMarca.Text);
                    txtMarca.Text = this.grdMarcas[1, fila].Value.ToString();
                    marcaAntes = this.grdMarcas[1, fila].Value.ToString();
                }
            }
        }

        private void busquedaMarca(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtMensaje.Text = "";
                MarcaD oMarca = new MarcaD();
                List<MarcaVehiculo> lsMarca = oMarca.buscarMarcas(txtBuscar.Text);

                txtCantidadRegistros.Text = "" + lsMarca.Count();
                if (lsMarca.Count() <= 0)
                {
                    txtMensaje.Text = "No hay tipos registrados";
                }
                this.grdMarcas.DataSource = lsMarca;
            }
        }       

        private bool verificarDatos()
        {
            if (txtMarca.Text.Equals(""))
            {
                MessageBox.Show("Debes agregar una marca.");
                return false;
            }
            return true;
        }
        private void limpiarDatos()
        {

            txtBuscar.Text = "";
            txtMarca.Text = "";
            txtCantidadRegistros.Text = "";
            txtMensaje.Text = "";

        }
        private void cargarMarcas()
        {
            MarcaD oMarcaD = new MarcaD();
            List<MarcaVehiculo> lsMarcas = oMarcaD.obtenerMarcas();

            txtCantidadRegistros.Text = "" + lsMarcas.Count();
            if (lsMarcas.ToString() == "")
            {
                txtMensaje.Text = "No hay marcas registrados";
            }
            this.grdMarcas.DataSource = lsMarcas;
        }
        private void cargarDataGriew()
        {
            this.grdMarcas.Columns["Id"].Visible = false;
            this.grdMarcas.Columns["MarcaVehiculo"].Width = 225;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}
