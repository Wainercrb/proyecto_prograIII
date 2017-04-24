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
                EntServicio.Precio = Double.Parse(txtPrecio.Text);
                EntServicio.Impuesto = Double.Parse(txtImpuesto.Text);
                EntServicio.Descripcion = txtDetalle.Text;
                EntServicio.DiasPromedio = Int32.Parse(npHorasPromedio.Value.ToString());
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
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?", "Error", MessageBoxButtons.YesNo,
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
        private void EditarServicio(object sender, EventArgs e)
        {
            if (this.grdServicios.Rows.Count > 0)
            {
                int fila = this.grdServicios.CurrentRow.Index;
                EntServicio.Id = Int32.Parse(this.grdServicios[0, fila].Value.ToString());
                txtServicio.Text = this.grdServicios[1, fila].Value.ToString();
                txtPrecio.Text = this.grdServicios[2, fila].Value.ToString();
                txtImpuesto.Text = this.grdServicios[3, fila].Value.ToString();
                txtDetalle.Text = this.grdServicios[4, fila].Value.ToString();
                npHorasPromedio.Value = Int32.Parse(this.grdServicios[5, fila].Value.ToString());
            }
        }
        private void seleccionServicio(object sender, MouseEventArgs e)
        {
            if (this.grdServicios.Rows.Count > 0)
            {
                int fila = this.grdServicios.CurrentRow.Index;
                txtMensaje.Text = "Codigo, " + grdServicios[0, fila].Value.ToString() + ", servicio " + grdServicios[1, fila].Value.ToString();
            }
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
                MessageBox.Show(ex.Message, "Error al ingresar datos", MessageBoxButtons.OK,
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
        //Metodo retorna una lista desde la clase BLL.servicio
        //y la agrega al datagriew
        public void cargar()
        {
            try
            {
                servicios = BllServicio.cargarServicio();
                grdServicios.DataSource = servicios;
                txtCantidadRegistros.Text = "" + servicios.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        //Metodo limpa los componentes utilizados en el frame
        private void limpiarDatos()
        {
            txtPrecio.Text = "";
            txtServicio.Text = "";
            txtImpuesto.Text = "";
            txtMensaje.Text = "";
            EntServicio = new ENT.Servicio();
        }
        //Metodo recibe una lista x con los valores a buscar que recibe
        //este metodo a buscar y esa lista la carga datagriew
        private void buscar(string cadena, int numero, string columna)
        {
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
                txtCantidadRegistros.Text = servicios.Count + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void validarImpuesto(object sender, KeyPressEventArgs e)
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
        private void validarNumeros(object sender, KeyPressEventArgs e)
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


