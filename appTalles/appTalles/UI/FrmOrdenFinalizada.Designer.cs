namespace appTalles.UI
{
    partial class FrmOrdenFinalizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenFinalizada));
            this.grdOrdenes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFinalizada = new System.Windows.Forms.ToolStripButton();
            this.btnPendiente = new System.Windows.Forms.ToolStripButton();
            this.btnReversarOrden = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizarOrden = new System.Windows.Forms.ToolStripButton();
            this.txtSeleccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdOrdenes
            // 
            this.grdOrdenes.AllowUserToAddRows = false;
            this.grdOrdenes.AllowUserToDeleteRows = false;
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
            this.grdOrdenes.Location = new System.Drawing.Point(1, 34);
            this.grdOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.grdOrdenes.Name = "grdOrdenes";
            this.grdOrdenes.ReadOnly = true;
            this.grdOrdenes.Size = new System.Drawing.Size(1015, 353);
            this.grdOrdenes.TabIndex = 0;
            this.grdOrdenes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seleccionOrden);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFinalizada,
            this.btnPendiente,
            this.btnReversarOrden,
            this.btnFinalizarOrden});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFinalizada
            // 
            this.btnFinalizada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFinalizada.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizada.Image")));
            this.btnFinalizada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizada.Name = "btnFinalizada";
            this.btnFinalizada.Size = new System.Drawing.Size(24, 24);
            this.btnFinalizada.Text = "Finazalida";
            this.btnFinalizada.Click += new System.EventHandler(this.btnFinalizada_Click);
            // 
            // btnPendiente
            // 
            this.btnPendiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPendiente.Image = ((System.Drawing.Image)(resources.GetObject("btnPendiente.Image")));
            this.btnPendiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(24, 24);
            this.btnPendiente.Text = "Pendiente";
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnReversarOrden
            // 
            this.btnReversarOrden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReversarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnReversarOrden.Image")));
            this.btnReversarOrden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReversarOrden.Name = "btnReversarOrden";
            this.btnReversarOrden.Size = new System.Drawing.Size(24, 24);
            this.btnReversarOrden.Text = "Reversar";
            this.btnReversarOrden.Click += new System.EventHandler(this.btnReversarOrden_Click);
            // 
            // btnFinalizarOrden
            // 
            this.btnFinalizarOrden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFinalizarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarOrden.Image")));
            this.btnFinalizarOrden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizarOrden.Name = "btnFinalizarOrden";
            this.btnFinalizarOrden.Size = new System.Drawing.Size(24, 24);
            this.btnFinalizarOrden.Text = "Finalizar orden";
            this.btnFinalizarOrden.Click += new System.EventHandler(this.btnFinalizarOrden_Click);
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.Location = new System.Drawing.Point(1, 395);
            this.txtSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(1013, 22);
            this.txtSeleccion.TabIndex = 2;
            // 
            // FrmOrdenFinalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 426);
            this.Controls.Add(this.txtSeleccion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdOrdenes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrdenFinalizada";
            this.Text = "FrmOrdenFinalizada";
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrdenes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFinalizada;
        private System.Windows.Forms.ToolStripButton btnPendiente;
        private System.Windows.Forms.ToolStripButton btnFinalizarOrden;
        private System.Windows.Forms.ToolStripButton btnReversarOrden;
        private System.Windows.Forms.TextBox txtSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
    }
}