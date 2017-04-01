using System;
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
using appTalles.Vista;

namespace Vista
{
    public partial class FrmOrden : Form
    {
        private Cliente cliente;
        private ClienteD clienteD;
        private Vehiculo vehiculo;
        private VehiculoD vehiculoD;
        private Empleado empleado;
        private EmpledoD empleadoD;
        private OrdenD ordenD;
        private Orden orden;

        public FrmOrden()
        {
            InitializeComponent();
            cliente = new Cliente();
            clienteD = new ClienteD();
            vehiculo = new Vehiculo();
            vehiculoD = new VehiculoD();
            empleado = new Empleado();
            empleadoD = new EmpledoD();
            ordenD = new OrdenD();
            orden = new Orden();
            cargarCombos();
        }

        private void cargarCombos()
        {

            llenarComboCliente();
            llenarComboVehiculo();
            llenarComboEncargado();

        }


        private void llenarComboCliente()
        {
            this.cbCliente.Items.Clear();
            List<Cliente> clientes = clienteD.obtenerClientes();
            foreach (Cliente oClienteL in clientes)
            {
                this.cbCliente.Items.Add(oClienteL);
            }
        }
        private void llenarComboVehiculo()
        {
            this.cbVehiculo.Items.Clear();
            List<Vehiculo> vehiculos = vehiculoD.obtenerVehiculos();
            foreach (Vehiculo oVehiculos in vehiculos)
            {
                this.cbVehiculo.Items.Add(oVehiculos.Placa);
            }
        }

        private void llenarComboEncargado()
        {
            {
                bool estado = true;
                this.cbEncargado.Items.Clear();
                List<Empleado> empleados = empleadoD.ObtenerEmpleados(ref estado);
                foreach (Empleado oEmpleados in empleados)
                {
                    this.cbEncargado.Items.Add(oEmpleados.Nombre + " " + oEmpleados.Apellido);
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {

            }
            else if (cbCliente.SelectedIndex != -1)
            {
                MessageBox.Show("selecciono cliente");
            }
            else if (cbVehiculo.SelectedIndex > -1)
            {

            }
            else if (cbEsatado.SelectedIndex > -1)
            {

            }
            else if (cbEncargado.SelectedIndex > -1)
            {

            }
            else if (dtIngreso.Checked == true)
            {
                MessageBox.Show("selecciono ");
            }
            else
            {

                cargarOrdenes();

            }
        }


        private void cargarOrdenes()
        {
            List<Orden> lsOrdenes = ordenD.obtenerOrden();
            txtMensaje.Text = "" + lsOrdenes.Count();
            if (lsOrdenes.Count <= 0)
            {
                txtMensaje.Text = "No hay Vehiculos registrados.";
            }
            else if (!ordenD.ErrorMsg.Equals(""))
            {
                txtMensaje.Text = "Error al cargar los vehículos, " + ordenD.ErrorMsg;
            }
            this.dgOrdenes.DataSource = lsOrdenes;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmOrdenReparaciones frm = new FrmOrdenReparaciones();
            frm.ShowDialog();
        }

        private void MateniminetoOrden(object sender, EventArgs e)
        {

            txtMensaje.Text = "";
            if (this.dgOrdenes.Rows.Count > 0)
            {
            
                int fila = this.dgOrdenes.CurrentRow.Index;
                orden.Id = Int32.Parse(this.dgOrdenes[0, fila].Value.ToString());
                orden.FechaIngreso = DateTime.Parse(this.dgOrdenes[1, fila].Value.ToString());
                orden.FechaSalida =  DateTime.Parse(this.dgOrdenes[2, fila].Value.ToString());
                orden.FechaFacturacion = DateTime.Parse(this.dgOrdenes[3, fila].Value.ToString());
                orden.Estado = this.dgOrdenes[4, fila].Value.ToString();
                orden.CostoTotal = Double.Parse(this.dgOrdenes[5, fila].Value.ToString());
                orden.Empleado = (Empleado)dgOrdenes[7, fila].Value;
                orden.Vehiculo = (Vehiculo)this.dgOrdenes[6, fila].Value;
                FrmOrdenReparaciones frm = new FrmOrdenReparaciones(orden);
                frm.ShowDialog();
            }
        }
    }
}
