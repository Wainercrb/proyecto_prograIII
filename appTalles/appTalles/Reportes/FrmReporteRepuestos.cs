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

namespace appTalles.Reportes
{
    public partial class FrmReporteRepuestos : Form
    {
        private BLL.Orden BllOrden;
        public FrmReporteRepuestos()
        {
            InitializeComponent();
            BllOrden = new BLL.Orden();
            cargar();
        }
        private void cargar() {

            CryRepuestos oOrdenes = new CryRepuestos();
            oOrdenes.SetDataSource(BllOrden.cargarInformeOrdenRepuesto());
            this.reporteRepuesto.ReportSource = oOrdenes;


        }
    }
}
