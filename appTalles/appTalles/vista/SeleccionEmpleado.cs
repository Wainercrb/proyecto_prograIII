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

namespace Vista
{
    public partial class SeleccionEmpleado : Form
    {
        private Empleado empleado;
        private EmpledoD empleadoD;
        public SeleccionEmpleado()
        {
            InitializeComponent();
            empleado = new Empleado();
            empleadoD = new EmpledoD();
            cargar();
        }

        private void cargar()
        {
            bool estado = true;
            EmpledoD pEmpleado = new EmpledoD();
            List<Empleado> lsMarcas = pEmpleado.ObtenerEmpleados(ref estado);
            if (estado)
            {
                this.grdEmpleado.DataSource = lsMarcas;
            }
        }

        public Empleado getEmpleado() {
            return empleado;
        }

        private void seleccion(object sender, EventArgs e)
        {
            int fila = this.grdEmpleado.CurrentRow.Index;

            if (grdEmpleado.RowCount > 0)
            {
                empleado.Id = Int32.Parse(grdEmpleado[0, fila].Value.ToString());
                this.Close();
            }
        }
    }
}
