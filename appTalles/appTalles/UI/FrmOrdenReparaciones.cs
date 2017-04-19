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
        private List<ENT.Vehiculo> vehiculos;
        private List<ENT.Empleado> empleados;
        private double agregado;
        private double quito;
        private bool modificio = false;

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
            vehiculos = new List<ENT.Vehiculo>();
            empleados = new List<ENT.Empleado>();
            vehiculos = new List<ENT.Vehiculo>();
            llenarComboEncargado();
            llenarComboVehiculo();
        }

        public FrmOrdenReparaciones(ENT.Orden orden)
        {
            InitializeComponent();
            EntOrdenServicio = new ENT.OrdenServicio();
            EntVehiculo = new ENT.Vehiculo();
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
            vehiculos = new List<ENT.Vehiculo>();
            empleados = new List<ENT.Empleado>();
            this.EntOrden = orden;
            llenarComboEncargado();
            llenarComboVehiculo();
            cargarComponentesOrden(orden);
            cargarRepuestosOrden();
            cargarServicioOrden();

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            seleccionComboEmpleado();
            seleccionComboVehiculo();
            EntOrden.FechaIngreso = dtIngreso.Value;
            EntOrden.FechaSalida = dtFechaSalida.Value;
            EntOrden.FechaFacturacion = dtFechaFacturacion.Value;
            EntOrden.Empleado = EntEmpleado;
            EntOrden.Vehiculo = EntVehiculo;
            EntOrden.Estado = seleccionEstado();
            int consecutivo = BllOrden.consecutivogAregarOrden(EntOrden);
            //EntOrden = BllOrden.buscarConsecutivoOrden(consecutivo);
            limpiarDatos();

        }
        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                modificio = true;
                double montoAgregadoUno;
                if (EntOrdenServicio.Id <= 0)
                {
                    SeleccionEmpleado frm = new SeleccionEmpleado();
                    frm.ShowDialog();
                    EntEmpleado = frm.EntEmpleado1;
                    EntOrdenServicio.Empleado = EntEmpleado;
                    EntOrdenServicio.Servicio = EntServicio;
                    EntOrdenServicio.Orden = EntOrden;
                }

                EntOrdenServicio.Cantidad = EntOrdenServicio.Cantidad + Int32.Parse(npAgregarServicio.Value.ToString());
                montoAgregadoUno = EntOrdenServicio.totalServicio(EntOrdenServicio, Int32.Parse(npAgregarServicio.Value.ToString()));
                EntOrdenServicio.Costo += montoAgregadoUno;
                agregado += montoAgregadoUno;
                BllOrdenServicio.agregarOrdenServicio(EntOrdenServicio);
                limpiarDatosServicios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnQuitarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                modificio = true;
                if (EntOrdenServicio.Id > 0)
                {
                    double monto;
                    if (npQuitarServicio.Value == npQuitarServicio.Maximum)
                    {
                        BllOrdenServicio.eliminarOrdenServicio(EntOrdenServicio);
                        quito = EntOrdenServicio.Costo;
                        limpiarDatosServicios();
                        return;
                    }
                    else
                    {
                        EntOrdenServicio.Cantidad = EntOrdenServicio.Cantidad - Int32.Parse(npQuitarServicio.Value.ToString());
                        monto = EntOrdenServicio.quitarServicio(EntOrdenServicio, Int32.Parse(npQuitarServicio.Value.ToString()));
                        EntOrdenServicio.Costo = monto;
                        quito += monto;
                        BllOrdenServicio.agregarOrdenServicio(EntOrdenServicio);
                        limpiarDatosServicios();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                modificio = true;
                double monto;
                if (EntOrdenServicio.Id <= 0)
                {
                    SeleccionEmpleado frm = new SeleccionEmpleado();
                    frm.ShowDialog();
                    EntEmpleado = frm.EntEmpleado1;
                    EntOrdenRepuesto.Empleado = EntEmpleado;
                    EntOrdenRepuesto.Repuesto1 = EntRepuesto;
                    EntOrdenRepuesto.Orden = EntOrden;
                }

                EntOrdenRepuesto.Cantidad = EntOrdenRepuesto.Cantidad + Int32.Parse(npRepuestoAgregar.Value.ToString());
                monto = EntOrdenRepuesto.totalRepuesto(EntOrdenRepuesto, Int32.Parse(npRepuestoAgregar.Value.ToString()));
                EntOrdenRepuesto.TotalRepuestos += monto;
                agregado += monto;
                BllOrdenRepuesto.agregarOrdenRepuesto(EntOrdenRepuesto);
                limpiarDatosRepuesto();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                modificio = true;
                if (EntOrdenRepuesto.Id > 0)
                {
                    double monto;
                    if (npQuitarRepuesto.Value == npQuitarRepuesto.Maximum)
                    {
                        BllOrdenRepuesto.eliminarOrdenRepuesto(EntOrdenRepuesto);
                        quito = EntOrdenRepuesto.TotalRepuestos;
                        limpiarDatosRepuesto();
                        return;
                    }
                    else
                    {
                        EntOrdenRepuesto.Cantidad = EntOrdenRepuesto.Cantidad - Int32.Parse(npQuitarRepuesto.Value.ToString());
                        monto = EntOrdenRepuesto.quitarRepuestos(EntOrdenRepuesto, Int32.Parse(npQuitarRepuesto.Value.ToString()));
                        EntOrdenRepuesto.TotalRepuestos = monto;
                        quito += monto;
                        BllOrdenRepuesto.agregarOrdenRepuesto(EntOrdenRepuesto);
                        limpiarDatosRepuesto();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnMasRepuestos_Click(object sender, EventArgs e)
        {
            try
            {
                if (EntOrdenRepuesto.Id > 0)
                {
                    modificio = true;
                    double monto;
                    EntOrdenRepuesto.Cantidad = EntOrdenRepuesto.Cantidad + Int32.Parse(npMasRepuesto.Value.ToString());
                    monto = EntOrdenRepuesto.totalRepuesto(EntOrdenRepuesto, Int32.Parse(npMasRepuesto.Value.ToString()));
                    EntOrdenRepuesto.TotalRepuestos += monto;
                    agregado += monto;
                    BllOrdenRepuesto.agregarOrdenRepuesto(EntOrdenRepuesto);
                    limpiarDatosRepuesto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seleccionOrdenServicio(object sender, MouseEventArgs e)
        {
            int fila = this.grdServiciosDos.CurrentRow.Index;
            if (fila >= 0)
            {
                modificio = true;
                EntOrdenServicio.Id = Int32.Parse(this.grdServiciosDos[0, fila].Value.ToString());
                EntOrdenServicio.Cantidad = Int32.Parse(this.grdServiciosDos[1, fila].Value.ToString());
                npQuitarServicio.Maximum = Int32.Parse(this.grdServiciosDos[1, fila].Value.ToString());
                EntOrdenServicio.Costo = Double.Parse(this.grdServiciosDos[2, fila].Value.ToString());
                EntOrdenServicio.Empleado = (ENT.Empleado)this.grdServiciosDos[3, fila].Value;
                EntOrdenServicio.Servicio = (ENT.Servicio)this.grdServiciosDos[4, fila].Value;
                EntOrdenServicio.Orden = (ENT.Orden)this.grdServiciosDos[5, fila].Value;
                txtQuitarServicio.Text = "Repuesto: " + EntOrdenServicio.Servicio + " aplicado por: " + EntOrdenServicio.Empleado.Nombre + " " + EntOrdenServicio.Empleado.Apellido;
            }
        }
        private void grdServicioUno_MouseClick(object sender, MouseEventArgs e)
        {
            int fila = this.grdServicioUno.CurrentRow.Index;
            if (fila >= 0)
            {
                modificio = true;
                EntServicio.Id = Int32.Parse(this.grdServicioUno[0, fila].Value.ToString());
                EntServicio.pServicio = this.grdServicioUno[1, fila].Value.ToString();
                EntServicio.Precio = Double.Parse(this.grdServicioUno[2, fila].Value.ToString());
                EntServicio.Impuesto = Double.Parse(this.grdServicioUno[3, fila].Value.ToString());
                txtAgregarServicio.Text = "Codigo: " + EntServicio.Id + ", servicio: " + EntServicio.pServicio;
            }
        }
        private void selectRepuesto(object sender, MouseEventArgs e)
        {
            int fila = this.grdRepuesto.CurrentRow.Index;
            if (fila >= 0)
            {
                modificio = true;
                npRepuestoAgregar.Enabled = true;
                EntRepuesto.Id = Int32.Parse(this.grdRepuesto[0, fila].Value.ToString());
                EntRepuesto.Repuesto = this.grdRepuesto[1, fila].Value.ToString();
                EntRepuesto.Precio = Double.Parse(this.grdRepuesto[2, fila].Value.ToString());
                EntRepuesto.Impuesto = Double.Parse(this.grdRepuesto[3, fila].Value.ToString());
                txtRepuestoUno.Text = "Codigo: " + EntRepuesto.Id + ", Repuesto: " + EntRepuesto.Repuesto;
            }
        }
        private void seleccionOrdenRepuest(object sender, MouseEventArgs e)
        {
            int fila = this.grdRepuestoDos.CurrentRow.Index;
            if (fila >= 0)
            {
                modificio = true;
                EntOrdenRepuesto.Id = Int32.Parse(this.grdRepuestoDos[5, fila].Value.ToString());
                EntOrdenRepuesto.Cantidad = Int32.Parse(this.grdRepuestoDos[0, fila].Value.ToString());
                npQuitarRepuesto.Maximum = Int32.Parse(this.grdRepuestoDos[0, fila].Value.ToString());
                EntOrdenRepuesto.TotalRepuestos = Double.Parse(this.grdRepuestoDos[1, fila].Value.ToString());
                EntOrdenRepuesto.Empleado = (ENT.Empleado)this.grdRepuestoDos[3, fila].Value;
                EntOrdenRepuesto.Repuesto1 = (RepuestoVehiculo)this.grdRepuestoDos[4, fila].Value;
                EntOrdenRepuesto.Orden = (ENT.Orden)this.grdRepuestoDos[2, fila].Value;
                txtQuitar.Text = "Repuesto: " + EntOrdenRepuesto.Repuesto1.Repuesto + " aplicado por: " + EntOrdenRepuesto.Empleado.Nombre + " " + EntOrdenRepuesto.Empleado.Apellido;
            }
        }

        private void cargarComponentesOrden(ENT.Orden orden)
        {
            txtCodigo.Text = orden.Id + "";
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
        //Metodo limpia los componentes de las identidades
        private void limpiarDatos()
        {
            cbEncargado.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            cbVehiculo.SelectedIndex = -1;
            EntOrdenRepuesto = new ENT.OrdenRepuesto();
            EntRepuesto = new ENT.RepuestoVehiculo();
            EntEmpleado = new ENT.Empleado();
            dtIngreso.Value = DateTime.Today;
            dtFechaSalida.Value = DateTime.Today;
            dtFechaFacturacion.Value = DateTime.Today;
        }
        //Metodo selecciona un item del combobox estado
        //y lo retorna en valor de string
        private string seleccionEstado()
        {
            string estado = "";
            if (cbEstado.SelectedIndex != -1)
            {
                modificio = true;
                int selectedIndex = -1;
                selectedIndex = cbEstado.SelectedIndex;
                estado = cbEstado.Items[selectedIndex].ToString();
            }
            return estado;
        }
        //Metodo seleccioa un item del combobox
        //vehiculo y lo agrega a la entidad vehiculo
        private void seleccionComboVehiculo()
        {
            if (cbVehiculo.SelectedIndex != -1)
            {
                modificio = true;
                int selectedIndex = -1;
                selectedIndex = cbVehiculo.SelectedIndex;
                ENT.Vehiculo selectedItem = (ENT.Vehiculo)cbVehiculo.SelectedItem;
                EntVehiculo.Id = selectedItem.Id;
            }
        }
        //Metodo selecciona el item de empleado y le agrega 
        //los valares a la entidad empleado
        private void seleccionComboEmpleado()
        {
            if (cbEncargado.SelectedIndex != -1)
            {
                modificio = true;
                int selectedIndex = cbEncargado.SelectedIndex;
                ENT.Empleado selectedItem = (ENT.Empleado)cbEncargado.SelectedItem;
                EntEmpleado.Id = selectedItem.Id;
                EntEmpleado.Nombre = selectedItem.Nombre;
            }
        }
        //Metodo carga una lista y las agrega al datagriew
        //y las agrega al datagriew de servicio
        private void cargarServicio(List<ENT.OrdenServicio> Ordenservicios)
        {
            try
            {
                bool esta = false;
                List<ENT.Servicio> tem = new List<ENT.Servicio>();
                servicios = BllServicio.cargarServicio();
                if (ordenServicios.Count <= 0)
                {
                    this.grdServicioUno.DataSource = servicios;
                    return;
                }
                esta = false;
                foreach (ENT.Servicio oServicio in servicios)
                {
                    foreach (ENT.OrdenServicio oOrdenServicio in Ordenservicios)
                    {
                        if (oServicio.Id != oOrdenServicio.Servicio.Id)
                        {
                            tem.Add(oServicio);
                        }
                        if (esta)
                        {
                            break;
                        }
                    }
                }

                this.grdServicioUno.DataSource = tem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo carga una lista y las agrega al datagriew
        //de repuestos
        private void cargarRepuestos(List<ENT.OrdenRepuesto> Ordenrepuestos)
        {
            try
            {
                bool esta = false;
                List<ENT.RepuestoVehiculo> tem = new List<ENT.RepuestoVehiculo>();
                repuestos = BllRepesto.cargarRepuestos();
                if (Ordenrepuestos.Count <= 0)
                {
                    this.grdRepuesto.DataSource = repuestos;
                    return;
                }
               
                     
                foreach (ENT.RepuestoVehiculo oRepuesto in repuestos)
                {
                    esta = false;
                    foreach (ENT.OrdenRepuesto oOrdenRepusto in Ordenrepuestos)
                    {
                        if (oRepuesto.Id != oOrdenRepusto.Repuesto1.Id)
                        {
                            esta = false;

                            foreach (ENT.RepuestoVehiculo item in tem)
                            {
                                if (item.Id == oOrdenRepusto.Repuesto1.Id)
                                {
                                    esta = true;
                                }
                                
                            }


                            if (esta == false)
                            {
                                tem.Add(oOrdenRepusto.Repuesto1);
                            }
                        }
                       
                   

      
                    }

                }
                           
                this.grdRepuesto.DataSource = tem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo retorna un lista y las agrega
        //al combobox de empleado
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
        //Metodo retorna una lista de vehiculos
        //y las agrega al combobox de vehiculos
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
        //Metodo carga los repuestos de una orden
        //y los agrega al grd de repuestos
        private void cargarRepuestosOrden()
        {
            try
            {
                ordenRepuestos = BllOrdenRepuesto.cargarOrdenRepuesto(Int32.Parse(txtCodigo.Text));
                this.grdRepuestoDos.DataSource = ordenRepuestos;
                cargarRepuestos(ordenRepuestos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        //Metodo carga los servcios de una orden
        //y los agrega al grd de servicios agregados
        private void cargarServicioOrden()
        {
            try
            {
                ordenServicios = BllOrdenServicio.cargarOrdenServicio(Int32.Parse(txtCodigo.Text));
                this.grdServiciosDos.DataSource = ordenServicios;
                cargarServicio(ordenServicios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void limpiarDatosServicios()
        {
            cargarServicioOrden();
            npQuitarServicio.Value = 1;
            npAgregarServicio.Value = 1;
            txtAgregarServicio.Text = "";
            txtQuitarServicio.Text = "";
            EntServicio = new ENT.Servicio();
            EntOrdenServicio = new ENT.OrdenServicio();
        }
        private void limpiarDatosRepuesto()
        {
            cargarRepuestosOrden();
            npQuitarRepuesto.Value = 1;
            npRepuestoAgregar.Value = 1;
            txtRepuestoUno.Text = "";
            txtQuitar.Text = "";
            EntRepuesto = new ENT.RepuestoVehiculo();
            EntOrdenRepuesto = new ENT.OrdenRepuesto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EntOrdenServicio.Id > 0)
                {
                    modificio = true;
                    double monto;
                    EntOrdenServicio.Cantidad = EntOrdenServicio.Cantidad + Int32.Parse(npMasServicio.Value.ToString());
                    monto = EntOrdenServicio.totalServicio(EntOrdenServicio, Int32.Parse(npMasServicio.Value.ToString()));
                    EntOrdenServicio.Costo += monto;
                    agregado += monto;
                    BllOrdenServicio.agregarOrdenServicio(EntOrdenServicio);
                    limpiarDatosServicios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmOrdenReparaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (modificio)
                {
                    if (agregado > 0)
                    {
                        EntOrden.CostoTotal = EntOrden.CostoTotal + agregado;
                    }
                    if (quito > 0)
                    {
                        EntOrden.CostoTotal = EntOrden.CostoTotal - quito;
                    }
                    seleccionComboEmpleado();
                    seleccionComboVehiculo();
                    EntOrden.FechaIngreso = dtIngreso.Value;
                    EntOrden.FechaSalida = dtFechaSalida.Value;
                    EntOrden.FechaFacturacion = dtFechaFacturacion.Value;
                    EntOrden.Empleado = EntEmpleado;
                    EntOrden.Vehiculo = EntVehiculo;
                    EntOrden.Estado = seleccionEstado();
                    BllOrden.agregarOrden(EntOrden);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}