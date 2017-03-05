namespace Vista
{
    partial class frmMarca
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
            this.grdMarcas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnElininar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMarcas
            // 
            this.grdMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarcas.Location = new System.Drawing.Point(1, 97);
            this.grdMarcas.Name = "grdMarcas";
            this.grdMarcas.Size = new System.Drawing.Size(352, 164);
            this.grdMarcas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(99, 12);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(268, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(268, 28);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnElininar
            // 
            this.btnElininar.Location = new System.Drawing.Point(268, 48);
            this.btnElininar.Name = "btnElininar";
            this.btnElininar.Size = new System.Drawing.Size(75, 23);
            this.btnElininar.TabIndex = 5;
            this.btnElininar.Text = "Eliminar";
            this.btnElininar.UseVisualStyleBackColor = true;
            this.btnElininar.Click += new System.EventHandler(this.btnElininar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Location = new System.Drawing.Point(13, 68);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(242, 13);
            this.txtMensaje.TabIndex = 6;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(268, 68);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 263);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnElininar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdMarcas);
            this.Name = "frmMarca";
            this.Text = "Marca";
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnElininar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnRefrescar;
    }
}