using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;
using System.Collections.Generic;

namespace Vista
{
    public partial class RegistroServicio : Form
    {

        private ServicioD oServicioD;
        private Servicio servicio;

        public RegistroServicio()
        {
            InitializeComponent();
            oServicioD = new ServicioD();
            servicio = new Servicio();
            cargarDataGriew();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargar()
        {
            bool estado = false;

            List<Servicio> lsServicios = oServicioD.Obtenerservicios(ref estado);

            if (estado)
            {
                this.grdServicios.DataSource = lsServicios;
                txtCantidadRegistros.Text = "" + lsServicios.Count();
            }
            else
            {
                MessageBox.Show("Detalles: " + oServicioD.Error, "¡Error al cargar los servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text == "" || txtDetalles.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            servicio.pServicio = txtServicio.Text;
            servicio.Detalle = txtDetalles.Text;
            if (servicio.Id > 0)
            {

                if (!oServicioD.actualizarServicio(servicio))
                {
                    txtMensaje.Text = "Se agrego la marca correctamente";
                    limpiarDatos();
                    cargar();
                }
                else
                {

                    MessageBox.Show("Detalles: " + oServicioD.ErrorMsg, "!Error al agregar el servicio¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {

                if (!oServicioD.agregarservicio(servicio))
                {
                    txtMensaje.Text = "Empleado Agregado Correctamente";
                    limpiarDatos();
                    cargar();


                }
                else
                {
                    MessageBox.Show("Detalles: " +
                                        oServicioD.ErrorMsg, "!Error al agregar el servicio¡",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.grdServicios.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.grdServicios.CurrentRow.Index;
                    servicio.Id = Convert.ToInt32(this.grdServicios[0, fila].Value.ToString());

                    if (!oServicioD.borrarservicio(servicio))
                    {
                        cargar();
                        txtMensaje.Text = "Empleado borrado";
                    }
                    else
                    {
                        MessageBox.Show("Error borrando Empleado: " +
                                   oServicioD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void limpiarDatos()
        {

            txtDetalles.Text = "";
            txtServicio.Text = "";
            servicio = new Servicio();

        }

        private void cargarDataGriew()
        {


            this.grdServicios.Columns["Id"].Width = 70;
            this.grdServicios.Columns["pServicio"].Width = 85;
            this.grdServicios.Columns["Detalle"].Width = 85;

        }

        private void EditarServicio(object sender, EventArgs e)
        {
            if (this.grdServicios.Rows.Count > 0)
            {
                int fila = this.grdServicios.CurrentRow.Index;

                servicio.Id = Int32.Parse(grdServicios[0, fila].Value.ToString());
                txtServicio.Text = grdServicios[1, fila].Value.ToString();
                txtDetalles.Text = grdServicios[2, fila].Value.ToString();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
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
                List<Servicio> lsServicos = oServicioD.buscarServicios(txtBuscar.Text);
                txtCantidadRegistros.Text = "" + lsServicos.Count();
                if (lsServicos.Count() <= 0)
                {
                    txtMensaje.Text = "No hay tipos registrados";
                }
                this.grdServicios.DataSource = lsServicos;
            }
        }

    }
}


