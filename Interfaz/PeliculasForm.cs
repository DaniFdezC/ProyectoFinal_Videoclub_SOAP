using Interfaz.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class PeliculasForm : Form {
        ServicioDeVideoclub.VideoclubServicioClient vid;
        Form formularioPrincipal;

        public PeliculasForm(ServicioDeVideoclub.VideoclubServicioClient vid, Form formularioPrincipal) {
            InitializeComponent();
            this.vid = vid;
            this.formularioPrincipal = formularioPrincipal;
        }

        // Mostrar peliculas
        private async void BtMostrarPeliculas_Click(object sender, EventArgs e) {
            ActivarPanelesMostrarPeliculas();

            ServicioDeVideoclub.Pelicula[] peliculas = await vid.DevuelvePeliculasAsync();

            DGVPelis.DataSource = peliculas;
        }

        // Añadir peliculas
        private async void BtAnadirPelicula_Click(object sender, EventArgs e) {
            ActivarPanelAnadirPelicula();

            ComboBGeneros.DataSource = await vid.DevuelveTiposPeliculasAsync();
        }
        private async void BtEnviarPeli_Click(object sender, EventArgs e) {
            string titulo = TxTitulo.Text;
            string genero = ComboBGeneros.SelectedItem.ToString();
            DateTime fecha = DateTFechaADic.Value;

            string texto = await vid.AnadePeliculaAsync(titulo, genero, fecha) ?
                "Se ha creado la película conéexito" : "No se ha podido crear la película";

            MessageBox.Show(texto);

            TxTitulo.Text = "";
        }

        // Eliminar peliculas
        private async void BtEliminaPelicula_Click(object sender, EventArgs e) {
            ActivarPanelesEliminarPeliculas();

            ServicioDeVideoclub.Pelicula[] peliculas = await vid.DevuelvePeliculasAsync();

            DGVPelis.DataSource = peliculas;
        }
        private void BtEnviarEliminar_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula peliculaAEliminar = (ServicioDeVideoclub.Pelicula)DGVPelis.SelectedRows[0].DataBoundItem;
            vid.EliminarPelicula(peliculaAEliminar);
            MessageBox.Show($"La pelicula {peliculaAEliminar.Titulo} {peliculaAEliminar.Id} ha sido eliminado con exito");
            DGVPelis.DataSource = vid.DevuelvePeliculas();
        }

        // Buscar peliculas
        private async void BtBuscarPelicula_Click(object sender, EventArgs e) {
            ActivarPanelesBuscarPeliculas();

            PanelBuscarIzda.Visible = true;

            CmbBuscarGenero.DataSource = await vid.DevuelveTiposPeliculasAsync();
        }

                // Genero
        private async void BtBuscarPorGenero_Click(object sender, EventArgs e) {
            CmbBuscarGenero.DataSource = await vid.DevuelveTiposPeliculasAsync();

            ControladorPaneles.ActivarPanelDesactivarResto(PanelPorGenero, PanelBuscarIzda.Controls);

        }
        private async void BtEnviarPorGenero_Click(object sender, EventArgs e) {
            string genero = CmbBuscarGenero.SelectedItem.ToString();
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorGeneroAsync(genero);

            ModificaTablaAMostrar(resultado);
        }

                // Nombre
        private void BtBuscarPorNombre_Click(object sender, EventArgs e) {
            TxNombrePeliculaBuscar.Text = "";

            ControladorPaneles.ActivarPanelDesactivarResto(PanelPorNombre, PanelBuscarIzda.Controls);
        }
        private async void BtEnviarPorNombre_Click(object sender, EventArgs e) {
            string titulo = TxNombrePeliculaBuscar.Text;
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorNombreAsync(titulo);

            ModificaTablaAMostrar(resultado);
        }

                // Dias
        private void BtBuscarPorDias_Click(object sender, EventArgs e) {
            NumericBuscarDias.Value = 1;

            ControladorPaneles.ActivarPanelDesactivarResto(PanelPorDias, PanelBuscarIzda.Controls);
        }
        private async void BtEnviarPorDias_Click(object sender, EventArgs e) {
            int dias = (int)NumericBuscarDias.Value;
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorDiasAsync(dias);

            ModificaTablaAMostrar(resultado);
        }


        // Extras
        private void ModificaTablaAMostrar(ServicioDeVideoclub.Pelicula[] peliculasMostrar) {
            if (peliculasMostrar.Length == 0)
                MessageBox.Show("No hay películas que mostrar");
            else
                DGVPelis.DataSource = peliculasMostrar;
        }

        // Formulario principal

        private void BtVolver_Click(object sender, EventArgs e) {
            formularioPrincipal.Show();
            this.Close();
        }


        // Extras visuales para los paneles
        private void ActivarPanelesMostrarPeliculas() {
            ControladorPaneles.ActivarDesactivar(PanelTablasPelis, PnAnadirPelicula);
            ControladorPaneles.DesactivarPaneles(PanelBuscarIzda, PanelEliminarIzda);
        }

        private void ActivarPanelesBuscarPeliculas() {
            ControladorPaneles.ActivarDesactivar(PanelTablasPelis, PnAnadirPelicula);
            ControladorPaneles.ActivarDesactivar(PanelBuscarIzda, PanelEliminarIzda);
            ControladorPaneles.DesactivarTodosPaneles(PanelBuscarIzda.Controls);
        }

        private void ActivarPanelesEliminarPeliculas() {
            ControladorPaneles.ActivarDesactivar(PanelTablasPelis, PnAnadirPelicula);
            ControladorPaneles.ActivarDesactivar(PanelEliminarIzda, PanelBuscarIzda);
        }

        private void ActivarPanelAnadirPelicula() {
            ControladorPaneles.ActivarDesactivar(PnAnadirPelicula, PanelTablasPelis);
            ControladorPaneles.DesactivarPaneles(PanelEliminarIzda, PanelBuscarIzda);
        }



    }
}
