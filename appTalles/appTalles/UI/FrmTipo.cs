using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ENT;

namespace Vista
{
    public partial class FrmTipo : Form
    {
        private ENT.TipoVehiculo EntTipo;
        private BLL.Tipo BllTipo;
        private List<ENT.TipoVehiculo> tiposVehiculos;

        private string tipoAntes;
        public FrmTipo()
        {
            EntTipo = new ENT.TipoVehiculo();
            BllTipo = new BLL.Tipo();
            tiposVehiculos = new List<ENT.TipoVehiculo>();
            InitializeComponent();
            cargarDataGriw();
        }

       
        private void Editar(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdTipos.Rows.Count > 0)
            {
                int fila = this.grdTipos.CurrentRow.Index;
                EntTipo.Id = Int32.Parse(this.grdTipos[0, fila].Value.ToString());
                txtTipo.Text = this.grdTipos[1, fila].Value.ToString();
                tipoAntes = this.grdTipos[1, fila].Value.ToString();
            }
        }
        private void cargarTipos()
        {
            try
            {
                tiposVehiculos = BllTipo.cargarTiposVehiculos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtMensaje.Text = "";
                if (this.grdTipos.Rows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        int fila = this.grdTipos.CurrentRow.Index;
                        EntTipo.Id = Int32.Parse(this.grdTipos[0, fila].Value.ToString());
                        BllTipo.eliminarTipoVehiculo(EntTipo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    

        private void enterSeleccion(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
              
            }
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
            this.grdTipos.Columns["tipoVehiculo"].Width = 168;

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntTipo.Tipo = txtTipo.Text;
                BllTipo.agregarTipoVehiculo(EntTipo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarTipos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}
