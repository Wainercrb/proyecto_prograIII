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
        AccesoDatosPostgre cnx;
        private int guardar_id;
        private int fila;
        public RegistroServicio(AccesoDatosPostgre pnx)
        {
            InitializeComponent();
            this.cnx = pnx;
            cargar();
        }

        public RegistroServicio(int guardar_id)
        {
            this.guardar_id = guardar_id;
        }

        public RegistroServicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void cargar()
        {
            bool estado = true;
            ServicioD server = new ServicioD(cnx);
          
            List<Servicio> lsServicios = server.Obtenerservicios(ref estado);
         
            if (estado)
            {
                this.grdServicios.DataSource = lsServicios;
                txtCantidadRegistros.Text = "" + lsServicios.Count();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text=="" ||txtDetalles.Text=="")
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Datos.ServicioD UD = new Datos.ServicioD(this.cnx);
            if (UD.agregarservicio(getservicio()))
            {
                MessageBox.Show("Empleado Agregado Correctamente");
            
            }
            else
            {
                MessageBox.Show("Error agregando el Empleado: " +
                                    UD.Error, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private Servicio  getservicio()
        {

            return new Logica.Servicio(guardar_id, txtServicio.Text, txtDetalles.Text);
       
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

                    fila = this.grdServicios.CurrentRow.Index;
                    guardar_id = Convert.ToInt32(this.grdServicios[0, fila].Value.ToString());
                    Servicio servericio = new Servicio(guardar_id,
                       this.grdServicios[1, fila].Value.ToString(), this.grdServicios[2, fila].Value.ToString()
                       );
                    ServicioD serv = new ServicioD(this.cnx);
                    if ( serv.borrarservicio(servericio))
                    {
                        cargar();
                        MessageBox.Show("Empleado borrado");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando Empleado: " +
                                   serv.Error, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}


