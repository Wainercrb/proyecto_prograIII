﻿namespace Vista
{
    partial class FrmCambio
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtInformacion = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(55, 139);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(89, 19);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.bntActual_Click_1);
            // 
            // txtInformacion
            // 
            this.txtInformacion.AutoSize = true;
            this.txtInformacion.Location = new System.Drawing.Point(52, 65);
            this.txtInformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(177, 13);
            this.txtInformacion.TabIndex = 11;
            this.txtInformacion.Text = "INGRESE CONTRASEÑA ACTUAL";
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(55, 101);
            this.txtActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.Size = new System.Drawing.Size(193, 20);
            this.txtActual.TabIndex = 10;
            this.txtActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingresarEnte);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtUsuario.Location = new System.Drawing.Point(131, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(98, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "USUARIO:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 19);
            this.button1.TabIndex = 18;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.txtActual);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label txtInformacion;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}