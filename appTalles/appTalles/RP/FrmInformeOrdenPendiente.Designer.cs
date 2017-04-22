namespace appTalles.RP
{
    partial class FrmInformeOrdenPendiente
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
            this.reporteInforme = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDia = new System.Windows.Forms.DateTimePicker();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reporteInforme
            // 
            this.reporteInforme.ActiveViewIndex = -1;
            this.reporteInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteInforme.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteInforme.Location = new System.Drawing.Point(0, 0);
            this.reporteInforme.Name = "reporteInforme";
            this.reporteInforme.Size = new System.Drawing.Size(597, 527);
            this.reporteInforme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Día:";
            // 
            // dtDia
            // 
            this.dtDia.Location = new System.Drawing.Point(46, 38);
            this.dtDia.Name = "dtDia";
            this.dtDia.Size = new System.Drawing.Size(153, 20);
            this.dtDia.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(72, 85);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmInformeOrdenPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 527);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporteInforme);
            this.Name = "FrmInformeOrdenPendiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformeOrdenPiente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDia;
        private System.Windows.Forms.Button btnCargar;
    }
}