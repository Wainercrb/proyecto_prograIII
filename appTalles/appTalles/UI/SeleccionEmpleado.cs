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
        private ENT.Empleado empleado;
        private DAL.Empleado empleadoD;
        public SeleccionEmpleado()
        {
            InitializeComponent();
            empleado = new ENT.Empleado();
            empleadoD = new DAL.Empleado();
            cargar();
        }

        private void cargar()
        {
            //bool estado = true;
            //Empledo pEmpleado = new Empledo();
            //List<Empleado> lsMarcas = pEmpleado.ObtenerEmpleados(ref estado);
            //if (estado)
            //{
            //    this.grdEmpleado.DataSource = lsMarcas;
            //}
        }

        public ENT.Empleado getEmpleado() {
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
