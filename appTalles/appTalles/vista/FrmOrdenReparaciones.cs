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
using Vista;

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
        private Servicio servicio;
        private RepuestoVehiculo repuesto;
        private OrdenRepuesto ordenRepuesto;
        private ordenRepuestoD ordenRepuestoD;
        private OrdenServicioD ordenServicioD;
        private List<RepuestoVehiculo> repuestos;
        private List<OrdenRepuesto> ordenRepuestos;
        private List<Servicio> servicios;
        private List<OrdenServicio> ordenServicios;
        private OrdenServicio ordenServicio;
       
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
            repuesto = new RepuestoVehiculo();
            ordenRepuesto = new OrdenRepuesto();
            ordenRepuestoD = new ordenRepuestoD();
            repuestos = new List<RepuestoVehiculo>();
            ordenRepuestos = new List<OrdenRepuesto>();
            servicios = new List<Servicio>();
            servicio = new Servicio();
            ordenServicios = new List<OrdenServicio>();
            ordenServicioD = new OrdenServicioD();
            ordenServicio = new OrdenServicio();          
            cargarCombos();
            agregarGrdSeleccionados();
            cargarGrdServicios();

        }

        public FrmOrdenReparaciones(Orden orden)
        {
            this.orden = orden;
            InitializeComponent();
            configurarGrd();
            vehiculo = new Vehiculo();
            vehiculoD = new VehiculoD();
            empleado = new Empleado();
            empleadoD = new EmpledoD();
            orden = new Orden();
            ordenD = new OrdenD();
            repuestoD = new RepuestoD();
            servicioD = new ServicioD();
            repuesto = new RepuestoVehiculo();
            ordenRepuesto = new OrdenRepuesto();
            ordenRepuestoD = new ordenRepuestoD();
            repuestos = new List<RepuestoVehiculo>();
            ordenRepuestos = new List<OrdenRepuesto>();
            servicios = new List<Servicio>();
            servicio = new Servicio();
            ordenServicios = new List<OrdenServicio>();
            ordenServicioD = new OrdenServicioD();
            ordenServicio = new OrdenServicio();
            cargarCombos();
            cargarComponentes();
            agregarGrdSeleccionados();
            cargarGrdServicios();

        }
        private void cargarComponentes()
        {
            configurarGrd();
            txtCodigo.Text = "" + orden.Id;
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ordenRepuesto.Repuesto1 = repuesto;
            ordenRepuesto.Orden = orden;
            ordenRepuesto.Cantidad = Int32.Parse(npCantidadAgregar.Value.ToString());
            ordenRepuesto.TotalRepuestos = ordenRepuesto.totalRepuesto(ordenRepuesto, Int32.Parse(npCantidadAgregar.Value.ToString()));
            SeleccionEmpleado frm = new SeleccionEmpleado();
            frm.ShowDialog();
            empleado = frm.getEmpleado();
            ordenRepuesto.Empleado = empleado;
            if (!validadDatos())
            {
                return;
            }
            if (!ordenRepuestoD.agregarOrdenRepuesto(ordenRepuesto))
            {
                txtMensaje.Text = "Se agrego a la orden el repuesto";
                limpiarDatos();
                agregarGrdSeleccionados();
            }
            else
            {

                MessageBox.Show("Error al agregar el repuesto, " + ordenRepuestoD.ErrorMsg);
            }
        }

        private bool validadDatos()
        {
            if (empleado.Id <= 0)
            {
                MessageBox.Show("Debes de seleccionar un empleado que aplico un repuesto");
                return false;
            }
            if (repuesto.Id <= 0)
            {
                MessageBox.Show("Debes seleccionar un repuesto");
                return false;
            }
            if (ordenRepuesto.Cantidad <= 0)
            {
                MessageBox.Show("Error al calcular el costo total");
                return false;
            }
            if (orden.Id <= 0)
            {
                MessageBox.Show("No se encotrar la orden a agregar vehiculo");
            }
            if (ordenRepuesto.Id < 0)
            {
                MessageBox.Show("Error al agregar los repuesto la orden");
            }
            return true;
        }

        private void limpiarEntidades()
        {
            ordenRepuesto = new OrdenRepuesto();
            repuesto = new Logica.RepuestoVehiculo();
            empleado = new Empleado();
        }

        private bool verificarLista(List<RepuestoVehiculo> repu, int valor) {

            for (int i = 0; i < repu.Count; i++)
            {
                if (repu[i].Id == valor)
                {
                    return true;
                }
            }

            return false;
        }
        private void agregarGrdSeleccionados()
        {
            cargarRepuestos();
            List<RepuestoVehiculo> temporal1 = new List<RepuestoVehiculo>();
            for (int i = 0; i < repuestos.Count; i++)
            {
                for (int k = 0; k < ordenRepuestos.Count ; k++)
                {
                    if (repuestos[i].Id != ordenRepuestos[k].Repuesto1.Id)
                    {
                        if (!verificarLista(temporal1, repuestos[i].Id))
                        {
                            temporal1.Add(repuestos[i]);
                        }
                    }                  
                }
            }            
            this.grdRepuesto.DataSource =repuestos;
            this.grdRepuestoDos.DataSource = ordenRepuestos;
        }

        private void cargarGrdServicios() {
            cargarServicio();


            this.grdServicioUno.DataSource = servicios;
            this.grdServiciosDos.DataSource = ordenServicios;
        }
        private void cargarServicio() {
            bool estado = true;

            servicios = servicioD.Obtenerservicios(ref estado);
            ordenServicios = ordenServicioD.buscarOrdenServicioPorID(orden.Id);
            
        }
        private void cargarRepuestos()
        {

            repuestos = repuestoD.obtenerRepesto();
            ordenRepuestos = ordenRepuestoD.buscarOrdenRepuestoPorID(orden.Id);
        }
        private void configurarGrd()
        {
            this.grdRepuestoDos.Columns["Id"].Width = 50;
            this.grdRepuestoDos.Columns["Cantidad"].Width = 50;
            this.grdRepuestoDos.Columns["TotalRepuestos"].Width = 50;
            this.grdRepuestoDos.Columns["Orden_d"].Visible = false;
            this.grdRepuestoDos.Columns["Empleado_D"].Width = 100;
            this.grdRepuestoDos.Columns["TotalRepuestos"].Width = 50;
            this.grdRepuestoDos.Columns["Repuesto1"].Width = 100;
            this.grdRepuesto.Columns["id_repuesto"].Visible = false;
            this.grdRepuesto.Columns["RepuestoVehiculo"].Width = 65;
            this.grdRepuesto.Columns["PrecioVehiculo"].Width = 65;
            this.grdRepuesto.Columns["ImpuestoVehiculo"].Width = 65;
            this.grdServicioUno.Columns["codigo"].Visible = false;
            this.grdServicioUno.Columns["servicio_s"].Width = 65;
            this.grdServicioUno.Columns["precio_s"].Width = 65;
            this.grdServicioUno.Columns["impuesto"].Width = 65;
            this.grdServiciosDos.Columns["id_servicio"].Width = 50;
            this.grdServiciosDos.Columns["cantidad_servicio"].Width = 50;
            this.grdServiciosDos.Columns["costo_servicio"].Width = 50;
            this.grdServiciosDos.Columns["empleado_servicio"].Width =100;
            this.grdServiciosDos.Columns["servicio_servicio"].Width = 100;
            this.grdServiciosDos.Columns["orden_servicio"].Visible = false;
        }

        private void seleccionOrdenRepuest(object sender, MouseEventArgs e)
        {
            int fila = this.grdRepuestoDos.CurrentRow.Index;
            if (fila >= 0)
            {
                ordenRepuesto.Id = Int32.Parse(this.grdRepuestoDos[5, fila].Value.ToString());
                ordenRepuesto.Cantidad = Int32.Parse(this.grdRepuestoDos[0, fila].Value.ToString());
                npQuitar.Maximum = Int32.Parse(this.grdRepuestoDos[0, fila].Value.ToString());
                ordenRepuesto.TotalRepuestos = Double.Parse(this.grdRepuestoDos[1, fila].Value.ToString());
                ordenRepuesto.Empleado = (Empleado)this.grdRepuestoDos[3, fila].Value;
                ordenRepuesto.Repuesto1 = (RepuestoVehiculo)this.grdRepuestoDos[4, fila].Value;
                txtQuitar.Text = "Repuesto: " + ordenRepuesto.Repuesto1.Repuesto + " aplicado por: " + ordenRepuesto.Empleado.Nombre + " " + ordenRepuesto.Empleado.Apellido;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if (npQuitar.Value == npQuitar.Maximum)
            {
                if (!ordenRepuestoD.borraOrdenRepuesto(ordenRepuesto))
                {
                    txtMensaje.Text = "Se elimino el repuesto de la orden";
                    agregarGrdSeleccionados();
                    npQuitar.Value = 1;
                    txtQuitar.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al elimina " + ordenRepuestoD.ErrorMsg);
                }
            }
            else
            {
                ordenRepuesto.TotalRepuestos = ordenRepuesto.quitarRepuestos(ordenRepuesto, Int32.Parse(npQuitar.Value.ToString()));
                ordenRepuesto.Cantidad = ordenRepuesto.Cantidad - Int32.Parse(npQuitar.Value.ToString());
                if (ordenRepuestoD.editarOrdenRepuesto(ordenRepuesto))
                {
                    MessageBox.Show("Error al editar ", ordenRepuestoD.ErrorMsg);
                    return;
                }
                else {
                    txtMensaje.Text = "se le quitaron " + npQuitar.Value + " repuestos";
                    agregarGrdSeleccionados();
                    npQuitar.Value = 1;

                }
            }
        }

        private void selectRepuesto(object sender, MouseEventArgs e)
        {
            int fila = this.grdRepuesto.CurrentRow.Index;
            if (fila >= 0)
            {
                repuesto.Id = Int32.Parse(this.grdRepuesto[0, fila].Value.ToString());
                repuesto.Repuesto = this.grdRepuesto[1, fila].Value.ToString();
                repuesto.Precio = Double.Parse(this.grdRepuesto[2, fila].Value.ToString());
                repuesto.Impuesto = Double.Parse(this.grdRepuesto[3, fila].Value.ToString());
                txtRepuestoUno.Text = repuesto.Repuesto;
            }
        }

        private void grdServicioUno_MouseClick(object sender, MouseEventArgs e)
        {
            int fila = this.grdServicioUno.CurrentRow.Index;
            if (fila >= 0)
            {
                servicio.Id = Int32.Parse(this.grdServicioUno[0, fila].Value.ToString());
                servicio.pServicio = this.grdServicioUno[1, fila].Value.ToString();
                servicio.Precio = Double.Parse(this.grdServicioUno[2, fila].Value.ToString());
                servicio.Impuesto  = Double.Parse(this.grdServicioUno[3, fila].Value.ToString());
                txtAgregarServicio.Text = servicio.pServicio;
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            ordenServicio.Servicio = servicio;
            ordenServicio.Orden = orden;
            ordenServicio.Cantidad = Int32.Parse(npAgregarServicio.Value.ToString());
            ordenServicio.Costo = ordenServicio.totalServicio(ordenServicio, Int32.Parse(npAgregarServicio.Value.ToString()));
            SeleccionEmpleado frm = new SeleccionEmpleado();
            frm.ShowDialog();
            empleado = frm.getEmpleado();
            ordenServicio.Empleado = empleado;
            //if (!validadDatos())
            //{
            //    return;
            //}
            if (!ordenServicioD.agregarOrdenServicio(ordenServicio))
            {
                txtMensaje.Text = "Se agrego a la orden un servicio a la orden";
                //limpiarDatos();
                cargarGrdServicios(); ;
            }
            else
            {

                MessageBox.Show("Error al agregar el servicio, " + ordenServicioD.ErrorMsg);
            }
        }

        private void seleccionOrdenServicio(object sender, MouseEventArgs e)
        {
            int fila = this.grdServiciosDos.CurrentRow.Index;
            if (fila >= 0)
            {
                ordenRepuesto.Id = Int32.Parse(this.grdServiciosDos[0, fila].Value.ToString());
                ordenServicio.Cantidad = Int32.Parse(this.grdServiciosDos[1, fila].Value.ToString());
                npQuitarServicio.Value = Int32.Parse(this.grdServiciosDos[1, fila].Value.ToString());
                ordenServicio.Costo = Double.Parse(this.grdServiciosDos[2, fila].Value.ToString());
                ordenServicio.Empleado = (Empleado)this.grdServiciosDos[3, fila].Value;
                ordenServicio.Servicio = (Servicio)this.grdServiciosDos[4, fila].Value;
                txtQuitarServicio.Text = "Repuesto: " + ordenServicio.Servicio + " aplicado por: " + ordenServicio.Empleado.Nombre + " " + ordenServicio.Empleado.Apellido;
            }
        }
    }
}
