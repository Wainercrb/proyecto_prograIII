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
    public partial class FrmRepuestoFrecuente : Form
    {
        private BLL.Repuesto BllRepuesto;
        public FrmRepuestoFrecuente()
        {
            InitializeComponent();
            BllRepuesto = new BLL.Repuesto();
            cargar();
        }
        private void cargar() {
            try
            {
                CryRepuestoFrecuente cry = new CryRepuestoFrecuente();
                cry.SetDataSource(BllRepuesto.cargarRepuestoFrecuentes());
                this.reporte.ReportSource = cry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }
        }
       
    }
}
