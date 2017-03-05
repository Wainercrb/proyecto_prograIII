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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdVehiculos = new System.Windows.Forms.DataGridView();
            this.txtPlaca = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.txtChazis = new System.Windows.Forms.TextBox();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.txtCilindraje = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).BeginInit();
            this.txtPlaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(321, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalir);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.grdVehiculos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listados vehiculos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdVehiculos
            // 
            this.grdVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehiculos.Location = new System.Drawing.Point(6, 54);
            this.grdVehiculos.Name = "grdVehiculos";
            this.grdVehiculos.Size = new System.Drawing.Size(423, 360);
            this.grdVehiculos.TabIndex = 0;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Controls.Add(this.button1);
            this.txtPlaca.Controls.Add(this.txtTarea);
            this.txtPlaca.Controls.Add(this.label11);
            this.txtPlaca.Controls.Add(this.btnEliminar);
            this.txtPlaca.Controls.Add(this.btnEditar);
            this.txtPlaca.Controls.Add(this.btnAgregar);
            this.txtPlaca.Controls.Add(this.cbTipo);
            this.txtPlaca.Controls.Add(this.cbMarca);
            this.txtPlaca.Controls.Add(this.cbCliente);
            this.txtPlaca.Controls.Add(this.label10);
            this.txtPlaca.Controls.Add(this.label9);
            this.txtPlaca.Controls.Add(this.label8);
            this.txtPlaca.Controls.Add(this.label7);
            this.txtPlaca.Controls.Add(this.checkBox1);
            this.txtPlaca.Controls.Add(this.txtCombustible);
            this.txtPlaca.Controls.Add(this.txtChazis);
            this.txtPlaca.Controls.Add(this.txtMotor);
            this.txtPlaca.Controls.Add(this.txtCilindraje);
            this.txtPlaca.Controls.Add(this.txtAnno);
            this.txtPlaca.Controls.Add(this.textBox1);
            this.txtPlaca.Controls.Add(this.label6);
            this.txtPlaca.Controls.Add(this.label5);
            this.txtPlaca.Controls.Add(this.label4);
            this.txtPlaca.Controls.Add(this.label3);
            this.txtPlaca.Controls.Add(this.label2);
            this.txtPlaca.Controls.Add(this.label1);
            this.txtPlaca.Location = new System.Drawing.Point(2, 118);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(313, 373);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TabStop = false;
            this.txtPlaca.Text = "Actualización vehiculo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(236, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(168, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(62, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(98, 264);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(199, 21);
            this.cbTipo.TabIndex = 19;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(98, 236);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(199, 21);
            this.cbMarca.TabIndex = 18;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(98, 208);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(199, 21);
            this.cbCliente.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(98, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Dañado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtCombustible
            // 
            this.txtCombustible.Location = new System.Drawing.Point(98, 157);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(121, 20);
            this.txtCombustible.TabIndex = 11;
            // 
            // txtChazis
            // 
            this.txtChazis.Location = new System.Drawing.Point(98, 131);
            this.txtChazis.Name = "txtChazis";
            this.txtChazis.Size = new System.Drawing.Size(121, 20);
            this.txtChazis.TabIndex = 10;
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(98, 104);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(121, 20);
            this.txtMotor.TabIndex = 9;
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.Location = new System.Drawing.Point(98, 78);
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Size = new System.Drawing.Size(121, 20);
            this.txtCilindraje.TabIndex = 8;
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(98, 52);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(121, 20);
            this.txtAnno.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Conbustible:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero chazis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero motor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cilindraje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero placa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tarea:";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(43, 340);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.ReadOnly = true;
            this.txtTarea.Size = new System.Drawing.Size(254, 20);
            this.txtTarea.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Buscar:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cantidad Vehiculos:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 430);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(301, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEdicionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 490);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdicionVehiculo";
            this.Text = "frmEdicionVehiculo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).EndInit();
            this.txtPlaca.ResumeLayout(false);
            this.txtPlaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox txtPlaca;
        private System.Windows.Forms.DataGridView grdVehiculos;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.TextBox txtChazis;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.TextBox txtCilindraje;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}