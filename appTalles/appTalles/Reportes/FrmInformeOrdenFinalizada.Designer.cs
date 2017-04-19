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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReporteOrdenFinalizada = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtBuscar = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(1, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ReporteOrdenFinalizada
            // 
            this.ReporteOrdenFinalizada.ActiveViewIndex = -1;
            this.ReporteOrdenFinalizada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteOrdenFinalizada.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteOrdenFinalizada.Location = new System.Drawing.Point(1, 49);
            this.ReporteOrdenFinalizada.Name = "ReporteOrdenFinalizada";
            this.ReporteOrdenFinalizada.Size = new System.Drawing.Size(1360, 693);
            this.ReporteOrdenFinalizada.TabIndex = 1;
            // 
            // dtBuscar
            // 
            this.dtBuscar.Location = new System.Drawing.Point(137, 16);
            this.dtBuscar.Name = "dtBuscar";
            this.dtBuscar.Size = new System.Drawing.Size(200, 20);
            this.dtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(343, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = ">>";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar orden finalizada:";
            // 
            // FrmInformeOrdenFinalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.ReporteOrdenFinalizada);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInformeOrdenFinalizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformeOrdenFinalizada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtBuscar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteOrdenFinalizada;
    }
}