namespace appTalles.Vista
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
            this.tabComponentes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMasServicio = new System.Windows.Forms.Button();
            this.npMasServicio = new System.Windows.Forms.NumericUpDown();
            this.btnQuitarServicio = new System.Windows.Forms.Button();
            this.txtQuitarServicio = new System.Windows.Forms.TextBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.npQuitarServicio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgregarServicio = new System.Windows.Forms.TextBox();
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
            this.btnMasRepuestos = new System.Windows.Forms.Button();
            this.npMasRepuesto = new System.Windows.Forms.NumericUpDown();
            this.grdRepuesto = new System.Windows.Forms.DataGridView();
            this.id_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuitar = new System.Windows.Forms.TextBox();
            this.txtRepuestoUno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.npQuitarRepuesto = new System.Windows.Forms.NumericUpDown();
            this.npRepuestoAgregar = new System.Windows.Forms.NumericUpDown();
            this.grdRepuestoDos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRepuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repuesto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.grdMarca = new System.Windows.Forms.DataGridView();
            this.txtFechaFacturacion = new System.Windows.Forms.TextBox();
            this.tabComponentes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMasServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitarServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npAgregarServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicioUno)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMasRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitarRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npRepuestoAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestoDos)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // tabComponentes
            // 
            this.tabComponentes.Controls.Add(this.tabPage1);
            this.tabComponentes.Controls.Add(this.tabPage2);
            this.tabComponentes.Location = new System.Drawing.Point(3, 198);
            this.tabComponentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabComponentes.Name = "tabComponentes";
            this.tabComponentes.SelectedIndex = 0;
            this.tabComponentes.Size = new System.Drawing.Size(988, 412);
            this.tabComponentes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.btnMasServicio);
            this.tabPage1.Controls.Add(this.npMasServicio);
            this.tabPage1.Controls.Add(this.btnQuitarServicio);
            this.tabPage1.Controls.Add(this.txtQuitarServicio);
            this.tabPage1.Controls.Add(this.btnAgregarServicio);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.npQuitarServicio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtAgregarServicio);
            this.tabPage1.Controls.Add(this.npAgregarServicio);
            this.tabPage1.Controls.Add(this.grdServiciosDos);
            this.tabPage1.Controls.Add(this.grdServicioUno);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(980, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reparaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMasServicio
            // 
            this.btnMasServicio.Location = new System.Drawing.Point(897, 11);
            this.btnMasServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasServicio.Name = "btnMasServicio";
            this.btnMasServicio.Size = new System.Drawing.Size(69, 28);
            this.btnMasServicio.TabIndex = 20;
            this.btnMasServicio.Text = "+";
            this.btnMasServicio.UseVisualStyleBackColor = true;
            this.btnMasServicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // npMasServicio
            // 
            this.npMasServicio.Location = new System.Drawing.Point(824, 15);
            this.npMasServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npMasServicio.Name = "npMasServicio";
            this.npMasServicio.Size = new System.Drawing.Size(65, 22);
            this.npMasServicio.TabIndex = 19;
            this.npMasServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnQuitarServicio
            // 
            this.btnQuitarServicio.Location = new System.Drawing.Point(345, 194);
            this.btnQuitarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitarServicio.Name = "btnQuitarServicio";
            this.btnQuitarServicio.Size = new System.Drawing.Size(69, 28);
            this.btnQuitarServicio.TabIndex = 18;
            this.btnQuitarServicio.Text = "<--";
            this.btnQuitarServicio.UseVisualStyleBackColor = true;
            this.btnQuitarServicio.Click += new System.EventHandler(this.btnQuitarServicio_Click);
            // 
            // txtQuitarServicio
            // 
            this.txtQuitarServicio.Location = new System.Drawing.Point(423, 351);
            this.txtQuitarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuitarServicio.Name = "txtQuitarServicio";
            this.txtQuitarServicio.Size = new System.Drawing.Size(549, 22);
            this.txtQuitarServicio.TabIndex = 16;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(345, 143);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(69, 28);
            this.btnAgregarServicio.TabIndex = 17;
            this.btnAgregarServicio.Text = "-->";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quitar:";
            // 
            // npQuitarServicio
            // 
            this.npQuitarServicio.Location = new System.Drawing.Point(469, 11);
            this.npQuitarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npQuitarServicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npQuitarServicio.Name = "npQuitarServicio";
            this.npQuitarServicio.Size = new System.Drawing.Size(89, 22);
            this.npQuitarServicio.TabIndex = 14;
            this.npQuitarServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Añadir:";
            // 
            // txtAgregarServicio
            // 
            this.txtAgregarServicio.Location = new System.Drawing.Point(8, 348);
            this.txtAgregarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgregarServicio.Name = "txtAgregarServicio";
            this.txtAgregarServicio.Size = new System.Drawing.Size(325, 22);
            this.txtAgregarServicio.TabIndex = 13;
            // 
            // npAgregarServicio
            // 
            this.npAgregarServicio.Location = new System.Drawing.Point(68, 11);
            this.npAgregarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npAgregarServicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npAgregarServicio.Name = "npAgregarServicio";
            this.npAgregarServicio.Size = new System.Drawing.Size(100, 22);
            this.npAgregarServicio.TabIndex = 11;
            this.npAgregarServicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grdServiciosDos
            // 
            this.grdServiciosDos.AllowUserToAddRows = false;
            this.grdServiciosDos.AllowUserToDeleteRows = false;
            this.grdServiciosDos.AllowUserToOrderColumns = true;
            this.grdServiciosDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServiciosDos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_servicio,
            this.cantidad_servicio,
            this.costo_servicio,
            this.empleado_servicio,
            this.servicio_servicio,
            this.orden_servicio});
            this.grdServiciosDos.Location = new System.Drawing.Point(423, 59);
            this.grdServiciosDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdServiciosDos.Name = "grdServiciosDos";
            this.grdServiciosDos.ReadOnly = true;
            this.grdServiciosDos.Size = new System.Drawing.Size(555, 284);
            this.grdServiciosDos.TabIndex = 3;
            this.grdServiciosDos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seleccionOrdenServicio);
            // 
            // id_servicio
            // 
            this.id_servicio.DataPropertyName = "Id";
            this.id_servicio.HeaderText = "Codigo";
            this.id_servicio.Name = "id_servicio";
            this.id_servicio.ReadOnly = true;
            this.id_servicio.Width = 50;
            // 
            // cantidad_servicio
            // 
            this.cantidad_servicio.DataPropertyName = "Cantidad";
            this.cantidad_servicio.HeaderText = "Cantidad";
            this.cantidad_servicio.Name = "cantidad_servicio";
            this.cantidad_servicio.ReadOnly = true;
            this.cantidad_servicio.Width = 50;
            // 
            // costo_servicio
            // 
            this.costo_servicio.DataPropertyName = "Costo";
            this.costo_servicio.HeaderText = "Costo";
            this.costo_servicio.Name = "costo_servicio";
            this.costo_servicio.ReadOnly = true;
            this.costo_servicio.Width = 60;
            // 
            // empleado_servicio
            // 
            this.empleado_servicio.DataPropertyName = "Empleado";
            this.empleado_servicio.HeaderText = "Empleado";
            this.empleado_servicio.Name = "empleado_servicio";
            this.empleado_servicio.ReadOnly = true;
            this.empleado_servicio.Width = 75;
            // 
            // servicio_servicio
            // 
            this.servicio_servicio.DataPropertyName = "Servicio";
            this.servicio_servicio.HeaderText = "Servicio";
            this.servicio_servicio.Name = "servicio_servicio";
            this.servicio_servicio.ReadOnly = true;
            this.servicio_servicio.Width = 55;
            // 
            // orden_servicio
            // 
            this.orden_servicio.DataPropertyName = "Orden";
            this.orden_servicio.HeaderText = "Orden";
            this.orden_servicio.Name = "orden_servicio";
            this.orden_servicio.ReadOnly = true;
            this.orden_servicio.Width = 80;
            // 
            // grdServicioUno
            // 
            this.grdServicioUno.AllowUserToAddRows = false;
            this.grdServicioUno.AllowUserToDeleteRows = false;
            this.grdServicioUno.AllowUserToOrderColumns = true;
            this.grdServicioUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicioUno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Servicio_s,
            this.precio_s,
            this.Impuesto});
            this.grdServicioUno.Location = new System.Drawing.Point(8, 59);
            this.grdServicioUno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdServicioUno.Name = "grdServicioUno";
            this.grdServicioUno.ReadOnly = true;
            this.grdServicioUno.Size = new System.Drawing.Size(327, 284);
            this.grdServicioUno.TabIndex = 2;
            this.grdServicioUno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdServicioUno_MouseClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Cod";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 45;
            // 
            // Servicio_s
            // 
            this.Servicio_s.DataPropertyName = "pServicio";
            this.Servicio_s.HeaderText = "Servicio";
            this.Servicio_s.Name = "Servicio_s";
            this.Servicio_s.ReadOnly = true;
            this.Servicio_s.Width = 55;
            // 
            // precio_s
            // 
            this.precio_s.DataPropertyName = "Precio";
            this.precio_s.HeaderText = "Precio";
            this.precio_s.Name = "precio_s";
            this.precio_s.ReadOnly = true;
            this.precio_s.Width = 55;
            // 
            // Impuesto
            // 
            this.Impuesto.DataPropertyName = "Impuesto";
            this.Impuesto.HeaderText = "I.V.I";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            this.Impuesto.Width = 45;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.btnMasRepuestos);
            this.tabPage2.Controls.Add(this.npMasRepuesto);
            this.tabPage2.Controls.Add(this.grdRepuesto);
            this.tabPage2.Controls.Add(this.txtQuitar);
            this.tabPage2.Controls.Add(this.txtRepuestoUno);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.npQuitarRepuesto);
            this.tabPage2.Controls.Add(this.npRepuestoAgregar);
            this.tabPage2.Controls.Add(this.grdRepuestoDos);
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(980, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Repuestos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMasRepuestos
            // 
            this.btnMasRepuestos.Location = new System.Drawing.Point(897, 7);
            this.btnMasRepuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasRepuestos.Name = "btnMasRepuestos";
            this.btnMasRepuestos.Size = new System.Drawing.Size(69, 28);
            this.btnMasRepuestos.TabIndex = 14;
            this.btnMasRepuestos.Text = "+";
            this.btnMasRepuestos.UseVisualStyleBackColor = true;
            this.btnMasRepuestos.Click += new System.EventHandler(this.btnMasRepuestos_Click);
            // 
            // npMasRepuesto
            // 
            this.npMasRepuesto.Location = new System.Drawing.Point(824, 11);
            this.npMasRepuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npMasRepuesto.Name = "npMasRepuesto";
            this.npMasRepuesto.Size = new System.Drawing.Size(65, 22);
            this.npMasRepuesto.TabIndex = 13;
            this.npMasRepuesto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grdRepuesto
            // 
            this.grdRepuesto.AllowUserToAddRows = false;
            this.grdRepuesto.AllowUserToDeleteRows = false;
            this.grdRepuesto.AllowUserToOrderColumns = true;
            this.grdRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_repuesto,
            this.RepuestoVehiculo,
            this.PrecioVehiculo,
            this.ImpuestoVehiculo});
            this.grdRepuesto.Location = new System.Drawing.Point(8, 59);
            this.grdRepuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdRepuesto.MultiSelect = false;
            this.grdRepuesto.Name = "grdRepuesto";
            this.grdRepuesto.ReadOnly = true;
            this.grdRepuesto.Size = new System.Drawing.Size(329, 284);
            this.grdRepuesto.TabIndex = 12;
            this.grdRepuesto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectRepuesto);
            // 
            // id_repuesto
            // 
            this.id_repuesto.DataPropertyName = "Id";
            this.id_repuesto.HeaderText = "Cod";
            this.id_repuesto.Name = "id_repuesto";
            this.id_repuesto.ReadOnly = true;
            this.id_repuesto.Width = 45;
            // 
            // RepuestoVehiculo
            // 
            this.RepuestoVehiculo.DataPropertyName = "Repuesto";
            this.RepuestoVehiculo.HeaderText = "Repuesto";
            this.RepuestoVehiculo.Name = "RepuestoVehiculo";
            this.RepuestoVehiculo.ReadOnly = true;
            this.RepuestoVehiculo.Width = 55;
            // 
            // PrecioVehiculo
            // 
            this.PrecioVehiculo.DataPropertyName = "Precio";
            this.PrecioVehiculo.HeaderText = "Precio";
            this.PrecioVehiculo.Name = "PrecioVehiculo";
            this.PrecioVehiculo.ReadOnly = true;
            this.PrecioVehiculo.Width = 55;
            // 
            // ImpuestoVehiculo
            // 
            this.ImpuestoVehiculo.DataPropertyName = "Impuesto";
            this.ImpuestoVehiculo.HeaderText = "I.V.I";
            this.ImpuestoVehiculo.Name = "ImpuestoVehiculo";
            this.ImpuestoVehiculo.ReadOnly = true;
            this.ImpuestoVehiculo.Width = 45;
            // 
            // txtQuitar
            // 
            this.txtQuitar.Location = new System.Drawing.Point(423, 351);
            this.txtQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuitar.Name = "txtQuitar";
            this.txtQuitar.Size = new System.Drawing.Size(553, 22);
            this.txtQuitar.TabIndex = 11;
            // 
            // txtRepuestoUno
            // 
            this.txtRepuestoUno.Location = new System.Drawing.Point(8, 348);
            this.txtRepuestoUno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepuestoUno.Name = "txtRepuestoUno";
            this.txtRepuestoUno.Size = new System.Drawing.Size(328, 22);
            this.txtRepuestoUno.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quitar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Añadir:";
            // 
            // npQuitarRepuesto
            // 
            this.npQuitarRepuesto.Location = new System.Drawing.Point(469, 11);
            this.npQuitarRepuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npQuitarRepuesto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npQuitarRepuesto.Name = "npQuitarRepuesto";
            this.npQuitarRepuesto.Size = new System.Drawing.Size(89, 22);
            this.npQuitarRepuesto.TabIndex = 7;
            this.npQuitarRepuesto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npRepuestoAgregar
            // 
            this.npRepuestoAgregar.Location = new System.Drawing.Point(68, 11);
            this.npRepuestoAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npRepuestoAgregar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npRepuestoAgregar.Name = "npRepuestoAgregar";
            this.npRepuestoAgregar.Size = new System.Drawing.Size(100, 22);
            this.npRepuestoAgregar.TabIndex = 6;
            this.npRepuestoAgregar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grdRepuestoDos
            // 
            this.grdRepuestoDos.AllowUserToAddRows = false;
            this.grdRepuestoDos.AllowUserToDeleteRows = false;
            this.grdRepuestoDos.AllowUserToOrderColumns = true;
            this.grdRepuestoDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuestoDos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cantidad,
            this.Empleado_D,
            this.TotalRepuestos,
            this.Orden_d,
            this.Repuesto1});
            this.grdRepuestoDos.Location = new System.Drawing.Point(423, 59);
            this.grdRepuestoDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdRepuestoDos.MultiSelect = false;
            this.grdRepuestoDos.Name = "grdRepuestoDos";
            this.grdRepuestoDos.ReadOnly = true;
            this.grdRepuestoDos.Size = new System.Drawing.Size(552, 284);
            this.grdRepuestoDos.TabIndex = 5;
            this.grdRepuestoDos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seleccionOrdenRepuest);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // Empleado_D
            // 
            this.Empleado_D.DataPropertyName = "Empleado";
            this.Empleado_D.HeaderText = "Empleado";
            this.Empleado_D.Name = "Empleado_D";
            this.Empleado_D.ReadOnly = true;
            this.Empleado_D.Width = 60;
            // 
            // TotalRepuestos
            // 
            this.TotalRepuestos.DataPropertyName = "TotalRepuestos";
            this.TotalRepuestos.HeaderText = "Total";
            this.TotalRepuestos.Name = "TotalRepuestos";
            this.TotalRepuestos.ReadOnly = true;
            this.TotalRepuestos.Width = 75;
            // 
            // Orden_d
            // 
            this.Orden_d.DataPropertyName = "Orden";
            this.Orden_d.HeaderText = "Orden";
            this.Orden_d.Name = "Orden_d";
            this.Orden_d.ReadOnly = true;
            this.Orden_d.Width = 55;
            // 
            // Repuesto1
            // 
            this.Repuesto1.DataPropertyName = "Repuesto1";
            this.Repuesto1.HeaderText = "Repuesto";
            this.Repuesto1.Name = "Repuesto1";
            this.Repuesto1.ReadOnly = true;
            this.Repuesto1.Width = 80;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(345, 194);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(69, 28);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "<--";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(345, 143);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "-->";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(448, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha factu:";
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Location = new System.Drawing.Point(555, 112);
            this.dtFechaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Size = new System.Drawing.Size(283, 22);
            this.dtFechaSalida.TabIndex = 24;
            // 
            // dtIngreso
            // 
            this.dtIngreso.Location = new System.Drawing.Point(555, 70);
            this.dtIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(283, 22);
            this.dtIngreso.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(444, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(444, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(85, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vehículo:";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(164, 73);
            this.cbVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(173, 24);
            this.cbVehiculo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Empleado:";
            // 
            // cbEncargado
            // 
            this.cbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncargado.FormattingEnabled = true;
            this.cbEncargado.Location = new System.Drawing.Point(164, 111);
            this.cbEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(173, 24);
            this.cbEncargado.TabIndex = 30;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(813, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(160, 22);
            this.txtCodigo.TabIndex = 32;
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(991, 27);
            this.toolStrip3.TabIndex = 33;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(99, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Finalizado"});
            this.cbEstado.Location = new System.Drawing.Point(165, 149);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(172, 24);
            this.cbEstado.TabIndex = 36;
            // 
            // grdMarca
            // 
            this.grdMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarca.Location = new System.Drawing.Point(3, 31);
            this.grdMarca.Name = "grdMarca";
            this.grdMarca.Size = new System.Drawing.Size(211, 214);
            this.grdMarca.TabIndex = 0;
            // 
            // txtFechaFacturacion
            // 
            this.txtFechaFacturacion.Location = new System.Drawing.Point(555, 154);
            this.txtFechaFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaFacturacion.Name = "txtFechaFacturacion";
            this.txtFechaFacturacion.Size = new System.Drawing.Size(283, 22);
            this.txtFechaFacturacion.TabIndex = 37;
            // 
            // FrmOrdenReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 608);
            this.Controls.Add(this.txtFechaFacturacion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbEncargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFechaSalida);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabComponentes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOrdenReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparaciónes y Servicios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenReparaciones_FormClosed);
            this.tabComponentes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMasServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitarServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npAgregarServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiciosDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicioUno)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMasRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npQuitarRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npRepuestoAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestoDos)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabComponentes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridView grdMarca;
        private System.Windows.Forms.DataGridView grdServicioUno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown npQuitarRepuesto;
        private System.Windows.Forms.NumericUpDown npRepuestoAgregar;
        private System.Windows.Forms.DataGridView grdRepuestoDos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtRepuestoUno;
        private System.Windows.Forms.TextBox txtQuitar;
        private System.Windows.Forms.DataGridView grdRepuesto;
        private System.Windows.Forms.Button btnQuitarServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.TextBox txtQuitarServicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown npQuitarServicio;
        private System.Windows.Forms.TextBox txtAgregarServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown npAgregarServicio;
        private System.Windows.Forms.DataGridView grdServiciosDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepuestoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repuesto1;
        private System.Windows.Forms.Button btnMasRepuestos;
        private System.Windows.Forms.NumericUpDown npMasRepuesto;
        private System.Windows.Forms.Button btnMasServicio;
        private System.Windows.Forms.NumericUpDown npMasServicio;
        private System.Windows.Forms.TextBox txtFechaFacturacion;
    }
}