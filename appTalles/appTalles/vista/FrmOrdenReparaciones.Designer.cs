﻿namespace appTalles.Vista
{
    partial class FrmOrdenReparaciones
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
            this.tbReparaciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbReparaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbReparaciones
            // 
            this.tbReparaciones.Controls.Add(this.tabPage1);
            this.tbReparaciones.Controls.Add(this.tabPage2);
            this.tbReparaciones.Location = new System.Drawing.Point(3, 172);
            this.tbReparaciones.Name = "tbReparaciones";
            this.tbReparaciones.SelectedIndex = 0;
            this.tbReparaciones.Size = new System.Drawing.Size(642, 274);
            this.tbReparaciones.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reparaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Repuestos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmOrdenReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 449);
            this.Controls.Add(this.tbReparaciones);
            this.Name = "FrmOrdenReparaciones";
            this.Text = "FrmOrdenReparaciones";
            this.tbReparaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbReparaciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}