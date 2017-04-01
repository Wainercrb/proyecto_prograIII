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

namespace appTalles.Vista
{
    public partial class FrmOrdenReparaciones : Form
    {
        private Vehiculo vehiculo;
        private VehiculoD vehiculoD;
        private Empleado empleado;
        private EmpledoD empleadoD;
        private Orden orden;
        private OrdenD ordenD;
        private RepuestoD repuestoD;
        private ServicioD servicioD;
        public FrmOrdenReparaciones()
        {
            InitializeComponent();
            vehiculo = new Vehiculo();
            vehiculoD = new VehiculoD();
            empleado = new Empleado();
            empleadoD = new EmpledoD();
            orden = new Orden();
            ordenD = new OrdenD();
            repuestoD = new RepuestoD();
            servicioD = new ServicioD();
            cargarCombos();
        }

        public FrmOrdenReparaciones(Orden orden)
        {
            this.orden = orden;
            InitializeComponent();
            vehiculo = new Vehiculo();
            vehiculoD = new VehiculoD();
            empleado = new Empleado();
            empleadoD = new EmpledoD();
            orden = new Orden();
            ordenD = new OrdenD();
            repuestoD = new RepuestoD();
            servicioD = new ServicioD();
            cargarCombos();
            cargarComponentes();
        }
        private void cargarComponentes() {
            cargarRepuestos();
            cargarReparaciones();
            txtCodigo.Text = ""+orden.Id;
            dtIngreso.Value = orden.FechaIngreso;
            dtFechaSalida.Value = orden.FechaSalida;
            dtFechaFacturacion.Value = orden.FechaFacturacion;
            for (int j = 0; j < cbEncargado.Items.Count; j++)
            {
                if (cbEncargado.Items[j].ToString() == orden.Empleado.ToString())
                {
                    cbEncargado.SelectedIndex = j;
                    break;
                }
            }
            for (int j = 0; j < cbVehiculo.Items.Count; j++)
            {
                if (cbVehiculo.Items[j].ToString() == orden.Vehiculo.ToString())
                {
                    cbVehiculo.SelectedIndex = j;
                    break;
                }
            }
            for (int j = 0; j < cbEstado.Items.Count; j++)
            {
                if (cbEstado.Items[j].ToString() == orden.Estado)
                {
                    cbEstado.SelectedIndex = j;
                    break;
                }
            }
        }
       
        private void cargarCombos()
        {


            llenarComboEncargado();
            llenarComboVehiculo();

        }
        private void llenarComboVehiculo()
        {
            this.cbVehiculo.Items.Clear();
            List<Vehiculo> vehiculos = vehiculoD.obtenerVehiculos();
            foreach (Vehiculo oVehiculos in vehiculos)
            {
                this.cbVehiculo.Items.Add(oVehiculos);
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
                    this.cbEncargado.Items.Add(oEmpleados);
                }
            }
        }
        private string seleccionEstado()
        {

            string estado = "";
            if (cbEstado.SelectedIndex != -1)
            {
                int selectedIndex = -1;
                selectedIndex = cbEstado.SelectedIndex;
                estado = cbEstado.Items[selectedIndex].ToString();

            }
            return estado;
        }

        private void seleccionarCombos()
        {

            if (cbEncargado.SelectedIndex != -1)
            {
                int selectedIndex = cbEncargado.SelectedIndex;
                Empleado selectedItem = (Empleado)cbEncargado.SelectedItem;
                empleado.Id = selectedItem.Id;
                empleado.Nombre = selectedItem.Nombre;
            }


            if (cbVehiculo.SelectedIndex != -1)
            {
                int selectedIndex = cbVehiculo.SelectedIndex;
                Vehiculo selectedItem = (Vehiculo)cbVehiculo.SelectedItem;
                vehiculo.Id = selectedItem.Id;
            }

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (!verificarDatos())
            {
                MessageBox.Show("Debes seleccinar todos los datos");
                return;
            }
            seleccionarCombos();
            orden.FechaIngreso = dtIngreso.Value;
            orden.FechaSalida = dtFechaSalida.Value;
            orden.FechaFacturacion = dtFechaFacturacion.Value;
            orden.Empleado = empleado;
            orden.Vehiculo = vehiculo;
            orden.Estado = seleccionEstado();

            if (orden.Id > 0)
            {

            }
            else
            {
                if (!ordenD.agregarOrden(orden))
                {
                    txtMensaje.Text = "Orden creada correctamente";
                }
                else
                {
                    MessageBox.Show("Error al agregar la orden, " + ordenD.ErrorMsg);
                    return;
                }
            }
            limpiarDatos();

        }

        private bool verificarDatos()
        {

            if (cbEncargado.SelectedIndex == -1 || cbVehiculo.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void limpiarDatos()
        {

            cbEncargado.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            cbVehiculo.SelectedIndex = -1;
            dtIngreso.Value = DateTime.Today;
            dtFechaSalida.Value = DateTime.Today;
            dtFechaFacturacion.Value = DateTime.Today;


        }

        private void FrmOrdenReparaciones_Load(object sender, EventArgs e)
        {

        }
        private void cargarRepuestos()
        {

            List<RepuestoVehiculo> lsRepuesto = repuestoD.obtenerRepesto();

            if (lsRepuesto.Count <= 0)
            {
                txtMensaje.Text = "No hay repuestos registrados.";
            }
            else if (!repuestoD.ErrorMsg.Equals(""))
            {
                txtMensaje.Text = "Error al cargar repuestos, " + repuestoD.ErrorMsg;
            }
            this.drgRepuesto.DataSource = lsRepuesto;
        }

        public void cargarReparaciones()
        {
            bool estado = false;

            List<Servicio> lsServicios = servicioD.Obtenerservicios(ref estado);

            if (estado)
            {
                this.drgReparacion.DataSource = lsServicios;
                txtMensaje.Text = "Total reparaciones:" + lsServicios.Count();
            }
            else
            {
                MessageBox.Show("Detalles: " + servicioD.Error, "¡Error al cargar los servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
