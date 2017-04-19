using appTalles.Reportes;
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
    public partial class FrmInformeOrdenFinalizada : Form
    {
        public FrmInformeOrdenFinalizada()
        {
            InitializeComponent();
        }

        private void cargar() {

            BLL.Orden BllOrden = new BLL.Orden();
            CyOrdenFinalizada oOrdenes = new CyOrdenFinalizada();
            oOrdenes.SetDataSource(BllOrden.cargarInformeOrdenFinalizada(dtBuscar.Value));
            this.ReporteOrdenFinalizada.ReportSource = oOrdenes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
