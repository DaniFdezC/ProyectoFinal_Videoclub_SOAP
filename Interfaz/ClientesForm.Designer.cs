namespace Interfaz {
    partial class ClientesForm {
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
            this.BtMostrarClientes = new System.Windows.Forms.Button();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.BtAnadirCliente = new System.Windows.Forms.Button();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.TxApellido = new System.Windows.Forms.TextBox();
            this.TxDireccion = new System.Windows.Forms.TextBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblApellidoCliente = new System.Windows.Forms.Label();
            this.LblDireccionCliente = new System.Windows.Forms.Label();
            this.TxDni = new System.Windows.Forms.TextBox();
            this.LblDniCliente = new System.Windows.Forms.Label();
            this.PnMostrar = new System.Windows.Forms.Panel();
            this.PnAnadir = new System.Windows.Forms.Panel();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.BtEliminaCliente = new System.Windows.Forms.Button();
            this.PnEliminar = new System.Windows.Forms.Panel();
            this.DGVElimCl = new System.Windows.Forms.DataGridView();
            this.BtElim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.PnMostrar.SuspendLayout();
            this.PnAnadir.SuspendLayout();
            this.PnEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVElimCl)).BeginInit();
            this.SuspendLayout();
            // 
            // BtMostrarClientes
            // 
            this.BtMostrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarClientes.Location = new System.Drawing.Point(3, 40);
            this.BtMostrarClientes.Name = "BtMostrarClientes";
            this.BtMostrarClientes.Size = new System.Drawing.Size(290, 60);
            this.BtMostrarClientes.TabIndex = 0;
            this.BtMostrarClientes.Text = "Mostrar clientes";
            this.BtMostrarClientes.UseVisualStyleBackColor = true;
            this.BtMostrarClientes.Click += new System.EventHandler(this.BtMostrarClientes_Click);
            // 
            // DGVClientes
            // 
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Location = new System.Drawing.Point(0, 0);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.RowHeadersVisible = false;
            this.DGVClientes.RowHeadersWidth = 51;
            this.DGVClientes.RowTemplate.Height = 24;
            this.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClientes.Size = new System.Drawing.Size(653, 427);
            this.DGVClientes.TabIndex = 2;
            // 
            // BtAnadirCliente
            // 
            this.BtAnadirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAnadirCliente.Location = new System.Drawing.Point(3, 140);
            this.BtAnadirCliente.Name = "BtAnadirCliente";
            this.BtAnadirCliente.Size = new System.Drawing.Size(290, 60);
            this.BtAnadirCliente.TabIndex = 3;
            this.BtAnadirCliente.Text = "Añadir cliente";
            this.BtAnadirCliente.UseVisualStyleBackColor = true;
            this.BtAnadirCliente.Click += new System.EventHandler(this.BtAnadirCliente_Click);
            // 
            // TxNombre
            // 
            this.TxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombre.Location = new System.Drawing.Point(8, 39);
            this.TxNombre.Multiline = true;
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(400, 38);
            this.TxNombre.TabIndex = 4;
            // 
            // TxApellido
            // 
            this.TxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxApellido.Location = new System.Drawing.Point(8, 123);
            this.TxApellido.Multiline = true;
            this.TxApellido.Name = "TxApellido";
            this.TxApellido.Size = new System.Drawing.Size(400, 38);
            this.TxApellido.TabIndex = 5;
            // 
            // TxDireccion
            // 
            this.TxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDireccion.Location = new System.Drawing.Point(8, 216);
            this.TxDireccion.Multiline = true;
            this.TxDireccion.Name = "TxDireccion";
            this.TxDireccion.Size = new System.Drawing.Size(400, 38);
            this.TxDireccion.TabIndex = 6;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCliente.Location = new System.Drawing.Point(3, 11);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(81, 25);
            this.LblNombreCliente.TabIndex = 7;
            this.LblNombreCliente.Text = "Nombre";
            // 
            // LblApellidoCliente
            // 
            this.LblApellidoCliente.AutoSize = true;
            this.LblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoCliente.Location = new System.Drawing.Point(3, 95);
            this.LblApellidoCliente.Name = "LblApellidoCliente";
            this.LblApellidoCliente.Size = new System.Drawing.Size(82, 25);
            this.LblApellidoCliente.TabIndex = 8;
            this.LblApellidoCliente.Text = "Apellido";
            // 
            // LblDireccionCliente
            // 
            this.LblDireccionCliente.AutoSize = true;
            this.LblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccionCliente.Location = new System.Drawing.Point(3, 188);
            this.LblDireccionCliente.Name = "LblDireccionCliente";
            this.LblDireccionCliente.Size = new System.Drawing.Size(93, 25);
            this.LblDireccionCliente.TabIndex = 9;
            this.LblDireccionCliente.Text = "Direccion";
            // 
            // TxDni
            // 
            this.TxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDni.Location = new System.Drawing.Point(8, 314);
            this.TxDni.Multiline = true;
            this.TxDni.Name = "TxDni";
            this.TxDni.Size = new System.Drawing.Size(400, 38);
            this.TxDni.TabIndex = 10;
            // 
            // LblDniCliente
            // 
            this.LblDniCliente.AutoSize = true;
            this.LblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDniCliente.Location = new System.Drawing.Point(3, 286);
            this.LblDniCliente.Name = "LblDniCliente";
            this.LblDniCliente.Size = new System.Drawing.Size(45, 25);
            this.LblDniCliente.TabIndex = 11;
            this.LblDniCliente.Text = "DNI";
            // 
            // PnMostrar
            // 
            this.PnMostrar.Controls.Add(this.DGVClientes);
            this.PnMostrar.Location = new System.Drawing.Point(403, 27);
            this.PnMostrar.Name = "PnMostrar";
            this.PnMostrar.Size = new System.Drawing.Size(686, 433);
            this.PnMostrar.TabIndex = 15;
            // 
            // PnAnadir
            // 
            this.PnAnadir.Controls.Add(this.BtEnviar);
            this.PnAnadir.Controls.Add(this.LblDireccionCliente);
            this.PnAnadir.Controls.Add(this.TxDireccion);
            this.PnAnadir.Controls.Add(this.LblNombreCliente);
            this.PnAnadir.Controls.Add(this.TxNombre);
            this.PnAnadir.Controls.Add(this.LblApellidoCliente);
            this.PnAnadir.Controls.Add(this.TxApellido);
            this.PnAnadir.Controls.Add(this.LblDniCliente);
            this.PnAnadir.Controls.Add(this.TxDni);
            this.PnAnadir.Location = new System.Drawing.Point(403, 27);
            this.PnAnadir.Name = "PnAnadir";
            this.PnAnadir.Size = new System.Drawing.Size(653, 430);
            this.PnAnadir.TabIndex = 16;
            // 
            // BtEnviar
            // 
            this.BtEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviar.Location = new System.Drawing.Point(494, 369);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(159, 61);
            this.BtEnviar.TabIndex = 17;
            this.BtEnviar.Text = "Enviar";
            this.BtEnviar.UseVisualStyleBackColor = true;
            this.BtEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // BtEliminaCliente
            // 
            this.BtEliminaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminaCliente.Location = new System.Drawing.Point(3, 240);
            this.BtEliminaCliente.Name = "BtEliminaCliente";
            this.BtEliminaCliente.Size = new System.Drawing.Size(290, 60);
            this.BtEliminaCliente.TabIndex = 17;
            this.BtEliminaCliente.Text = "Eliminar cliente";
            this.BtEliminaCliente.UseVisualStyleBackColor = true;
            this.BtEliminaCliente.Click += new System.EventHandler(this.BtEliminaCliente_Click);
            // 
            // PnEliminar
            // 
            this.PnEliminar.Controls.Add(this.DGVElimCl);
            this.PnEliminar.Controls.Add(this.BtElim);
            this.PnEliminar.Location = new System.Drawing.Point(403, 27);
            this.PnEliminar.Name = "PnEliminar";
            this.PnEliminar.Size = new System.Drawing.Size(653, 528);
            this.PnEliminar.TabIndex = 18;
            // 
            // DGVElimCl
            // 
            this.DGVElimCl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVElimCl.Location = new System.Drawing.Point(0, 0);
            this.DGVElimCl.Name = "DGVElimCl";
            this.DGVElimCl.ReadOnly = true;
            this.DGVElimCl.RowHeadersVisible = false;
            this.DGVElimCl.RowHeadersWidth = 51;
            this.DGVElimCl.RowTemplate.Height = 24;
            this.DGVElimCl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVElimCl.Size = new System.Drawing.Size(653, 427);
            this.DGVElimCl.TabIndex = 3;
            // 
            // BtElim
            // 
            this.BtElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtElim.Location = new System.Drawing.Point(10, 461);
            this.BtElim.Name = "BtElim";
            this.BtElim.Size = new System.Drawing.Size(130, 58);
            this.BtElim.TabIndex = 1;
            this.BtElim.Text = "Eliminar";
            this.BtElim.UseVisualStyleBackColor = true;
            this.BtElim.Click += new System.EventHandler(this.BtElim_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.BtEliminaCliente);
            this.Controls.Add(this.PnEliminar);
            this.Controls.Add(this.PnAnadir);
            this.Controls.Add(this.PnMostrar);
            this.Controls.Add(this.BtAnadirCliente);
            this.Controls.Add(this.BtMostrarClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.PnMostrar.ResumeLayout(false);
            this.PnAnadir.ResumeLayout(false);
            this.PnAnadir.PerformLayout();
            this.PnEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVElimCl)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button BtMostrarClientes;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button BtAnadirCliente;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.TextBox TxApellido;
        private System.Windows.Forms.TextBox TxDireccion;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblApellidoCliente;
        private System.Windows.Forms.Label LblDireccionCliente;
        private System.Windows.Forms.TextBox TxDni;
        private System.Windows.Forms.Label LblDniCliente;
        private System.Windows.Forms.Panel PnMostrar;
        private System.Windows.Forms.Panel PnAnadir;
        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.Button BtEliminaCliente;
        private System.Windows.Forms.Panel PnEliminar;
        private System.Windows.Forms.Button BtElim;
        private System.Windows.Forms.DataGridView DGVElimCl;
    }
}