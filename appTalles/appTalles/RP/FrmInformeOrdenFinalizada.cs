using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appTalles.RP;

namespace appTalles.RP
{
    public partial class FrmInformeOrdenFinalizada : Form
    {
        private BLL.Orden BllOrden;
        public FrmInformeOrdenFinalizada()
        {
            InitializeComponent();
            BllOrden = new BLL.Orden();
            cargar();
        }
        private void cargar() {
            try
            {
                CryOrdenFinalizada cry = new CryOrdenFinalizada();
                cry.SetDataSource(BllOrden.cargarInformeOrdenFinalizada(dtDia.Value));
                this.reporte.ReportSource = cry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
