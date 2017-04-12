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
using Vista;

namespace appTalles.Vista
{
    public partial class FrmOrdenReparaciones : Form
    {
        private ENT.Vehiculo EntVehiculo;
        private ENT.OrdenServicio EntOrdenServicio;
        private ENT.Orden EntOrden;
        private ENT.RepuestoVehiculo EntRepuesto;
        private ENT.OrdenRepuesto EntOrdenRepuesto;
        private ENT.Empleado EntEmpleado;
        private ENT.Servicio EntServicio;
        private BLL.Vehiculo BllVehiculo;
        private BLL.Empleado BllEmpleado;
        private BLL.Orden BllOrden;
        private BLL.Repuesto BllRepesto;
        private BLL.Servicio BllServicio;
        private BLL.OrdenRepuesto BllOrdenRepuesto;
        private BLL.OrdenServicio BllOrdenServicio;
        private List<ENT.RepuestoVehiculo> repuestos;
        private List<ENT.OrdenRepuesto> ordenRepuestos;
        private List<ENT.Servicio> servicios;
        private List<ENT.OrdenServicio> ordenServicios;
        private double agregado;
        private double quito;

        public ENT.Orden EntOrden1
        {
            get
            {
                return EntOrden;
            }

            set
            {
                EntOrden = value;
            }
        }

        public FrmOrdenReparaciones()
        {
            InitializeComponent();
            EntVehiculo = new ENT.Vehiculo();
            EntOrdenServicio = new ENT.OrdenServicio();
            EntOrden = new ENT.Orden();
            EntRepuesto = new ENT.RepuestoVehiculo();
            EntOrdenRepuesto = new ENT.OrdenRepuesto();
            EntEmpleado = new ENT.Empleado();
            EntServicio = new ENT.Servicio();
            BllVehiculo = new BLL.Vehiculo();
            BllEmpleado = new BLL.Empleado();
            BllOrden = new BLL.Orden();
            BllRepesto = new BLL.Repuesto();
            BllServicio = new BLL.Servicio();
            BllOrdenRepuesto = new BLL.OrdenRepuesto();
            BllOrdenServicio = new BLL.OrdenServicio();
            repuestos = new List<ENT.RepuestoVehiculo>();
            servicios = new List<ENT.Servicio>();
            ordenRepuestos = new List<OrdenRepuesto>();
            ordenServicios = new List<ENT.OrdenServicio>();
            cargarCombos();
            agregarGrdSeleccionados();
            cargarGrdServicios();

        }

