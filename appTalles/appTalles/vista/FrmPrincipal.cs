using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;
using Vista;
using appTalles.Vista;

namespace Vista


{
    public partial class FrmPrincipal : Form
    {

        private Empleado empleado;

        public FrmPrincipal()
        {
            InitializeComponent();


        }
        public FrmPrincipal(Empleado empleado)
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
            FrmOrden frm = new FrmOrden();
            frm.Show();
           
        }
    }
}
