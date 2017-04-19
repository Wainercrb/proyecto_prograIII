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
    public partial class repor : Form
    {
        public repor()
        {
            InitializeComponent();
            //cargar();
            cargar2();
        }


        private void cargar() {




            //DAL.Orden DalOrden = new DAL.Orden();
       
            ////List<ENT.RepuestoVehiculo> repuestoENT = DalRepuesto.obtenerReporteRepuesto(1);

            //CryRepuesto oOrdenes = new CryRepuesto();
            //oOrdenes.SetDataSource(DalOrden.consulaOrdenReporte(1));
            //if (DalOrden.Error)
            //{
            //    MessageBox.Show(DalOrden.ErrorMsg);
            //}
            //////oOrdenes.SetDataSource(repuestoENT);
            ////this.visorReporte.ReportSource = oOrdenes;


            ////--------

            ////oOrdenes.SetDataSource(repuestoENT);

            //this.report.ReportSource = oOrdenes;

        }

        private void cargar2()
        {




            //DAL.Orden DalOrden = new DAL.Orden();

            ////List<ENT.RepuestoVehiculo> repuestoENT = DalRepuesto.obtenerReporteRepuesto(1);
            DAL.Repuesto re = new DAL.Repuesto();
            CrystalReport1 oOrdenes = new CrystalReport1();
            oOrdenes.SetDataSource(re.obtenerServiioDataset());
            oOrdenes.SetDataSource(re.obtenerRepestoDataset());
         
            //this.visorReporte.ReportSource = oOrdenes;


            ////--------

            ////oOrdenes.SetDataSource(repuestoENT);

            this.report.ReportSource = oOrdenes;

        }
    }
}
