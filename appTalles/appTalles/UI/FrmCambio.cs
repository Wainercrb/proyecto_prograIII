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
using ENT;

namespace Vista
{
    public partial class FrmCambio : Form
    {

        public string user;
        private BLL.Empleado BllEmpleado;
        private ENT.Empleado EntEmpleado;
        private string contrasenaAntes;

        public FrmCambio()
        {
            InitializeComponent();
            BllEmpleado = new BLL.Empleado();
            txtUsuario.Text = EntEmpleado.Usuario;
        }

        public FrmCambio(ENT.Empleado empleado)
        {
            InitializeComponent();
            this.EntEmpleado = empleado;
            BllEmpleado = new BLL.Empleado();
            txtUsuario.Text = empleado.Usuario;
        }

        private void bntActual_Click_1(object sender, EventArgs e)
        {
            ingresar();
        }
        private void ingresar()
        {
            try
            {
                string nueva = "";

                if (btnConfirmar.Text == "CONFIRMAR")
                {
                    if (txtActual.Text == EntEmpleado.Contrasenna)
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
                    if (txtActual.Text == EntEmpleado.Contrasenna)
                    {
                        MessageBox.Show("La contraseña debe ser diferente a la anterior", "!Error contraseñas iguales¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        BllEmpleado.cambioCantrasenna(EntEmpleado, txtActual.Text);
                        MessageBox.Show("Se combio la contraseña", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInformacion.Text = "INGRESE CONTRASEÑA ACTUAL";
                        btnConfirmar.Text = "COMFIRMAR";
                        EntEmpleado.Contrasenna = contrasenaAntes;
                        this.Close();

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Información de tramite", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