        public FrmOrdenReparaciones(ENT.Orden orden)
        {
            this.EntOrden = orden;
            InitializeComponent();
            configurarGrd();
            EntVehiculo = new ENT.Vehiculo();
            EntOrdenServicio = new ENT.OrdenServicio();
            EntOrden = new ENT.Orden();
            EntRepuesto = new ENT.RepuestoVehiculo();
            EntOrdenRepuesto = new ENT.OrdenRepuesto();
            EntEmpleado = new ENT.Empleado();
            EntServicio = new ENT.Servicio();
            BllVehiculo = new BLL.Vehiculo();
            BllEmpleado = new BLL.Empleado();
            BllOrden = new BLL.Orden();
            BllRepesto = new BLL.Repuesto();
            BllServicio = new BLL.Servicio();
            BllOrdenRepuesto = new BLL.OrdenRepuesto();
            BllOrdenServicio = new BLL.OrdenServicio();
            repuestos = new List<ENT.RepuestoVehiculo>();
            servicios = new List<ENT.Servicio>();
            ordenRepuestos = new List<OrdenRepuesto>();
            ordenServicios = new List<ENT.OrdenServicio>();
            cargarCombos();
            cargarComponentes();
            agregarGrdSeleccionados();
            cargarGrdServicios();

        }
        private void cargarComponentes()
        {
            configurarGrd();
            txtCodigo.Text = "" + EntOrden.Id;
            dtIngreso.Value = EntOrden.FechaIngreso;
            dtFechaSalida.Value = EntOrden.FechaSalida;
            dtFechaFacturacion.Value = EntOrden.FechaFacturacion;
            for (int j = 0; j < cbEncargado.Items.Count; j++)
            {
                if (cbEncargado.Items[j].ToString() == EntOrden.Empleado.ToString())
                {
                    cbEncargado.SelectedIndex = j;
                    break;
                }
            }
            for (int j = 0; j < cbVehiculo.Items.Count; j++)
            {
                if (cbVehiculo.Items[j].ToString() == EntOrden.Vehiculo.ToString())
                {
                    cbVehiculo.SelectedIndex = j;
                    break;
                }
            }
            for (int j = 0; j < cbEstado.Items.Count; j++)
            {
                if (cbEstado.Items[j].ToString() == EntOrden.Estado)
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
            try
            {
                this.cbVehiculo.Items.Clear();
                List<ENT.Vehiculo> vehiculos = BllVehiculo.cargarVehiculos();
                foreach (ENT.Vehiculo oVehiculos in vehiculos)
                {
                    this.cbVehiculo.Items.Add(oVehiculos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarComboEncargado()
        {
            try
            {
                cbEncargado.Items.Clear();
                this.cbEncargado.Items.Clear();
                List<ENT.Empleado> empleados = BllEmpleado.cargarEmpleados();
                foreach (ENT.Empleado oEmpleados in empleados)
                {
                    this.cbEncargado.Items.Add(oEmpleados);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                ENT.Empleado selectedItem = (ENT.Empleado)cbEncargado.SelectedItem;
                EntEmpleado.Id = selectedItem.Id;
                EntEmpleado.Nombre = selectedItem.Nombre;
            }
            if (cbVehiculo.SelectedIndex != -1)
            {
                int selectedIndex = cbVehiculo.SelectedIndex;
                ENT.Vehiculo selectedItem = (ENT.Vehiculo)cbVehiculo.SelectedItem;
                EntVehiculo.Id = selectedItem.Id;
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionarCombos();
                EntOrden.FechaIngreso = dtIngreso.Value;
                EntOrden.FechaSalida = dtFechaSalida.Value;
                EntOrden.FechaFacturacion = dtFechaFacturacion.Value;
                EntOrden.Empleado = EntEmpleado;
                EntOrden.Vehiculo = EntVehiculo;
                EntOrden.Estado = seleccionEstado();
                limpiarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

            //double montoUno;
            //double montoDos;

            //if (ordenRepuesto.Id > 0)
            //{
            //    ordenRepuesto.Cantidad = ordenRepuesto.Cantidad + Int32.Parse(npCantidadAgregar.Value.ToString());
            //    montoUno = ordenRepuesto.totalRepuesto(ordenRepuesto, Int32.Parse(npCantidadAgregar.Value.ToString()));
            //    ordenRepuesto.TotalRepuestos += montoUno;
            //    agregado += montoUno;
            //    if (!ordenRepuestoD.editarOrdenRepuesto(ordenRepuesto))
            //    {
            //        txtMensaje.Text = "Se agregaron más repuestos";
            //    }
            //    else
            //    {

            //        MessageBox.Show("Error al agreagar el repuesto, " + ordenRepuestoD.ErrorMsg);

            //    }
            //}
            //else
            //{
            //    //if (!validadDatos())
            //    //{
            //    //    return;
            //    //}
            //    ordenRepuesto.Repuesto1 = repuesto;
            //    ordenRepuesto.Orden = Orden;
            //    ordenRepuesto.Cantidad = Int32.Parse(npCantidadAgregar.Value.ToString());
            //    montoDos = ordenRepuesto.totalRepuesto(ordenRepuesto, Int32.Parse(npCantidadAgregar.Value.ToString()));
            //    ordenRepuesto.TotalRepuestos += montoDos;
            //    agregado += montoDos;
            //    SeleccionEmpleado frm = new SeleccionEmpleado();
            //    frm.ShowDialog();
            //    empleado = frm.getEmpleado();
            //    ordenRepuesto.Empleado = empleado;
            //    if (!ordenRepuestoD.agregarOrdenRepuesto(ordenRepuesto))
            //    {
            //        txtMensaje.Text = "Se agrego a la orden el repuesto";

            //    }
            //    else
            //    {

            //        MessageBox.Show("Error al agregar el repuesto, " + ordenRepuestoD.ErrorMsg);
            //    }
            //}
            //npCantidadAgregar.Value = 1;
            //txtAgregarServicio.Text = "";
            //agregarGrdSeleccionados();
        }

             
        private void limpiarEntidades()
        {
            EntOrdenRepuesto = new OrdenRepuesto();
            EntRepuesto = new RepuestoVehiculo();
            EntEmpleado = new ENT.Empleado();
        }

        private bool verificarLista(List<RepuestoVehiculo> repu, int valor)
        {

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
                for (int k = 0; k < ordenRepuestos.Count; k++)
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
            this.grdRepuesto.DataSource = repuestos;
            this.grdRepuestoDos.DataSource = ordenRepuestos;
        }

        private void cargarGrdServicios()
        {
            cargarServicio();


            this.grdServicioUno.DataSource = servicios;
            this.grdServiciosDos.DataSource = ordenServicios;
        }
        private void cargarServicio()
        {
            bool estado = true;

            servicios = BllServicio.cargarServicio();
            //ordenServicios = BllServicio.buscarOrdenServicioPorID((int)Orden.Id);

        }
        private void cargarRepuestos()
        {

            repuestos = BllRepesto.cargarRepuestos();
           // ordenRepuestos = ordenRepuestoD.buscarOrdenRepuestoPorID((int)Orden.Id);
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
            this.grdServiciosDos.Columns["empleado_servicio"].Width = 100;
            this.grdServiciosDos.Columns["servicio_servicio"].Width = 100;
            this.grdServiciosDos.Columns["orden_servicio"].Visible = false;
        }

        private void seleccionOrdenRepuest(object sender, MouseEventArgs e)
        {
            int fila = this.grdRepuestoDos.CurrentRow.Index;
            if (fila >= 0)
            {
                EntOrdenRepuesto.Id = Int32.Parse(this.grdRepuestoDos[5, fila].Value.ToString());
                EntOrdenRepuesto.Cantidad = Int32.Parse(this.grdRepuestoDos[0, fila].Value.ToString());
                npQuitar.Maximum = Int32.Parse(this.grdRepuestoDos[0, fila].Value.ToString());
                EntOrdenRepuesto.TotalRepuestos = Double.Parse(this.grdRepuestoDos[1, fila].Value.ToString());
                EntOrdenRepuesto.Empleado = (ENT.Empleado)this.grdRepuestoDos[3, fila].Value;
                EntOrdenRepuesto.Repuesto1 = (RepuestoVehiculo)this.grdRepuestoDos[4, fila].Value;
                txtQuitar.Text = "Repuesto: " + EntOrdenRepuesto.Repuesto1.Repuesto + " aplicado por: " + EntOrdenRepuesto.Empleado.Nombre + " " + EntOrdenRepuesto.Empleado.Apellido;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //double monto;
            //if (npQuitar.Value == npQuitar.Maximum)
            //{
            //    if (!ordenRepuestoD.borraOrdenRepuesto(ordenRepuesto))
            //    {
            //        txtMensaje.Text = "Se elimino el repuesto de la orden";
            //        agregarGrdSeleccionados();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al elimina " + ordenRepuestoD.ErrorMsg);
            //    }
            //}
            //else
            //{
            //    monto = ordenRepuesto.quitarRepuestos(ordenRepuesto, Int32.Parse(npQuitar.Value.ToString()));
            //    ordenRepuesto.TotalRepuestos = monto;
            //    quito = monto;
            //    ordenRepuesto.Cantidad = ordenRepuesto.Cantidad - Int32.Parse(npQuitar.Value.ToString());
            //    if (ordenRepuestoD.editarOrdenRepuesto(ordenRepuesto))
            //    {
            //        MessageBox.Show("Error al editar ", ordenRepuestoD.ErrorMsg);
            //        return;
            //    }
            //    else
            //    {
            //        txtMensaje.Text = "se le quitaron " + npQuitar.Value + " repuestos";
            //        agregarGrdSeleccionados();
            //        npQuitar.Value = 1;

            //    }
            //}
            //npQuitar.Value = 1;
            //txtQuitar.Text = "";
        }

        private void selectRepuesto(object sender, MouseEventArgs e)
        {
            int fila = this.grdRepuesto.CurrentRow.Index;
            if (fila >= 0)
            {
                npCantidadAgregar.Enabled = true;
                EntRepuesto.Id = Int32.Parse(this.grdRepuesto[0, fila].Value.ToString());
                EntRepuesto.Repuesto = this.grdRepuesto[1, fila].Value.ToString();
                EntRepuesto.Precio = Double.Parse(this.grdRepuesto[2, fila].Value.ToString());
                EntRepuesto.Impuesto = Double.Parse(this.grdRepuesto[3, fila].Value.ToString());
                txtRepuestoUno.Text = EntRepuesto.Repuesto;
            }
        }

        private void grdServicioUno_MouseClick(object sender, MouseEventArgs e)
        {
            int fila = this.grdServicioUno.CurrentRow.Index;
            if (fila >= 0)
            {
                EntServicio.Id = Int32.Parse(this.grdServicioUno[0, fila].Value.ToString());
                EntServicio.pServicio = this.grdServicioUno[1, fila].Value.ToString();
                EntServicio.Precio = Double.Parse(this.grdServicioUno[2, fila].Value.ToString());
                EntServicio.Impuesto = Double.Parse(this.grdServicioUno[3, fila].Value.ToString());
                txtAgregarServicio.Text = EntServicio.pServicio;
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            //double montoAgregadoUno;
            //double montoAgregadoDos;
            //if (ordenServicio.Id > 0)
            //{
            //    ordenServicio.Cantidad = ordenServicio.Cantidad + Int32.Parse(npAgregarServicio.Value.ToString());
            //    montoAgregadoUno = ordenServicio.totalServicio(ordenServicio, Int32.Parse(npAgregarServicio.Value.ToString()));
            //    ordenServicio.Costo += montoAgregadoUno;
            //    agregado += montoAgregadoUno;
            //    if (!ordenServicioD.editarOrdenServicio(ordenServicio))
            //    {
            //        txtMensaje.Text = "Se agregaron más servicios";
            //    }
            //    else
            //    {

            //        MessageBox.Show("Error al agreagar el servicio, " + servicioD.ErrorMsg);

            //    }
            //}
            //else
            //{

            //    //if (!validadDatosServicio())
            //    //{
            //    //    return;
            //    //}
            //    ordenServicio.Servicio = servicio;
            //    ordenServicio.Orden = Orden;
            //    ordenServicio.Cantidad = Int32.Parse(npAgregarServicio.Value.ToString());
            //    montoAgregadoDos = ordenServicio.totalServicio(ordenServicio, Int32.Parse(npAgregarServicio.Value.ToString()));
            //    ordenServicio.Costo += montoAgregadoDos;
            //    agregado += montoAgregadoDos;
            //    SeleccionEmpleado frm = new SeleccionEmpleado();
            //    frm.ShowDialog();
            //    empleado = frm.getEmpleado();
            //    ordenServicio.Empleado = empleado;

            //    if (!ordenServicioD.agregarOrdenServicio(ordenServicio))
            //    {
            //        txtMensaje.Text = "Se agrego a la orden un servicio a la orden";
            //    }
            //    else
            //    {

            //        MessageBox.Show("Error al agregar el servicio, " + ordenServicioD.ErrorMsg);
            //    }
            //}

            //cargarGrdServicios();
            //npAgregarServicio.Value = 1;
        }

        private void seleccionOrdenServicio(object sender, MouseEventArgs e)
        {
            int fila = this.grdServiciosDos.CurrentRow.Index;
            if (fila >= 0)
            {
                EntOrdenServicio.Id = Int32.Parse(this.grdServiciosDos[0, fila].Value.ToString());
                EntOrdenServicio.Cantidad = Int32.Parse(this.grdServiciosDos[1, fila].Value.ToString());
                npQuitarServicio.Maximum = Int32.Parse(this.grdServiciosDos[1, fila].Value.ToString());
                EntOrdenServicio.Costo = Double.Parse(this.grdServiciosDos[2, fila].Value.ToString());
                EntOrdenServicio.Empleado = (ENT.Empleado)this.grdServiciosDos[3, fila].Value;
                EntOrdenServicio.Servicio = (ENT.Servicio)this.grdServiciosDos[4, fila].Value;
                txtQuitarServicio.Text = "Repuesto: " + EntOrdenServicio.Servicio + " aplicado por: " + EntOrdenServicio.Empleado.Nombre + " " + EntOrdenServicio.Empleado.Apellido;
            }
        }

        private void btnQuitarServicio_Click(object sender, EventArgs e)
        {
            //double monto;
            //if (npQuitarServicio.Value == npQuitarServicio.Maximum)
            //{
            //    if (!ordenServicioD.borraOrdenServicio(ordenServicio))
            //    {
            //        quito = ordenServicio.Costo;
            //        txtMensaje.Text = "Se elimino el servicio de la orden";
            //        cargarGrdServicios();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al eliminar " + ordenServicioD.ErrorMsg);
            //    }
            //}
            //else
            //{
            //    ordenServicio.Cantidad = ordenServicio.Cantidad - Int32.Parse(npQuitarServicio.Value.ToString());
            //    monto = ordenServicio.quitarServicio(ordenServicio, Int32.Parse(npQuitarServicio.Value.ToString()));
            //    ordenServicio.Costo -= monto;
            //    quito += monto;
            //    if (ordenServicioD.editarOrdenServicio(ordenServicio))
            //    {
            //        MessageBox.Show("Error al editar ", ordenServicioD.ErrorMsg);
            //    }
            //    else
            //    {
            //        txtMensaje.Text = "se le quitaron " + npQuitarServicio.Value + " servicios";
            //        cargarGrdServicios();
            //        npQuitarServicio.Value = 1;
            //        return;
            //    }
            //}
            //npQuitarServicio.Enabled = false;
            //npQuitarServicio.Value = 1;
            //txtQuitarServicio.Text = "";
        }

        private void FrmOrdenReparaciones_FormClosed(object sender, FormClosedEventArgs e)
        {

            //if (agregado > 0)
            //{
            //    Orden.CostoTotal = orden.CostoTotal + agregado;
            //}
            //if (quito > 0)
            //{
            //    Orden.CostoTotal = orden.CostoTotal - quito;
            //}
            //if (ordenD.actualizarTotal((ENT.Orden)Orden))
            //{
            //    MessageBox.Show("Error al guardar el total de las repuesto y servicios, " + ordenD.ErrorMsg);
            //}
        }

    }
}
