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
    public partial class FromReporteOrden : Form
    {
        private BLL.Orden BllOrden;
        public FromReporteOrden()
        {
            InitializeComponent();
            BllOrden = new BLL.Orden();
            carcarReportes();

        }

        private void carcarReportes()
        {
           
            //DAL.Orden DalOrden = new DAL.Orden();
            //DAL.Repuesto DalRepuesto = new DAL.Repuesto();
            //List<ENT.RepuestoVehiculo> repuestoENT = DalRepuesto.obtenerReporteRepuesto(1);

            ////CrOrden oOrdenes = new CrOrden();
            ////oOrdenes.SetDataSource(DalOrden.consulaOrdenReporte(1));
            //////oOrdenes.SetDataSource(repuestoENT);
            ////this.visorReporte.ReportSource = oOrdenes;


            ////--------

            // oOrdenes.SetDataSource(repuestoENT);

            //this.visorReporte.ReportSource = oOrdenes;


        }
    }
}
