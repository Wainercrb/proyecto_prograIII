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
    public partial class FrmCambio : Form
    {

        public string user;
        private EmpledoD pEmpleado;
        private Empleado empleado;
        private string contrasenaAntes;

        public FrmCambio()
        {
            InitializeComponent();
            pEmpleado = new EmpledoD();
            txtUsuario.Text = empleado.Usuario;

        }

        public FrmCambio(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            pEmpleado = new EmpledoD();
            txtUsuario.Text = empleado.Usuario;
        }

        private void bntActual_Click_1(object sender, EventArgs e)
        {
            ingresar();
        }

   

        private void ingresar() {

            string nueva = "";

            if (btnConfirmar.Text == "CONFIRMAR")
            {
                if (txtActual.Text == empleado.Contrasenna)
                {
                    btnConfirmar.Text = "CAMBIAR";
                    txtInformacion.Text = "INGRESE SU CONTRASEÑA NUEVA";
                    txtActual.Text = "";
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtActual.Text = "";
                }

                return;

            }

            if (btnConfirmar.Text == "CAMBIAR")
            {
                if (txtActual.Text.ToString().Length < 6)
                {
                    MessageBox.Show("Contraseña muy corta");
                    txtActual.Text = "";
                    return;
                }

                nueva = txtActual.Text;
                contrasenaAntes = txtActual.Text;
                txtActual.Text = "";
                txtInformacion.Text = "INGRESE LA VERIFICACIÓN.";
                btnConfirmar.Text = "VERIFICAR";
                return;

            }

            if (btnConfirmar.Text == "VERIFICAR")
            {
                if (contrasenaAntes == txtActual.Text)
                {
                    if (!pEmpleado.cambioContrasenna(empleado, txtActual.Text))
                    {
                        MessageBox.Show("Se combio la contraseña");
                        txtInformacion.Text = "INGRESE CONTRASEÑA ACTUAL";
                        btnConfirmar.Text = "COMFIRMAR";
                        empleado.Contrasenna = contrasenaAntes;
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Error al actualizar la contraseña " + pEmpleado.ErrorMsg);

                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    btnConfirmar.Text = "CAMBIAR";
                    txtInformacion.Text = "INGRESE SU CONTRASEÑA NUEVA";
                    txtActual.Text = "";
                }

                return;
            }

        }

        private void ingresarEnte(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ingresar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
