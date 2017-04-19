namespace appTalles.UI
{
    partial class FrmInformeOrdenFinalizada
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
            this.ReporteOrdenFinalizada = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteOrdenFinalizada
            // 
            this.ReporteOrdenFinalizada.ActiveViewIndex = -1;
            this.ReporteOrdenFinalizada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteOrdenFinalizada.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteOrdenFinalizada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteOrdenFinalizada.Location = new System.Drawing.Point(0, 0);
            this.ReporteOrdenFinalizada.Name = "ReporteOrdenFinalizada";
            this.ReporteOrdenFinalizada.Size = new System.Drawing.Size(725, 539);
            this.ReporteOrdenFinalizada.TabIndex = 0;
            // 
            // FrmInformeOrdenFinalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 539);
            this.Controls.Add(this.ReporteOrdenFinalizada);
            this.Name = "FrmInformeOrdenFinalizada";
            this.Text = "FrmInformeOrdenFinalizada";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteOrdenFinalizada;
    }
}