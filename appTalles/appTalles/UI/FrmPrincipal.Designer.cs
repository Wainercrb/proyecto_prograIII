namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClasesVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCatalogoRepuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCatalogoReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediarOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarReparacionesRepuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizoOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeOrdenFinalizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeReparacionesAtendidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeEstadisticoAtendidioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeOrdenPendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.grdOrdenes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mantenimientoModelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.parámetrosToolStripMenuItem,
            this.ediarOrdenesToolStripMenuItem,
            this.gestionGerenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioContraseñaToolStripMenuItem,
            this.registroEmpleadoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cambioContraseñaToolStripMenuItem
            // 
            this.cambioContraseñaToolStripMenuItem.Name = "cambioContraseñaToolStripMenuItem";
            this.cambioContraseñaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cambioContraseñaToolStripMenuItem.Text = "Cambio contraseña";
            this.cambioContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioContraseñaToolStripMenuItem_Click);
            // 
            // registroEmpleadoToolStripMenuItem
            // 
            this.registroEmpleadoToolStripMenuItem.Name = "registroEmpleadoToolStripMenuItem";
            this.registroEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registroEmpleadoToolStripMenuItem.Text = "Registro empleado";
            this.registroEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registroEmpleadoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.registroMarcasToolStripMenuItem,
            this.registroClasesVehiculoToolStripMenuItem,
            this.registroVehiculoToolStripMenuItem,
            this.registroCatalogoRepuestosToolStripMenuItem,
            this.registroCatalogoReparacionToolStripMenuItem,
            this.mantenimientoModelosToolStripMenuItem});
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.parámetrosToolStripMenuItem.Text = "Parámetros";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registroClienteToolStripMenuItem.Text = "Registro cliente";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // registroMarcasToolStripMenuItem
            // 
            this.registroMarcasToolStripMenuItem.Name = "registroMarcasToolStripMenuItem";
            this.registroMarcasToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registroMarcasToolStripMenuItem.Text = "Mantenimiento marcas";
            this.registroMarcasToolStripMenuItem.Click += new System.EventHandler(this.registroMarcasToolStripMenuItem_Click);
            // 
            // registroClasesVehiculoToolStripMenuItem
            // 
            this.registroClasesVehiculoToolStripMenuItem.Name = "registroClasesVehiculoToolStripMenuItem";
            this.registroClasesVehiculoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registroClasesVehiculoToolStripMenuItem.Text = "Mantenimineto tipos vehículos";
            this.registroClasesVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroClasesVehiculoToolStripMenuItem_Click);
            // 
            // registroVehiculoToolStripMenuItem
            // 
            this.registroVehiculoToolStripMenuItem.Name = "registroVehiculoToolStripMenuItem";
            this.registroVehiculoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registroVehiculoToolStripMenuItem.Text = "Mantenimiento Vehiculo";
            this.registroVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroVehiculoToolStripMenuItem_Click);
            // 
            // registroCatalogoRepuestosToolStripMenuItem
            // 
            this.registroCatalogoRepuestosToolStripMenuItem.Name = "registroCatalogoRepuestosToolStripMenuItem";
            this.registroCatalogoRepuestosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registroCatalogoRepuestosToolStripMenuItem.Text = "Catalogo Repuestos";
            this.registroCatalogoRepuestosToolStripMenuItem.Click += new System.EventHandler(this.registroCatalogoRepuestosToolStripMenuItem_Click);
            // 
            // registroCatalogoReparacionToolStripMenuItem
            // 
            this.registroCatalogoReparacionToolStripMenuItem.Name = "registroCatalogoReparacionToolStripMenuItem";
            this.registroCatalogoReparacionToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registroCatalogoReparacionToolStripMenuItem.Text = "Catalogo Reparaciones";
            this.registroCatalogoReparacionToolStripMenuItem.Click += new System.EventHandler(this.registroCatalogoReparacionToolStripMenuItem_Click);
            // 
            // ediarOrdenesToolStripMenuItem
            // 
            this.ediarOrdenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearOrdenToolStripMenuItem,
            this.registrarReparacionesRepuestosToolStripMenuItem,
            this.finalizoOrdenToolStripMenuItem,
            this.facturaOrdenToolStripMenuItem});
            this.ediarOrdenesToolStripMenuItem.Name = "ediarOrdenesToolStripMenuItem";
            this.ediarOrdenesToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.ediarOrdenesToolStripMenuItem.Text = "Administración ordenes ";
            // 
            // crearOrdenToolStripMenuItem
            // 
            this.crearOrdenToolStripMenuItem.Name = "crearOrdenToolStripMenuItem";
            this.crearOrdenToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.crearOrdenToolStripMenuItem.Text = "Crear orden";
            this.crearOrdenToolStripMenuItem.Click += new System.EventHandler(this.crearOrdenToolStripMenuItem_Click);
            // 
            // registrarReparacionesRepuestosToolStripMenuItem
            // 
            this.registrarReparacionesRepuestosToolStripMenuItem.Name = "registrarReparacionesRepuestosToolStripMenuItem";
            this.registrarReparacionesRepuestosToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.registrarReparacionesRepuestosToolStripMenuItem.Text = "Registrar reparaciones y repuestos";
            this.registrarReparacionesRepuestosToolStripMenuItem.Click += new System.EventHandler(this.registrarReparacionesRepuestosToolStripMenuItem_Click);
            // 
            // finalizoOrdenToolStripMenuItem
            // 
            this.finalizoOrdenToolStripMenuItem.Name = "finalizoOrdenToolStripMenuItem";
            this.finalizoOrdenToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.finalizoOrdenToolStripMenuItem.Text = "Finaliza orden";
            this.finalizoOrdenToolStripMenuItem.Click += new System.EventHandler(this.finalizoOrdenToolStripMenuItem_Click);
            // 
            // facturaOrdenToolStripMenuItem
            // 
            this.facturaOrdenToolStripMenuItem.Name = "facturaOrdenToolStripMenuItem";
            this.facturaOrdenToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.facturaOrdenToolStripMenuItem.Text = "Factura orden";
            this.facturaOrdenToolStripMenuItem.Click += new System.EventHandler(this.facturaOrdenToolStripMenuItem_Click);
            // 
            // gestionGerenciaToolStripMenuItem
            // 
            this.gestionGerenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeOrdenFinalizadaToolStripMenuItem,
            this.informeReparacionesAtendidasToolStripMenuItem,
            this.informeEstadisticoAtendidioToolStripMenuItem,
            this.informeOrdenPendienteToolStripMenuItem});
            this.gestionGerenciaToolStripMenuItem.Name = "gestionGerenciaToolStripMenuItem";
            this.gestionGerenciaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestionGerenciaToolStripMenuItem.Text = "Gestion gerencia";
            // 
            // informeOrdenFinalizadaToolStripMenuItem
            // 
            this.informeOrdenFinalizadaToolStripMenuItem.Name = "informeOrdenFinalizadaToolStripMenuItem";
            this.informeOrdenFinalizadaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeOrdenFinalizadaToolStripMenuItem.Text = "Informe orden finalizada";
            this.informeOrdenFinalizadaToolStripMenuItem.Click += new System.EventHandler(this.informeOrdenFinalizadaToolStripMenuItem_Click);
            // 
            // informeReparacionesAtendidasToolStripMenuItem
            // 
            this.informeReparacionesAtendidasToolStripMenuItem.Name = "informeReparacionesAtendidasToolStripMenuItem";
            this.informeReparacionesAtendidasToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeReparacionesAtendidasToolStripMenuItem.Text = "Informe reparaciones atendidas";
            this.informeReparacionesAtendidasToolStripMenuItem.Click += new System.EventHandler(this.informeReparacionesAtendidasToolStripMenuItem_Click);
            // 
            // informeEstadisticoAtendidioToolStripMenuItem
            // 
            this.informeEstadisticoAtendidioToolStripMenuItem.Name = "informeEstadisticoAtendidioToolStripMenuItem";
            this.informeEstadisticoAtendidioToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeEstadisticoAtendidioToolStripMenuItem.Text = "Informe estadistico atendidio";
            this.informeEstadisticoAtendidioToolStripMenuItem.Click += new System.EventHandler(this.informeEstadisticoAtendidioToolStripMenuItem_Click);
            // 
            // informeOrdenPendienteToolStripMenuItem
            // 
            this.informeOrdenPendienteToolStripMenuItem.Name = "informeOrdenPendienteToolStripMenuItem";
            this.informeOrdenPendienteToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeOrdenPendienteToolStripMenuItem.Text = "Informe orden pendiente";
            this.informeOrdenPendienteToolStripMenuItem.Click += new System.EventHandler(this.informeOrdenPendienteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(850, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenes Pendientes :(";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleado.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(1194, 27);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(168, 18);
            this.txtEmpleado.TabIndex = 4;
            // 
            // grdOrdenes
            // 
            this.grdOrdenes.AllowUserToAddRows = false;
            this.grdOrdenes.AllowUserToDeleteRows = false;
            this.grdOrdenes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaIngreso,
            this.fechaSalida,
            this.fechaFacturacion,
            this.Costo,
            this.Estado,
            this.Empleado,
            this.Vehiculo});
            this.grdOrdenes.Location = new System.Drawing.Point(582, 195);
            this.grdOrdenes.Name = "grdOrdenes";
            this.grdOrdenes.ReadOnly = true;
            this.grdOrdenes.Size = new System.Drawing.Size(768, 424);
            this.grdOrdenes.TabIndex = 5;
            this.grdOrdenes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.seleccionOrden);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 70;
            // 
            // fechaSalida
            // 
            this.fechaSalida.DataPropertyName = "FechaSalida";
            this.fechaSalida.HeaderText = "Salida";
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.ReadOnly = true;
            this.fechaSalida.Width = 70;
            // 
            // fechaFacturacion
            // 
            this.fechaFacturacion.DataPropertyName = "FechaFacturacion";
            this.fechaFacturacion.HeaderText = "Facturación";
            this.fechaFacturacion.Name = "fechaFacturacion";
            this.fechaFacturacion.ReadOnly = true;
            this.fechaFacturacion.Width = 70;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "CostoTotal";
            this.Costo.HeaderText = "Costo total";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 70;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "Empleado";
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 150;
            // 
            // Vehiculo
            // 
            this.Vehiculo.DataPropertyName = "Vehiculo";
            this.Vehiculo.HeaderText = "Vehículo";
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            this.Vehiculo.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 191);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // mantenimientoModelosToolStripMenuItem
            // 
            this.mantenimientoModelosToolStripMenuItem.Name = "mantenimientoModelosToolStripMenuItem";
            this.mantenimientoModelosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.mantenimientoModelosToolStripMenuItem.Text = "Mantenimiento Modelos";
            this.mantenimientoModelosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoModelosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdOrdenes);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller UTN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediarOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGerenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClasesVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCatalogoRepuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCatalogoReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarReparacionesRepuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizoOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeOrdenFinalizadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeReparacionesAtendidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeEstadisticoAtendidioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.DataGridView grdOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem informeOrdenPendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoModelosToolStripMenuItem;
    }
}

