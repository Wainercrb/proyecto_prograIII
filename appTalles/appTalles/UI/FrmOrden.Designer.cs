﻿namespace Vista
{
    partial class FrmOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrden));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.cbEncargado = new System.Windows.Forms.ComboBox();
            this.dgOrdenes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEsatado = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculos_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encargado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(65, 81);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(197, 21);
            this.cbVehiculo.TabIndex = 6;
            // 
            // cbEncargado
            // 
            this.cbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncargado.FormattingEnabled = true;
            this.cbEncargado.Location = new System.Drawing.Point(359, 55);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(195, 21);
            this.cbEncargado.TabIndex = 7;
            // 
            // dgOrdenes
            // 
            this.dgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaIngreso,
            this.FechaSalida,
            this.FechaFacturacion,
            this.Estado,
            this.CostoTotal,
            this.Vehiculos_,
            this.Empleado_});
            this.dgOrdenes.Location = new System.Drawing.Point(12, 116);
            this.dgOrdenes.Name = "dgOrdenes";
            this.dgOrdenes.Size = new System.Drawing.Size(763, 248);
            this.dgOrdenes.TabIndex = 11;
            this.dgOrdenes.DoubleClick += new System.EventHandler(this.MateniminetoOrden);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado:";
            // 
            // cbEsatado
            // 
            this.cbEsatado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsatado.FormattingEnabled = true;
            this.cbEsatado.Location = new System.Drawing.Point(359, 27);
            this.cbEsatado.Name = "cbEsatado";
            this.cbEsatado.Size = new System.Drawing.Size(108, 21);
            this.cbEsatado.TabIndex = 18;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 20);
            this.txtCodigo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(66, 53);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(196, 21);
            this.cbCliente.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha ingreso:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(620, 34);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 25;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtIngreso
            // 
            this.dtIngreso.Checked = false;
            this.dtIngreso.Location = new System.Drawing.Point(359, 82);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(195, 20);
            this.dtIngreso.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "al";
            // 
            // dtSalida
            // 
            this.dtSalida.Checked = false;
            this.dtSalida.Location = new System.Drawing.Point(581, 82);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(194, 20);
            this.dtSalida.TabIndex = 28;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Location = new System.Drawing.Point(0, 371);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(353, 20);
            this.txtMensaje.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ordnes:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(675, 368);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 31;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.Width = 60;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 80;
            // 
            // FechaSalida
            // 
            this.FechaSalida.DataPropertyName = "FechaSalida";
            this.FechaSalida.HeaderText = "Salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.Width = 80;
            // 
            // FechaFacturacion
            // 
            this.FechaFacturacion.DataPropertyName = "FechaFacturacion";
            this.FechaFacturacion.HeaderText = "Facturación";
            this.FechaFacturacion.Name = "FechaFacturacion";
            this.FechaFacturacion.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 60;
            // 
            // CostoTotal
            // 
            this.CostoTotal.DataPropertyName = "CostoTotal";
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.Width = 80;
            // 
            // Vehiculos_
            // 
            this.Vehiculos_.DataPropertyName = "Vehiculo";
            this.Vehiculos_.HeaderText = "Vehículo";
            this.Vehiculos_.Name = "Vehiculos_";
            this.Vehiculos_.Width = 140;
            // 
            // Empleado_
            // 
            this.Empleado_.DataPropertyName = "Empleado";
            this.Empleado_.HeaderText = "Empleado";
            this.Empleado_.Name = "Empleado_";
            this.Empleado_.Width = 140;
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 396);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.dtSalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEsatado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgOrdenes);
            this.Controls.Add(this.cbEncargado);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.ComboBox cbEncargado;
        private System.Windows.Forms.DataGridView dgOrdenes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEsatado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculos_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_;
    }
}