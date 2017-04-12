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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
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
            this.registroCatalogoReparacionToolStripMenuItem});
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.parámetrosToolStripMenuItem.Text = "Parámetros";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroClienteToolStripMenuItem.Text = "Registro cliente";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // registroMarcasToolStripMenuItem
            // 
            this.registroMarcasToolStripMenuItem.Name = "registroMarcasToolStripMenuItem";
            this.registroMarcasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroMarcasToolStripMenuItem.Text = "Registro marcas y modulos ";
            this.registroMarcasToolStripMenuItem.Click += new System.EventHandler(this.registroMarcasToolStripMenuItem_Click);
            // 
            // registroClasesVehiculoToolStripMenuItem
            // 
            this.registroClasesVehiculoToolStripMenuItem.Name = "registroClasesVehiculoToolStripMenuItem";
            this.registroClasesVehiculoToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroClasesVehiculoToolStripMenuItem.Text = "Registro Clases Vehiculo";
            this.registroClasesVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroClasesVehiculoToolStripMenuItem_Click);
            // 
            // registroVehiculoToolStripMenuItem
            // 
            this.registroVehiculoToolStripMenuItem.Name = "registroVehiculoToolStripMenuItem";
            this.registroVehiculoToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroVehiculoToolStripMenuItem.Text = "Registro Vehiculo";
            this.registroVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroVehiculoToolStripMenuItem_Click);
            // 
            // registroCatalogoRepuestosToolStripMenuItem
            // 
            this.registroCatalogoRepuestosToolStripMenuItem.Name = "registroCatalogoRepuestosToolStripMenuItem";
            this.registroCatalogoRepuestosToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroCatalogoRepuestosToolStripMenuItem.Text = "Registro Catalogo Repuestos";
            this.registroCatalogoRepuestosToolStripMenuItem.Click += new System.EventHandler(this.registroCatalogoRepuestosToolStripMenuItem_Click);
            // 
            // registroCatalogoReparacionToolStripMenuItem
            // 
            this.registroCatalogoReparacionToolStripMenuItem.Name = "registroCatalogoReparacionToolStripMenuItem";
            this.registroCatalogoReparacionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroCatalogoReparacionToolStripMenuItem.Text = "Registro Catalogo Reparacion";
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
            // 
            // finalizoOrdenToolStripMenuItem
            // 
            this.finalizoOrdenToolStripMenuItem.Name = "finalizoOrdenToolStripMenuItem";
            this.finalizoOrdenToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.finalizoOrdenToolStripMenuItem.Text = "Finaliza orden";
            // 
            // facturaOrdenToolStripMenuItem
            // 
            this.facturaOrdenToolStripMenuItem.Name = "facturaOrdenToolStripMenuItem";
            this.facturaOrdenToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.facturaOrdenToolStripMenuItem.Text = "Factura orden";
            // 
            // gestionGerenciaToolStripMenuItem
            // 
            this.gestionGerenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeOrdenFinalizadaToolStripMenuItem,
            this.informeReparacionesAtendidasToolStripMenuItem,
            this.informeEstadisticoAtendidioToolStripMenuItem});
            this.gestionGerenciaToolStripMenuItem.Name = "gestionGerenciaToolStripMenuItem";
            this.gestionGerenciaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestionGerenciaToolStripMenuItem.Text = "Gestion gerencia";
            // 
            // informeOrdenFinalizadaToolStripMenuItem
            // 
            this.informeOrdenFinalizadaToolStripMenuItem.Name = "informeOrdenFinalizadaToolStripMenuItem";
            this.informeOrdenFinalizadaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeOrdenFinalizadaToolStripMenuItem.Text = "Informe orden finalizada";
            // 
            // informeReparacionesAtendidasToolStripMenuItem
            // 
            this.informeReparacionesAtendidasToolStripMenuItem.Name = "informeReparacionesAtendidasToolStripMenuItem";
            this.informeReparacionesAtendidasToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeReparacionesAtendidasToolStripMenuItem.Text = "Informe reparaciones atendidas";
            // 
            // informeEstadisticoAtendidioToolStripMenuItem
            // 
            this.informeEstadisticoAtendidioToolStripMenuItem.Name = "informeEstadisticoAtendidioToolStripMenuItem";
            this.informeEstadisticoAtendidioToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.informeEstadisticoAtendidioToolStripMenuItem.Text = "Informe estadistico atendidio";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 492);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller UTN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

