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
            this.BtEliminaPelicula = new System.Windows.Forms.Button();
            this.BtAnadirPelicula = new System.Windows.Forms.Button();
            this.BtBuscarPelicula = new System.Windows.Forms.Button();
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
            this.BtElim = new System.Windows.Forms.Button();
            this.PnBusqueda = new System.Windows.Forms.Panel();
            this.ListBGeneroBuscar = new System.Windows.Forms.ListBox();
            this.BtBuscarPorGenero = new System.Windows.Forms.Button();
            this.BtBuscarNovedades = new System.Windows.Forms.Button();
            this.DGVBuscar = new System.Windows.Forms.DataGridView();
            this.BtMostrarPeliculas = new System.Windows.Forms.Button();
            this.PnAnadirPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).BeginInit();
            this.PnMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).BeginInit();
            this.PnEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVElimPeli)).BeginInit();
            this.PnBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtEliminaPelicula
            // 
            this.BtEliminaPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminaPelicula.Location = new System.Drawing.Point(3, 240);
            this.BtEliminaPelicula.Name = "BtEliminaPelicula";
            this.BtEliminaPelicula.Size = new System.Drawing.Size(290, 60);
            this.BtEliminaPelicula.TabIndex = 19;
            this.BtEliminaPelicula.Text = "Eliminar pelicula";
            this.BtEliminaPelicula.UseVisualStyleBackColor = true;
            this.BtEliminaPelicula.Click += new System.EventHandler(this.BtEliminaPelicula_Click);
            // 
            // BtAnadirPelicula
            // 
            this.BtAnadirPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAnadirPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAnadirPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAnadirPelicula.Location = new System.Drawing.Point(3, 140);
            this.BtAnadirPelicula.Name = "BtAnadirPelicula";
            this.BtAnadirPelicula.Size = new System.Drawing.Size(290, 60);
            this.BtAnadirPelicula.TabIndex = 18;
            this.BtAnadirPelicula.Text = "Añadir pelicula";
            this.BtAnadirPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAnadirPelicula.UseVisualStyleBackColor = true;
            this.BtAnadirPelicula.Click += new System.EventHandler(this.BtAnadirPelicula_Click);
            // 
            // BtBuscarPelicula
            // 
            this.BtBuscarPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPelicula.Location = new System.Drawing.Point(3, 340);
            this.BtBuscarPelicula.Name = "BtBuscarPelicula";
            this.BtBuscarPelicula.Size = new System.Drawing.Size(290, 60);
            this.BtBuscarPelicula.TabIndex = 20;
            this.BtBuscarPelicula.Text = "Buscar pelicula";
            this.BtBuscarPelicula.UseVisualStyleBackColor = true;
            this.BtBuscarPelicula.Click += new System.EventHandler(this.BtBuscarPelicula_Click);
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
            this.PnEliminar.Controls.Add(this.BtElim);
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
            // PnBusqueda
            // 
            this.PnBusqueda.Controls.Add(this.ListBGeneroBuscar);
            this.PnBusqueda.Controls.Add(this.BtBuscarPorGenero);
            this.PnBusqueda.Controls.Add(this.BtBuscarNovedades);
            this.PnBusqueda.Controls.Add(this.DGVBuscar);
            this.PnBusqueda.Location = new System.Drawing.Point(403, 27);
            this.PnBusqueda.Name = "PnBusqueda";
            this.PnBusqueda.Size = new System.Drawing.Size(653, 528);
            this.PnBusqueda.TabIndex = 24;
            // 
            // ListBGeneroBuscar
            // 
            this.ListBGeneroBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBGeneroBuscar.FormattingEnabled = true;
            this.ListBGeneroBuscar.ItemHeight = 25;
            this.ListBGeneroBuscar.Location = new System.Drawing.Point(507, 490);
            this.ListBGeneroBuscar.Name = "ListBGeneroBuscar";
            this.ListBGeneroBuscar.Size = new System.Drawing.Size(133, 29);
            this.ListBGeneroBuscar.Sorted = true;
            this.ListBGeneroBuscar.TabIndex = 25;
            // 
            // BtBuscarPorGenero
            // 
            this.BtBuscarPorGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarPorGenero.Location = new System.Drawing.Point(255, 461);
            this.BtBuscarPorGenero.Name = "BtBuscarPorGenero";
            this.BtBuscarPorGenero.Size = new System.Drawing.Size(246, 64);
            this.BtBuscarPorGenero.TabIndex = 4;
            this.BtBuscarPorGenero.Text = "Buscar por genero";
            this.BtBuscarPorGenero.UseVisualStyleBackColor = true;
            // 
            // BtBuscarNovedades
            // 
            this.BtBuscarNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarNovedades.Location = new System.Drawing.Point(3, 461);
            this.BtBuscarNovedades.Name = "BtBuscarNovedades";
            this.BtBuscarNovedades.Size = new System.Drawing.Size(246, 64);
            this.BtBuscarNovedades.TabIndex = 3;
            this.BtBuscarNovedades.Text = "Buscar novedades";
            this.BtBuscarNovedades.UseVisualStyleBackColor = true;
            this.BtBuscarNovedades.Click += new System.EventHandler(this.BtBuscarNovedades_Click);
            // 
            // DGVBuscar
            // 
            this.DGVBuscar.AllowUserToAddRows = false;
            this.DGVBuscar.AllowUserToDeleteRows = false;
            this.DGVBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscar.Location = new System.Drawing.Point(0, 0);
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
            this.BtMostrarPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMostrarPeliculas.Location = new System.Drawing.Point(3, 40);
            this.BtMostrarPeliculas.Name = "BtMostrarPeliculas";
            this.BtMostrarPeliculas.Size = new System.Drawing.Size(290, 60);
            this.BtMostrarPeliculas.TabIndex = 1;
            this.BtMostrarPeliculas.Text = "Mostrar peliculas";
            this.BtMostrarPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtMostrarPeliculas.UseVisualStyleBackColor = true;
            this.BtMostrarPeliculas.Click += new System.EventHandler(this.BtMostrarPeliculas_Click);
            // 
            // PeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.PnBusqueda);
            this.Controls.Add(this.PnEliminar);
            this.Controls.Add(this.PnMostrar);
            this.Controls.Add(this.PnAnadirPelicula);
            this.Controls.Add(this.BtBuscarPelicula);
            this.Controls.Add(this.BtEliminaPelicula);
            this.Controls.Add(this.BtAnadirPelicula);
            this.Controls.Add(this.BtMostrarPeliculas);
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
        private System.Windows.Forms.Button BtElim;
        private System.Windows.Forms.Panel PnBusqueda;
        private System.Windows.Forms.DataGridView DGVBuscar;
        private System.Windows.Forms.Button BtBuscarPorGenero;
        private System.Windows.Forms.Button BtBuscarNovedades;
        private System.Windows.Forms.ListBox ListBGeneroBuscar;
    }
}