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
using appTalles.Vista;

namespace Vista
{
    public partial class FrmOrden : Form
    {
        private ENT.Cliente cliente;
        private ENT.Vehiculo vehiculo;
        private ENT.Empleado empleado;
        private ENT.Orden orden;
        private BLL.Cliente BllCliente;
        private BLL.Vehiculo BllVehiculo;
        private BLL.Empleado BllEmpleado;
        private BLL.Orden BllOrden;
        private List<ENT.Cliente> clientes;
        private List<ENT.Vehiculo> vehiculos;
        private List<ENT.Empleado> empleados;
        private List<ENT.Orden> ordenes;

        public FrmOrden()
        {
            InitializeComponent();
            cliente = new ENT.Cliente();
            BllCliente = new BLL.Cliente();
            vehiculo = new ENT.Vehiculo();
            BllVehiculo = new BLL.Vehiculo();
            empleado = new ENT.Empleado();
            BllEmpleado = new BLL.Empleado();
            BllOrden = new BLL.Orden();
            orden = new ENT.Orden();
            clientes = new List<ENT.Cliente>();
            vehiculos = new List<ENT.Vehiculo>();
            empleados = new List<ENT.Empleado>();
            ordenes = new List<ENT.Orden>();
            cargarCombos();
            anadirItemsEstado();
        }   
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BllOrden.eliminarOrden(orden.Id);
                limpiarDatos();
                cargarOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != "")
                {
                    buscar("", Int32.Parse(txtCodigo.Text), "id_orden");
                    return;
                }
                if (cbCliente.SelectedIndex >= 0)
                {
                    seleccionComboCliente();
                    buscar("", cliente.Id, "id_cliente");
                    return;
                }
                if (cbEncargado.SelectedIndex >= 0)
                {
                    seleccionComboEncargado();
                    buscar("", empleado.Id, "id_empleado");
                    return;
                }
                if (cbEsatado.SelectedIndex >= 0)
                {
                    buscar(seleccionEstado(), 0, "estado");
                    return;
                }
                if (cbVehiculo.SelectedIndex >= 0)
                {
                    seleccionComboVehiculo();
                    buscar("", vehiculo.Id, "id_vehiculo");
                    return;
                }
                if (dtIngreso.Checked && dtSalida.Checked)
                {
                    ordenes = BllOrden.buscarFechas(dtIngreso.Value, dtSalida.Value);
                    this.dgOrdenes.DataSource = ordenes;
                    txtNumero.Text = "" + ordenes.Count;
                    return;
                }
                limpiarDatos();
                cargarOrdenes();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void buscar(string valor, int numero, string columna)
        {
            try
            {
                if (valor == "")
                {
                    ordenes = BllOrden.cargarIntOrden(numero, columna);
                }
                if (valor != "")
                {
                    ordenes = BllOrden.cargarStringOrden(valor, columna);
                }
                this.dgOrdenes.DataSource = ordenes;
                txtNumero.Text = "" + ordenes.Count;
                limpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmOrdenReparaciones frm = new FrmOrdenReparaciones();
            frm.ShowDialog();
            buscar("", frm.EntOrden1.Id, "id_orden");
        }
        private void MateniminetoOrden(object sender, EventArgs e)
        {
            if (this.dgOrdenes.Rows.Count > 0)
            {
                int fila = this.dgOrdenes.CurrentRow.Index;
                orden.Id = Int32.Parse(this.dgOrdenes[0, fila].Value.ToString());
                orden.FechaIngreso = DateTime.Parse(this.dgOrdenes[1, fila].Value.ToString());
                orden.FechaSalida = DateTime.Parse(this.dgOrdenes[2, fila].Value.ToString());
                orden.FechaFacturacion = DateTime.Parse(this.dgOrdenes[3, fila].Value.ToString());
                orden.Estado = this.dgOrdenes[4, fila].Value.ToString();
                orden.CostoTotal = Double.Parse(this.dgOrdenes[5, fila].Value.ToString());
                orden.Empleado = (ENT.Empleado)dgOrdenes[7, fila].Value;
                orden.Vehiculo = (ENT.Vehiculo)this.dgOrdenes[6, fila].Value;
                FrmOrdenReparaciones frm = new FrmOrdenReparaciones(orden);
                frm.ShowDialog();
                buscar("", orden.Id, "id_orden");
            }
        }
        private void seleccionMause(object sender, MouseEventArgs e)
        {
            if (this.dgOrdenes.Rows.Count > 0)
            {
                int fila = this.dgOrdenes.CurrentRow.Index;
                orden.Id = Int32.Parse(this.dgOrdenes[0, fila].Value.ToString());
                orden.FechaIngreso = DateTime.Parse(this.dgOrdenes[1, fila].Value.ToString());
                orden.FechaSalida = DateTime.Parse(this.dgOrdenes[2, fila].Value.ToString());
                orden.FechaFacturacion = DateTime.Parse(this.dgOrdenes[3, fila].Value.ToString());
                orden.Estado = this.dgOrdenes[4, fila].Value.ToString();
                orden.CostoTotal = Double.Parse(this.dgOrdenes[5, fila].Value.ToString());
                orden.Empleado = (ENT.Empleado)dgOrdenes[7, fila].Value;
                orden.Vehiculo = (ENT.Vehiculo)this.dgOrdenes[6, fila].Value;
                txtMensaje.Text = "Codigo orden" + orden.Id + " ---> costo total >>" + orden.CostoTotal;
            }
        }
        //Metodo carga todos los combobox
        private void cargarCombos()
        {
            llenarComboCliente();
            llenarComboVehiculo();
            llenarComboEncargado();
        }
        //Metodo limpia los componentes utilizados
        //en el frame
        private void limpiarDatos()
        {
            txtCodigo.Text = "";
            txtMensaje.Text = "";
            cbCliente.SelectedIndex = -1;
            cbEncargado.SelectedIndex = -1;
            cbEsatado.SelectedIndex = -1;
            cbVehiculo.SelectedIndex = -1;
            dtIngreso.Value = DateTime.Today;
            dtSalida.Value = DateTime.Today;
            dtIngreso.Checked = false;
            dtSalida.Checked = false;
        }
        //Metodo carga la lista de ordenes y las agrega al 
        //data griew view
        private void cargarOrdenes()
        {
            try
            {
                ordenes = BllOrden.cargarOrden();
                this.dgOrdenes.DataSource = ordenes;
                txtNumero.Text = "" + ordenes.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo retorna una lista de cliente que las agrega
        //al combobox de clientes
        private void llenarComboCliente()
        {
            try
            {
                this.cbCliente.Items.Clear();
                clientes = BllCliente.cargarClientes();
                foreach (ENT.Cliente oClienteL in clientes)
                {
                    this.cbCliente.Items.Add(oClienteL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo retorna una lista de vehículos que las
        //retorna y las agrega al combo de vehículo
        private void llenarComboVehiculo()
        {
            try
            {
                this.cbVehiculo.Items.Clear();
                vehiculos = BllVehiculo.cargarVehiculos();
                foreach (ENT.Vehiculo oVehiculos in vehiculos)
                {
                    this.cbVehiculo.Items.Add(oVehiculos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo retorna una lista de empleados
        //y las agrega el combobox de encargado
        private void llenarComboEncargado()
        {
            try
            {
                this.cbEncargado.Items.Clear();
                empleados = BllEmpleado.cargarEmpleados();
                foreach (ENT.Empleado oEmpleados in empleados)
                {
                    this.cbEncargado.Items.Add(oEmpleados);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo selecciona un vehiculo del combobox y lo agrega
        //a la entidad vehículo
        private void seleccionComboVehiculo()
        {
            if (cbVehiculo.SelectedIndex != -1)
            {
                int selectedIndex = cbVehiculo.SelectedIndex;
                ENT.Vehiculo selectedItem = (ENT.Vehiculo)cbVehiculo.SelectedItem;
                vehiculo.Id = selectedItem.Id;
            }
        }
        //Metodo selecciona un encargado del combobox y lo agrega
        //a la entidad encargado
        private void seleccionComboEncargado()
        {
            if (cbEncargado.SelectedIndex != -1)
            {
                int selectedIndex = cbEncargado.SelectedIndex;
                ENT.Empleado selectedItem = (ENT.Empleado)cbEncargado.SelectedItem;
                empleado.Id = selectedItem.Id;
            }
        }
        //Metodo selecciona un cliente del combobox y lo agrega
        //a la entidad cliente
        private void seleccionComboCliente()
        {
            if (cbCliente.SelectedIndex != -1)
            {
                int selectedIndex = cbCliente.SelectedIndex;
                ENT.Cliente selectedItem = (ENT.Cliente)cbCliente.SelectedItem;
                cliente.Id = selectedItem.Id;
            }
        }
        //Metodo selecciona un vehiculo del combobox y lo agrega
        //a la entidad vehículo
        private string seleccionEstado()
        {
            string estado = "";
            if (cbEsatado.SelectedIndex != -1)
            {
                int selectedIndex;
                selectedIndex = cbEsatado.SelectedIndex;
                estado = (string)cbEsatado.SelectedItem;
            }
            return estado;
        }
        //Metodo añade los items string al
        //combobox de estado
        private void anadirItemsEstado()
        {
            cbEsatado.Items.Add("Dañado");
            cbEsatado.Items.Add("Pendiente");
            cbEsatado.Items.Add("Finalizado");
        }
    }
}
