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
using appTalles.Vista;

namespace Vista


{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.ShowDialog();
        }
    }
}
