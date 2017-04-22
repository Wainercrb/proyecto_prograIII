using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTalles.RP
{
    public partial class FrmServicioPorEmpleado : Form
    {
        private BLL.Servicio bllServicio;
        private BLL.Empleado BllEmpleado;
        private List<ENT.Empleado> empleados;
        public FrmServicioPorEmpleado()
        {
            InitializeComponent();
            bllServicio = new BLL.Servicio();
            BllEmpleado = new BLL.Empleado();
            empleados = new List<ENT.Empleado>();
            llenarComboEncargado();
        }
        //Metodo istancia el reporte que carga los datos
        //y asigna esos datos al informe
        private void cargar()
        {
            try
            {
                CryServicioPorEmpleado cry = new CryServicioPorEmpleado();
                cry.SetDataSource(bllServicio.cargarServiciosPorEmpleadoConFecha(seleccionComboEncargado(), dtDel.Value, dtAl.Value));
                this.reporte.ReportSource = cry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo retorna una lista de empleados
        //y las agrega el combobox de encargado
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

        //Metodo selecciona un encargado del combobox y lo agrega
        //a la entidad encargado
        private int seleccionComboEncargado()
        {
            int id = 0;
            if (cbEmpleado.SelectedIndex != -1)
            {
                int selectedIndex = cbEmpleado.SelectedIndex;
                ENT.Empleado selectedItem = (ENT.Empleado)cbEmpleado.SelectedItem;
                id = selectedItem.Id;
            }
            return id;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
