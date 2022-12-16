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
            MuestraPanel(PnMostrar);
            this.vid = vid;
        }
        private void BtMostrarPeliculas_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula[] peliculas = vid.DevuelvePeliculas();

            DGVPeliculas.DataSource = peliculas;

            MuestraPanel(PnMostrar);
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

        private void BtEliminaPelicula_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Pelicula[] peliculas = vid.DevuelvePeliculas();

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
            MuestraPanel(PnBusqueda);

            ListBGeneroBuscar.DataSource = Generos.DevuelveGeneros();
        }

        private void BtBuscarNovedades_Click(object sender, EventArgs e) {
            DGVBuscar.DataSource = vid.DevuelvePeliculasNovedades();
        }
    }
}
