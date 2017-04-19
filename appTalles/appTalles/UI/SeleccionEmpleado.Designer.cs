namespace Vista
{
    partial class SeleccionEmpleado
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
            this.grdEmpleado = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoResidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            this.SuspendLayout();
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
            this.Apellidos,
            this.Direccion,
            this.TelefonoResidencia,
            this.TelefonoCelular,
            this.TelefonoCasa,
            this.Puesto,
            this.Permiso,
            this.Usuario,
            this.Contrasenna});
            this.grdEmpleado.Location = new System.Drawing.Point(3, 0);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.ReadOnly = true;
            this.grdEmpleado.Size = new System.Drawing.Size(344, 233);
            this.grdEmpleado.TabIndex = 0;
            this.grdEmpleado.DoubleClick += new System.EventHandler(this.seleccion);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellido";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Visible = false;
            // 
            // TelefonoResidencia
            // 
            this.TelefonoResidencia.DataPropertyName = "TelefonoResidencia";
            this.TelefonoResidencia.HeaderText = "Tel Residencia";
            this.TelefonoResidencia.Name = "TelefonoResidencia";
            this.TelefonoResidencia.ReadOnly = true;
            this.TelefonoResidencia.Visible = false;
            // 
            // TelefonoCelular
            // 
            this.TelefonoCelular.DataPropertyName = "TelefonoCelular";
            this.TelefonoCelular.HeaderText = "Tel Celular";
            this.TelefonoCelular.Name = "TelefonoCelular";
            this.TelefonoCelular.ReadOnly = true;
            this.TelefonoCelular.Visible = false;
            // 
            // TelefonoCasa
            // 
            this.TelefonoCasa.DataPropertyName = "TelefonoCasa";
            this.TelefonoCasa.HeaderText = "Tel casa";
            this.TelefonoCasa.Name = "TelefonoCasa";
            this.TelefonoCasa.ReadOnly = true;
            this.TelefonoCasa.Visible = false;
            // 
            // Puesto
            // 
            this.Puesto.DataPropertyName = "Puesto";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Visible = false;
            // 
            // Permiso
            // 
            this.Permiso.DataPropertyName = "Permiso";
            this.Permiso.HeaderText = "Permiso";
            this.Permiso.Name = "Permiso";
            this.Permiso.ReadOnly = true;
            this.Permiso.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // Contrasenna
            // 
            this.Contrasenna.DataPropertyName = "Contrasenna";
            this.Contrasenna.HeaderText = "Contraseña";
            this.Contrasenna.Name = "Contrasenna";
            this.Contrasenna.ReadOnly = true;
            this.Contrasenna.Visible = false;
            // 
            // SeleccionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 234);
            this.Controls.Add(this.grdEmpleado);
            this.Name = "SeleccionEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoResidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenna;
    }
}