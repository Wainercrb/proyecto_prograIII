using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using DAL;
using BLL;

namespace Vista
{
    public partial class frmMarca : Form
    {
        private ENT.MarcaVehiculo EntMarca;
        private BLL.Marca BllMarca;
        private ENT.Modelo EntModelo;
        private BLL.Modelo BllModelo;
        private List<ENT.Modelo> modelos;
        private List<ENT.MarcaVehiculo> marcas;

        public frmMarca()
        {
            InitializeComponent();
            EntMarca = new ENT.MarcaVehiculo();
            BllMarca = new BLL.Marca();
            EntModelo = new ENT.Modelo();
            BllModelo = new BLL.Modelo();
            modelos = new List<ENT.Modelo>();
            llenarComboModelo();  
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                seleccionComboModelo();
                EntMarca.Marca = txtMarca.Text;
                EntMarca.Modelo = EntModelo;
                BllMarca.insertarMarca(EntMarca);
                cargarMarcas();
                limpiarDatos();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BllMarca.eliminarMarca(EntMarca);
                limpiarDatos();
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Editar(object sender, EventArgs e)
        {
            if (this.grdMarcas.Rows.Count > 0)
            {
                int fila = this.grdMarcas.CurrentRow.Index;
                EntMarca.Id = Int32.Parse(this.grdMarcas[0, fila].Value.ToString());
                txtMensaje.Text = this.grdMarcas[1, fila].Value.ToString();                           
            }
        }
        //Metodo edita y agrega los valore del datagrew al 
        //los difentes componentes de frame
        private void Editar(object sender, MouseEventArgs e)
        {
            if (this.grdMarcas.Rows.Count > 0)
            {
                int fila = this.grdMarcas.CurrentRow.Index;
                EntMarca.Id = Int32.Parse(this.grdMarcas[0, fila].Value.ToString());
                txtMarca.Text = this.grdMarcas[1, fila].Value.ToString();
                EntModelo = (ENT.Modelo)this.grdMarcas[2, fila].Value;
                for (int j = 0; j < cbModelo.Items.Count; j++)
                {
                    if (cbModelo.Items[j].ToString() == EntModelo.ToString())
                    {
                        cbModelo.SelectedIndex = j;
                        break;
                    }
                }
            }
        }
        private void seleccionMarca(object sender, MouseEventArgs e)
        {
            if (this.grdMarcas.Rows.Count > 0)
            {
                int fila = this.grdMarcas.CurrentRow.Index;
                txtMensaje.Text = this.grdMarcas[1, fila].Value.ToString();
            }
        }
        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            cargarMarcas();
        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        private void busquedaMarca(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    marcas = BllMarca.buscarMarca(txtBuscar.Text);
                    grdMarcas.DataSource = marcas;
                    txtCantidadRegistros.Text = "" + marcas.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Metodo limpia los comentes utilizados en el frame
        private void limpiarDatos()
        {
            txtBuscar.Text = "";
            txtMarca.Text = "";
            txtCantidadRegistros.Text = "";
            txtMensaje.Text = "";
            EntMarca = new ENT.MarcaVehiculo();
        }
        //Metodo recine la lista de marcas desde BLL.marca
        //y lo agrega a el datagriew
        private void cargarMarcas()
        {
            try
            {
                marcas = BllMarca.cargarMarca();
                grdMarcas.DataSource = marcas;
                txtCantidadRegistros.Text = "" + marcas.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Metodo retorna un lista y las agrega
        //al combobox de empleado
        private void llenarComboModelo()
        {
            try
            {
                this.cbModelo.Items.Clear();
                modelos = BllModelo.cargarModelo();
                foreach (ENT.Modelo oModelo in modelos)
                {
                    this.cbModelo.Items.Add(oModelo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo selecciona un cliente del combobox y lo agrega
        //a la entidad cliente
        private void seleccionComboModelo()
        {
            if (cbModelo.SelectedIndex != -1)
            {
                int selectedIndex = cbModelo.SelectedIndex;
                ENT.Modelo selectedItem = (ENT.Modelo)cbModelo.SelectedItem;
                EntModelo.Id = selectedItem.Id;
            }   
        }
    }
}

