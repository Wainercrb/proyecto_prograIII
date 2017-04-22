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
    public partial class FrmInformeOrdenPendiente : Form
    {
        private BLL.Orden BllOrden;
        public FrmInformeOrdenPendiente()
        {
            InitializeComponent();
            BllOrden = new BLL.Orden();
            cargar();
        }
        //Metodo carga el reporte y le agrega los datos
        //al mismo
        private void cargar()
        {
            try
            {
                CryOrdenPendiente cry = new CryOrdenPendiente();
                cry.SetDataSource(BllOrden.cargarInformeOrdenPendiente(dtDia.Value));
                this.reporteInforme.ReportSource = cry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error de transación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
