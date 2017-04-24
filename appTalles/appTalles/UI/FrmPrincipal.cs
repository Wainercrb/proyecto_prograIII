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
using appTalles.UI;
using appTalles.RP;
using System.Threading;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {

        private ENT.Empleado EntEmpleado;
        private ENT.Orden EntOrden;
        private BLL.Orden BllOrden;
        private List<ENT.Orden> ordenes;
        private Thread cierre;
        private bool estado = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            EntOrden = new ENT.Orden();
            BllOrden = new BLL.Orden();
            ordenes = new List<ENT.Orden>();
            cargarOrden();
          


        }
        public FrmPrincipal(ENT.Empleado empleado)
        {
            InitializeComponent();
            this.EntEmpleado = empleado;
            EntOrden = new ENT.Orden();
            BllOrden = new BLL.Orden();
            ordenes = new List<ENT.Orden>();
            txtUsuario.Text = empleado.Usuario;
            cargarOrden();
        }
        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Permiso == "Administrador")
            {
                FrmCambio frm = new FrmCambio(EntEmpleado);
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                frmMarca frm = new frmMarca();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registroVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                frmEdicionVehiculo frm = new frmEdicionVehiculo();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registroClasesVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                FrmTipo frm = new FrmTipo();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                frmCliente frm = new frmCliente();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registroEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Permiso == "Administrador")
            {
                FrmEmpleado frm = new FrmEmpleado();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void registroCatalogoRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                FrmRepuestos frm = new FrmRepuestos();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void registroCatalogoReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                RegistroServicio frm = new RegistroServicio();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void crearOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                FrmOrdenReparaciones frm = new FrmOrdenReparaciones();
                frm.Show();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void registrarReparacionesRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Mecanico" || EntEmpleado.Puesto == "Jefe")
            {
                FrmOrden frm = new FrmOrden();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void finalizoOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Mecanico" || EntEmpleado.Puesto == "Jefe")
            {
                FrmOrdenFinalizada frm = new FrmOrdenFinalizada(EntEmpleado);
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void facturaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntEmpleado.Puesto == "Cajero" || EntEmpleado.Puesto == "Jefe")
            {
                FrmFacturaOrden frm = new FrmFacturaOrden();
                frm.ShowDialog();
                return;
            }
            MessageBox.Show("No tienes permisos para acceder a esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void informeOrdenFinalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformeOrdenFinalizada frm = new FrmInformeOrdenFinalizada();
            frm.ShowDialog();

            //FrmRepuestoFrecuentes frm = new FrmRepuestoFrecuentes();
            //frm.ShowDialog();

        }

        private void informeReparacionesAtendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicioPorEmpleado frm = new FrmServicioPorEmpleado();
            frm.ShowDialog();
        }

        private void informeEstadisticoAtendidioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepuestoFrecuente frm = new FrmRepuestoFrecuente();
            frm.ShowDialog();
        }

        private void cargarOrden()
        {
            try
            {
                ordenes = BllOrden.cargarStringOrden("Pendiente", "estado");
                this.grdOrdenes.DataSource = ordenes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        
        private void seleccionOrden(object sender, MouseEventArgs e)
        {

            if (this.grdOrdenes.Rows.Count > 0)
            {
                int fila = this.grdOrdenes.CurrentRow.Index;
                EntOrden.Id = Int32.Parse(this.grdOrdenes[0, fila].Value.ToString());
                EntOrden.FechaIngreso = DateTime.Parse(this.grdOrdenes[1, fila].Value.ToString());
                EntOrden.FechaSalida = DateTime.Parse(this.grdOrdenes[2, fila].Value.ToString());
                EntOrden.FechaFacturacion = DateTime.Parse(this.grdOrdenes[3, fila].Value.ToString());
                EntOrden.Estado = this.grdOrdenes[4, fila].Value.ToString();
                EntOrden.CostoTotal = Double.Parse(this.grdOrdenes[5, fila].Value.ToString());
                EntOrden.Empleado = (ENT.Empleado)grdOrdenes[7, fila].Value;
                EntOrden.Vehiculo = (ENT.Vehiculo)this.grdOrdenes[6, fila].Value;
                FrmOrdenReparaciones frm = new FrmOrdenReparaciones(EntOrden);
                frm.ShowDialog();
                cargarOrden();
            }
        }

        private void informeOrdenPendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformeOrdenPendiente frm = new FrmInformeOrdenPendiente();
            frm.ShowDialog();
        }

        private void mantenimientoModelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelo frm = new FrmModelo();
            frm.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Close();
            cierre = new Thread(llamar_segundo);
            cierre.SetApartmentState(ApartmentState.STA);
            cierre.Start();
            estado = true;
            return;
        }


        private void llamar_segundo(Object obj)
        {
            Application.Run(new FrmLogin());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
