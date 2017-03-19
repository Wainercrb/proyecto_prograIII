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
        private TipoD oTipoD;
        private string tipoAntes;
        public FrmTipo()
        {
            this.tipo = new TipoVehiculo();
            oTipoD = new TipoD();
            InitializeComponent();
            cargarDataGriw();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (!verificarDatos())
            {
                return;
            }

            if (tipo.Id > 0)
            {
                tipo.Tipo = txtTipo.Text;
                if (!oTipoD.editarTipos(tipo))
                {
                    txtMensaje.Text = "Tipo " + tipoAntes + " editada a (" + txtTipo.Text + ") correctamente.";
                    cargarTipos();
                }
                else
                {
                    txtMensaje.Text = "Error al editar el tipo de vehiculo." + "\n" +
                        "Detalles: " + oTipoD.ErrorMsg;
                }
            }
            else
            {
                TipoVehiculo tipo = new TipoVehiculo(0, txtTipo.Text);
                if (!oTipoD.agregarTipo(tipo))
                {
                    txtMensaje.Text = "Tipo de vehículo  " + txtTipo.Text + " agregado.";
                    txtTipo.Text = "";
                    cargarTipos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el tipo de vehículo, " + oTipoD.ErrorMsg, "!Error¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tipo = new TipoVehiculo();
            txtTipo.Text = "";
        }



        private void Editar(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdTipos.Rows.Count > 0)
            {
                int fila = this.grdTipos.CurrentRow.Index;
                tipo.Id = Int32.Parse(this.grdTipos[0, fila].Value.ToString());
                txtTipo.Text = this.grdTipos[1, fila].Value.ToString();
                tipoAntes = this.grdTipos[1, fila].Value.ToString();
            }
        }
        private void cargarTipos()
        {
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
                    if (!oTipoD.borrarTipo(oTipo))
                    {
                        txtMensaje.Text = "Tipo de vehiculo eliminado correctamente";
                        cargarTipos();

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar este tipo de vehículo, " + oTipoD.ErrorMsg, "¡Error al eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarTipos();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void enterSeleccion(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtMensaje.Text = "";
                List<TipoVehiculo> lsTipo = oTipoD.buscarTipos(txtBuscar.Text);
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
        private bool verificarDatos()
        {
            if (txtTipo.Text.Equals(""))
            {
                MessageBox.Show("Debes ingresar un tipo de vehículo.");
                return false;
            }
            return true;
        }

        private void limpiarDatos()
        {
            txtMensaje.Text = "";
            txtCantidadRegistros.Text = "";
            txtTipo.Text = "";
        }

        private void cargarDataGriw()
        {

            this.grdTipos.Columns["Id"].Width = 60;
            this.grdTipos.Columns["tipoVehiculo"].Width = 240;

        }
    }
}
