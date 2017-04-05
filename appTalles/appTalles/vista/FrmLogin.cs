﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Vista;
using Logica;
using System.Threading;


namespace Vista
{
    public partial class FrmLogin : Form
    {
        private Thread cierre;
        private Empleado empleado;
        private bool estado = false;

        public FrmLogin()
        {
            empleado = new Empleado();
            InitializeComponent();
        }
        private void llamar_segundo(Object obj)
        {
            Application.Run(new FrmPrincipal(empleado));
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

            bool estado = true;
            empleado.Usuario = txtUsuario.Text;
            empleado.Contrasenna = txtcontraseña.Text;
            EmpledoD empleadoD = new EmpledoD();
            List<Empleado> pEmpleado = empleadoD.ObtenerEmpleados(ref estado);

            for (int i = 0; i < pEmpleado.Count; i++)
            {
                if (pEmpleado[i].Usuario.Equals(empleado.Usuario) && pEmpleado[i].Contrasenna.Equals(empleado.Contrasenna))
                {
                    empleado = pEmpleado[i];
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
    }
}

