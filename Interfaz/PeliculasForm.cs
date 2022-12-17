using Interfaz.Utiles;
using Negocio;
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

        private void ActivarPanelesMostrarPeliculas() {
            PanelTablasPelis.Visible = true;
            PnAnadirPelicula.Visible = false;
            PanelBuscarIzda.Visible = false;
            PanelEliminarIzda.Visible = false;
        }

        private void ActivarPanelesBuscarPeliculas() {
            PanelTablasPelis.Visible = true;
            PnAnadirPelicula.Visible = false;
            PanelBuscarIzda.Visible = true;
            PanelEliminarIzda.Visible = false;
        }

        private void ActivarPanelesEliminarPeliculas() {
            PanelTablasPelis.Visible = true;
            PnAnadirPelicula.Visible = false;
            PanelBuscarIzda.Visible = false;
            PanelEliminarIzda.Visible = true;
        }

        private void ActivarPanelAnadirPelicula() {
            PanelTablasPelis.Visible = false;
            PnAnadirPelicula.Visible = true;
            PanelBuscarIzda.Visible = false;
            PanelEliminarIzda.Visible = false;
        }
        public PeliculasForm(ServicioDeVideoclub.VideoclubServicioClient vid) {
            InitializeComponent();
            this.vid = vid;
        }

        private async void BtMostrarPeliculas_Click(object sender, EventArgs e) {
            ActivarPanelesMostrarPeliculas();
            ServicioDeVideoclub.Pelicula[] peliculas = await vid.DevuelvePeliculasAsync();

            DGVPelis.DataSource = peliculas;
        }


        private void BtAnadirPelicula_Click(object sender, EventArgs e) {
            ActivarPanelAnadirPelicula();
            ComboBGeneros.DataSource = Generos.DevuelveGeneros();
        }
        private async void BtEnviarPeli_Click(object sender, EventArgs e) {
            string titulo = TxTitulo.Text;
            string genero = ComboBGeneros.SelectedItem.ToString();
            DateTime fecha = DateTFechaADic.Value;

            string texto = await vid.AnadePeliculaAsync(titulo, genero, fecha) ?
                "Se ha creado la pelicula con exito" : "No se ha podido crear la pelicula";

            MessageBox.Show(texto);

            TxTitulo.Text = "";
        }


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


        private void BtBuscarPelicula_Click(object sender, EventArgs e) {
            ActivarPanelesBuscarPeliculas();
            ControladorPaneles.DesactivarPanelBusqueda(PanelBuscarIzda.Controls);
            PanelBuscarIzda.Visible = true;

            CmbBuscarGenero.DataSource = Generos.DevuelveGeneros();
        }

        ///^????????????????
        /*private async void BtBuscarNovedades_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula[] novedades = await vid.DevuelvePeliculasNovedadesAsync();

            if (novedades.Length == 0)
                MessageBox.Show("No hay películas creadas hace menos de 7 días");
            else
                DGVPelis.DataSource = vid.DevuelvePeliculasNovedades();

        }*/

        private async void BtBuscarPorGenero_Click(object sender, EventArgs e) {
            CmbBuscarGenero.DataSource = await vid.DevuelveTiposPeliculasAsync();

            ControladorPaneles.ActivarPanelBusqueda(PanelPorGenero, PanelBuscarIzda.Controls);

        }
        private async void BtEnviarPorGenero_Click(object sender, EventArgs e) {
            string genero = CmbBuscarGenero.SelectedItem.ToString();
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorGeneroAsync(genero);

            ModificaTablaAMostrar(resultado);
        }


        private void BtBuscarPorNombre_Click(object sender, EventArgs e) {
            TxNombrePeliculaBuscar.Text = "";

            ControladorPaneles.ActivarPanelBusqueda(PanelPorNombre, PanelBuscarIzda.Controls);
        }
        private async void BtEnviarPorNombre_Click(object sender, EventArgs e) {
            string titulo = TxNombrePeliculaBuscar.Text;
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorNombreAsync(titulo);

            ModificaTablaAMostrar(resultado);
        }


        private void BtBuscarPorDias_Click(object sender, EventArgs e) {
            NumericBuscarDias.Value = 1;

            ControladorPaneles.ActivarPanelBusqueda(PanelPorDias, PanelBuscarIzda.Controls);
        }
        private async void BtEnviarPorDias_Click(object sender, EventArgs e) {
            int dias = (int)NumericBuscarDias.Value;
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorDiasAsync(dias);

            ModificaTablaAMostrar(resultado);
        }


        private void ModificaTablaAMostrar(ServicioDeVideoclub.Pelicula[] peliculasMostrar) {
            if (peliculasMostrar.Length == 0)
                MessageBox.Show("No hay películas que mostrar");
            else
                DGVPelis.DataSource = peliculasMostrar;
        }

    }
}
