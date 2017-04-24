using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTalles.UI
{
    public partial class FrmModelo : Form
    {
        private ENT.Modelo EntModelo;
        private List<ENT.Modelo> modelos;
        private BLL.Modelo BllModelo;
        public FrmModelo()
        {
            InitializeComponent();
            EntModelo = new ENT.Modelo();
            modelos = new List<ENT.Modelo>();
            BllModelo = new BLL.Modelo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                EntModelo.pModelo = txtModelo.Text;
                BllModelo.agregarModelo(EntModelo);
                cargar();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BllModelo.eliminarModelo(EntModelo);
                cargar();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void cargar()
        {
            try
            {
                modelos = BllModelo.cargarModelo();
                this.grdModelo.DataSource = modelos;
                txtRegistro.Text = "" + modelos.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void Refrescar_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private void limpiar()
        {
            txtModelo.Text = "";
            EntModelo = new ENT.Modelo();
        }
        private void seleccion(object sender, MouseEventArgs e)
        {
            if (this.grdModelo.Rows.Count > 0)
            {
                int fila = this.grdModelo.CurrentRow.Index;
                txtMensaje.Text = "Modelo: " + this.grdModelo[1, fila].Value.ToString();
            }
        }
        private void EditorAndEliminar(object sender, MouseEventArgs e)
        {
            if (this.grdModelo.Rows.Count > 0)
            {
                int fila = this.grdModelo.CurrentRow.Index;

                EntModelo.Id = Int32.Parse(this.grdModelo[0, fila].Value.ToString());
                EntModelo.pModelo = this.grdModelo[1, fila].Value.ToString();
                txtModelo.Text = EntModelo.pModelo;
                txtMensaje.Text = "Modelo: " + this.grdModelo[1, fila].Value.ToString();
            }
        }
        private void buscar(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buscar();
            }
        }
        //Metodo buscar validad el tipo de dato y los agrega a las direfenres
        //columnas despues carga el datagriew
        private void buscar()
        {
            try
            {
                if (rbCodigo.Checked)
                {
                    modelos = BllModelo.cargarModeloPorId(Int32.Parse(txtBuscar.Text));
                }
                if (rbModelo.Checked)
                {
                    modelos = BllModelo.cargarModeloPorModelo(txtBuscar.Text);
                }
                this.grdModelo.DataSource = modelos;
                txtRegistro.Text = "" + modelos.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
