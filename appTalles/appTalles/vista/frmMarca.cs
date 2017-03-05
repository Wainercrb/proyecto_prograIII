﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;

namespace Vista
{
    public partial class frmMarca : Form
    {

        private MarcaVehiculo marca;

        public frmMarca()
        {
            this.marca = new MarcaVehiculo();
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            MarcaD oMarca = new MarcaD();
            txtMensaje.Text = "";
            if (txtMarca.Text == "")
            {
                MessageBox.Show("Debes ingresar una marca", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (marca.Id > 0)
            {
                MarcaD pMarca = new MarcaD();
                marca.Marca = txtMarca.Text;
                pMarca.editarVehiculos(marca);
                txtMensaje.Text = "Marca editada correctamente correctamente";
                cargarMarcas();
             
            }
            else
            {
                MarcaVehiculo marca = new MarcaVehiculo(0, txtMarca.Text);
          
                oMarca.agregarMarca(marca);
                txtMensaje.Text = "Marca " + txtMarca.Text + " agregada.";
                txtMarca.Text = "";
                cargarMarcas();
            }

            marca = new MarcaVehiculo();
            txtMarca.Text = "";
            txtMensaje.Text = "";

        }


        private void cargarMarcas()
        {
            MarcaD oMarcaD = new MarcaD();
            List<MarcaVehiculo> lsMarcas = oMarcaD.obtenerMarcas();
            if (lsMarcas.ToString() == "")
            {
                txtMensaje.Text = "No hay marcas registrados";
            }
            this.grdMarcas.DataSource = lsMarcas;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void btnElininar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdMarcas.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.grdMarcas.CurrentRow.Index;

                    MarcaVehiculo oMarca = new MarcaVehiculo(Int32.Parse(this.grdMarcas[0, fila].Value.ToString()),
                                             this.grdMarcas[1, fila].Value.ToString());
                    MarcaD pMarca = new MarcaD();
                    pMarca.borrarMarca(oMarca);
                    txtMensaje.Text = "Marca eliminada correctamente";
                    cargarMarcas();
                        
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            if (this.grdMarcas.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de editar esta marca?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.grdMarcas.CurrentRow.Index;
                    marca = new MarcaVehiculo();
                    marca = new MarcaVehiculo(Int32.Parse(this.grdMarcas[0, fila].Value.ToString()),
                                             txtMarca.Text);

                    MessageBox.Show("" + Int32.Parse(this.grdMarcas[0, fila].Value.ToString()));
                    txtMarca.Text = this.grdMarcas[1, fila].Value.ToString();
                  

                }
            }
        }
    }
}
