using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Vista;
using ENT;
using System.Threading;


namespace Vista
{
    public partial class FrmLogin : Form
    {
        private Thread cierre;
        private ENT.Empleado EntEmpleado;
        private BLL.Empleado BllEmpleado;
        private bool estado = false;

        public FrmLogin()
        {
            EntEmpleado = new ENT.Empleado();
            BllEmpleado = new BLL.Empleado();
            InitializeComponent();
        }
        private void llamar_segundo(Object obj)
        {
            Application.Run(new FrmPrincipal(EntEmpleado));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void seleccionIngresaar(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ingresar();
            }
        }

        internal bool correcto()
        {
            return estado;
        }

        private void ingresar()
        {
            try
            {
                EntEmpleado.Usuario = txtUsuario.Text;
                EntEmpleado.Contrasenna = txtcontraseña.Text;
                DAL.Empleado empleadoD = new DAL.Empleado();
                List<ENT.Empleado> pEmpleado = BllEmpleado.cargarEmpleados();
                for (int i = 0; i < pEmpleado.Count; i++)
                {
                    if (pEmpleado[i].Usuario.Equals(EntEmpleado.Usuario) && pEmpleado[i].Contrasenna.Equals(EntEmpleado.Contrasenna))
                    {
                        EntEmpleado = pEmpleado[i];
                        this.Close();
                        cierre = new Thread(llamar_segundo);
                        cierre.SetApartmentState(ApartmentState.STA);
                        cierre.Start();
                        estado = true;
                        return;
                    }
                }
                MessageBox.Show("Por favor verifique su usuario y contraseña que sean correctos.", "!Error al ingresar¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Información",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

