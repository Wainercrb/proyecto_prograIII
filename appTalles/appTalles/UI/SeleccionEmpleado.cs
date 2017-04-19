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

namespace Vista
{
    public partial class SeleccionEmpleado : Form
    {
        private ENT.Empleado EntEmpleado;
        private BLL.Empleado BllEmpleado;

        public ENT.Empleado EntEmpleado1
        {
            get
            {
                return EntEmpleado;
            }

            set
            {
                EntEmpleado = value;
            }
        }

        public SeleccionEmpleado()
        {
            InitializeComponent();
            EntEmpleado = new ENT.Empleado();
            BllEmpleado = new BLL.Empleado();
            cargar();
        }

        private void cargar()
        {
            try
            {
                List<ENT.Empleado> lsMarcas = BllEmpleado.cargarEmpleados();
                this.grdEmpleado.DataSource = lsMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seleccion(object sender, EventArgs e)
        {

            if (this.grdEmpleado.RowCount >= 0)
            {
                int fila = this.grdEmpleado.CurrentRow.Index;
                EntEmpleado.Id = Int32.Parse(this.grdEmpleado[1, fila].Value.ToString());
                this.Close();
            }
        }
    }
}
