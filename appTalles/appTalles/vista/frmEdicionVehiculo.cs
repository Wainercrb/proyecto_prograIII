using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;

namespace Vista
{
    public partial class frmEdicionVehiculo : Form
    {
        public frmEdicionVehiculo()
        {
            InitializeComponent();
            llenarComboMarca();
            llenarComboTipo();
        }

        public void llenarComboMarca()
        {
            this.cbMarca.Items.Clear();
            MarcaD oMarcaD = new MarcaD();
            List<MarcaVehiculo> marcas = oMarcaD.obtenerMarcas();

            foreach (MarcaVehiculo oMarcaL in marcas)
            {
                this.cbMarca.Items.Add(oMarcaL.Marca);
            }
        }


        public void llenarComboTipo()
        {
            this.cbTipo.Items.Clear();
            TipoD oTipoD = new TipoD();
            List<TipoVehiculo> tipos = oTipoD.obtenerTipos();

            foreach (TipoVehiculo oTipoL in tipos)
            {
                this.cbTipo.Items.Add(oTipoL.Tipo);
            }
        }


    
  
    }
}
