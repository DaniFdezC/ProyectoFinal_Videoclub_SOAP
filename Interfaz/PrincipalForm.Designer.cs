using System.Collections.Generic;
using System.Drawing;
using System;

namespace Interfaz {
    partial class PrincipalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtClientes = new System.Windows.Forms.Button();
            this.BtPeliculas = new System.Windows.Forms.Button();
            this.BtAlquilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtClientes
            // 
            this.BtClientes.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtClientes.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClientes.ForeColor = System.Drawing.Color.White;
            this.BtClientes.Location = new System.Drawing.Point(0, 432);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Size = new System.Drawing.Size(1182, 221);
            this.BtClientes.TabIndex = 0;
            this.BtClientes.Text = "Clientes";
            this.BtClientes.UseVisualStyleBackColor = false;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // BtPeliculas
            // 
            this.BtPeliculas.BackColor = System.Drawing.Color.Blue;
            this.BtPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtPeliculas.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPeliculas.ForeColor = System.Drawing.Color.White;
            this.BtPeliculas.Location = new System.Drawing.Point(0, 0);
            this.BtPeliculas.Name = "BtPeliculas";
            this.BtPeliculas.Size = new System.Drawing.Size(1182, 213);
            this.BtPeliculas.TabIndex = 1;
            this.BtPeliculas.Text = "Películas";
            this.BtPeliculas.UseVisualStyleBackColor = false;
            this.BtPeliculas.Click += new System.EventHandler(this.BtPeliculas_Click);
            // 
            // BtAlquilar
            // 
            this.BtAlquilar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtAlquilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtAlquilar.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlquilar.ForeColor = System.Drawing.Color.White;
            this.BtAlquilar.Location = new System.Drawing.Point(0, 213);
            this.BtAlquilar.Name = "BtAlquilar";
            this.BtAlquilar.Size = new System.Drawing.Size(1182, 219);
            this.BtAlquilar.TabIndex = 2;
            this.BtAlquilar.Text = "Alquilar";
            this.BtAlquilar.UseVisualStyleBackColor = false;
            this.BtAlquilar.Click += new System.EventHandler(this.BtAlquilar_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.BtAlquilar);
            this.Controls.Add(this.BtPeliculas);
            this.Controls.Add(this.BtClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button BtPeliculas;
        private System.Windows.Forms.Button BtAlquilar;
    }
}

