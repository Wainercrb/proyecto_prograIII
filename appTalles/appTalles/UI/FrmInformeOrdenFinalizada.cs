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
            cargar();
        }

        private void cargar() {

            DAL.Orden orden = new DAL.Orden();
            CyOrdenFinalizada oOrdenes = new CyOrdenFinalizada();
            oOrdenes.SetDataSource(orden.cargarDataTableOrden(DateTime.Today));
            this.ReporteOrdenFinalizada.ReportSource = oOrdenes;


        }
    }
}
