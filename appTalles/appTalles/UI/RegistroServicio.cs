using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ENT;
using System.Collections.Generic;

namespace Vista
{
    public partial class RegistroServicio : Form
    {
        private BLL.Servicio BllServicio;
        private ENT.Servicio EntServicio;
        private List<ENT.Servicio> servicios;
        public RegistroServicio()
        {
            InitializeComponent();
            BllServicio = new BLL.Servicio();
            EntServicio = new ENT.Servicio();
            servicios = new List<ENT.Servicio>();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntServicio.pServicio = txtServicio.Text;
                EntServicio.Precio = int.Parse(txtPrecio.Text);
                EntServicio.Impuesto = Double.Parse(txtImpuesto.Text);
                BllServicio.agregarServicio(EntServicio);
                limpiarDatos();
                cargar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?","Error", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    BllServicio.eliminarServicio(EntServicio);
                    limpiarDatos();
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        public void cargar()
        {
            try
            {
                servicios = BllServicio.cargarServicio();
                grdServicios.DataSource = servicios;
                txtCantidadRegistros.Text = ""+servicios.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }
        private void EditarServicio(object sender, EventArgs e)
        {
            if (this.grdServicios.Rows.Count > 0)
            {
                int fila = this.grdServicios.CurrentRow.Index;
                EntServicio.Id = Int32.Parse(this.grdServicios[0, fila].Value.ToString());
                txtServicio.Text = this.grdServicios[1, fila].Value.ToString();
                txtPrecio.Text = this.grdServicios[2, fila].Value.ToString();
                txtImpuesto.Text = this.grdServicios[3, fila].Value.ToString();
            }
        }
        private void seleccionServicio(object sender, MouseEventArgs e)
        {
            if (this.grdServicios.Rows.Count > 0)
            {
                int fila = this.grdServicios.CurrentRow.Index;
                EntServicio.Id = Int32.Parse(grdServicios[0, fila].Value.ToString());
                txtMensaje.Text = "Codigo, " + grdServicios[0, fila].Value.ToString() + ", servicio " + grdServicios[1, fila].Value.ToString();
            }
        }
        private void limpiarDatos()
        {
            txtPrecio.Text = "";
            txtServicio.Text = "";
            txtImpuesto.Text = "";
            txtMensaje.Text = "";
            EntServicio = new ENT.Servicio();
        }
     
        private void enterSeleccion(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (rbBuscarCodigo.Checked)
                    {
                        buscar("", Int32.Parse(txtBuscar.Text), "id_servicio");
                    }
                    if (rbBuscarServicio.Checked)
                    {
                        buscar(txtBuscar.Text, 0, "servcio");
                    }
                    if (rbBuscaPrecio.Checked)
                    {
                        buscar("", Int32.Parse(txtBuscar.Text), "precio");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar datos",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void buscar(string cadena, int numero, string columna) {
            try
            {              
                if (cadena == "" && numero > 0)
                {
                    servicios = BllServicio.buscarIntServicio(numero, columna);
                }
                if (numero == 0 && cadena != "")
                {
                    servicios = BllServicio.buscarStringServicio(cadena, columna);
                }
                grdServicios.DataSource = servicios;
                txtCantidadRegistros.Text = servicios.Count+"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }       
        }
        private void validarNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}


