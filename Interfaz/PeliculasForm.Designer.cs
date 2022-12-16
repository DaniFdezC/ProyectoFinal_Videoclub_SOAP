namespace Interfaz {
    partial class PeliculasForm {
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
            this.PnAnadirPelicula = new System.Windows.Forms.Panel();
            this.ListBGenero = new System.Windows.Forms.ListBox();
            this.NumYear = new System.Windows.Forms.NumericUpDown();
            this.DateTFechaADic = new System.Windows.Forms.DateTimePicker();
            this.BtEnviarPeli = new System.Windows.Forms.Button();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblTituloPeli = new System.Windows.Forms.Label();
            this.TxTitulo = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblFechaAnadido = new System.Windows.Forms.Label();
            this.PnMostrar = new System.Windows.Forms.Panel();
            this.DGVPeliculas = new System.Windows.Forms.DataGridView();
            this.PnEliminar = new System.Windows.Forms.Panel();
            this.DGVElimPeli = new System.Windows.Forms.DataGridView();
            this.PnBusqueda = new System.Windows.Forms.Panel();
            this.DGVBuscar = new System.Windows.Forms.DataGridView();
            this.BtMostrarPeliculas = new System.Windows.Forms.Button();
            this.CmbBuscarGenero = new System.Windows.Forms.ComboBox();
            this.PanelIzda = new System.Windows.Forms.Panel();
            this.PanelBuscarIzda = new System.Windows.Forms.Panel();
            this.BtBuscarPorGenero = new System.Windows.Forms.Button();
            this.PanelBusquedaPorGenero = new System.Windows.Forms.Panel();
            this.BtEnviarPorGenero = new System.Windows.Forms.Button();
            this.BtEliminaPelicula = new System.Windows.Forms.Button();
            this.BtAnadirPelicula = new System.Windows.Forms.Button();
            this.BtBuscarPelicula = new System.Windows.Forms.Button();
            this.PanelPorGenero = new System.Windows.Forms.Panel();
            this.PanelPorNombre = new System.Windows.Forms.Panel();
            this.BtBuscarPorNombre = new System.Windows.Forms.Button();
            this.PanelBusquedaPorNombre = new System.Windows.Forms.Panel();
            this.BtEnviarPorNombre = new System.Windows.Forms.Button();
            this.TxNombrePeliculaBuscar = new System.Windows.Forms.TextBox();
            this.PanelPorDias = new System.Windows.Forms.Panel();
            this.BtBuscarPorDias = new System.Windows.Forms.Button();
            this.PanelBusquedaPorDias = new System.Windows.Forms.Panel();
            this.BtEnviarPorDias = new System.Windows.Forms.Button();
            this.NumericBuscarDias = new System.Windows.Forms.NumericUpDown();
            this.PanelEliminarIzda = new System.Windows.Forms.Panel();
            this.BtElim = new System.Windows.Forms.Button();
            this.PanelDcha = new System.Windows.Forms.Panel();
            this.PnAnadirPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).BeginInit();
            this.PnMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).BeginInit();
            this.PnEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVElimPeli)).BeginInit();
            this.PnBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscar)).BeginInit();
            this.PanelIzda.SuspendLayout();
            this.PanelBuscarIzda.SuspendLayout();
            this.PanelBusquedaPorGenero.SuspendLayout();
            this.PanelPorGenero.SuspendLayout();
            this.PanelPorNombre.SuspendLayout();
            this.PanelBusquedaPorNombre.SuspendLayout();
            this.PanelPorDias.SuspendLayout();
            this.PanelBusquedaPorDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBuscarDias)).BeginInit();
            this.PanelEliminarIzda.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnAnadirPelicula
            // 
            this.PnAnadirPelicula.Controls.Add(this.ListBGenero);
            this.PnAnadirPelicula.Controls.Add(this.NumYear);
            this.PnAnadirPelicula.Controls.Add(this.DateTFechaADic);
            this.PnAnadirPelicula.Controls.Add(this.BtEnviarPeli);
            this.PnAnadirPelicula.Controls.Add(this.LblYear);
            this.PnAnadirPelicula.Controls.Add(this.LblTituloPeli);
            this.PnAnadirPelicula.Controls.Add(this.TxTitulo);
            this.PnAnadirPelicula.Controls.Add(this.LblGenero);
            this.PnAnadirPelicula.Controls.Add(this.LblFechaAnadido);
            this.PnAnadirPelicula.Location = new System.Drawing.Point(403, 27);
            this.PnAnadirPelicula.Name = "PnAnadirPelicula";
            this.PnAnadirPelicula.Size = new System.Drawing.Size(653, 430);
            this.PnAnadirPelicula.TabIndex = 21;
            // 
            // ListBGenero
            // 
            this.ListBGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBGenero.FormattingEnabled = true;
            this.ListBGenero.ItemHeight = 25;
            this.ListBGenero.Location = new System.Drawing.Point(8, 123);
            this.ListBGenero.Name = "ListBGenero";
            this.ListBGenero.Size = new System.Drawing.Size(400, 29);
            this.ListBGenero.Sorted = true;
            this.ListBGenero.TabIndex = 24;
            // 
            // NumYear
            // 
            this.NumYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumYear.Location = new System.Drawing.Point(8, 216);
            this.NumYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NumYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NumYear.Name = "NumYear";
            this.NumYear.Size = new System.Drawing.Size(139, 30);
            this.NumYear.TabIndex = 23;
            this.NumYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // DateTFechaADic
            // 
            this.DateTFechaADic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTFechaADic.Location = new System.Drawing.Point(8, 314);
            this.DateTFechaADic.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DateTFechaADic.Name = "DateTFechaADic";
            this.DateTFechaADic.Size = new System.Drawing.Size(400, 30);
            this.DateTFechaADic.TabIndex = 22;
            // 
            // BtEnviarPeli
            // 
            this.BtEnviarPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPeli.Location = new System.Drawing.Point(494, 369);
            this.BtEnviarPeli.Name = "BtEnviarPeli";
            this.BtEnviarPeli.Size = new System.Drawing.Size(159, 61);
            this.BtEnviarPeli.TabIndex = 17;
            this.BtEnviarPeli.Text = "Enviar";
            this.BtEnviarPeli.UseVisualStyleBackColor = true;
            this.BtEnviarPeli.Click += new System.EventHandler(this.BtEnviarPeli_Click);
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(3, 188);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(48, 25);
            this.LblYear.TabIndex = 9;
            this.LblYear.Text = "Año";
            // 
            // LblTituloPeli
            // 
            this.LblTituloPeli.AutoSize = true;
            this.LblTituloPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPeli.Location = new System.Drawing.Point(3, 11);
            this.LblTituloPeli.Name = "LblTituloPeli";
            this.LblTituloPeli.Size = new System.Drawing.Size(60, 25);
            this.LblTituloPeli.TabIndex = 7;
            this.LblTituloPeli.Text = "Titulo";
            // 
            // TxTitulo
            // 
            this.TxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTitulo.Location = new System.Drawing.Point(8, 39);
            this.TxTitulo.Multiline = true;
            this.TxTitulo.Name = "TxTitulo";
            this.TxTitulo.Size = new System.Drawing.Size(400, 38);
            this.TxTitulo.TabIndex = 4;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(3, 95);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(77, 25);
            this.LblGenero.TabIndex = 8;
            this.LblGenero.Text = "Genero";
            // 
            // LblFechaAnadido
            // 
            this.LblFechaAnadido.AutoSize = true;
            this.LblFechaAnadido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAnadido.Location = new System.Drawing.Point(3, 286);
            this.LblFechaAnadido.Name = "LblFechaAnadido";
            this.LblFechaAnadido.Size = new System.Drawing.Size(134, 25);
            this.LblFechaAnadido.TabIndex = 11;
            this.LblFechaAnadido.Text = "Fecha adición";
            // 
            // PnMostrar
            // 
            this.PnMostrar.Controls.Add(this.DGVPeliculas);
            this.PnMostrar.Location = new System.Drawing.Point(403, 27);
            this.PnMostrar.Name = "PnMostrar";
            this.PnMostrar.Size = new System.Drawing.Size(653, 433);
            this.PnMostrar.TabIndex = 22;
            // 
            // DGVPeliculas
            // 
            this.DGVPeliculas.AllowUserToAddRows = false;
            this.DGVPeliculas.AllowUserToDeleteRows = false;
            this.DGVPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPeliculas.Location = new System.Drawing.Point(0, 0);
            this.DGVPeliculas.Name = "DGVPeliculas";
            this.DGVPeliculas.ReadOnly = true;
            this.DGVPeliculas.RowHeadersVisible = false;
            this.DGVPeliculas.RowHeadersWidth = 51;
            this.DGVPeliculas.RowTemplate.Height = 24;
            this.DGVPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPeliculas.Size = new System.Drawing.Size(570, 427);
            this.DGVPeliculas.TabIndex = 2;
            // 
            // PnEliminar
            // 
            this.PnEliminar.Controls.Add(this.DGVElimPeli);
            this.PnEliminar.Location = new System.Drawing.Point(403, 27);
            this.PnEliminar.Name = "PnEliminar";
            this.PnEliminar.Size = new System.Drawing.Size(653, 430);
            this.PnEliminar.TabIndex = 23;
            // 
            // DGVElimPeli
            // 
            this.DGVElimPeli.AllowUserToAddRows = false;
            this.DGVElimPeli.AllowUserToDeleteRows = false;
            this.DGVElimPeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVElimPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVElimPeli.Location = new System.Drawing.Point(0, 0);
            this.DGVElimPeli.Name = "DGVElimPeli";
            this.DGVElimPeli.ReadOnly = true;
            this.DGVElimPeli.RowHeadersVisible = false;
            this.DGVElimPeli.RowHeadersWidth = 51;
            this.DGVElimPeli.RowTemplate.Height = 24;
            this.DGVElimPeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVElimPeli.Size = new System.Drawing.Size(570, 427);
            this.DGVElimPeli.TabIndex = 3;
            // 
            // PnBusqueda
            // 
            this.PnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PnBusqueda.Controls.Add(this.DGVBuscar);
            this.PnBusqueda.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnBusqueda.Location = new System.Drawing.Point(340, 0);
            this.PnBusqueda.Name = "PnBusqueda";
            this.PnBusqueda.Size = new System.Drawing.Size(842, 653);
            this.PnBusqueda.TabIndex = 24;
            // 
            // DGVBuscar
            // 
            this.DGVBuscar.AllowUserToAddRows = false;
            this.DGVBuscar.AllowUserToDeleteRows = false;
            this.DGVBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGVBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscar.Location = new System.Drawing.Point(307, 12);
            this.DGVBuscar.Name = "DGVBuscar";
            this.DGVBuscar.ReadOnly = true;
            this.DGVBuscar.RowHeadersVisible = false;
            this.DGVBuscar.RowHeadersWidth = 51;
            this.DGVBuscar.RowTemplate.Height = 24;
            this.DGVBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBuscar.Size = new System.Drawing.Size(570, 427);
            this.DGVBuscar.TabIndex = 2;
            // 
            // BtMostrarPeliculas
            // 
            this.BtMostrarPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtMostrarPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtMostrarPeliculas.FlatAppearance.BorderSize = 0;
            this.BtMostrarPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarPeliculas.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarPeliculas.ForeColor = System.Drawing.Color.White;
            this.BtMostrarPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtMostrarPeliculas.Location = new System.Drawing.Point(0, 0);
            this.BtMostrarPeliculas.Name = "BtMostrarPeliculas";
            this.BtMostrarPeliculas.Size = new System.Drawing.Size(342, 60);
            this.BtMostrarPeliculas.TabIndex = 1;
            this.BtMostrarPeliculas.Text = "Mostrar peliculas";
            this.BtMostrarPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarPeliculas.UseVisualStyleBackColor = true;
            this.BtMostrarPeliculas.Click += new System.EventHandler(this.BtMostrarPeliculas_Click);
            // 
            // CmbBuscarGenero
            // 
            this.CmbBuscarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBuscarGenero.ForeColor = System.Drawing.Color.White;
            this.CmbBuscarGenero.FormattingEnabled = true;
            this.CmbBuscarGenero.Location = new System.Drawing.Point(67, 0);
            this.CmbBuscarGenero.Name = "CmbBuscarGenero";
            this.CmbBuscarGenero.Size = new System.Drawing.Size(178, 28);
            this.CmbBuscarGenero.TabIndex = 26;
            // 
            // PanelIzda
            // 
            this.PanelIzda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelIzda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelIzda.Controls.Add(this.PanelBuscarIzda);
            this.PanelIzda.Controls.Add(this.BtBuscarPelicula);
            this.PanelIzda.Controls.Add(this.PanelEliminarIzda);
            this.PanelIzda.Controls.Add(this.BtEliminaPelicula);
            this.PanelIzda.Controls.Add(this.BtAnadirPelicula);
            this.PanelIzda.Controls.Add(this.BtMostrarPeliculas);
            this.PanelIzda.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzda.Location = new System.Drawing.Point(0, 0);
            this.PanelIzda.Name = "PanelIzda";
            this.PanelIzda.Size = new System.Drawing.Size(342, 653);
            this.PanelIzda.TabIndex = 26;
            // 
            // PanelBuscarIzda
            // 
            this.PanelBuscarIzda.Controls.Add(this.PanelPorDias);
            this.PanelBuscarIzda.Controls.Add(this.PanelPorGenero);
            this.PanelBuscarIzda.Controls.Add(this.PanelPorNombre);
            this.PanelBuscarIzda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBuscarIzda.Location = new System.Drawing.Point(0, 274);
            this.PanelBuscarIzda.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBuscarIzda.Name = "PanelBuscarIzda";
            this.PanelBuscarIzda.Size = new System.Drawing.Size(342, 311);
            this.PanelBuscarIzda.TabIndex = 22;
            // 
            // BtBuscarPorGenero
            // 
            this.BtBuscarPorGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtBuscarPorGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorGenero.FlatAppearance.BorderSize = 0;
            this.BtBuscarPorGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPorGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPorGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPorGenero.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPorGenero.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPorGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPorGenero.Location = new System.Drawing.Point(0, 0);
            this.BtBuscarPorGenero.Name = "BtBuscarPorGenero";
            this.BtBuscarPorGenero.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtBuscarPorGenero.Size = new System.Drawing.Size(342, 38);
            this.BtBuscarPorGenero.TabIndex = 27;
            this.BtBuscarPorGenero.Text = "Por genero";
            this.BtBuscarPorGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPorGenero.UseVisualStyleBackColor = false;
            // 
            // PanelBusquedaPorGenero
            // 
            this.PanelBusquedaPorGenero.Controls.Add(this.BtEnviarPorGenero);
            this.PanelBusquedaPorGenero.Controls.Add(this.CmbBuscarGenero);
            this.PanelBusquedaPorGenero.Location = new System.Drawing.Point(1, 38);
            this.PanelBusquedaPorGenero.Name = "PanelBusquedaPorGenero";
            this.PanelBusquedaPorGenero.Size = new System.Drawing.Size(342, 34);
            this.PanelBusquedaPorGenero.TabIndex = 32;
            // 
            // BtEnviarPorGenero
            // 
            this.BtEnviarPorGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtEnviarPorGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPorGenero.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPorGenero.FlatAppearance.BorderSize = 0;
            this.BtEnviarPorGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtEnviarPorGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtEnviarPorGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPorGenero.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPorGenero.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPorGenero.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarPorGenero.Name = "BtEnviarPorGenero";
            this.BtEnviarPorGenero.Size = new System.Drawing.Size(75, 34);
            this.BtEnviarPorGenero.TabIndex = 28;
            this.BtEnviarPorGenero.Text = "Enviar";
            this.BtEnviarPorGenero.UseVisualStyleBackColor = false;
            // 
            // BtEliminaPelicula
            // 
            this.BtEliminaPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtEliminaPelicula.FlatAppearance.BorderSize = 0;
            this.BtEliminaPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminaPelicula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminaPelicula.ForeColor = System.Drawing.Color.White;
            this.BtEliminaPelicula.Image = global::Interfaz.Properties.Resources.eliminarR;
            this.BtEliminaPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEliminaPelicula.Location = new System.Drawing.Point(0, 120);
            this.BtEliminaPelicula.Name = "BtEliminaPelicula";
            this.BtEliminaPelicula.Size = new System.Drawing.Size(342, 60);
            this.BtEliminaPelicula.TabIndex = 19;
            this.BtEliminaPelicula.Text = "Eliminar pelicula";
            this.BtEliminaPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEliminaPelicula.UseVisualStyleBackColor = true;
            this.BtEliminaPelicula.Click += new System.EventHandler(this.BtEliminaPelicula_Click);
            // 
            // BtAnadirPelicula
            // 
            this.BtAnadirPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtAnadirPelicula.FlatAppearance.BorderSize = 0;
            this.BtAnadirPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAnadirPelicula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAnadirPelicula.ForeColor = System.Drawing.Color.White;
            this.BtAnadirPelicula.Image = global::Interfaz.Properties.Resources.anadirR;
            this.BtAnadirPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAnadirPelicula.Location = new System.Drawing.Point(0, 60);
            this.BtAnadirPelicula.Name = "BtAnadirPelicula";
            this.BtAnadirPelicula.Size = new System.Drawing.Size(342, 60);
            this.BtAnadirPelicula.TabIndex = 18;
            this.BtAnadirPelicula.Text = "Añadir pelicula";
            this.BtAnadirPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAnadirPelicula.UseVisualStyleBackColor = true;
            this.BtAnadirPelicula.Click += new System.EventHandler(this.BtAnadirPelicula_Click);
            // 
            // BtBuscarPelicula
            // 
            this.BtBuscarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtBuscarPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPelicula.FlatAppearance.BorderSize = 0;
            this.BtBuscarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPelicula.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPelicula.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPelicula.Image = global::Interfaz.Properties.Resources.lupaR;
            this.BtBuscarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPelicula.Location = new System.Drawing.Point(0, 214);
            this.BtBuscarPelicula.Name = "BtBuscarPelicula";
            this.BtBuscarPelicula.Size = new System.Drawing.Size(342, 60);
            this.BtBuscarPelicula.TabIndex = 20;
            this.BtBuscarPelicula.Text = "Buscar pelicula";
            this.BtBuscarPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPelicula.UseVisualStyleBackColor = false;
            this.BtBuscarPelicula.Click += new System.EventHandler(this.BtBuscarPelicula_Click);
            // 
            // PanelPorGenero
            // 
            this.PanelPorGenero.Controls.Add(this.BtBuscarPorGenero);
            this.PanelPorGenero.Controls.Add(this.PanelBusquedaPorGenero);
            this.PanelPorGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorGenero.Location = new System.Drawing.Point(0, 72);
            this.PanelPorGenero.Name = "PanelPorGenero";
            this.PanelPorGenero.Size = new System.Drawing.Size(342, 72);
            this.PanelPorGenero.TabIndex = 33;
            // 
            // PanelPorNombre
            // 
            this.PanelPorNombre.Controls.Add(this.BtBuscarPorNombre);
            this.PanelPorNombre.Controls.Add(this.PanelBusquedaPorNombre);
            this.PanelPorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorNombre.Location = new System.Drawing.Point(0, 0);
            this.PanelPorNombre.Name = "PanelPorNombre";
            this.PanelPorNombre.Size = new System.Drawing.Size(342, 72);
            this.PanelPorNombre.TabIndex = 34;
            // 
            // BtBuscarPorNombre
            // 
            this.BtBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtBuscarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorNombre.FlatAppearance.BorderSize = 0;
            this.BtBuscarPorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
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
            // 
            // PanelBusquedaPorNombre
            // 
            this.PanelBusquedaPorNombre.Controls.Add(this.TxNombrePeliculaBuscar);
            this.PanelBusquedaPorNombre.Controls.Add(this.BtEnviarPorNombre);
            this.PanelBusquedaPorNombre.Location = new System.Drawing.Point(1, 38);
            this.PanelBusquedaPorNombre.Name = "PanelBusquedaPorNombre";
            this.PanelBusquedaPorNombre.Size = new System.Drawing.Size(340, 34);
            this.PanelBusquedaPorNombre.TabIndex = 32;
            // 
            // BtEnviarPorNombre
            // 
            this.BtEnviarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtEnviarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPorNombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPorNombre.FlatAppearance.BorderSize = 0;
            this.BtEnviarPorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtEnviarPorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtEnviarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPorNombre.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPorNombre.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPorNombre.Location = new System.Drawing.Point(265, 0);
            this.BtEnviarPorNombre.Name = "BtEnviarPorNombre";
            this.BtEnviarPorNombre.Size = new System.Drawing.Size(75, 34);
            this.BtEnviarPorNombre.TabIndex = 28;
            this.BtEnviarPorNombre.Text = "Enviar";
            this.BtEnviarPorNombre.UseVisualStyleBackColor = false;
            // 
            // TxNombrePeliculaBuscar
            // 
            this.TxNombrePeliculaBuscar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombrePeliculaBuscar.Location = new System.Drawing.Point(67, 0);
            this.TxNombrePeliculaBuscar.Name = "TxNombrePeliculaBuscar";
            this.TxNombrePeliculaBuscar.Size = new System.Drawing.Size(178, 31);
            this.TxNombrePeliculaBuscar.TabIndex = 29;
            // 
            // PanelPorDias
            // 
            this.PanelPorDias.Controls.Add(this.BtBuscarPorDias);
            this.PanelPorDias.Controls.Add(this.PanelBusquedaPorDias);
            this.PanelPorDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorDias.Location = new System.Drawing.Point(0, 144);
            this.PanelPorDias.Name = "PanelPorDias";
            this.PanelPorDias.Size = new System.Drawing.Size(342, 72);
            this.PanelPorDias.TabIndex = 35;
            // 
            // BtBuscarPorDias
            // 
            this.BtBuscarPorDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtBuscarPorDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorDias.FlatAppearance.BorderSize = 0;
            this.BtBuscarPorDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPorDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtBuscarPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPorDias.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPorDias.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPorDias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPorDias.Location = new System.Drawing.Point(0, 0);
            this.BtBuscarPorDias.Name = "BtBuscarPorDias";
            this.BtBuscarPorDias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtBuscarPorDias.Size = new System.Drawing.Size(342, 38);
            this.BtBuscarPorDias.TabIndex = 27;
            this.BtBuscarPorDias.Text = "Por dias";
            this.BtBuscarPorDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPorDias.UseVisualStyleBackColor = false;
            // 
            // PanelBusquedaPorDias
            // 
            this.PanelBusquedaPorDias.Controls.Add(this.NumericBuscarDias);
            this.PanelBusquedaPorDias.Controls.Add(this.BtEnviarPorDias);
            this.PanelBusquedaPorDias.Location = new System.Drawing.Point(1, 38);
            this.PanelBusquedaPorDias.Name = "PanelBusquedaPorDias";
            this.PanelBusquedaPorDias.Size = new System.Drawing.Size(342, 34);
            this.PanelBusquedaPorDias.TabIndex = 32;
            // 
            // BtEnviarPorDias
            // 
            this.BtEnviarPorDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtEnviarPorDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPorDias.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPorDias.FlatAppearance.BorderSize = 0;
            this.BtEnviarPorDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtEnviarPorDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtEnviarPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPorDias.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPorDias.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPorDias.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarPorDias.Name = "BtEnviarPorDias";
            this.BtEnviarPorDias.Size = new System.Drawing.Size(75, 34);
            this.BtEnviarPorDias.TabIndex = 28;
            this.BtEnviarPorDias.Text = "Enviar";
            this.BtEnviarPorDias.UseVisualStyleBackColor = false;
            // 
            // NumericBuscarDias
            // 
            this.NumericBuscarDias.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericBuscarDias.Location = new System.Drawing.Point(67, 0);
            this.NumericBuscarDias.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.NumericBuscarDias.Name = "NumericBuscarDias";
            this.NumericBuscarDias.Size = new System.Drawing.Size(72, 31);
            this.NumericBuscarDias.TabIndex = 29;
            this.NumericBuscarDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PanelEliminarIzda
            // 
            this.PanelEliminarIzda.Controls.Add(this.BtElim);
            this.PanelEliminarIzda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEliminarIzda.Location = new System.Drawing.Point(0, 180);
            this.PanelEliminarIzda.Name = "PanelEliminarIzda";
            this.PanelEliminarIzda.Size = new System.Drawing.Size(342, 34);
            this.PanelEliminarIzda.TabIndex = 23;
            // 
            // BtElim
            // 
            this.BtElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtElim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtElim.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtElim.FlatAppearance.BorderSize = 0;
            this.BtElim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtElim.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtElim.ForeColor = System.Drawing.Color.White;
            this.BtElim.Location = new System.Drawing.Point(266, 0);
            this.BtElim.Name = "BtElim";
            this.BtElim.Size = new System.Drawing.Size(76, 34);
            this.BtElim.TabIndex = 28;
            this.BtElim.Text = "Enviar";
            this.BtElim.UseVisualStyleBackColor = false;
            // 
            // PanelDcha
            // 
            this.PanelDcha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelDcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDcha.Location = new System.Drawing.Point(342, 0);
            this.PanelDcha.Name = "PanelDcha";
            this.PanelDcha.Size = new System.Drawing.Size(0, 653);
            this.PanelDcha.TabIndex = 27;
            // 
            // PeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PanelDcha);
            this.Controls.Add(this.PanelIzda);
            this.Controls.Add(this.PnBusqueda);
            this.Controls.Add(this.PnEliminar);
            this.Controls.Add(this.PnMostrar);
            this.Controls.Add(this.PnAnadirPelicula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PeliculasForm";
            this.Text = "PeliculasForm";
            this.PnAnadirPelicula.ResumeLayout(false);
            this.PnAnadirPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).EndInit();
            this.PnMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).EndInit();
            this.PnEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVElimPeli)).EndInit();
            this.PnBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscar)).EndInit();
            this.PanelIzda.ResumeLayout(false);
            this.PanelBuscarIzda.ResumeLayout(false);
            this.PanelBusquedaPorGenero.ResumeLayout(false);
            this.PanelPorGenero.ResumeLayout(false);
            this.PanelPorNombre.ResumeLayout(false);
            this.PanelBusquedaPorNombre.ResumeLayout(false);
            this.PanelBusquedaPorNombre.PerformLayout();
            this.PanelPorDias.ResumeLayout(false);
            this.PanelBusquedaPorDias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericBuscarDias)).EndInit();
            this.PanelEliminarIzda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtMostrarPeliculas;
        private System.Windows.Forms.Button BtEliminaPelicula;
        private System.Windows.Forms.Button BtAnadirPelicula;
        private System.Windows.Forms.Button BtBuscarPelicula;
        private System.Windows.Forms.Panel PnAnadirPelicula;
        private System.Windows.Forms.Button BtEnviarPeli;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblTituloPeli;
        private System.Windows.Forms.TextBox TxTitulo;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblFechaAnadido;
        private System.Windows.Forms.DateTimePicker DateTFechaADic;
        private System.Windows.Forms.NumericUpDown NumYear;
        private System.Windows.Forms.ListBox ListBGenero;
        private System.Windows.Forms.Panel PnMostrar;
        private System.Windows.Forms.DataGridView DGVPeliculas;
        private System.Windows.Forms.Panel PnEliminar;
        private System.Windows.Forms.DataGridView DGVElimPeli;
        private System.Windows.Forms.Panel PnBusqueda;
        private System.Windows.Forms.DataGridView DGVBuscar;
        private System.Windows.Forms.ComboBox CmbBuscarGenero;
        private System.Windows.Forms.Panel PanelIzda;
        private System.Windows.Forms.Panel PanelBuscarIzda;
        private System.Windows.Forms.Button BtBuscarPorGenero;
        private System.Windows.Forms.Panel PanelBusquedaPorGenero;
        private System.Windows.Forms.Button BtEnviarPorGenero;
        private System.Windows.Forms.Panel PanelPorGenero;
        private System.Windows.Forms.Panel PanelPorNombre;
        private System.Windows.Forms.Button BtBuscarPorNombre;
        private System.Windows.Forms.Panel PanelBusquedaPorNombre;
        private System.Windows.Forms.TextBox TxNombrePeliculaBuscar;
        private System.Windows.Forms.Button BtEnviarPorNombre;
        private System.Windows.Forms.Panel PanelPorDias;
        private System.Windows.Forms.Button BtBuscarPorDias;
        private System.Windows.Forms.Panel PanelBusquedaPorDias;
        private System.Windows.Forms.NumericUpDown NumericBuscarDias;
        private System.Windows.Forms.Button BtEnviarPorDias;
        private System.Windows.Forms.Panel PanelEliminarIzda;
        private System.Windows.Forms.Button BtElim;
        private System.Windows.Forms.Panel PanelDcha;
    }
}