namespace Vista
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefonoCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoResodencia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbempleado = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.grupPuesto = new System.Windows.Forms.GroupBox();
            this.rbjefe = new System.Windows.Forms.RadioButton();
            this.rbCajero = new System.Windows.Forms.RadioButton();
            this.rbmecanico = new System.Windows.Forms.RadioButton();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdEmpleado = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoResidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadRegistros = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnRegrescar = new System.Windows.Forms.ToolStripButton();
            this.brnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBuscarNombre = new System.Windows.Forms.RadioButton();
            this.rbBuscarPuesto = new System.Windows.Forms.RadioButton();
            this.rbBuscarPermiso = new System.Windows.Forms.RadioButton();
            this.txtSeleccion = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupPuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtusuario);
            this.groupBox4.Controls.Add(this.txtcontraseña);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(416, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(308, 106);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Perfil empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(99, 27);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(176, 23);
            this.txtusuario.TabIndex = 0;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(99, 65);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(176, 23);
            this.txtcontraseña.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Contraseña:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTelefonoCelular);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTelefonoResodencia);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(416, 122);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(316, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teléfonos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Celular:";
            // 
            // txtTelefonoCelular
            // 
            this.txtTelefonoCelular.Location = new System.Drawing.Point(101, 60);
            this.txtTelefonoCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCelular.Name = "txtTelefonoCelular";
            this.txtTelefonoCelular.Size = new System.Drawing.Size(193, 23);
            this.txtTelefonoCelular.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Residencia:";
            // 
            // txtTelefonoResodencia
            // 
            this.txtTelefonoResodencia.Location = new System.Drawing.Point(101, 22);
            this.txtTelefonoResodencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoResodencia.Name = "txtTelefonoResodencia";
            this.txtTelefonoResodencia.Size = new System.Drawing.Size(195, 23);
            this.txtTelefonoResodencia.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbempleado);
            this.groupBox2.Controls.Add(this.rbAdministrador);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(293, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permiso";
            // 
            // rbempleado
            // 
            this.rbempleado.AutoSize = true;
            this.rbempleado.Location = new System.Drawing.Point(129, 20);
            this.rbempleado.Margin = new System.Windows.Forms.Padding(4);
            this.rbempleado.Name = "rbempleado";
            this.rbempleado.Size = new System.Drawing.Size(89, 21);
            this.rbempleado.TabIndex = 1;
            this.rbempleado.TabStop = true;
            this.rbempleado.Text = "Empleado";
            this.rbempleado.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Checked = true;
            this.rbAdministrador.Location = new System.Drawing.Point(4, 20);
            this.rbAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(113, 21);
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // grupPuesto
            // 
            this.grupPuesto.BackColor = System.Drawing.Color.Transparent;
            this.grupPuesto.Controls.Add(this.rbjefe);
            this.grupPuesto.Controls.Add(this.rbCajero);
            this.grupPuesto.Controls.Add(this.rbmecanico);
            this.grupPuesto.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupPuesto.Location = new System.Drawing.Point(24, 186);
            this.grupPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.grupPuesto.Name = "grupPuesto";
            this.grupPuesto.Padding = new System.Windows.Forms.Padding(4);
            this.grupPuesto.Size = new System.Drawing.Size(293, 58);
            this.grupPuesto.TabIndex = 4;
            this.grupPuesto.TabStop = false;
            this.grupPuesto.Text = "Puesto";
            // 
            // rbjefe
            // 
            this.rbjefe.AutoSize = true;
            this.rbjefe.Location = new System.Drawing.Point(204, 23);
            this.rbjefe.Margin = new System.Windows.Forms.Padding(4);
            this.rbjefe.Name = "rbjefe";
            this.rbjefe.Size = new System.Drawing.Size(53, 21);
            this.rbjefe.TabIndex = 2;
            this.rbjefe.TabStop = true;
            this.rbjefe.Text = "Jefe";
            this.rbjefe.UseVisualStyleBackColor = true;
            // 
            // rbCajero
            // 
            this.rbCajero.AutoSize = true;
            this.rbCajero.Location = new System.Drawing.Point(107, 23);
            this.rbCajero.Margin = new System.Windows.Forms.Padding(4);
            this.rbCajero.Name = "rbCajero";
            this.rbCajero.Size = new System.Drawing.Size(69, 21);
            this.rbCajero.TabIndex = 1;
            this.rbCajero.TabStop = true;
            this.rbCajero.Text = "Cajero";
            this.rbCajero.UseVisualStyleBackColor = true;
            // 
            // rbmecanico
            // 
            this.rbmecanico.AutoSize = true;
            this.rbmecanico.Checked = true;
            this.rbmecanico.Location = new System.Drawing.Point(4, 23);
            this.rbmecanico.Margin = new System.Windows.Forms.Padding(4);
            this.rbmecanico.Name = "rbmecanico";
            this.rbmecanico.Size = new System.Drawing.Size(85, 21);
            this.rbmecanico.TabIndex = 0;
            this.rbmecanico.TabStop = true;
            this.rbmecanico.Text = "Mecánico";
            this.rbmecanico.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(105, 43);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(225, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(105, 78);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(225, 23);
            this.txtDireccion.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(105, 7);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(225, 23);
            this.txtnombre.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(391, 11);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // grdEmpleado
            // 
            this.grdEmpleado.AllowUserToAddRows = false;
            this.grdEmpleado.AllowUserToDeleteRows = false;
            this.grdEmpleado.AllowUserToOrderColumns = true;
            this.grdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.TelefonoResidencia,
            this.TelefonoCelular,
            this.Puesto,
            this.Permiso,
            this.Usuario,
            this.Contrasenna});
            this.grdEmpleado.Location = new System.Drawing.Point(4, 300);
            this.grdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.ReadOnly = true;
            this.grdEmpleado.Size = new System.Drawing.Size(787, 368);
            this.grdEmpleado.TabIndex = 0;
            this.grdEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seleccionEmpleado);
            this.grdEmpleado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdEmpleado_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 65;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 65;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 80;
            // 
            // TelefonoResidencia
            // 
            this.TelefonoResidencia.DataPropertyName = "TelefonoResidencia";
            this.TelefonoResidencia.HeaderText = "Tel. Residencia";
            this.TelefonoResidencia.Name = "TelefonoResidencia";
            this.TelefonoResidencia.ReadOnly = true;
            this.TelefonoResidencia.Width = 65;
            // 
            // TelefonoCelular
            // 
            this.TelefonoCelular.DataPropertyName = "TelefonoCelular";
            this.TelefonoCelular.HeaderText = "Tel. Célular";
            this.TelefonoCelular.Name = "TelefonoCelular";
            this.TelefonoCelular.ReadOnly = true;
            this.TelefonoCelular.Width = 65;
            // 
            // Puesto
            // 
            this.Puesto.DataPropertyName = "Puesto";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Width = 50;
            // 
            // Permiso
            // 
            this.Permiso.DataPropertyName = "Permiso";
            this.Permiso.HeaderText = "Permiso";
            this.Permiso.Name = "Permiso";
            this.Permiso.ReadOnly = true;
            this.Permiso.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 50;
            // 
            // Contrasenna
            // 
            this.Contrasenna.DataPropertyName = "Contrasenna";
            this.Contrasenna.HeaderText = "Contraseña";
            this.Contrasenna.Name = "Contrasenna";
            this.Contrasenna.ReadOnly = true;
            this.Contrasenna.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 679);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registros";
            // 
            // txtCantidadRegistros
            // 
            this.txtCantidadRegistros.Location = new System.Drawing.Point(695, 676);
            this.txtCantidadRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadRegistros.Name = "txtCantidadRegistros";
            this.txtCantidadRegistros.ReadOnly = true;
            this.txtCantidadRegistros.Size = new System.Drawing.Size(95, 22);
            this.txtCantidadRegistros.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnRegrescar,
            this.brnLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(24, 262);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(147, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(24, 24);
            this.btnAgregar.Text = "Refrescar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(24, 24);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegrescar
            // 
            this.btnRegrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegrescar.Image")));
            this.btnRegrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegrescar.Name = "btnRegrescar";
            this.btnRegrescar.Size = new System.Drawing.Size(24, 24);
            this.btnRegrescar.Text = "Refrescar";
            this.btnRegrescar.Click += new System.EventHandler(this.btnRegrescar_Click);
            // 
            // brnLimpiar
            // 
            this.brnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("brnLimpiar.Image")));
            this.brnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brnLimpiar.Name = "brnLimpiar";
            this.brnLimpiar.Size = new System.Drawing.Size(24, 24);
            this.brnLimpiar.Text = "Limpiar";
            this.brnLimpiar.Click += new System.EventHandler(this.brnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbBuscarNombre);
            this.groupBox1.Controls.Add(this.rbBuscarPuesto);
            this.groupBox1.Controls.Add(this.rbBuscarPermiso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(195, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 42);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbBuscarNombre
            // 
            this.rbBuscarNombre.AutoSize = true;
            this.rbBuscarNombre.Checked = true;
            this.rbBuscarNombre.Location = new System.Drawing.Point(87, 14);
            this.rbBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbBuscarNombre.Name = "rbBuscarNombre";
            this.rbBuscarNombre.Size = new System.Drawing.Size(78, 21);
            this.rbBuscarNombre.TabIndex = 4;
            this.rbBuscarNombre.TabStop = true;
            this.rbBuscarNombre.Text = "Nombre";
            this.rbBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // rbBuscarPuesto
            // 
            this.rbBuscarPuesto.AutoSize = true;
            this.rbBuscarPuesto.Location = new System.Drawing.Point(305, 14);
            this.rbBuscarPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.rbBuscarPuesto.Name = "rbBuscarPuesto";
            this.rbBuscarPuesto.Size = new System.Drawing.Size(71, 21);
            this.rbBuscarPuesto.TabIndex = 3;
            this.rbBuscarPuesto.TabStop = true;
            this.rbBuscarPuesto.Text = "Puesto";
            this.rbBuscarPuesto.UseVisualStyleBackColor = true;
            // 
            // rbBuscarPermiso
            // 
            this.rbBuscarPermiso.AutoSize = true;
            this.rbBuscarPermiso.Location = new System.Drawing.Point(200, 14);
            this.rbBuscarPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.rbBuscarPermiso.Name = "rbBuscarPermiso";
            this.rbBuscarPermiso.Size = new System.Drawing.Size(77, 21);
            this.rbBuscarPermiso.TabIndex = 2;
            this.rbBuscarPermiso.TabStop = true;
            this.rbBuscarPermiso.Text = "Permiso";
            this.rbBuscarPermiso.UseVisualStyleBackColor = true;
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeleccion.Location = new System.Drawing.Point(14, 676);
            this.txtSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeleccion.Multiline = true;
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(597, 25);
            this.txtSeleccion.TabIndex = 14;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 706);
            this.Controls.Add(this.txtSeleccion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdEmpleado);
            this.Controls.Add(this.grupPuesto);
            this.Controls.Add(this.txtCantidadRegistros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupPuesto.ResumeLayout(false);
            this.grupPuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdEmpleado;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtTelefonoResodencia;
        private System.Windows.Forms.TextBox txtTelefonoCelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbempleado;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.GroupBox grupPuesto;
        private System.Windows.Forms.RadioButton rbjefe;
        private System.Windows.Forms.RadioButton rbCajero;
        private System.Windows.Forms.RadioButton rbmecanico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadRegistros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnRegrescar;
        private System.Windows.Forms.ToolStripButton brnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBuscarNombre;
        private System.Windows.Forms.RadioButton rbBuscarPuesto;
        private System.Windows.Forms.RadioButton rbBuscarPermiso;
        private System.Windows.Forms.TextBox txtSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoResidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenna;
    }
}