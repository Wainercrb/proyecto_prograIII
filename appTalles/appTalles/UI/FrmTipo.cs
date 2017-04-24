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
        public FrmTipo()
        {
            EntTipo = new ENT.TipoVehiculo();
            BllTipo = new BLL.Tipo();
            tiposVehiculos = new List<ENT.TipoVehiculo>();
            InitializeComponent();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntTipo.Tipo = txtTipo.Text;
                BllTipo.agregarTipoVehiculo(EntTipo);
                limpiarDatos();
                cargarTipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                BllTipo.eliminarTipoVehiculo(EntTipo);
                limpiarDatos();
                cargarTipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    BllTipo.eliminarTipoVehiculo(EntTipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Editar(object sender, EventArgs e)
        {
            if (this.grdTipos.Rows.Count > 0)
            {
                int fila = this.grdTipos.CurrentRow.Index;
                EntTipo.Id = Int32.Parse(this.grdTipos[0, fila].Value.ToString());
                txtTipo.Text = this.grdTipos[1, fila].Value.ToString();
            }
        }
        private void seleccionTipo(object sender, MouseEventArgs e)
        {
            if (this.grdTipos.Rows.Count > 0)
            {
                int fila = this.grdTipos.CurrentRow.Index;
                EntTipo.Id = Int32.Parse(this.grdTipos[0, fila].Value.ToString());
                EntTipo.Tipo = this.grdTipos[1, fila].Value.ToString();
                txtMensaje.Text = this.grdTipos[1, fila].Value.ToString();
            }
        }
        private void enterSeleccion(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    tiposVehiculos = BllTipo.buscarStringTipo(txtBuscar.Text);
                    grdTipos.DataSource = tiposVehiculos;
                    txtCantidadRegistros.Text = "" + tiposVehiculos.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo recibe una lista de tipos de vehículos desde la
        //clase BLL.tipo y la agrega al datagriew
        private void cargarTipos()
        {
            try
            {
                tiposVehiculos = BllTipo.cargarTiposVehiculos();
                grdTipos.DataSource = tiposVehiculos;
                txtCantidadRegistros.Text = "" + tiposVehiculos.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo limpia los componentes utilizados en el frame
        private void limpiarDatos()
        {
            txtMensaje.Text = "";
            txtCantidadRegistros.Text = "";
            txtTipo.Text = "";
            EntTipo = new ENT.TipoVehiculo();
        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {

        }
    }
}
