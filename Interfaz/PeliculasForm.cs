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
        public PeliculasForm(ServicioDeVideoclub.VideoclubServicioClient vid) {
            InitializeComponent();
            //PanelBuscarIzda.Visible = false;
            //MuestraPanel(PnMostrar);
            this.vid = vid;
        }
        private async void BtMostrarPeliculas_Click(object sender, EventArgs e) {
            //PanelBuscarIzda.Visible = false;
            ServicioDeVideoclub.Pelicula[] peliculas = await vid.DevuelvePeliculasAsync();

            DGVPeliculas.DataSource = peliculas;
            

            //MuestraPanel(PnMostrar);
        }

        private void BtAnadirPelicula_Click(object sender, EventArgs e) {
            MuestraPanel(PnAnadirPelicula);
            ListBGenero.DataSource = Generos.DevuelveGeneros();
        }

        private async void BtEnviarPeli_Click(object sender, EventArgs e) {
            string titulo = TxTitulo.Text;
            string genero = ListBGenero.SelectedItem.ToString();
            DateTime fecha = DateTFechaADic.Value;

            string texto = await vid.AnadePeliculaAsync(titulo, genero, fecha) ?
                "Se ha creado la pelicula con exito" : "No se ha podido crear la pelicula";

            MessageBox.Show(texto);

            TxTitulo.Text = "";
        }

        private void MuestraPanel(Panel panelAMostrar) {
            foreach (Panel panel in this.Controls.OfType<Panel>()) {

                if (panel == panelAMostrar)
                    panel.Visible = true;

                else
                    panel.Visible = false;

            }
        }

        private async void BtEliminaPelicula_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula[] peliculas = await vid.DevuelvePeliculasAsync();

            DGVElimPeli.DataSource = peliculas;

            MuestraPanel(PnEliminar);
        }


        private void BtElim_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula peliculaAEliminar = (ServicioDeVideoclub.Pelicula)DGVElimPeli.SelectedRows[0].DataBoundItem;
            MessageBox.Show(peliculaAEliminar.Titulo + " " + peliculaAEliminar.Id);
            vid.EliminarPelicula(peliculaAEliminar);
            MessageBox.Show($"La pelicula {peliculaAEliminar.Titulo} {peliculaAEliminar.Id} ha sido eliminado con exito");
            DGVElimPeli.DataSource = vid.DevuelvePeliculas();
        }

        private void BtBuscarPelicula_Click(object sender, EventArgs e) {
            //MuestraPanel(PnBusqueda);
            PanelBuscarIzda.Visible = true;


            CmbBuscarGenero.DataSource = Generos.DevuelveGeneros();
        }

        private async void BtBuscarNovedades_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula[] novedades = await vid.DevuelvePeliculasNovedadesAsync();

            if (novedades.Length == 0)
                MessageBox.Show("No hay películas creadas hace menos de 7 días");
            else
                DGVBuscar.DataSource = vid.DevuelvePeliculasNovedades();

        }

        private async void BtBuscarPorGenero_Click(object sender, EventArgs e) {
            string genero = CmbBuscarGenero.SelectedItem.ToString();
            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorGeneroAsync(genero);

            if (resultado.Length == 0)
                MessageBox.Show("No hay películas registradas con ese género");
            else
                DGVBuscar.DataSource = resultado;

        }
    }
}
