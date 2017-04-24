using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTalles.UI
{
    public partial class FrmOrdenFinalizada : Form
    {
        private ENT.Orden EntOrden;
        private BLL.Orden BllOrden;
        private List<ENT.Orden> ordenes;
        private ENT.Empleado EntEmpleado;
        string estado;
        public FrmOrdenFinalizada(ENT.Empleado empleado)
        {
            EntOrden = new ENT.Orden();
            BllOrden = new BLL.Orden();
            ordenes = new List<ENT.Orden>();
            this.EntEmpleado = empleado;
            InitializeComponent();
        }
        private void btnFinalizada_Click(object sender, EventArgs e)
        {
            estado = "Finalizado";
            cargarOrden(estado, "estado");
        }
        private void cargarOrden(string valor, string columna) {
            try
            {
                ordenes = BllOrden.cargarStringOrden(valor, columna);
                this.grdOrdenes.DataSource = ordenes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }           
        }
        private void btnPendiente_Click(object sender, EventArgs e)
        {
            estado = "Pendiente";
            cargarOrden(estado, "estado");
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
                txtSeleccion.Text = "Codigo: " + EntOrden.Id +" Estado: "+ EntOrden.Estado ;
                if (this.grdOrdenes[4, fila].Value.ToString() == "Pendiente")
                {
                    btnFinalizarOrden.Enabled = true;
                    btnReversarOrden.Enabled = false;
                }
                else {

                    btnReversarOrden.Enabled = true;
                    btnFinalizarOrden.Enabled = false;
                }
            }
        }

        private void btnFinalizarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificarEmpleado())
                {
                    MessageBox.Show("No tiene permiso para finalizar esta orden");
                    return;
                }
                EntOrden.Estado = "Finalizado";
                BllOrden.actualizarEstadoOrden(EntOrden, "Finalizado", DateTime.Today);
                txtSeleccion.Text = "Orden finalizado correctamente";
                cargarOrden(estado, "estado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnReversarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificarEmpleado())
                {
                    MessageBox.Show("No tiene permiso para reversar esta orden");
                    return;
                }
                EntOrden.Estado = "Pendiente";
                BllOrden.actualizarEstadoOrden(EntOrden, "Pendiente", DateTime.Parse("0001-01-01"));
                txtSeleccion.Text = "Orden reversada correctamente";
                cargarOrden(estado, "estado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private bool verificarEmpleado() {

            foreach (ENT.Orden item in ordenes)
            {
                if (item.Empleado.Usuario == EntEmpleado.Usuario && item.Empleado.Contrasenna == EntEmpleado.Contrasenna)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
