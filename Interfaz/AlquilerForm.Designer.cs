namespace Interfaz {
    partial class AlquilerForm {
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
            this.P3_Arriba = new System.Windows.Forms.Panel();
            this.BtVolver = new System.Windows.Forms.Button();
            this.LabelGestion = new System.Windows.Forms.Label();
            this.P2_Izquierda = new System.Windows.Forms.Panel();
            this.P2_1_BuscarAlquiler = new System.Windows.Forms.Panel();
            this.BtEnviarAlquilerPorNombre = new System.Windows.Forms.Button();
            this.TxNombreClienteAlquilerBuscar = new System.Windows.Forms.TextBox();
            this.BtMostrarAlquileresCliente = new System.Windows.Forms.Button();
            this.P2_2_BuscarPeliculaNombre = new System.Windows.Forms.Panel();
            this.TxNombrePeliculaBuscar = new System.Windows.Forms.TextBox();
            this.BtEnviarPeliculaPorNombre = new System.Windows.Forms.Button();
            this.BtBuscarPelicula = new System.Windows.Forms.Button();
            this.P2_3_BuscarClienteNombre = new System.Windows.Forms.Panel();
            this.BtEnviarClientePorNombre = new System.Windows.Forms.Button();
            this.TxNombreClienteBuscar = new System.Windows.Forms.TextBox();
            this.BtBuscarCliente = new System.Windows.Forms.Button();
            this.BtMostrarClientes = new System.Windows.Forms.Button();
            this.BtMostrarPeliculas = new System.Windows.Forms.Button();
            this.P1_Derecha = new System.Windows.Forms.Panel();
            this.P1_2_Centro_ClientesPeliculas = new System.Windows.Forms.Panel();
            this.DateTFechaAlquilar = new System.Windows.Forms.DateTimePicker();
            this.BtAlquilar = new System.Windows.Forms.Button();
            this.DGVPelis = new System.Windows.Forms.DataGridView();
            this.LblPelis = new System.Windows.Forms.Label();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.LblClientes = new System.Windows.Forms.Label();
            this.P1_1_Centro_Alquileres = new System.Windows.Forms.Panel();
            this.BtDevolver = new System.Windows.Forms.Button();
            this.DGVAlquileres = new System.Windows.Forms.DataGridView();
            this.LblAlquileres = new System.Windows.Forms.Label();
            this.P3_Arriba.SuspendLayout();
            this.P2_Izquierda.SuspendLayout();
            this.P2_1_BuscarAlquiler.SuspendLayout();
            this.P2_2_BuscarPeliculaNombre.SuspendLayout();
            this.P2_3_BuscarClienteNombre.SuspendLayout();
            this.P1_Derecha.SuspendLayout();
            this.P1_2_Centro_ClientesPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.P1_1_Centro_Alquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // P3_Arriba
            // 
            this.P3_Arriba.BackColor = System.Drawing.Color.Purple;
            this.P3_Arriba.Controls.Add(this.BtVolver);
            this.P3_Arriba.Controls.Add(this.LabelGestion);
            this.P3_Arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3_Arriba.Location = new System.Drawing.Point(0, 0);
            this.P3_Arriba.Name = "P3_Arriba";
            this.P3_Arriba.Size = new System.Drawing.Size(1182, 46);
            this.P3_Arriba.TabIndex = 29;
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
            this.LabelGestion.Size = new System.Drawing.Size(331, 38);
            this.LabelGestion.TabIndex = 0;
            this.LabelGestion.Text = "Gestión de alquileres";
            this.LabelGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P2_Izquierda
            // 
            this.P2_Izquierda.BackColor = System.Drawing.Color.Orchid;
            this.P2_Izquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P2_Izquierda.Controls.Add(this.P2_1_BuscarAlquiler);
            this.P2_Izquierda.Controls.Add(this.BtMostrarAlquileresCliente);
            this.P2_Izquierda.Controls.Add(this.P2_2_BuscarPeliculaNombre);
            this.P2_Izquierda.Controls.Add(this.BtBuscarPelicula);
            this.P2_Izquierda.Controls.Add(this.P2_3_BuscarClienteNombre);
            this.P2_Izquierda.Controls.Add(this.BtBuscarCliente);
            this.P2_Izquierda.Controls.Add(this.BtMostrarClientes);
            this.P2_Izquierda.Controls.Add(this.BtMostrarPeliculas);
            this.P2_Izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.P2_Izquierda.Location = new System.Drawing.Point(0, 46);
            this.P2_Izquierda.Name = "P2_Izquierda";
            this.P2_Izquierda.Size = new System.Drawing.Size(342, 607);
            this.P2_Izquierda.TabIndex = 31;
            // 
            // P2_1_BuscarAlquiler
            // 
            this.P2_1_BuscarAlquiler.Controls.Add(this.BtEnviarAlquilerPorNombre);
            this.P2_1_BuscarAlquiler.Controls.Add(this.TxNombreClienteAlquilerBuscar);
            this.P2_1_BuscarAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.P2_1_BuscarAlquiler.Location = new System.Drawing.Point(0, 337);
            this.P2_1_BuscarAlquiler.Margin = new System.Windows.Forms.Padding(0);
            this.P2_1_BuscarAlquiler.Name = "P2_1_BuscarAlquiler";
            this.P2_1_BuscarAlquiler.Size = new System.Drawing.Size(342, 31);
            this.P2_1_BuscarAlquiler.TabIndex = 34;
            this.P2_1_BuscarAlquiler.Visible = false;
            // 
            // BtEnviarAlquilerPorNombre
            // 
            this.BtEnviarAlquilerPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarAlquilerPorNombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarAlquilerPorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarAlquilerPorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarAlquilerPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarAlquilerPorNombre.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarAlquilerPorNombre.ForeColor = System.Drawing.Color.White;
            this.BtEnviarAlquilerPorNombre.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarAlquilerPorNombre.Name = "BtEnviarAlquilerPorNombre";
            this.BtEnviarAlquilerPorNombre.Size = new System.Drawing.Size(75, 31);
            this.BtEnviarAlquilerPorNombre.TabIndex = 28;
            this.BtEnviarAlquilerPorNombre.Text = "Enviar";
            this.BtEnviarAlquilerPorNombre.UseVisualStyleBackColor = false;
            this.BtEnviarAlquilerPorNombre.Click += new System.EventHandler(this.BtEnviarAlquilerPorNombre_Click);
            // 
            // TxNombreClienteAlquilerBuscar
            // 
            this.TxNombreClienteAlquilerBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxNombreClienteAlquilerBuscar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombreClienteAlquilerBuscar.Location = new System.Drawing.Point(0, 0);
            this.TxNombreClienteAlquilerBuscar.Name = "TxNombreClienteAlquilerBuscar";
            this.TxNombreClienteAlquilerBuscar.Size = new System.Drawing.Size(342, 31);
            this.TxNombreClienteAlquilerBuscar.TabIndex = 29;
            // 
            // BtMostrarAlquileresCliente
            // 
            this.BtMostrarAlquileresCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtMostrarAlquileresCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtMostrarAlquileresCliente.FlatAppearance.BorderSize = 0;
            this.BtMostrarAlquileresCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarAlquileresCliente.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarAlquileresCliente.ForeColor = System.Drawing.Color.White;
            this.BtMostrarAlquileresCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtMostrarAlquileresCliente.Location = new System.Drawing.Point(0, 282);
            this.BtMostrarAlquileresCliente.Name = "BtMostrarAlquileresCliente";
            this.BtMostrarAlquileresCliente.Size = new System.Drawing.Size(342, 55);
            this.BtMostrarAlquileresCliente.TabIndex = 27;
            this.BtMostrarAlquileresCliente.Text = "Mostrar alquileres de cliente";
            this.BtMostrarAlquileresCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarAlquileresCliente.UseVisualStyleBackColor = true;
            this.BtMostrarAlquileresCliente.Click += new System.EventHandler(this.BtMostrarAlquileresCliente_Click);
            // 
            // P2_2_BuscarPeliculaNombre
            // 
            this.P2_2_BuscarPeliculaNombre.Controls.Add(this.TxNombrePeliculaBuscar);
            this.P2_2_BuscarPeliculaNombre.Controls.Add(this.BtEnviarPeliculaPorNombre);
            this.P2_2_BuscarPeliculaNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.P2_2_BuscarPeliculaNombre.Location = new System.Drawing.Point(0, 251);
            this.P2_2_BuscarPeliculaNombre.Margin = new System.Windows.Forms.Padding(0);
            this.P2_2_BuscarPeliculaNombre.Name = "P2_2_BuscarPeliculaNombre";
            this.P2_2_BuscarPeliculaNombre.Size = new System.Drawing.Size(342, 31);
            this.P2_2_BuscarPeliculaNombre.TabIndex = 33;
            this.P2_2_BuscarPeliculaNombre.Visible = false;
            // 
            // TxNombrePeliculaBuscar
            // 
            this.TxNombrePeliculaBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxNombrePeliculaBuscar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombrePeliculaBuscar.Location = new System.Drawing.Point(0, 0);
            this.TxNombrePeliculaBuscar.Name = "TxNombrePeliculaBuscar";
            this.TxNombrePeliculaBuscar.Size = new System.Drawing.Size(267, 31);
            this.TxNombrePeliculaBuscar.TabIndex = 29;
            // 
            // BtEnviarPeliculaPorNombre
            // 
            this.BtEnviarPeliculaPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPeliculaPorNombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPeliculaPorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPeliculaPorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPeliculaPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPeliculaPorNombre.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPeliculaPorNombre.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPeliculaPorNombre.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarPeliculaPorNombre.Name = "BtEnviarPeliculaPorNombre";
            this.BtEnviarPeliculaPorNombre.Size = new System.Drawing.Size(75, 31);
            this.BtEnviarPeliculaPorNombre.TabIndex = 28;
            this.BtEnviarPeliculaPorNombre.Text = "Enviar";
            this.BtEnviarPeliculaPorNombre.UseVisualStyleBackColor = false;
            this.BtEnviarPeliculaPorNombre.Click += new System.EventHandler(this.BtEnviarPeliculaPorNombre_Click);
            // 
            // BtBuscarPelicula
            // 
            this.BtBuscarPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPelicula.FlatAppearance.BorderSize = 0;
            this.BtBuscarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPelicula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPelicula.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPelicula.Image = global::Interfaz.Properties.Resources.lupaR;
            this.BtBuscarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPelicula.Location = new System.Drawing.Point(0, 196);
            this.BtBuscarPelicula.Name = "BtBuscarPelicula";
            this.BtBuscarPelicula.Size = new System.Drawing.Size(342, 55);
            this.BtBuscarPelicula.TabIndex = 32;
            this.BtBuscarPelicula.Text = "Buscar pelicula";
            this.BtBuscarPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPelicula.UseVisualStyleBackColor = false;
            this.BtBuscarPelicula.Click += new System.EventHandler(this.BtBuscarPelicula_Click);
            // 
            // P2_3_BuscarClienteNombre
            // 
            this.P2_3_BuscarClienteNombre.Controls.Add(this.BtEnviarClientePorNombre);
            this.P2_3_BuscarClienteNombre.Controls.Add(this.TxNombreClienteBuscar);
            this.P2_3_BuscarClienteNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.P2_3_BuscarClienteNombre.Location = new System.Drawing.Point(0, 165);
            this.P2_3_BuscarClienteNombre.Margin = new System.Windows.Forms.Padding(0);
            this.P2_3_BuscarClienteNombre.Name = "P2_3_BuscarClienteNombre";
            this.P2_3_BuscarClienteNombre.Size = new System.Drawing.Size(342, 31);
            this.P2_3_BuscarClienteNombre.TabIndex = 31;
            this.P2_3_BuscarClienteNombre.Visible = false;
            // 
            // BtEnviarClientePorNombre
            // 
            this.BtEnviarClientePorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarClientePorNombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarClientePorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarClientePorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarClientePorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarClientePorNombre.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarClientePorNombre.ForeColor = System.Drawing.Color.White;
            this.BtEnviarClientePorNombre.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarClientePorNombre.Name = "BtEnviarClientePorNombre";
            this.BtEnviarClientePorNombre.Size = new System.Drawing.Size(75, 31);
            this.BtEnviarClientePorNombre.TabIndex = 28;
            this.BtEnviarClientePorNombre.Text = "Enviar";
            this.BtEnviarClientePorNombre.UseVisualStyleBackColor = false;
            this.BtEnviarClientePorNombre.Click += new System.EventHandler(this.BtEnviarClientePorNombre_Click);
            // 
            // TxNombreClienteBuscar
            // 
            this.TxNombreClienteBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxNombreClienteBuscar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombreClienteBuscar.Location = new System.Drawing.Point(0, 0);
            this.TxNombreClienteBuscar.Name = "TxNombreClienteBuscar";
            this.TxNombreClienteBuscar.Size = new System.Drawing.Size(342, 31);
            this.TxNombreClienteBuscar.TabIndex = 29;
            // 
            // BtBuscarCliente
            // 
            this.BtBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarCliente.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.BtBuscarCliente.Image = global::Interfaz.Properties.Resources.lupaR;
            this.BtBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarCliente.Location = new System.Drawing.Point(0, 110);
            this.BtBuscarCliente.Name = "BtBuscarCliente";
            this.BtBuscarCliente.Size = new System.Drawing.Size(342, 55);
            this.BtBuscarCliente.TabIndex = 30;
            this.BtBuscarCliente.Text = "Buscar cliente";
            this.BtBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarCliente.UseVisualStyleBackColor = false;
            this.BtBuscarCliente.Click += new System.EventHandler(this.BtBuscarCliente_Click);
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
            this.BtMostrarClientes.Location = new System.Drawing.Point(0, 55);
            this.BtMostrarClientes.Name = "BtMostrarClientes";
            this.BtMostrarClientes.Size = new System.Drawing.Size(342, 55);
            this.BtMostrarClientes.TabIndex = 23;
            this.BtMostrarClientes.Text = "Mostrar clientes";
            this.BtMostrarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarClientes.UseVisualStyleBackColor = true;
            this.BtMostrarClientes.Click += new System.EventHandler(this.BtMostrarClientes_Click);
            // 
            // BtMostrarPeliculas
            // 
            this.BtMostrarPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtMostrarPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtMostrarPeliculas.FlatAppearance.BorderSize = 0;
            this.BtMostrarPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarPeliculas.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarPeliculas.ForeColor = System.Drawing.Color.White;
            this.BtMostrarPeliculas.Image = global::Interfaz.Properties.Resources.peliculasR;
            this.BtMostrarPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtMostrarPeliculas.Location = new System.Drawing.Point(0, 0);
            this.BtMostrarPeliculas.Name = "BtMostrarPeliculas";
            this.BtMostrarPeliculas.Size = new System.Drawing.Size(342, 55);
            this.BtMostrarPeliculas.TabIndex = 29;
            this.BtMostrarPeliculas.Text = "Mostrar peliculas";
            this.BtMostrarPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarPeliculas.UseVisualStyleBackColor = true;
            this.BtMostrarPeliculas.Click += new System.EventHandler(this.BtMostrarPeliculas_Click);
            // 
            // P1_Derecha
            // 
            this.P1_Derecha.BackColor = System.Drawing.Color.Plum;
            this.P1_Derecha.Controls.Add(this.P1_2_Centro_ClientesPeliculas);
            this.P1_Derecha.Controls.Add(this.P1_1_Centro_Alquileres);
            this.P1_Derecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P1_Derecha.Location = new System.Drawing.Point(342, 46);
            this.P1_Derecha.Name = "P1_Derecha";
            this.P1_Derecha.Size = new System.Drawing.Size(840, 607);
            this.P1_Derecha.TabIndex = 32;
            // 
            // P1_2_Centro_ClientesPeliculas
            // 
            this.P1_2_Centro_ClientesPeliculas.Controls.Add(this.DateTFechaAlquilar);
            this.P1_2_Centro_ClientesPeliculas.Controls.Add(this.BtAlquilar);
            this.P1_2_Centro_ClientesPeliculas.Controls.Add(this.DGVPelis);
            this.P1_2_Centro_ClientesPeliculas.Controls.Add(this.LblPelis);
            this.P1_2_Centro_ClientesPeliculas.Controls.Add(this.DGVClientes);
            this.P1_2_Centro_ClientesPeliculas.Controls.Add(this.LblClientes);
            this.P1_2_Centro_ClientesPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P1_2_Centro_ClientesPeliculas.Location = new System.Drawing.Point(0, 0);
            this.P1_2_Centro_ClientesPeliculas.Name = "P1_2_Centro_ClientesPeliculas";
            this.P1_2_Centro_ClientesPeliculas.Padding = new System.Windows.Forms.Padding(20, 5, 60, 0);
            this.P1_2_Centro_ClientesPeliculas.Size = new System.Drawing.Size(840, 607);
            this.P1_2_Centro_ClientesPeliculas.TabIndex = 24;
            // 
            // DateTFechaAlquilar
            // 
            this.DateTFechaAlquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTFechaAlquilar.Location = new System.Drawing.Point(134, 560);
            this.DateTFechaAlquilar.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DateTFechaAlquilar.Name = "DateTFechaAlquilar";
            this.DateTFechaAlquilar.Size = new System.Drawing.Size(400, 30);
            this.DateTFechaAlquilar.TabIndex = 29;
            // 
            // BtAlquilar
            // 
            this.BtAlquilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtAlquilar.FlatAppearance.BorderSize = 0;
            this.BtAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlquilar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlquilar.ForeColor = System.Drawing.Color.White;
            this.BtAlquilar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAlquilar.Location = new System.Drawing.Point(23, 540);
            this.BtAlquilar.Name = "BtAlquilar";
            this.BtAlquilar.Size = new System.Drawing.Size(105, 55);
            this.BtAlquilar.TabIndex = 28;
            this.BtAlquilar.Text = "Alquilar";
            this.BtAlquilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAlquilar.UseVisualStyleBackColor = true;
            this.BtAlquilar.Click += new System.EventHandler(this.BtAlquilar_Click);
            // 
            // DGVPelis
            // 
            this.DGVPelis.AllowUserToAddRows = false;
            this.DGVPelis.AllowUserToDeleteRows = false;
            this.DGVPelis.AllowUserToResizeRows = false;
            this.DGVPelis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVPelis.BackgroundColor = System.Drawing.Color.Plum;
            this.DGVPelis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPelis.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVPelis.Location = new System.Drawing.Point(20, 297);
            this.DGVPelis.Name = "DGVPelis";
            this.DGVPelis.ReadOnly = true;
            this.DGVPelis.RowHeadersVisible = false;
            this.DGVPelis.RowHeadersWidth = 51;
            this.DGVPelis.RowTemplate.Height = 24;
            this.DGVPelis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPelis.Size = new System.Drawing.Size(760, 216);
            this.DGVPelis.TabIndex = 3;
            // 
            // LblPelis
            // 
            this.LblPelis.AutoSize = true;
            this.LblPelis.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPelis.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPelis.Location = new System.Drawing.Point(20, 249);
            this.LblPelis.Name = "LblPelis";
            this.LblPelis.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.LblPelis.Size = new System.Drawing.Size(110, 48);
            this.LblPelis.TabIndex = 8;
            this.LblPelis.Text = "Películas";
            this.LblPelis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.AllowUserToResizeRows = false;
            this.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVClientes.BackgroundColor = System.Drawing.Color.Plum;
            this.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVClientes.Location = new System.Drawing.Point(20, 33);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.RowHeadersVisible = false;
            this.DGVClientes.RowHeadersWidth = 51;
            this.DGVClientes.RowTemplate.Height = 24;
            this.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClientes.Size = new System.Drawing.Size(760, 216);
            this.DGVClientes.TabIndex = 2;
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblClientes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.Location = new System.Drawing.Point(20, 5);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(102, 28);
            this.LblClientes.TabIndex = 8;
            this.LblClientes.Text = "Clientes";
            this.LblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // P1_1_Centro_Alquileres
            // 
            this.P1_1_Centro_Alquileres.Controls.Add(this.BtDevolver);
            this.P1_1_Centro_Alquileres.Controls.Add(this.DGVAlquileres);
            this.P1_1_Centro_Alquileres.Controls.Add(this.LblAlquileres);
            this.P1_1_Centro_Alquileres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P1_1_Centro_Alquileres.Location = new System.Drawing.Point(0, 0);
            this.P1_1_Centro_Alquileres.Name = "P1_1_Centro_Alquileres";
            this.P1_1_Centro_Alquileres.Padding = new System.Windows.Forms.Padding(20, 5, 60, 0);
            this.P1_1_Centro_Alquileres.Size = new System.Drawing.Size(840, 607);
            this.P1_1_Centro_Alquileres.TabIndex = 25;
            this.P1_1_Centro_Alquileres.Visible = false;
            // 
            // BtDevolver
            // 
            this.BtDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtDevolver.FlatAppearance.BorderSize = 0;
            this.BtDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDevolver.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDevolver.ForeColor = System.Drawing.Color.White;
            this.BtDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDevolver.Location = new System.Drawing.Point(25, 499);
            this.BtDevolver.Name = "BtDevolver";
            this.BtDevolver.Size = new System.Drawing.Size(117, 55);
            this.BtDevolver.TabIndex = 29;
            this.BtDevolver.Text = "Devolver";
            this.BtDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDevolver.UseVisualStyleBackColor = true;
            this.BtDevolver.Click += new System.EventHandler(this.BtDevolver_Click);
            // 
            // DGVAlquileres
            // 
            this.DGVAlquileres.AllowUserToAddRows = false;
            this.DGVAlquileres.AllowUserToDeleteRows = false;
            this.DGVAlquileres.AllowUserToOrderColumns = true;
            this.DGVAlquileres.AllowUserToResizeRows = false;
            this.DGVAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVAlquileres.BackgroundColor = System.Drawing.Color.Plum;
            this.DGVAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlquileres.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVAlquileres.Location = new System.Drawing.Point(20, 33);
            this.DGVAlquileres.Name = "DGVAlquileres";
            this.DGVAlquileres.ReadOnly = true;
            this.DGVAlquileres.RowHeadersVisible = false;
            this.DGVAlquileres.RowHeadersWidth = 51;
            this.DGVAlquileres.RowTemplate.Height = 24;
            this.DGVAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAlquileres.Size = new System.Drawing.Size(760, 335);
            this.DGVAlquileres.TabIndex = 3;
            // 
            // LblAlquileres
            // 
            this.LblAlquileres.AutoSize = true;
            this.LblAlquileres.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblAlquileres.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlquileres.Location = new System.Drawing.Point(20, 5);
            this.LblAlquileres.Name = "LblAlquileres";
            this.LblAlquileres.Size = new System.Drawing.Size(122, 28);
            this.LblAlquileres.TabIndex = 8;
            this.LblAlquileres.Text = "Alquileres";
            this.LblAlquileres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AlquilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.P1_Derecha);
            this.Controls.Add(this.P2_Izquierda);
            this.Controls.Add(this.P3_Arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlquilerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlquilerForm";
            this.P3_Arriba.ResumeLayout(false);
            this.P3_Arriba.PerformLayout();
            this.P2_Izquierda.ResumeLayout(false);
            this.P2_1_BuscarAlquiler.ResumeLayout(false);
            this.P2_1_BuscarAlquiler.PerformLayout();
            this.P2_2_BuscarPeliculaNombre.ResumeLayout(false);
            this.P2_2_BuscarPeliculaNombre.PerformLayout();
            this.P2_3_BuscarClienteNombre.ResumeLayout(false);
            this.P2_3_BuscarClienteNombre.PerformLayout();
            this.P1_Derecha.ResumeLayout(false);
            this.P1_2_Centro_ClientesPeliculas.ResumeLayout(false);
            this.P1_2_Centro_ClientesPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.P1_1_Centro_Alquileres.ResumeLayout(false);
            this.P1_1_Centro_Alquileres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlquileres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P3_Arriba;
        private System.Windows.Forms.Label LabelGestion;
        private System.Windows.Forms.Panel P2_Izquierda;
        private System.Windows.Forms.Panel P1_Derecha;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.Button BtMostrarClientes;
        private System.Windows.Forms.Panel P1_2_Centro_ClientesPeliculas;
        private System.Windows.Forms.DataGridView DGVPelis;
        private System.Windows.Forms.Label LblPelis;
        private System.Windows.Forms.Button BtMostrarAlquileresCliente;
        private System.Windows.Forms.Panel P1_1_Centro_Alquileres;
        private System.Windows.Forms.DataGridView DGVAlquileres;
        private System.Windows.Forms.Label LblAlquileres;
        private System.Windows.Forms.Button BtMostrarPeliculas;
        private System.Windows.Forms.Button BtBuscarCliente;
        private System.Windows.Forms.Panel P2_3_BuscarClienteNombre;
        private System.Windows.Forms.TextBox TxNombreClienteBuscar;
        private System.Windows.Forms.Button BtEnviarClientePorNombre;
        private System.Windows.Forms.Panel P2_1_BuscarAlquiler;
        private System.Windows.Forms.TextBox TxNombreClienteAlquilerBuscar;
        private System.Windows.Forms.Button BtEnviarAlquilerPorNombre;
        private System.Windows.Forms.Panel P2_2_BuscarPeliculaNombre;
        private System.Windows.Forms.TextBox TxNombrePeliculaBuscar;
        private System.Windows.Forms.Button BtEnviarPeliculaPorNombre;
        private System.Windows.Forms.Button BtBuscarPelicula;
        private System.Windows.Forms.Button BtAlquilar;
        private System.Windows.Forms.DateTimePicker DateTFechaAlquilar;
        private System.Windows.Forms.Button BtDevolver;
        private System.Windows.Forms.Button BtVolver;
    }
}