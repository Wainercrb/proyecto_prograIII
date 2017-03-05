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
    public partial class FrmTipo : Form
    {
        private TipoVehiculo tipo;
        private string tipoAntes;
        public FrmTipo()
        {
            this.tipo = new TipoVehiculo();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoD oTipo = new TipoD();
            txtMensaje.Text = "";
            if (txtTipo.Text == "")
            {
                MessageBox.Show("Debes ingresar una Tipo ", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipo.Id > 0)
            {
                TipoD pTipo = new TipoD();
                tipo.Tipo = txtTipo.Text;
                pTipo.editarTipos(tipo);
                txtMensaje.Text = "Tipo " + tipoAntes + " editada a (" + txtTipo.Text + ") correctamente.";
                cargarTipos();

            }
            else
            {
                TipoVehiculo tipo = new TipoVehiculo(0, txtTipo.Text);
                oTipo.agregarTipo(tipo);
                txtMensaje.Text = "Marca " + txtTipo.Text + " agregada.";
                txtTipo.Text = "";
                cargarTipos();
            }

            tipo = new TipoVehiculo();
            txtTipo.Text = "";
        }
        private void cargarTipos()
        {
            TipoD oTipoD = new TipoD();
            List<TipoVehiculo> lsTipos = oTipoD.obtenerTipos();

            txtCantidadRegistros.Text = "" + lsTipos.Count();
            if (lsTipos.ToString() == "")
            {
                txtMensaje.Text = "No hay marcas registrados";
            }
            this.grdTipos.DataSource = lsTipos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdTipos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    int fila = this.grdTipos.CurrentRow.Index;
                    TipoVehiculo oTipo = new TipoVehiculo(Int32.Parse(this.grdTipos[0, fila].Value.ToString()), this.grdTipos[1, fila].Value.ToString());
                    TipoD pTipo = new TipoD();
                    pTipo.borrarTipo(oTipo);
                    txtMensaje.Text = "Marca eliminada correctamente";
                    cargarTipos();

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtMensaje.Text = "";
            if (this.grdTipos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de editar este tipo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.grdTipos.CurrentRow.Index;
                    tipo = new TipoVehiculo();
                    tipo = new TipoVehiculo(Int32.Parse(this.grdTipos[0, fila].Value.ToString()), txtTipo.Text);
                    txtTipo.Text = this.grdTipos[1, fila].Value.ToString();
                    tipoAntes = this.grdTipos[1, fila].Value.ToString();


                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarTipos();
        }

        private void enterSeleccion(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtMensaje.Text = "";
                TipoD oTipo = new TipoD();
                List<TipoVehiculo> lsTipo = oTipo.buscarTipos(txtBuscar.Text);

                txtCantidadRegistros.Text = "" + lsTipo.Count();
                if (lsTipo.Count() <= 0)
                {
                    txtMensaje.Text = "No hay tipos registrados";
                }
                this.grdTipos.DataSource = lsTipo;


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
