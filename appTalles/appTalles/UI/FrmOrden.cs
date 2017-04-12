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
        private DAL.Cliente clienteD;
        private ENT.Vehiculo vehiculo;
        private DAL.Vehiculo vehiculoD;
        private ENT.Empleado empleado;
        private DAL.Empleado empleadoD;
        private DAL.Orden ordenD;
        private ENT.Orden orden;

        public FrmOrden()
        {
            InitializeComponent();
            cliente = new ENT.Cliente();
            clienteD = new DAL.Cliente();
            vehiculo = new ENT.Vehiculo();
            vehiculoD = new DAL.Vehiculo();
            empleado = new ENT.Empleado();
            empleadoD = new DAL.Empleado();
            ordenD = new DAL.Orden();
            orden = new ENT.Orden();
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
            List<ENT.Cliente> clientes = clienteD.obtenerClientes();
            foreach (ENT.Cliente oClienteL in clientes)
            {
                this.cbCliente.Items.Add(oClienteL);
            }
        }
        private void llenarComboVehiculo()
        {
            this.cbVehiculo.Items.Clear();
            List<ENT.Vehiculo> vehiculos = vehiculoD.obtenerVehiculos();
            foreach (ENT.Vehiculo oVehiculos in vehiculos)
            {
                this.cbVehiculo.Items.Add(oVehiculos);
            }
        }

        private void llenarComboEncargado()
        {
            {
                //bool estado = true;
                //this.cbEncargado.Items.Clear();
                //List<Empleado> empleados = empleadoD.ObtenerEmpleados(ref estado);
                //foreach (Empleado oEmpleados in empleados)
                //{
                //    this.cbEncargado.Items.Add(oEmpleados.Nombre + " " + oEmpleados.Apellido);
                //}
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<ENT.Orden> lsOrdenes = new List<ENT.Orden>(); ;

            if (txtCodigo.Text != "")
            {
                lsOrdenes = ordenD.obtenerOrdenString(Int32.Parse(txtCodigo.Text), "o.id_orden");

            }
            else if (cbCliente.SelectedIndex != -1)
            {
                ENT.Cliente selectedItem = (ENT.Cliente)cbCliente.SelectedItem;
                cliente = new ENT.Cliente();
                cliente = new ENT.Cliente(selectedItem.Id, selectedItem.Nombre, selectedItem.Cedula, selectedItem.ApellidoPaterno, selectedItem.ApellidoMaterno, selectedItem.TelefonoCasa, selectedItem.TelefonoOficina, selectedItem.TelefonoCelular);
                lsOrdenes = ordenD.obtenerOrdenString(cliente.Id, "c.id_cliente");

            }
            else if (cbVehiculo.SelectedIndex > -1)
            {
                ENT.Vehiculo selectedItem = (ENT.Vehiculo)cbVehiculo.SelectedItem;
                vehiculo = new ENT.Vehiculo(selectedItem.Id, selectedItem.Placa, selectedItem.Anno, selectedItem.Cilindraje, selectedItem.NumeroMotor, selectedItem.NumeroChazis, selectedItem.TipoCombustible, selectedItem.Estado, new MarcaVehiculo(), new ENT.Cliente(), new TipoVehiculo());
                lsOrdenes = ordenD.obtenerOrdenString(vehiculo.Id, "v.id_vehiculo");
            }
            else if (cbEsatado.SelectedIndex > -1)
            {

            }
            else if (cbEncargado.SelectedIndex > -1)
            {
                lsOrdenes = ordenD.obtenerOrdenFecha(dtIngreso.Value, dtIngreso.Value, "o.fecha_ingreso", "o.fecha_salida");
            }
            else if (dtIngreso.Checked == true)
            {

            }
            else
            {

                cargarOrdenes();
                return;

            }

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


        private void cargarOrdenes()
        {
            List<ENT.Orden> lsOrdenes = ordenD.obtenerOrden();
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
                orden.FechaSalida = DateTime.Parse(this.dgOrdenes[2, fila].Value.ToString());
                orden.FechaFacturacion = DateTime.Parse(this.dgOrdenes[3, fila].Value.ToString());
                orden.Estado = this.dgOrdenes[4, fila].Value.ToString();
                orden.CostoTotal = Double.Parse(this.dgOrdenes[5, fila].Value.ToString());
                orden.Empleado = (ENT.Empleado)dgOrdenes[7, fila].Value;
                orden.Vehiculo = (ENT.Vehiculo)this.dgOrdenes[6, fila].Value;
                FrmOrdenReparaciones frm = new FrmOrdenReparaciones(orden);
                frm.ShowDialog();

                List<ENT.Orden> lsOrdenes = ordenD.obtenerOrdenId((ENT.Orden)frm.EntOrden1);

                this.dgOrdenes.DataSource = lsOrdenes;
            }
        }
    }
}
