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
    public partial class FrmFacturaOrden : Form
    {
        private BLL.Orden BllOrden;
        private List<ENT.Orden> ordenes;
        private BLL.OrdenRepuesto BllOrdenRepuesto;
        private BLL.OrdenServicio BllOrdenServicio;
        private BLL.Cliente BllCliente;
        public FrmFacturaOrden()
        {
            InitializeComponent();
            BllOrden = new BLL.Orden();
            ordenes = new List<ENT.Orden>();
            BllOrdenRepuesto = new BLL.OrdenRepuesto();
            BllOrdenServicio = new BLL.OrdenServicio();
            BllCliente = new BLL.Cliente();                
            llenarComboOrden();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }
        //Metodo los direntes reportes y le agrega los
        //subreportes y carga el reporte principal
        private void cargar() {
            try { 
                CryFacturaOrden cry = new CryFacturaOrden();
                cry.Subreports[0].SetDataSource(BllOrden.cargarInformeOrdenPorId(seleccionComboOrden()));
                cry.Subreports[1].SetDataSource(BllOrdenRepuesto.cargarInformeRepuestoPorId(seleccionComboOrden()));
                cry.Subreports[2].SetDataSource(BllOrdenServicio.cargarInformeServicoPorId(seleccionComboOrden()));
                cry.SetDataSource(BllCliente.cargarInformeClientePorIdOrden(seleccionComboOrden()));
                this.ReporteV.ReportSource = cry;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }   
        }

        //Metodo recorre la lista y agrega los 
        //items al combobox a la misma lista
        private void llenarComboOrden() {
            try
            {
                this.cbComboOrden.Items.Clear();
                ordenes = BllOrden.cargarOrden();
                foreach (ENT.Orden oOrdenes in ordenes)
                {
                    this.cbComboOrden.Items.Add(oOrdenes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo relecciona un item del combobox
        //y retorna un int seleccionado
        private int seleccionComboOrden()
        {
            int id= 0;
            if (cbComboOrden.SelectedIndex != -1)
            {
                int selectedIndex = cbComboOrden.SelectedIndex;
                ENT.Orden selectedItem = (ENT.Orden)cbComboOrden.SelectedItem;
                id = selectedItem.Id;
            }
            return id;
        }
    }
}
