namespace Vista
{
    partial class frmEdicionVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicionVehiculo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBuscarCilindraje = new System.Windows.Forms.RadioButton();
            this.rbBuscarCombustible = new System.Windows.Forms.RadioButton();
            this.rbBuscarChazis = new System.Windows.Forms.RadioButton();
            this.rbBuscarMotor = new System.Windows.Forms.RadioButton();
            this.rbBuscarAnno = new System.Windows.Forms.RadioButton();
            this.rbBuscarPlaca = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grdVehiculos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cilindraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chazis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca_Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nubAnno = new System.Windows.Forms.NumericUpDown();
            this.nubChazis = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nubMotor = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCilindraje = new System.Windows.Forms.NumericUpDown();
            this.cbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.grbEstado = new System.Windows.Forms.GroupBox();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbDanado = new System.Windows.Forms.RadioButton();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlacaa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrecar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubChazis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindraje)).BeginInit();
            this.grbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBuscarCilindraje);
            this.groupBox1.Controls.Add(this.rbBuscarCombustible);
            this.groupBox1.Controls.Add(this.rbBuscarChazis);
            this.groupBox1.Controls.Add(this.rbBuscarMotor);
            this.groupBox1.Controls.Add(this.rbBuscarAnno);
            this.groupBox1.Controls.Add(this.rbBuscarPlaca);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(4, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbBuscarCilindraje
            // 
            this.rbBuscarCilindraje.AutoSize = true;
            this.rbBuscarCilindraje.Location = new System.Drawing.Point(232, 13);
            this.rbBuscarCilindraje.Name = "rbBuscarCilindraje";
            this.rbBuscarCilindraje.Size = new System.Drawing.Size(77, 17);
            this.rbBuscarCilindraje.TabIndex = 4;
            this.rbBuscarCilindraje.Text = "# Cilindraje";
            this.rbBuscarCilindraje.UseVisualStyleBackColor = true;
            // 
            // rbBuscarCombustible
            // 
            this.rbBuscarCombustible.AutoSize = true;
            this.rbBuscarCombustible.Location = new System.Drawing.Point(397, 14);
            this.rbBuscarCombustible.Name = "rbBuscarCombustible";
            this.rbBuscarCombustible.Size = new System.Drawing.Size(85, 17);
            this.rbBuscarCombustible.TabIndex = 6;
            this.rbBuscarCombustible.Text = "Combustible:";
            this.rbBuscarCombustible.UseVisualStyleBackColor = true;
            // 
            // rbBuscarChazis
            // 
            this.rbBuscarChazis.AutoSize = true;
            this.rbBuscarChazis.Location = new System.Drawing.Point(325, 14);
            this.rbBuscarChazis.Name = "rbBuscarChazis";
            this.rbBuscarChazis.Size = new System.Drawing.Size(66, 17);
            this.rbBuscarChazis.TabIndex = 5;
            this.rbBuscarChazis.Text = "# Chazis";
            this.rbBuscarChazis.UseVisualStyleBackColor = true;
            // 
            // rbBuscarMotor
            // 
            this.rbBuscarMotor.AutoSize = true;
            this.rbBuscarMotor.Location = new System.Drawing.Point(164, 15);
            this.rbBuscarMotor.Name = "rbBuscarMotor";
            this.rbBuscarMotor.Size = new System.Drawing.Size(62, 17);
            this.rbBuscarMotor.TabIndex = 3;
            this.rbBuscarMotor.Text = "# Motor";
            this.rbBuscarMotor.UseVisualStyleBackColor = true;
            // 
            // rbBuscarAnno
            // 
            this.rbBuscarAnno.AutoSize = true;
            this.rbBuscarAnno.Location = new System.Drawing.Point(114, 14);
            this.rbBuscarAnno.Name = "rbBuscarAnno";
            this.rbBuscarAnno.Size = new System.Drawing.Size(44, 17);
            this.rbBuscarAnno.TabIndex = 2;
            this.rbBuscarAnno.Text = "Año";
            this.rbBuscarAnno.UseVisualStyleBackColor = true;
            // 
            // rbBuscarPlaca
            // 
            this.rbBuscarPlaca.AutoSize = true;
            this.rbBuscarPlaca.Checked = true;
            this.rbBuscarPlaca.Location = new System.Drawing.Point(56, 14);
            this.rbBuscarPlaca.Name = "rbBuscarPlaca";
            this.rbBuscarPlaca.Size = new System.Drawing.Size(52, 17);
            this.rbBuscarPlaca.TabIndex = 1;
            this.rbBuscarPlaca.TabStop = true;
            this.rbBuscarPlaca.Text = "Placa";
            this.rbBuscarPlaca.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(488, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(239, 20);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusquedaVehiculo);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Buscar:";
            // 
            // grdVehiculos
            // 
            this.grdVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Placa,
            this.Año,
            this.Cilindraje,
            this.Motor,
            this.Chazis,
            this.Combustible,
            this.Estado,
            this.Marca_Vehiculo,
            this.tipo_,
            this.Cliente_});
            this.grdVehiculos.Location = new System.Drawing.Point(4, 242);
            this.grdVehiculos.Name = "grdVehiculos";
            this.grdVehiculos.ReadOnly = true;
            this.grdVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehiculos.Size = new System.Drawing.Size(744, 215);
            this.grdVehiculos.StandardTab = true;
            this.grdVehiculos.TabIndex = 0;
            this.grdVehiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Editar);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Anno";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Cilindraje
            // 
            this.Cilindraje.DataPropertyName = "Cilindraje";
            this.Cilindraje.HeaderText = "Cilindraje";
            this.Cilindraje.Name = "Cilindraje";
            this.Cilindraje.ReadOnly = true;
            // 
            // Motor
            // 
            this.Motor.DataPropertyName = "NumeroMotor";
            this.Motor.HeaderText = "Motor";
            this.Motor.Name = "Motor";
            this.Motor.ReadOnly = true;
            // 
            // Chazis
            // 
            this.Chazis.DataPropertyName = "NumeroChazis";
            this.Chazis.HeaderText = "Chazis";
            this.Chazis.Name = "Chazis";
            this.Chazis.ReadOnly = true;
            // 
            // Combustible
            // 
            this.Combustible.DataPropertyName = "TipoCombustible";
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Marca_Vehiculo
            // 
            this.Marca_Vehiculo.DataPropertyName = "Marca";
            this.Marca_Vehiculo.HeaderText = "Marca";
            this.Marca_Vehiculo.Name = "Marca_Vehiculo";
            this.Marca_Vehiculo.ReadOnly = true;
            // 
            // tipo_
            // 
            this.tipo_.DataPropertyName = "Tipo";
            this.tipo_.HeaderText = "Tipo";
            this.tipo_.Name = "tipo_";
            this.tipo_.ReadOnly = true;
            // 
            // Cliente_
            // 
            this.Cliente_.DataPropertyName = "Cliente";
            this.Cliente_.HeaderText = "Cliente";
            this.Cliente_.Name = "Cliente_";
            this.Cliente_.ReadOnly = true;
            // 
            // nubAnno
            // 
            this.nubAnno.Location = new System.Drawing.Point(95, 32);
            this.nubAnno.Name = "nubAnno";
            this.nubAnno.Size = new System.Drawing.Size(86, 20);
            this.nubAnno.TabIndex = 1;
            // 
            // nubChazis
            // 
            this.nubChazis.Location = new System.Drawing.Point(95, 110);
            this.nubChazis.Name = "nubChazis";
            this.nubChazis.Size = new System.Drawing.Size(86, 20);
            this.nubChazis.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Caballos de fuerza.";
            // 
            // nubMotor
            // 
            this.nubMotor.Location = new System.Drawing.Point(95, 85);
            this.nubMotor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nubMotor.Name = "nubMotor";
            this.nubMotor.Size = new System.Drawing.Size(86, 20);
            this.nubMotor.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "cc.";
            // 
            // nudCilindraje
            // 
            this.nudCilindraje.Location = new System.Drawing.Point(95, 58);
            this.nudCilindraje.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCilindraje.Name = "nudCilindraje";
            this.nudCilindraje.Size = new System.Drawing.Size(86, 20);
            this.nudCilindraje.TabIndex = 2;
            // 
            // cbTipoCombustible
            // 
            this.cbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCombustible.FormattingEnabled = true;
            this.cbTipoCombustible.Items.AddRange(new object[] {
            "Súper",
            "Regúlar",
            "Diésel",
            "Otro"});
            this.cbTipoCombustible.Location = new System.Drawing.Point(94, 139);
            this.cbTipoCombustible.Name = "cbTipoCombustible";
            this.cbTipoCombustible.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCombustible.TabIndex = 5;
            // 
            // grbEstado
            // 
            this.grbEstado.Controls.Add(this.rbFinalizado);
            this.grbEstado.Controls.Add(this.rbPendiente);
            this.grbEstado.Controls.Add(this.rbDanado);
            this.grbEstado.Location = new System.Drawing.Point(329, 6);
            this.grbEstado.Name = "grbEstado";
            this.grbEstado.Size = new System.Drawing.Size(206, 41);
            this.grbEstado.TabIndex = 6;
            this.grbEstado.TabStop = false;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(134, 15);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(72, 17);
            this.rbFinalizado.TabIndex = 2;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Location = new System.Drawing.Point(59, 15);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbPendiente.TabIndex = 1;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbDanado
            // 
            this.rbDanado.AutoSize = true;
            this.rbDanado.Checked = true;
            this.rbDanado.Location = new System.Drawing.Point(1, 15);
            this.rbDanado.Name = "rbDanado";
            this.rbDanado.Size = new System.Drawing.Size(63, 17);
            this.rbDanado.TabIndex = 0;
            this.rbDanado.TabStop = true;
            this.rbDanado.Text = "Dañado";
            this.rbDanado.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(329, 109);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(206, 21);
            this.cbTipo.TabIndex = 9;
            this.cbTipo.SelectionChangeCommitted += new System.EventHandler(this.seleccionCbTipo);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(329, 81);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(206, 21);
            this.cbMarca.TabIndex = 8;
            this.cbMarca.SelectionChangeCommitted += new System.EventHandler(this.seleccionCbMarca);
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(329, 53);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(206, 21);
            this.cbCliente.TabIndex = 7;
            this.cbCliente.SelectionChangeCommitted += new System.EventHandler(this.cbClienteSeleccion);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // txtPlacaa
            // 
            this.txtPlacaa.Location = new System.Drawing.Point(94, 6);
            this.txtPlacaa.Name = "txtPlacaa";
            this.txtPlacaa.Size = new System.Drawing.Size(121, 20);
            this.txtPlacaa.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Combustible:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chazis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cilindraje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tarea:";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(45, 463);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.ReadOnly = true;
            this.txtTarea.Size = new System.Drawing.Size(294, 20);
            this.txtTarea.TabIndex = 24;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnRefrecar,
            this.btnLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(13, 163);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnRefrecar
            // 
            this.btnRefrecar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefrecar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrecar.Image")));
            this.btnRefrecar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrecar.Name = "btnRefrecar";
            this.btnRefrecar.Size = new System.Drawing.Size(23, 22);
            this.btnRefrecar.Text = "Refrescar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "Limpiar";
            // 
            // frmEdicionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grdVehiculos);
            this.Controls.Add(this.cbTipoCombustible);
            this.Controls.Add(this.nubAnno);
            this.Controls.Add(this.grbEstado);
            this.Controls.Add(this.nubChazis);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPlacaa);
            this.Controls.Add(this.nubMotor);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudCilindraje);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "frmEdicionVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubChazis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindraje)).EndInit();
            this.grbEstado.ResumeLayout(false);
            this.grbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdVehiculos;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlacaa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbEstado;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.RadioButton rbDanado;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cilindraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chazis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca_Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBuscarCilindraje;
        private System.Windows.Forms.RadioButton rbBuscarCombustible;
        private System.Windows.Forms.RadioButton rbBuscarChazis;
        private System.Windows.Forms.RadioButton rbBuscarMotor;
        private System.Windows.Forms.RadioButton rbBuscarAnno;
        private System.Windows.Forms.RadioButton rbBuscarPlaca;
        private System.Windows.Forms.ComboBox cbTipoCombustible;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudCilindraje;
        private System.Windows.Forms.NumericUpDown nubMotor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nubChazis;
        private System.Windows.Forms.NumericUpDown nubAnno;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnRefrecar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label label11;
    }
}