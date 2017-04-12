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
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmpleado
            // 
            this.grdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleado.Location = new System.Drawing.Point(3, 0);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.Size = new System.Drawing.Size(347, 238);
            this.grdEmpleado.TabIndex = 0;
            this.grdEmpleado.DoubleClick += new System.EventHandler(this.seleccion);
            // 
            // SeleccionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 234);
            this.Controls.Add(this.grdEmpleado);
            this.Name = "SeleccionEmpleado";
            this.Text = "SeleccionEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmpleado;
    }
}