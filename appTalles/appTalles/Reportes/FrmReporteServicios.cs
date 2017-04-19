using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTalles.Reportes
{
    public partial class FrmReporteServicios : Form
    {
        private BLL.Empleado BllEmpleado;
        private List<ENT.Empleado> empleados;
        private ENT.Empleado EntEmpleado;
        private BLL.Orden BllOrden;
        public FrmReporteServicios()
        {
            InitializeComponent();
            BllEmpleado = new BLL.Empleado();
            empleados = new List<ENT.Empleado>();
            EntEmpleado = new ENT.Empleado();
            BllOrden = new BLL.Orden();
            llenarComboEncargado();
        }

        private void llenarComboEncargado()
        {
            try
            {
                this.cbEmpleado.Items.Clear();
                empleados = BllEmpleado.cargarEmpleados();
                foreach (ENT.Empleado oEmpleados in empleados)
                {
                    this.cbEmpleado.Items.Add(oEmpleados);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void seleccionComboEncargado()
        {
            if (cbEmpleado.SelectedIndex != -1)
            {
                int selectedIndex = cbEmpleado.SelectedIndex;
                ENT.Empleado selectedItem = (ENT.Empleado)cbEmpleado.SelectedItem;
                EntEmpleado.Id = selectedItem.Id;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionComboEncargado();
               
        
                CyServicio oOrdenes = new CyServicio();
                oOrdenes.SetDataSource(BllOrden.cargarInformeOrdenServicios(EntEmpleado.Id, dtFechaUno.Value, dtFechaDos.Value));
                this.reporteServicio.ReportSource = oOrdenes;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }
    }
}
