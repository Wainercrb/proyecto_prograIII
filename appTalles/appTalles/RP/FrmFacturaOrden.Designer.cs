namespace appTalles.RP
{
    partial class FrmFacturaOrden
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
            this.ReporteV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbComboOrden = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReporteV
            // 
            this.ReporteV.ActiveViewIndex = -1;
            this.ReporteV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteV.Location = new System.Drawing.Point(0, 0);
            this.ReporteV.Name = "ReporteV";
            this.ReporteV.Size = new System.Drawing.Size(772, 499);
            this.ReporteV.TabIndex = 0;
            // 
            // cbComboOrden
            // 
            this.cbComboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComboOrden.FormattingEnabled = true;
            this.cbComboOrden.Location = new System.Drawing.Point(0, 60);
            this.cbComboOrden.Name = "cbComboOrden";
            this.cbComboOrden.Size = new System.Drawing.Size(185, 21);
            this.cbComboOrden.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(54, 110);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmFacturaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 499);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cbComboOrden);
            this.Controls.Add(this.ReporteV);
            this.Name = "FrmFacturaOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturaOrden";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteV;
        private System.Windows.Forms.ComboBox cbComboOrden;
        private System.Windows.Forms.Button btnCargar;
    }
}