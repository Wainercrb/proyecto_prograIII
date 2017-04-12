﻿namespace appTalles.Vista
{
    partial class FrmOrdenReparaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenReparaciones));
            this.grdRepara = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQuitarServicio = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.txtQuitarServicio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.npQuitarServicio = new System.Windows.Forms.NumericUpDown();
            this.txtAgregarServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.npAgregarServicio = new System.Windows.Forms.NumericUpDown();
            this.grdServiciosDos = new System.Windows.Forms.DataGridView();
            this.id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdServicioUno = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdRepuesto = new System.Windows.Forms.DataGridView();
            this.id_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuitar = new System.Windows.Forms.TextBox();
            this.txtRepuestoUno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.npQuitar = new System.Windows.Forms.NumericUpDown();
            this.npCantidadAgregar = new System.Windows.Forms.NumericUpDown();
            this.grdRepuestoDos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRepuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repuesto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEncargado = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.grdMarca = new System.Windows.Forms.DataGridView();
            this.grdRepara.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitarServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npAgregarServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicioUno)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npCantidadAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestoDos)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRepara
            // 
            this.grdRepara.Controls.Add(this.tabPage1);
            this.grdRepara.Controls.Add(this.tabPage2);
            this.grdRepara.Location = new System.Drawing.Point(2, 161);
            this.grdRepara.Name = "grdRepara";
            this.grdRepara.SelectedIndex = 0;
            this.grdRepara.Size = new System.Drawing.Size(739, 311);
            this.grdRepara.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnQuitarServicio);
            this.tabPage1.Controls.Add(this.btnAgregarServicio);
            this.tabPage1.Controls.Add(this.txtQuitarServicio);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.npQuitarServicio);
            this.tabPage1.Controls.Add(this.txtAgregarServicio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.npAgregarServicio);
            this.tabPage1.Controls.Add(this.grdServiciosDos);
            this.tabPage1.Controls.Add(this.grdServicioUno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reparaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnQuitarServicio
            // 
            this.btnQuitarServicio.Location = new System.Drawing.Point(265, 152);
            this.btnQuitarServicio.Name = "btnQuitarServicio";
            this.btnQuitarServicio.Size = new System.Drawing.Size(52, 23);
            this.btnQuitarServicio.TabIndex = 18;
            this.btnQuitarServicio.Text = "<--";
            this.btnQuitarServicio.UseVisualStyleBackColor = true;
            this.btnQuitarServicio.Click += new System.EventHandler(this.btnQuitarServicio_Click);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(265, 110);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(52, 23);
            this.btnAgregarServicio.TabIndex = 17;
            this.btnAgregarServicio.Text = "-->";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // txtQuitarServicio
            // 
            this.txtQuitarServicio.Location = new System.Drawing.Point(443, 6);
            this.txtQuitarServicio.Name = "txtQuitarServicio";
            this.txtQuitarServicio.Size = new System.Drawing.Size(285, 20);
            this.txtQuitarServicio.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quitar:";
            // 
            // npQuitarServicio
            // 
            this.npQuitarServicio.Location = new System.Drawing.Point(370, 6);
            this.npQuitarServicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npQuitarServicio.Name = "npQuitarServicio";
            this.npQuitarServicio.Size = new System.Drawing.Size(67, 20);
            this.npQuitarServicio.TabIndex = 14;
            this.npQuitarServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAgregarServicio
            // 
            this.txtAgregarServicio.Location = new System.Drawing.Point(138, 3);
            this.txtAgregarServicio.Name = "txtAgregarServicio";
            this.txtAgregarServicio.Size = new System.Drawing.Size(110, 20);
            this.txtAgregarServicio.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Añadir:";
            // 
            // npAgregarServicio
            // 
            this.npAgregarServicio.Location = new System.Drawing.Point(57, 6);
            this.npAgregarServicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npAgregarServicio.Name = "npAgregarServicio";
            this.npAgregarServicio.Size = new System.Drawing.Size(75, 20);
            this.npAgregarServicio.TabIndex = 11;
            this.npAgregarServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grdServiciosDos
            // 
            this.grdServiciosDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServiciosDos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_servicio,
            this.cantidad_servicio,
            this.costo_servicio,
            this.empleado_servicio,
            this.servicio_servicio,
            this.orden_servicio});
            this.grdServiciosDos.Location = new System.Drawing.Point(333, 29);
            this.grdServiciosDos.Name = "grdServiciosDos";
            this.grdServiciosDos.Size = new System.Drawing.Size(395, 250);
            this.grdServiciosDos.TabIndex = 3;
            this.grdServiciosDos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seleccionOrdenServicio);
            // 
            // id_servicio
            // 
            this.id_servicio.DataPropertyName = "Id";
            this.id_servicio.HeaderText = "Codigo";
            this.id_servicio.Name = "id_servicio";
            // 
            // cantidad_servicio
            // 
            this.cantidad_servicio.DataPropertyName = "Cantidad";
            this.cantidad_servicio.HeaderText = "Cantidad";
            this.cantidad_servicio.Name = "cantidad_servicio";
            // 
            // costo_servicio
            // 
            this.costo_servicio.DataPropertyName = "Costo";
            this.costo_servicio.HeaderText = "Costo";
            this.costo_servicio.Name = "costo_servicio";
            // 
            // empleado_servicio
            // 
            this.empleado_servicio.DataPropertyName = "Empleado";
            this.empleado_servicio.HeaderText = "Empleado";
            this.empleado_servicio.Name = "empleado_servicio";
            // 
            // servicio_servicio
            // 
            this.servicio_servicio.DataPropertyName = "Servicio";
            this.servicio_servicio.HeaderText = "Servicio";
            this.servicio_servicio.Name = "servicio_servicio";
            // 
            // orden_servicio
            // 
            this.orden_servicio.DataPropertyName = "Orden";
            this.orden_servicio.HeaderText = "Orden";
            this.orden_servicio.Name = "orden_servicio";
            // 
            // grdServicioUno
            // 
            this.grdServicioUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicioUno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Servicio_s,
            this.precio_s,
            this.Impuesto});
            this.grdServicioUno.Location = new System.Drawing.Point(3, 29);
            this.grdServicioUno.Name = "grdServicioUno";
            this.grdServicioUno.Size = new System.Drawing.Size(245, 250);
            this.grdServicioUno.TabIndex = 2;
            this.grdServicioUno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdServicioUno_MouseClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "id";
            this.Codigo.Name = "Codigo";
            // 
            // Servicio_s
            // 
            this.Servicio_s.DataPropertyName = "pServicio";
            this.Servicio_s.HeaderText = "Servicio";
            this.Servicio_s.Name = "Servicio_s";
            // 
            // precio_s
            // 
            this.precio_s.DataPropertyName = "Precio";
            this.precio_s.HeaderText = "Precio";
            this.precio_s.Name = "precio_s";
            // 
            // Impuesto
            // 
            this.Impuesto.DataPropertyName = "Impuesto";
            this.Impuesto.HeaderText = "I.V.I";
            this.Impuesto.Name = "Impuesto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdRepuesto);
            this.tabPage2.Controls.Add(this.txtQuitar);
            this.tabPage2.Controls.Add(this.txtRepuestoUno);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.npQuitar);
            this.tabPage2.Controls.Add(this.npCantidadAgregar);
            this.tabPage2.Controls.Add(this.grdRepuestoDos);
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Repuestos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdRepuesto
            // 
            this.grdRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_repuesto,
            this.RepuestoVehiculo,
            this.PrecioVehiculo,
            this.ImpuestoVehiculo});
            this.grdRepuesto.Location = new System.Drawing.Point(6, 32);
            this.grdRepuesto.MultiSelect = false;
            this.grdRepuesto.Name = "grdRepuesto";
            this.grdRepuesto.Size = new System.Drawing.Size(242, 247);
            this.grdRepuesto.TabIndex = 12;
            this.grdRepuesto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectRepuesto);
            // 
            // id_repuesto
            // 
            this.id_repuesto.DataPropertyName = "Id";
            this.id_repuesto.HeaderText = "Id";
            this.id_repuesto.Name = "id_repuesto";
            // 
            // RepuestoVehiculo
            // 
            this.RepuestoVehiculo.DataPropertyName = "Repuesto";
            this.RepuestoVehiculo.HeaderText = "Repuesto";
            this.RepuestoVehiculo.Name = "RepuestoVehiculo";
            // 
            // PrecioVehiculo
            // 
            this.PrecioVehiculo.DataPropertyName = "Precio";
            this.PrecioVehiculo.HeaderText = "Precio";
            this.PrecioVehiculo.Name = "PrecioVehiculo";
            // 
            // ImpuestoVehiculo
            // 
            this.ImpuestoVehiculo.DataPropertyName = "Impuesto";
            this.ImpuestoVehiculo.HeaderText = "Impuesto";
            this.ImpuestoVehiculo.Name = "ImpuestoVehiculo";
            // 
            // txtQuitar
            // 
            this.txtQuitar.Location = new System.Drawing.Point(425, 6);
            this.txtQuitar.Name = "txtQuitar";
            this.txtQuitar.Size = new System.Drawing.Size(300, 20);
            this.txtQuitar.TabIndex = 11;
            // 
            // txtRepuestoUno
            // 
            this.txtRepuestoUno.Location = new System.Drawing.Point(137, 6);
            this.txtRepuestoUno.Name = "txtRepuestoUno";
            this.txtRepuestoUno.Size = new System.Drawing.Size(110, 20);
            this.txtRepuestoUno.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quitar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Añadir:";
            // 
            // npQuitar
            // 
            this.npQuitar.Location = new System.Drawing.Point(352, 6);
            this.npQuitar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npQuitar.Name = "npQuitar";
            this.npQuitar.Size = new System.Drawing.Size(67, 20);
            this.npQuitar.TabIndex = 7;
            this.npQuitar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npCantidadAgregar
            // 
            this.npCantidadAgregar.Location = new System.Drawing.Point(56, 9);
            this.npCantidadAgregar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npCantidadAgregar.Name = "npCantidadAgregar";
            this.npCantidadAgregar.Size = new System.Drawing.Size(75, 20);
            this.npCantidadAgregar.TabIndex = 6;
            this.npCantidadAgregar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grdRepuestoDos
            // 
            this.grdRepuestoDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuestoDos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cantidad,
            this.Empleado_D,
            this.TotalRepuestos,
            this.Orden_d,
            this.Repuesto1});
            this.grdRepuestoDos.Location = new System.Drawing.Point(312, 32);
            this.grdRepuestoDos.MultiSelect = false;
            this.grdRepuestoDos.Name = "grdRepuestoDos";
            this.grdRepuestoDos.Size = new System.Drawing.Size(414, 247);
            this.grdRepuestoDos.TabIndex = 5;
            this.grdRepuestoDos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seleccionOrdenRepuest);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Empleado_D
            // 
            this.Empleado_D.DataPropertyName = "Empleado";
            this.Empleado_D.HeaderText = "Empleado";
            this.Empleado_D.Name = "Empleado_D";
            // 
            // TotalRepuestos
            // 
            this.TotalRepuestos.DataPropertyName = "TotalRepuestos";
            this.TotalRepuestos.HeaderText = "Total";
            this.TotalRepuestos.Name = "TotalRepuestos";
            // 
            // Orden_d
            // 
            this.Orden_d.DataPropertyName = "Orden";
            this.Orden_d.HeaderText = "Orden";
            this.Orden_d.Name = "Orden_d";
            // 
            // Repuesto1
            // 
            this.Repuesto1.DataPropertyName = "Repuesto1";
            this.Repuesto1.HeaderText = "Repuesto";
            this.Repuesto1.Name = "Repuesto1";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(254, 156);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(52, 23);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "<--";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(254, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(52, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "-->";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtFechaFacturacion
            // 
            this.dtFechaFacturacion.Location = new System.Drawing.Point(416, 122);
            this.dtFechaFacturacion.Name = "dtFechaFacturacion";
            this.dtFechaFacturacion.Size = new System.Drawing.Size(213, 20);
            this.dtFechaFacturacion.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha factu:";
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Location = new System.Drawing.Point(416, 91);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Size = new System.Drawing.Size(213, 20);
            this.dtFechaSalida.TabIndex = 24;
            // 
            // dtIngreso
            // 
            this.dtIngreso.Location = new System.Drawing.Point(416, 57);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(213, 20);
            this.dtIngreso.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vehículo:";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(123, 59);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(131, 21);
            this.cbVehiculo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Empleado:";
            // 
            // cbEncargado
            // 
            this.cbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncargado.FormattingEnabled = true;
            this.cbEncargado.Location = new System.Drawing.Point(123, 90);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(131, 21);
            this.cbEncargado.TabIndex = 30;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(610, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 32;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(743, 25);
            this.toolStrip3.TabIndex = 33;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Dañado",
            "Pendiente",
            "Finalizado"});
            this.cbEstado.Location = new System.Drawing.Point(124, 121);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(130, 21);
            this.cbEstado.TabIndex = 36;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Location = new System.Drawing.Point(6, 468);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(731, 20);
            this.txtMensaje.TabIndex = 37;
            // 
            // grdMarca
            // 
            this.grdMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarca.Location = new System.Drawing.Point(3, 31);
            this.grdMarca.Name = "grdMarca";
            this.grdMarca.Size = new System.Drawing.Size(211, 214);
            this.grdMarca.TabIndex = 0;
            // 
            // FrmOrdenReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 492);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbEncargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaFacturacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFechaSalida);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdRepara);
            this.Name = "FrmOrdenReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdenReparaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenReparaciones_FormClosed);
            this.grdRepara.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitarServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npAgregarServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicioUno)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npCantidadAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestoDos)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl grdRepara;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtFechaFacturacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFechaSalida;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEncargado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.DataGridView grdMarca;
        private System.Windows.Forms.DataGridView grdServicioUno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown npQuitar;
        private System.Windows.Forms.NumericUpDown npCantidadAgregar;
        private System.Windows.Forms.DataGridView grdRepuestoDos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtRepuestoUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repuesto1;
        private System.Windows.Forms.TextBox txtQuitar;
        private System.Windows.Forms.DataGridView grdRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepuestoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoVehiculo;
        private System.Windows.Forms.Button btnQuitarServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.TextBox txtQuitarServicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown npQuitarServicio;
        private System.Windows.Forms.TextBox txtAgregarServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown npAgregarServicio;
        private System.Windows.Forms.DataGridView grdServiciosDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden_servicio;
    }
}