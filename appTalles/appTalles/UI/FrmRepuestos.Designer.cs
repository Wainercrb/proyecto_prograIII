namespace Vista
{
    partial class FrmRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepuestos));
            this.grdRepuesto = new System.Windows.Forms.DataGridView();
            this.id_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImpuesto = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTipoMarca = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbImpuesto = new System.Windows.Forms.RadioButton();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbRepuesto = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarcas = new System.Windows.Forms.TextBox();
            this.grdMarca = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadRepuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdRepuesto
            // 
            this.grdRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_repuesto,
            this.RepuestoVehiculo,
            this.PrecioVehiculo,
            this.ImpuestoVehiculo});
            this.grdRepuesto.Location = new System.Drawing.Point(12, 154);
            this.grdRepuesto.Name = "grdRepuesto";
            this.grdRepuesto.Size = new System.Drawing.Size(308, 140);
            this.grdRepuesto.TabIndex = 0;
            this.grdRepuesto.DoubleClick += new System.EventHandler(this.editarRepuesto);
            this.grdRepuesto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obtenerMarcas);
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
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(75, 49);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(84, 20);
            this.txtImpuesto.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(245, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(112, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(75, 23);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(112, 20);
            this.txtRepuesto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Impuesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repuesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "  %";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(12, 562);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(186, 20);
            this.txtMensaje.TabIndex = 10;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(345, 436);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(83, 23);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTipoMarca
            // 
            this.btnTipoMarca.Location = new System.Drawing.Point(326, 219);
            this.btnTipoMarca.Name = "btnTipoMarca";
            this.btnTipoMarca.Size = new System.Drawing.Size(83, 23);
            this.btnTipoMarca.TabIndex = 16;
            this.btnTipoMarca.Text = "Agregar marca";
            this.btnTipoMarca.UseVisualStyleBackColor = true;
            this.btnTipoMarca.Click += new System.EventHandler(this.btnTipoMarca_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(326, 192);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(100, 21);
            this.cbMarca.TabIndex = 15;
            this.cbMarca.SelectionChangeCommitted += new System.EventHandler(this.selecionMarca);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marcas compatibles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Marcas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbImpuesto);
            this.groupBox2.Controls.Add(this.rbPrecio);
            this.groupBox2.Controls.Add(this.rbRepuesto);
            this.groupBox2.Location = new System.Drawing.Point(47, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 35);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rbImpuesto
            // 
            this.rbImpuesto.AutoSize = true;
            this.rbImpuesto.Location = new System.Drawing.Point(145, 12);
            this.rbImpuesto.Name = "rbImpuesto";
            this.rbImpuesto.Size = new System.Drawing.Size(68, 17);
            this.rbImpuesto.TabIndex = 19;
            this.rbImpuesto.TabStop = true;
            this.rbImpuesto.Text = "Impuesto";
            this.rbImpuesto.UseVisualStyleBackColor = true;
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Location = new System.Drawing.Point(84, 11);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(55, 17);
            this.rbPrecio.TabIndex = 1;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            // 
            // rbRepuesto
            // 
            this.rbRepuesto.AutoSize = true;
            this.rbRepuesto.Checked = true;
            this.rbRepuesto.Location = new System.Drawing.Point(10, 10);
            this.rbRepuesto.Name = "rbRepuesto";
            this.rbRepuesto.Size = new System.Drawing.Size(71, 17);
            this.rbRepuesto.TabIndex = 0;
            this.rbRepuesto.TabStop = true;
            this.rbRepuesto.Text = "Repuesto";
            this.rbRepuesto.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(303, 122);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarRepuesto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Buscar:";
            // 
            // txtMarcas
            // 
            this.txtMarcas.Location = new System.Drawing.Point(345, 520);
            this.txtMarcas.Name = "txtMarcas";
            this.txtMarcas.Size = new System.Drawing.Size(74, 20);
            this.txtMarcas.TabIndex = 18;
            // 
            // grdMarca
            // 
            this.grdMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.marcaVehiculo});
            this.grdMarca.Location = new System.Drawing.Point(12, 336);
            this.grdMarca.Name = "grdMarca";
            this.grdMarca.Size = new System.Drawing.Size(308, 204);
            this.grdMarca.TabIndex = 6;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "Id";
            this.idMarca.HeaderText = "Id";
            this.idMarca.Name = "idMarca";
            // 
            // marcaVehiculo
            // 
            this.marcaVehiculo.DataPropertyName = "marca";
            this.marcaVehiculo.HeaderText = "Marca";
            this.marcaVehiculo.Name = "marcaVehiculo";
            // 
            // txtCantidadRepuesto
            // 
            this.txtCantidadRepuesto.Location = new System.Drawing.Point(326, 310);
            this.txtCantidadRepuesto.Name = "txtCantidadRepuesto";
            this.txtCantidadRepuesto.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRepuesto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Repuestos:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnRefrescar,
            this.btnLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(13, 89);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 25);
            this.toolStrip1.TabIndex = 19;
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(23, 22);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 594);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.btnTipoMarca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.txtMarcas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.grdRepuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.grdMarca);
            this.Controls.Add(this.txtRepuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadRepuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "FrmRepuestos";
            this.Text = "FrmReparaciones";
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRepuesto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbRepuesto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadRepuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtImpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdMarca;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTipoMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepuestoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoVehiculo;
        private System.Windows.Forms.TextBox txtMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVehiculo;
        private System.Windows.Forms.RadioButton rbImpuesto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
    }
}