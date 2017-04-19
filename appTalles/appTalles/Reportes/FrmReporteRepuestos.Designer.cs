namespace appTalles.Reportes
{
    partial class FrmReporteRepuestos
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
            this.reporteRepuesto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporteRepuesto
            // 
            this.reporteRepuesto.ActiveViewIndex = -1;
            this.reporteRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteRepuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteRepuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteRepuesto.Location = new System.Drawing.Point(0, 0);
            this.reporteRepuesto.Name = "reporteRepuesto";
            this.reporteRepuesto.Size = new System.Drawing.Size(707, 534);
            this.reporteRepuesto.TabIndex = 0;
            // 
            // FrmReporteRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 534);
            this.Controls.Add(this.reporteRepuesto);
            this.Name = "FrmReporteRepuestos";
            this.Text = "FrmReporteRepuestos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteRepuesto;
    }
}