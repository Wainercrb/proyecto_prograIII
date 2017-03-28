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
            this.grdRepuesto = new System.Windows.Forms.DataGridView();
            this.id_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImpuesto = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMarcas = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTipoMarca = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grdMarca = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbImpuesto = new System.Windows.Forms.RadioButton();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbRepuesto = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadRepuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.grdRepuesto.Location = new System.Drawing.Point(6, 41);
            this.grdRepuesto.Name = "grdRepuesto";
            this.grdRepuesto.Size = new System.Drawing.Size(239, 306);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtMensaje);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtRepuesto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edición repuestos:";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(70, 96);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(84, 20);
            this.txtImpuesto.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(92, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(188, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(56, 194);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(216, 20);
            this.txtMensaje.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tarea:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 148);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(62, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(70, 66);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(112, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(70, 35);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(112, 20);
            this.txtRepuesto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Impuesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repuesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "  %";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(288, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 433);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMarcas);
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnTipoMarca);
            this.tabPage2.Controls.Add(this.cbMarca);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.grdMarca);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtCantidadRepuesto);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSalir);
            this.tabPage2.Controls.Add(this.grdRepuesto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de repuestos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMarcas
            // 
            this.txtMarcas.Location = new System.Drawing.Point(261, 364);
            this.txtMarcas.Name = "txtMarcas";
            this.txtMarcas.Size = new System.Drawing.Size(74, 20);
            this.txtMarcas.TabIndex = 18;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(364, 110);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(83, 23);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTipoMarca
            // 
            this.btnTipoMarca.Location = new System.Drawing.Point(364, 76);
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
            this.cbMarca.Location = new System.Drawing.Point(261, 76);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(100, 21);
            this.cbMarca.TabIndex = 15;
            this.cbMarca.SelectionChangeCommitted += new System.EventHandler(this.selecionMarca);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marcas compatibles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Marcas:";
            // 
            // grdMarca
            // 
            this.grdMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.marcaVehiculo});
            this.grdMarca.Location = new System.Drawing.Point(261, 146);
            this.grdMarca.Name = "grdMarca";
            this.grdMarca.Size = new System.Drawing.Size(186, 204);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbImpuesto);
            this.groupBox2.Controls.Add(this.rbPrecio);
            this.groupBox2.Controls.Add(this.rbRepuesto);
            this.groupBox2.Location = new System.Drawing.Point(46, 0);
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
            this.txtBuscar.Location = new System.Drawing.Point(302, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarRepuesto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Buscar:";
            // 
            // txtCantidadRepuesto
            // 
            this.txtCantidadRepuesto.Location = new System.Drawing.Point(130, 364);
            this.txtCantidadRepuesto.Name = "txtCantidadRepuesto";
            this.txtCantidadRepuesto.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRepuesto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad de repuestos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(372, 369);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRepuestos";
            this.Text = "FrmReparaciones";
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuesto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRepuesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbRepuesto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadRepuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
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
    }
}