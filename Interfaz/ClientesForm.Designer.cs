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
            this.PanelArriba = new System.Windows.Forms.Panel();
            this.BtVolver = new System.Windows.Forms.Button();
            this.LabelGestion = new System.Windows.Forms.Label();
            this.PanelIzda = new System.Windows.Forms.Panel();
            this.PanelBuscarIzda = new System.Windows.Forms.Panel();
            this.PanelPorNombre = new System.Windows.Forms.Panel();
            this.TxNombreClienteBuscar = new System.Windows.Forms.TextBox();
            this.BtEnviarPorNombre = new System.Windows.Forms.Button();
            this.BtBuscarPorNombre = new System.Windows.Forms.Button();
            this.BtBuscarCliente = new System.Windows.Forms.Button();
            this.PanelEliminarIzda = new System.Windows.Forms.Panel();
            this.BtEnviarEliminar = new System.Windows.Forms.Button();
            this.BtEliminaCliente = new System.Windows.Forms.Button();
            this.BtAnadirCliente = new System.Windows.Forms.Button();
            this.BtMostrarClientes = new System.Windows.Forms.Button();
            this.PanelDcha = new System.Windows.Forms.Panel();
            this.PanelTablasClientes = new System.Windows.Forms.Panel();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.PnAnadirCliente = new System.Windows.Forms.Panel();
            this.BtEnviarCliente = new System.Windows.Forms.Button();
            this.TxDNI = new System.Windows.Forms.TextBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.PanelArriba.SuspendLayout();
            this.PanelIzda.SuspendLayout();
            this.PanelBuscarIzda.SuspendLayout();
            this.PanelPorNombre.SuspendLayout();
            this.PanelEliminarIzda.SuspendLayout();
            this.PanelDcha.SuspendLayout();
            this.PanelTablasClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.PnAnadirCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.Green;
            this.PanelArriba.Controls.Add(this.BtVolver);
            this.PanelArriba.Controls.Add(this.LabelGestion);
            this.PanelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArriba.Location = new System.Drawing.Point(0, 0);
            this.PanelArriba.Name = "PanelArriba";
            this.PanelArriba.Size = new System.Drawing.Size(1182, 46);
            this.PanelArriba.TabIndex = 29;
            // 
            // BtVolver
            // 
            this.BtVolver.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVolver.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVolver.ForeColor = System.Drawing.Color.White;
            this.BtVolver.Location = new System.Drawing.Point(0, 0);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(105, 46);
            this.BtVolver.TabIndex = 2;
            this.BtVolver.Text = "Volver";
            this.BtVolver.UseVisualStyleBackColor = true;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // LabelGestion
            // 
            this.LabelGestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGestion.AutoSize = true;
            this.LabelGestion.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGestion.ForeColor = System.Drawing.Color.White;
            this.LabelGestion.Location = new System.Drawing.Point(431, 0);
            this.LabelGestion.Name = "LabelGestion";
            this.LabelGestion.Size = new System.Drawing.Size(303, 38);
            this.LabelGestion.TabIndex = 0;
            this.LabelGestion.Text = "Gestión de clientes";
            this.LabelGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelIzda
            // 
            this.PanelIzda.BackColor = System.Drawing.Color.LimeGreen;
            this.PanelIzda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelIzda.Controls.Add(this.PanelBuscarIzda);
            this.PanelIzda.Controls.Add(this.BtBuscarCliente);
            this.PanelIzda.Controls.Add(this.PanelEliminarIzda);
            this.PanelIzda.Controls.Add(this.BtEliminaCliente);
            this.PanelIzda.Controls.Add(this.BtAnadirCliente);
            this.PanelIzda.Controls.Add(this.BtMostrarClientes);
            this.PanelIzda.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzda.Location = new System.Drawing.Point(0, 46);
            this.PanelIzda.Name = "PanelIzda";
            this.PanelIzda.Size = new System.Drawing.Size(342, 607);
            this.PanelIzda.TabIndex = 30;
            // 
            // PanelBuscarIzda
            // 
            this.PanelBuscarIzda.Controls.Add(this.PanelPorNombre);
            this.PanelBuscarIzda.Controls.Add(this.BtBuscarPorNombre);
            this.PanelBuscarIzda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBuscarIzda.Location = new System.Drawing.Point(0, 274);
            this.PanelBuscarIzda.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBuscarIzda.Name = "PanelBuscarIzda";
            this.PanelBuscarIzda.Size = new System.Drawing.Size(342, 311);
            this.PanelBuscarIzda.TabIndex = 22;
            this.PanelBuscarIzda.Visible = false;
            // 
            // PanelPorNombre
            // 
            this.PanelPorNombre.Controls.Add(this.TxNombreClienteBuscar);
            this.PanelPorNombre.Controls.Add(this.BtEnviarPorNombre);
            this.PanelPorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorNombre.Location = new System.Drawing.Point(0, 38);
            this.PanelPorNombre.Name = "PanelPorNombre";
            this.PanelPorNombre.Size = new System.Drawing.Size(342, 34);
            this.PanelPorNombre.TabIndex = 34;
            this.PanelPorNombre.Visible = false;
            // 
            // TxNombreClienteBuscar
            // 
            this.TxNombreClienteBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxNombreClienteBuscar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombreClienteBuscar.Location = new System.Drawing.Point(0, 0);
            this.TxNombreClienteBuscar.Name = "TxNombreClienteBuscar";
            this.TxNombreClienteBuscar.Size = new System.Drawing.Size(267, 31);
            this.TxNombreClienteBuscar.TabIndex = 29;
            // 
            // BtEnviarPorNombre
            // 
            this.BtEnviarPorNombre.BackColor = System.Drawing.Color.LimeGreen;
            this.BtEnviarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPorNombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPorNombre.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPorNombre.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPorNombre.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarPorNombre.Name = "BtEnviarPorNombre";
            this.BtEnviarPorNombre.Size = new System.Drawing.Size(75, 34);
            this.BtEnviarPorNombre.TabIndex = 28;
            this.BtEnviarPorNombre.Text = "Enviar";
            this.BtEnviarPorNombre.UseVisualStyleBackColor = false;
            this.BtEnviarPorNombre.Click += new System.EventHandler(this.BtEnviarPorNombre_Click);
            // 
            // BtBuscarPorNombre
            // 
            this.BtBuscarPorNombre.BackColor = System.Drawing.Color.LimeGreen;
            this.BtBuscarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorNombre.FlatAppearance.BorderSize = 0;
            this.BtBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPorNombre.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPorNombre.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPorNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPorNombre.Location = new System.Drawing.Point(0, 0);
            this.BtBuscarPorNombre.Name = "BtBuscarPorNombre";
            this.BtBuscarPorNombre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtBuscarPorNombre.Size = new System.Drawing.Size(342, 38);
            this.BtBuscarPorNombre.TabIndex = 27;
            this.BtBuscarPorNombre.Text = "Por nombre";
            this.BtBuscarPorNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPorNombre.UseVisualStyleBackColor = false;
            this.BtBuscarPorNombre.Click += new System.EventHandler(this.BtBuscarPorNombre_Click);
            // 
            // BtBuscarCliente
            // 
            this.BtBuscarCliente.BackColor = System.Drawing.Color.LimeGreen;
            this.BtBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarCliente.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.BtBuscarCliente.Image = global::Interfaz.Properties.Resources.lupaR;
            this.BtBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarCliente.Location = new System.Drawing.Point(0, 214);
            this.BtBuscarCliente.Name = "BtBuscarCliente";
            this.BtBuscarCliente.Size = new System.Drawing.Size(342, 60);
            this.BtBuscarCliente.TabIndex = 20;
            this.BtBuscarCliente.Text = "Buscar cliente";
            this.BtBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarCliente.UseVisualStyleBackColor = false;
            this.BtBuscarCliente.Click += new System.EventHandler(this.BtBuscarCliente_Click);
            // 
            // PanelEliminarIzda
            // 
            this.PanelEliminarIzda.Controls.Add(this.BtEnviarEliminar);
            this.PanelEliminarIzda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEliminarIzda.Location = new System.Drawing.Point(0, 180);
            this.PanelEliminarIzda.Name = "PanelEliminarIzda";
            this.PanelEliminarIzda.Size = new System.Drawing.Size(342, 34);
            this.PanelEliminarIzda.TabIndex = 23;
            this.PanelEliminarIzda.Visible = false;
            // 
            // BtEnviarEliminar
            // 
            this.BtEnviarEliminar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtEnviarEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarEliminar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEnviarEliminar.Location = new System.Drawing.Point(266, 0);
            this.BtEnviarEliminar.Name = "BtEnviarEliminar";
            this.BtEnviarEliminar.Size = new System.Drawing.Size(76, 34);
            this.BtEnviarEliminar.TabIndex = 28;
            this.BtEnviarEliminar.Text = "Enviar";
            this.BtEnviarEliminar.UseVisualStyleBackColor = false;
            this.BtEnviarEliminar.Click += new System.EventHandler(this.BtEnviarEliminar_Click);
            // 
            // BtEliminaCliente
            // 
            this.BtEliminaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtEliminaCliente.FlatAppearance.BorderSize = 0;
            this.BtEliminaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminaCliente.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminaCliente.ForeColor = System.Drawing.Color.White;
            this.BtEliminaCliente.Image = global::Interfaz.Properties.Resources.eliminarR;
            this.BtEliminaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEliminaCliente.Location = new System.Drawing.Point(0, 120);
            this.BtEliminaCliente.Name = "BtEliminaCliente";
            this.BtEliminaCliente.Size = new System.Drawing.Size(342, 60);
            this.BtEliminaCliente.TabIndex = 19;
            this.BtEliminaCliente.Text = "Eliminar cliente";
            this.BtEliminaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEliminaCliente.UseVisualStyleBackColor = true;
            this.BtEliminaCliente.Click += new System.EventHandler(this.BtEliminaCliente_Click);
            // 
            // BtAnadirCliente
            // 
            this.BtAnadirCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtAnadirCliente.FlatAppearance.BorderSize = 0;
            this.BtAnadirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAnadirCliente.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAnadirCliente.ForeColor = System.Drawing.Color.White;
            this.BtAnadirCliente.Image = global::Interfaz.Properties.Resources.anadirR;
            this.BtAnadirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAnadirCliente.Location = new System.Drawing.Point(0, 60);
            this.BtAnadirCliente.Name = "BtAnadirCliente";
            this.BtAnadirCliente.Size = new System.Drawing.Size(342, 60);
            this.BtAnadirCliente.TabIndex = 18;
            this.BtAnadirCliente.Text = "Añadir cliente";
            this.BtAnadirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAnadirCliente.UseVisualStyleBackColor = true;
            this.BtAnadirCliente.Click += new System.EventHandler(this.BtAnadirCliente_Click);
            // 
            // BtMostrarClientes
            // 
            this.BtMostrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtMostrarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtMostrarClientes.FlatAppearance.BorderSize = 0;
            this.BtMostrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarClientes.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarClientes.ForeColor = System.Drawing.Color.White;
            this.BtMostrarClientes.Image = global::Interfaz.Properties.Resources.clientesR;
            this.BtMostrarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtMostrarClientes.Location = new System.Drawing.Point(0, 0);
            this.BtMostrarClientes.Name = "BtMostrarClientes";
            this.BtMostrarClientes.Size = new System.Drawing.Size(342, 60);
            this.BtMostrarClientes.TabIndex = 1;
            this.BtMostrarClientes.Text = "Mostrar clientes";
            this.BtMostrarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarClientes.UseVisualStyleBackColor = true;
            this.BtMostrarClientes.Click += new System.EventHandler(this.BtMostrarClientes_Click);
            // 
            // PanelDcha
            // 
            this.PanelDcha.BackColor = System.Drawing.Color.White;
            this.PanelDcha.Controls.Add(this.PanelTablasClientes);
            this.PanelDcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDcha.Location = new System.Drawing.Point(342, 46);
            this.PanelDcha.Name = "PanelDcha";
            this.PanelDcha.Size = new System.Drawing.Size(840, 607);
            this.PanelDcha.TabIndex = 31;
            // 
            // PanelTablasClientes
            // 
            this.PanelTablasClientes.Controls.Add(this.DGVClientes);
            this.PanelTablasClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTablasClientes.Location = new System.Drawing.Point(0, 0);
            this.PanelTablasClientes.Name = "PanelTablasClientes";
            this.PanelTablasClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PanelTablasClientes.Size = new System.Drawing.Size(840, 607);
            this.PanelTablasClientes.TabIndex = 22;
            this.PanelTablasClientes.Visible = false;
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.AllowUserToResizeRows = false;
            this.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVClientes.BackgroundColor = System.Drawing.Color.White;
            this.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVClientes.Location = new System.Drawing.Point(10, 0);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.RowHeadersVisible = false;
            this.DGVClientes.RowHeadersWidth = 51;
            this.DGVClientes.RowTemplate.Height = 24;
            this.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClientes.Size = new System.Drawing.Size(830, 607);
            this.DGVClientes.TabIndex = 2;
            // 
            // PnAnadirCliente
            // 
            this.PnAnadirCliente.BackColor = System.Drawing.Color.PaleGreen;
            this.PnAnadirCliente.Controls.Add(this.BtEnviarCliente);
            this.PnAnadirCliente.Controls.Add(this.TxDNI);
            this.PnAnadirCliente.Controls.Add(this.LblDNI);
            this.PnAnadirCliente.Controls.Add(this.TxDireccion);
            this.PnAnadirCliente.Controls.Add(this.LblDireccion);
            this.PnAnadirCliente.Controls.Add(this.TxApellidos);
            this.PnAnadirCliente.Controls.Add(this.LblApellidos);
            this.PnAnadirCliente.Controls.Add(this.TxNombre);
            this.PnAnadirCliente.Controls.Add(this.LblNombre);
            this.PnAnadirCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnAnadirCliente.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnAnadirCliente.Location = new System.Drawing.Point(342, 46);
            this.PnAnadirCliente.Name = "PnAnadirCliente";
            this.PnAnadirCliente.Size = new System.Drawing.Size(840, 607);
            this.PnAnadirCliente.TabIndex = 21;
            this.PnAnadirCliente.Visible = false;
            // 
            // BtEnviarCliente
            // 
            this.BtEnviarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarCliente.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarCliente.Location = new System.Drawing.Point(647, 480);
            this.BtEnviarCliente.Name = "BtEnviarCliente";
            this.BtEnviarCliente.Size = new System.Drawing.Size(159, 61);
            this.BtEnviarCliente.TabIndex = 17;
            this.BtEnviarCliente.Text = "Enviar";
            this.BtEnviarCliente.UseVisualStyleBackColor = false;
            this.BtEnviarCliente.Click += new System.EventHandler(this.BtEnviarCliente_Click);
            // 
            // TxDNI
            // 
            this.TxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDNI.Location = new System.Drawing.Point(10, 340);
            this.TxDNI.MaximumSize = new System.Drawing.Size(600, 100);
            this.TxDNI.Multiline = true;
            this.TxDNI.Name = "TxDNI";
            this.TxDNI.Size = new System.Drawing.Size(465, 38);
            this.TxDNI.TabIndex = 20;
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDNI.Location = new System.Drawing.Point(6, 308);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(53, 28);
            this.LblDNI.TabIndex = 11;
            this.LblDNI.Text = "DNI";
            // 
            // TxDireccion
            // 
            this.TxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDireccion.Location = new System.Drawing.Point(10, 240);
            this.TxDireccion.MaximumSize = new System.Drawing.Size(600, 100);
            this.TxDireccion.Multiline = true;
            this.TxDireccion.Name = "TxDireccion";
            this.TxDireccion.Size = new System.Drawing.Size(465, 38);
            this.TxDireccion.TabIndex = 19;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(6, 208);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(116, 28);
            this.LblDireccion.TabIndex = 9;
            this.LblDireccion.Text = "Direccion";
            // 
            // TxApellidos
            // 
            this.TxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxApellidos.Location = new System.Drawing.Point(10, 140);
            this.TxApellidos.MaximumSize = new System.Drawing.Size(600, 100);
            this.TxApellidos.Multiline = true;
            this.TxApellidos.Name = "TxApellidos";
            this.TxApellidos.Size = new System.Drawing.Size(465, 38);
            this.TxApellidos.TabIndex = 18;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(6, 108);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(113, 28);
            this.LblApellidos.TabIndex = 8;
            this.LblApellidos.Text = "Apellidos";
            // 
            // TxNombre
            // 
            this.TxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombre.Location = new System.Drawing.Point(10, 40);
            this.TxNombre.MaximumSize = new System.Drawing.Size(600, 100);
            this.TxNombre.Multiline = true;
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(465, 38);
            this.TxNombre.TabIndex = 4;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(6, 8);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(97, 28);
            this.LblNombre.TabIndex = 7;
            this.LblNombre.Text = "Nombre";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PnAnadirCliente);
            this.Controls.Add(this.PanelDcha);
            this.Controls.Add(this.PanelIzda);
            this.Controls.Add(this.PanelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesForm";
            this.PanelArriba.ResumeLayout(false);
            this.PanelArriba.PerformLayout();
            this.PanelIzda.ResumeLayout(false);
            this.PanelBuscarIzda.ResumeLayout(false);
            this.PanelPorNombre.ResumeLayout(false);
            this.PanelPorNombre.PerformLayout();
            this.PanelEliminarIzda.ResumeLayout(false);
            this.PanelDcha.ResumeLayout(false);
            this.PanelTablasClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.PnAnadirCliente.ResumeLayout(false);
            this.PnAnadirCliente.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel PanelArriba;
        private System.Windows.Forms.Label LabelGestion;
        private System.Windows.Forms.Panel PanelIzda;
        private System.Windows.Forms.Panel PanelBuscarIzda;
        private System.Windows.Forms.Panel PanelPorNombre;
        private System.Windows.Forms.TextBox TxNombreClienteBuscar;
        private System.Windows.Forms.Button BtEnviarPorNombre;
        private System.Windows.Forms.Button BtBuscarPorNombre;
        private System.Windows.Forms.Button BtBuscarCliente;
        private System.Windows.Forms.Panel PanelEliminarIzda;
        private System.Windows.Forms.Button BtEnviarEliminar;
        private System.Windows.Forms.Button BtEliminaCliente;
        private System.Windows.Forms.Button BtAnadirCliente;
        private System.Windows.Forms.Button BtMostrarClientes;
        private System.Windows.Forms.Panel PanelDcha;
        private System.Windows.Forms.Panel PnAnadirCliente;
        private System.Windows.Forms.TextBox TxDNI;
        private System.Windows.Forms.TextBox TxDireccion;
        private System.Windows.Forms.TextBox TxApellidos;
        private System.Windows.Forms.Button BtEnviarCliente;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Panel PanelTablasClientes;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button BtVolver;
    }
}