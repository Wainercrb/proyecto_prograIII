namespace appTalles.RP
{
    partial class FrmServicioPorEmpleado
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
            this.reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDel = new System.Windows.Forms.DateTimePicker();
            this.dtAl = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.ActiveViewIndex = -1;
            this.reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(498, 470);
            this.reporte.TabIndex = 0;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(12, 45);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(182, 21);
            this.cbEmpleado.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(68, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Del:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "al:";
            // 
            // dtDel
            // 
            this.dtDel.Checked = false;
            this.dtDel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDel.Location = new System.Drawing.Point(41, 83);
            this.dtDel.Name = "dtDel";
            this.dtDel.Size = new System.Drawing.Size(149, 20);
            this.dtDel.TabIndex = 5;
            // 
            // dtAl
            // 
            this.dtAl.Checked = false;
            this.dtAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAl.Location = new System.Drawing.Point(41, 126);
            this.dtAl.Name = "dtAl";
            this.dtAl.Size = new System.Drawing.Size(153, 20);
            this.dtAl.TabIndex = 6;
            // 
            // FrmServicioPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 470);
            this.Controls.Add(this.dtAl);
            this.Controls.Add(this.dtDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.reporte);
            this.Name = "FrmServicioPorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServicioPorEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporte;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDel;
        private System.Windows.Forms.DateTimePicker dtAl;
    }
}