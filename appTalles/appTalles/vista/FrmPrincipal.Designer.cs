namespace Vista
{
    partial class From1
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
            this.mantenimientoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClasesVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCatalogoRepuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCatalogoReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediarOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.registroEmpleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpleadoToolStripMenuItem});
            this.registroEmpleadoToolStripMenuItem.Name = "registroEmpleadoToolStripMenuItem";
            this.registroEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registroEmpleadoToolStripMenuItem.Text = "Registro empleado";
            // 
            // mantenimientoEmpleadoToolStripMenuItem
            // 
            this.mantenimientoEmpleadoToolStripMenuItem.Name = "mantenimientoEmpleadoToolStripMenuItem";
            this.mantenimientoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mantenimientoEmpleadoToolStripMenuItem.Text = "Mantenimiento empleado";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.registroToolStripMenuItem,
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
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroToolStripMenuItem.Text = "Registro proyectos y Modulos";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
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
            // 
            // registroCatalogoReparacionToolStripMenuItem
            // 
            this.registroCatalogoReparacionToolStripMenuItem.Name = "registroCatalogoReparacionToolStripMenuItem";
            this.registroCatalogoReparacionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.registroCatalogoReparacionToolStripMenuItem.Text = "Registro Catalogo Reparacion";
            // 
            // ediarOrdenesToolStripMenuItem
            // 
            this.ediarOrdenesToolStripMenuItem.Name = "ediarOrdenesToolStripMenuItem";
            this.ediarOrdenesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.ediarOrdenesToolStripMenuItem.Text = "Ediar ordenes ";
            // 
            // gestionGerenciaToolStripMenuItem
            // 
            this.gestionGerenciaToolStripMenuItem.Name = "gestionGerenciaToolStripMenuItem";
            this.gestionGerenciaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestionGerenciaToolStripMenuItem.Text = "Gestion gerencia";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 492);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "From1";
            this.Text = "Taller UTN";
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
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClasesVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCatalogoRepuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCatalogoReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpleadoToolStripMenuItem;
    }
}

