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
            this.ComboBGeneros = new System.Windows.Forms.ComboBox();
            this.NumYear = new System.Windows.Forms.NumericUpDown();
            this.DateTFechaADic = new System.Windows.Forms.DateTimePicker();
            this.BtEnviarPeli = new System.Windows.Forms.Button();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblTituloPeli = new System.Windows.Forms.Label();
            this.TxTitulo = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblFechaAnadido = new System.Windows.Forms.Label();
            this.BtMostrarPeliculas = new System.Windows.Forms.Button();
            this.CmbBuscarGenero = new System.Windows.Forms.ComboBox();
            this.PanelIzda = new System.Windows.Forms.Panel();
            this.PanelBuscarIzda = new System.Windows.Forms.Panel();
            this.PanelPorDias = new System.Windows.Forms.Panel();
            this.NumericBuscarDias = new System.Windows.Forms.NumericUpDown();
            this.BtEnviarPorDias = new System.Windows.Forms.Button();
            this.BtBuscarPorDias = new System.Windows.Forms.Button();
            this.PanelPorNombre = new System.Windows.Forms.Panel();
            this.TxNombrePeliculaBuscar = new System.Windows.Forms.TextBox();
            this.BtEnviarPorNombre = new System.Windows.Forms.Button();
            this.BtBuscarPorNombre = new System.Windows.Forms.Button();
            this.PanelPorGenero = new System.Windows.Forms.Panel();
            this.BtEnviarPorGenero = new System.Windows.Forms.Button();
            this.BtBuscarPorGenero = new System.Windows.Forms.Button();
            this.BtBuscarPelicula = new System.Windows.Forms.Button();
            this.PanelEliminarIzda = new System.Windows.Forms.Panel();
            this.BtEnviarEliminar = new System.Windows.Forms.Button();
            this.BtEliminaPelicula = new System.Windows.Forms.Button();
            this.BtAnadirPelicula = new System.Windows.Forms.Button();
            this.PanelDcha = new System.Windows.Forms.Panel();
            this.PanelTablasPelis = new System.Windows.Forms.Panel();
            this.DGVPelis = new System.Windows.Forms.DataGridView();
            this.PanelArriba = new System.Windows.Forms.Panel();
            this.BtVolver = new System.Windows.Forms.Button();
            this.LabelGestion = new System.Windows.Forms.Label();
            this.PnAnadirPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).BeginInit();
            this.PanelIzda.SuspendLayout();
            this.PanelBuscarIzda.SuspendLayout();
            this.PanelPorDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBuscarDias)).BeginInit();
            this.PanelPorNombre.SuspendLayout();
            this.PanelPorGenero.SuspendLayout();
            this.PanelEliminarIzda.SuspendLayout();
            this.PanelDcha.SuspendLayout();
            this.PanelTablasPelis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelis)).BeginInit();
            this.PanelArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnAnadirPelicula
            // 
            this.PnAnadirPelicula.Controls.Add(this.ComboBGeneros);
            this.PnAnadirPelicula.Controls.Add(this.NumYear);
            this.PnAnadirPelicula.Controls.Add(this.DateTFechaADic);
            this.PnAnadirPelicula.Controls.Add(this.BtEnviarPeli);
            this.PnAnadirPelicula.Controls.Add(this.LblYear);
            this.PnAnadirPelicula.Controls.Add(this.LblTituloPeli);
            this.PnAnadirPelicula.Controls.Add(this.TxTitulo);
            this.PnAnadirPelicula.Controls.Add(this.LblGenero);
            this.PnAnadirPelicula.Controls.Add(this.LblFechaAnadido);
            this.PnAnadirPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnAnadirPelicula.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnAnadirPelicula.Location = new System.Drawing.Point(0, 0);
            this.PnAnadirPelicula.Name = "PnAnadirPelicula";
            this.PnAnadirPelicula.Size = new System.Drawing.Size(840, 607);
            this.PnAnadirPelicula.TabIndex = 21;
            this.PnAnadirPelicula.Visible = false;
            // 
            // ComboBGeneros
            // 
            this.ComboBGeneros.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBGeneros.ForeColor = System.Drawing.Color.Black;
            this.ComboBGeneros.FormattingEnabled = true;
            this.ComboBGeneros.Location = new System.Drawing.Point(8, 126);
            this.ComboBGeneros.Name = "ComboBGeneros";
            this.ComboBGeneros.Size = new System.Drawing.Size(231, 32);
            this.ComboBGeneros.TabIndex = 24;
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
            this.BtEnviarPeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPeli.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPeli.Location = new System.Drawing.Point(647, 480);
            this.BtEnviarPeli.Name = "BtEnviarPeli";
            this.BtEnviarPeli.Size = new System.Drawing.Size(159, 61);
            this.BtEnviarPeli.TabIndex = 17;
            this.BtEnviarPeli.Text = "Enviar";
            this.BtEnviarPeli.UseVisualStyleBackColor = false;
            this.BtEnviarPeli.Click += new System.EventHandler(this.BtEnviarPeli_Click);
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(3, 188);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(54, 28);
            this.LblYear.TabIndex = 9;
            this.LblYear.Text = "Año";
            // 
            // LblTituloPeli
            // 
            this.LblTituloPeli.AutoSize = true;
            this.LblTituloPeli.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPeli.Location = new System.Drawing.Point(3, 11);
            this.LblTituloPeli.Name = "LblTituloPeli";
            this.LblTituloPeli.Size = new System.Drawing.Size(75, 28);
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
            this.LblGenero.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(3, 95);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(90, 28);
            this.LblGenero.TabIndex = 8;
            this.LblGenero.Text = "Genero";
            // 
            // LblFechaAnadido
            // 
            this.LblFechaAnadido.AutoSize = true;
            this.LblFechaAnadido.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAnadido.Location = new System.Drawing.Point(3, 286);
            this.LblFechaAnadido.Name = "LblFechaAnadido";
            this.LblFechaAnadido.Size = new System.Drawing.Size(162, 28);
            this.LblFechaAnadido.TabIndex = 11;
            this.LblFechaAnadido.Text = "Fecha adición";
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
            this.BtMostrarPeliculas.Size = new System.Drawing.Size(342, 60);
            this.BtMostrarPeliculas.TabIndex = 1;
            this.BtMostrarPeliculas.Text = "Mostrar peliculas";
            this.BtMostrarPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarPeliculas.UseVisualStyleBackColor = true;
            this.BtMostrarPeliculas.Click += new System.EventHandler(this.BtMostrarPeliculas_Click);
            // 
            // CmbBuscarGenero
            // 
            this.CmbBuscarGenero.BackColor = System.Drawing.Color.White;
            this.CmbBuscarGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbBuscarGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBuscarGenero.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBuscarGenero.ForeColor = System.Drawing.Color.Black;
            this.CmbBuscarGenero.FormattingEnabled = true;
            this.CmbBuscarGenero.Location = new System.Drawing.Point(0, 0);
            this.CmbBuscarGenero.Name = "CmbBuscarGenero";
            this.CmbBuscarGenero.Size = new System.Drawing.Size(267, 32);
            this.CmbBuscarGenero.TabIndex = 26;
            // 
            // PanelIzda
            // 
            this.PanelIzda.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelIzda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelIzda.Controls.Add(this.PanelBuscarIzda);
            this.PanelIzda.Controls.Add(this.BtBuscarPelicula);
            this.PanelIzda.Controls.Add(this.PanelEliminarIzda);
            this.PanelIzda.Controls.Add(this.BtEliminaPelicula);
            this.PanelIzda.Controls.Add(this.BtAnadirPelicula);
            this.PanelIzda.Controls.Add(this.BtMostrarPeliculas);
            this.PanelIzda.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzda.Location = new System.Drawing.Point(0, 46);
            this.PanelIzda.Name = "PanelIzda";
            this.PanelIzda.Size = new System.Drawing.Size(342, 607);
            this.PanelIzda.TabIndex = 26;
            // 
            // PanelBuscarIzda
            // 
            this.PanelBuscarIzda.Controls.Add(this.PanelPorDias);
            this.PanelBuscarIzda.Controls.Add(this.BtBuscarPorDias);
            this.PanelBuscarIzda.Controls.Add(this.PanelPorNombre);
            this.PanelBuscarIzda.Controls.Add(this.BtBuscarPorNombre);
            this.PanelBuscarIzda.Controls.Add(this.PanelPorGenero);
            this.PanelBuscarIzda.Controls.Add(this.BtBuscarPorGenero);
            this.PanelBuscarIzda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBuscarIzda.Location = new System.Drawing.Point(0, 274);
            this.PanelBuscarIzda.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBuscarIzda.Name = "PanelBuscarIzda";
            this.PanelBuscarIzda.Size = new System.Drawing.Size(342, 311);
            this.PanelBuscarIzda.TabIndex = 22;
            this.PanelBuscarIzda.Visible = false;
            // 
            // PanelPorDias
            // 
            this.PanelPorDias.Controls.Add(this.NumericBuscarDias);
            this.PanelPorDias.Controls.Add(this.BtEnviarPorDias);
            this.PanelPorDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorDias.Location = new System.Drawing.Point(0, 182);
            this.PanelPorDias.Name = "PanelPorDias";
            this.PanelPorDias.Size = new System.Drawing.Size(342, 34);
            this.PanelPorDias.TabIndex = 35;
            this.PanelPorDias.Visible = false;
            // 
            // NumericBuscarDias
            // 
            this.NumericBuscarDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericBuscarDias.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericBuscarDias.InterceptArrowKeys = false;
            this.NumericBuscarDias.Location = new System.Drawing.Point(0, 0);
            this.NumericBuscarDias.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.NumericBuscarDias.Name = "NumericBuscarDias";
            this.NumericBuscarDias.Size = new System.Drawing.Size(267, 31);
            this.NumericBuscarDias.TabIndex = 29;
            this.NumericBuscarDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericBuscarDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtEnviarPorDias
            // 
            this.BtEnviarPorDias.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtEnviarPorDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPorDias.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPorDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPorDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPorDias.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPorDias.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPorDias.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarPorDias.Name = "BtEnviarPorDias";
            this.BtEnviarPorDias.Size = new System.Drawing.Size(75, 34);
            this.BtEnviarPorDias.TabIndex = 28;
            this.BtEnviarPorDias.Text = "Enviar";
            this.BtEnviarPorDias.UseVisualStyleBackColor = false;
            this.BtEnviarPorDias.Click += new System.EventHandler(this.BtEnviarPorDias_Click);
            // 
            // BtBuscarPorDias
            // 
            this.BtBuscarPorDias.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtBuscarPorDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorDias.FlatAppearance.BorderSize = 0;
            this.BtBuscarPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPorDias.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPorDias.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPorDias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPorDias.Location = new System.Drawing.Point(0, 144);
            this.BtBuscarPorDias.Name = "BtBuscarPorDias";
            this.BtBuscarPorDias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtBuscarPorDias.Size = new System.Drawing.Size(342, 38);
            this.BtBuscarPorDias.TabIndex = 27;
            this.BtBuscarPorDias.Text = "Por dias";
            this.BtBuscarPorDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPorDias.UseVisualStyleBackColor = false;
            this.BtBuscarPorDias.Click += new System.EventHandler(this.BtBuscarPorDias_Click);
            // 
            // PanelPorNombre
            // 
            this.PanelPorNombre.Controls.Add(this.TxNombrePeliculaBuscar);
            this.PanelPorNombre.Controls.Add(this.BtEnviarPorNombre);
            this.PanelPorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorNombre.Location = new System.Drawing.Point(0, 110);
            this.PanelPorNombre.Name = "PanelPorNombre";
            this.PanelPorNombre.Size = new System.Drawing.Size(342, 34);
            this.PanelPorNombre.TabIndex = 34;
            this.PanelPorNombre.Visible = false;
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
            // BtEnviarPorNombre
            // 
            this.BtEnviarPorNombre.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.BtBuscarPorNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtBuscarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorNombre.FlatAppearance.BorderSize = 0;
            this.BtBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscarPorNombre.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPorNombre.ForeColor = System.Drawing.Color.White;
            this.BtBuscarPorNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBuscarPorNombre.Location = new System.Drawing.Point(0, 72);
            this.BtBuscarPorNombre.Name = "BtBuscarPorNombre";
            this.BtBuscarPorNombre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtBuscarPorNombre.Size = new System.Drawing.Size(342, 38);
            this.BtBuscarPorNombre.TabIndex = 27;
            this.BtBuscarPorNombre.Text = "Por nombre";
            this.BtBuscarPorNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBuscarPorNombre.UseVisualStyleBackColor = false;
            this.BtBuscarPorNombre.Click += new System.EventHandler(this.BtBuscarPorNombre_Click);
            // 
            // PanelPorGenero
            // 
            this.PanelPorGenero.Controls.Add(this.CmbBuscarGenero);
            this.PanelPorGenero.Controls.Add(this.BtEnviarPorGenero);
            this.PanelPorGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPorGenero.Location = new System.Drawing.Point(0, 38);
            this.PanelPorGenero.Name = "PanelPorGenero";
            this.PanelPorGenero.Size = new System.Drawing.Size(342, 34);
            this.PanelPorGenero.TabIndex = 33;
            this.PanelPorGenero.Visible = false;
            // 
            // BtEnviarPorGenero
            // 
            this.BtEnviarPorGenero.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtEnviarPorGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtEnviarPorGenero.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtEnviarPorGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPorGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtEnviarPorGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviarPorGenero.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnviarPorGenero.ForeColor = System.Drawing.Color.White;
            this.BtEnviarPorGenero.Location = new System.Drawing.Point(267, 0);
            this.BtEnviarPorGenero.Name = "BtEnviarPorGenero";
            this.BtEnviarPorGenero.Size = new System.Drawing.Size(75, 34);
            this.BtEnviarPorGenero.TabIndex = 28;
            this.BtEnviarPorGenero.Text = "Enviar";
            this.BtEnviarPorGenero.UseVisualStyleBackColor = false;
            this.BtEnviarPorGenero.Click += new System.EventHandler(this.BtEnviarPorGenero_Click);
            // 
            // BtBuscarPorGenero
            // 
            this.BtBuscarPorGenero.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtBuscarPorGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPorGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPorGenero.FlatAppearance.BorderSize = 0;
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
            this.BtBuscarPorGenero.Click += new System.EventHandler(this.BtBuscarPorGenero_Click);
            // 
            // BtBuscarPelicula
            // 
            this.BtBuscarPelicula.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtBuscarPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtBuscarPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtBuscarPelicula.FlatAppearance.BorderSize = 0;
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
            this.BtEnviarEliminar.BackColor = System.Drawing.Color.RoyalBlue;
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
            // PanelDcha
            // 
            this.PanelDcha.BackColor = System.Drawing.Color.Lavender;
            this.PanelDcha.Controls.Add(this.PanelTablasPelis);
            this.PanelDcha.Controls.Add(this.PnAnadirPelicula);
            this.PanelDcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDcha.Location = new System.Drawing.Point(342, 46);
            this.PanelDcha.Name = "PanelDcha";
            this.PanelDcha.Size = new System.Drawing.Size(840, 607);
            this.PanelDcha.TabIndex = 27;
            // 
            // PanelTablasPelis
            // 
            this.PanelTablasPelis.Controls.Add(this.DGVPelis);
            this.PanelTablasPelis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTablasPelis.Location = new System.Drawing.Point(0, 0);
            this.PanelTablasPelis.Name = "PanelTablasPelis";
            this.PanelTablasPelis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PanelTablasPelis.Size = new System.Drawing.Size(840, 607);
            this.PanelTablasPelis.TabIndex = 22;
            this.PanelTablasPelis.Visible = false;
            // 
            // DGVPelis
            // 
            this.DGVPelis.AllowUserToAddRows = false;
            this.DGVPelis.AllowUserToDeleteRows = false;
            this.DGVPelis.AllowUserToResizeRows = false;
            this.DGVPelis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVPelis.BackgroundColor = System.Drawing.Color.Lavender;
            this.DGVPelis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPelis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPelis.Location = new System.Drawing.Point(10, 0);
            this.DGVPelis.Name = "DGVPelis";
            this.DGVPelis.ReadOnly = true;
            this.DGVPelis.RowHeadersVisible = false;
            this.DGVPelis.RowHeadersWidth = 51;
            this.DGVPelis.RowTemplate.Height = 24;
            this.DGVPelis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPelis.Size = new System.Drawing.Size(830, 607);
            this.DGVPelis.TabIndex = 2;
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.Blue;
            this.PanelArriba.Controls.Add(this.BtVolver);
            this.PanelArriba.Controls.Add(this.LabelGestion);
            this.PanelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArriba.Location = new System.Drawing.Point(0, 0);
            this.PanelArriba.Name = "PanelArriba";
            this.PanelArriba.Size = new System.Drawing.Size(1182, 46);
            this.PanelArriba.TabIndex = 28;
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
            this.BtVolver.TabIndex = 1;
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
            this.LabelGestion.Size = new System.Drawing.Size(319, 38);
            this.LabelGestion.TabIndex = 0;
            this.LabelGestion.Text = "Gestión de películas";
            this.LabelGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PanelDcha);
            this.Controls.Add(this.PanelIzda);
            this.Controls.Add(this.PanelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PeliculasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeliculasForm";
            this.PnAnadirPelicula.ResumeLayout(false);
            this.PnAnadirPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).EndInit();
            this.PanelIzda.ResumeLayout(false);
            this.PanelBuscarIzda.ResumeLayout(false);
            this.PanelPorDias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericBuscarDias)).EndInit();
            this.PanelPorNombre.ResumeLayout(false);
            this.PanelPorNombre.PerformLayout();
            this.PanelPorGenero.ResumeLayout(false);
            this.PanelEliminarIzda.ResumeLayout(false);
            this.PanelDcha.ResumeLayout(false);
            this.PanelTablasPelis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelis)).EndInit();
            this.PanelArriba.ResumeLayout(false);
            this.PanelArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtMostrarPeliculas;
        private System.Windows.Forms.Button BtEliminaPelicula;
        private System.Windows.Forms.Button BtAnadirPelicula;
        private System.Windows.Forms.Button BtBuscarPelicula;
        private System.Windows.Forms.Panel PnAnadirPelicula;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblTituloPeli;
        private System.Windows.Forms.TextBox TxTitulo;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblFechaAnadido;
        private System.Windows.Forms.DateTimePicker DateTFechaADic;
        private System.Windows.Forms.NumericUpDown NumYear;
        private System.Windows.Forms.ComboBox CmbBuscarGenero;
        private System.Windows.Forms.Panel PanelIzda;
        private System.Windows.Forms.Panel PanelBuscarIzda;
        private System.Windows.Forms.Button BtBuscarPorGenero;
        private System.Windows.Forms.Button BtEnviarPorGenero;
        private System.Windows.Forms.Panel PanelPorGenero;
        private System.Windows.Forms.Panel PanelPorNombre;
        private System.Windows.Forms.Button BtBuscarPorNombre;
        private System.Windows.Forms.TextBox TxNombrePeliculaBuscar;
        private System.Windows.Forms.Button BtEnviarPorNombre;
        private System.Windows.Forms.Panel PanelPorDias;
        private System.Windows.Forms.Button BtBuscarPorDias;
        private System.Windows.Forms.NumericUpDown NumericBuscarDias;
        private System.Windows.Forms.Button BtEnviarPorDias;
        private System.Windows.Forms.Panel PanelEliminarIzda;
        private System.Windows.Forms.Button BtEnviarEliminar;
        private System.Windows.Forms.Panel PanelDcha;
        private System.Windows.Forms.DataGridView DGVPelis;
        private System.Windows.Forms.ComboBox ComboBGeneros;
        private System.Windows.Forms.Panel PanelArriba;
        private System.Windows.Forms.Button BtEnviarPeli;
        private System.Windows.Forms.Panel PanelTablasPelis;
        private System.Windows.Forms.Label LabelGestion;
        private System.Windows.Forms.Button BtVolver;
    }
}