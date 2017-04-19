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
using Vista;
using appTalles.Vista;
using ENT;
using appTalles.UI;
using appTalles.Reportes;

namespace Vista


{
    public partial class FrmPrincipal : Form
    {

        private ENT.Empleado empleado;
        private ENT.Empleado empleado1;

        public FrmPrincipal()
        {
            InitializeComponent();


        }
        public FrmPrincipal(ENT.Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambio frm = new FrmCambio(empleado);
            frm.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.ShowDialog();
        }

        private void registroVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdicionVehiculo frm = new frmEdicionVehiculo();
            frm.ShowDialog();
        }

        private void registroClasesVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipo frm = new FrmTipo();
            frm.ShowDialog();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void registroEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empleado.Permiso == "Administrador")
            {
                FrmEmpleado frm = new FrmEmpleado();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función");
        }
        private void registroCatalogoRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepuestos frm = new FrmRepuestos();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroCatalogoReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroServicio frm = new RegistroServicio();
            frm.ShowDialog();
        }

        private void crearOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenReparaciones frm = new FrmOrdenReparaciones();
            frm.Show();           
        }
        private void registrarReparacionesRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrden frm = new FrmOrden();
            frm.ShowDialog();
        }

        private void finalizoOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenFinalizada frm = new FrmOrdenFinalizada();
            frm.ShowDialog();
        }

        private void facturaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repor frm = new repor();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.Orden or = new DAL.Orden();
            
            this.grdPrueba.DataSource = or.cargarDataTableOrden(DateTime.Today);
        }

        private void informeOrdenFinalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformeOrdenFinalizada frm = new FrmInformeOrdenFinalizada();
            frm.ShowDialog();
        }

        private void informeReparacionesAtendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteServicios frm = new FrmReporteServicios();
            frm.ShowDialog();
        }

        private void informeEstadisticoAtendidioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteRepuestos frm = new FrmReporteRepuestos();
            frm.ShowDialog();
        }
    }
}
