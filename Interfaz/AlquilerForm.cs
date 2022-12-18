using Interfaz.Utiles;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class AlquilerForm : Form {
        ServicioDeVideoclub.VideoclubServicioClient vid;
        Form formularioPrincipal;
        public AlquilerForm(ServicioDeVideoclub.VideoclubServicioClient vid, Form formularioPrincipal) {
            InitializeComponent();
            this.vid = vid;
            this.formularioPrincipal = formularioPrincipal;

            DGVPelis.DataSource = vid.DevuelvePeliculasSinAlquilar();
            DGVClientes.DataSource = vid.DevuelveClientes();
        }

        private void MuestraClientesPeliculas() {
            ControladorPaneles.ActivarDesactivar(P1_2_Centro_ClientesPeliculas, P1_1_Centro_Alquileres);
        }

        private void MuestraAlquileres() {
            ControladorPaneles.ActivarDesactivar(P1_1_Centro_Alquileres, P1_2_Centro_ClientesPeliculas);

        }

        private void EscondePanelesBusquedas() {
            ControladorPaneles.DesactivarPaneles(P2_1_BuscarAlquiler, P2_2_BuscarPeliculaNombre, P2_3_BuscarClienteNombre);
        }



        private async void BtMostrarPeliculas_Click(object sender, EventArgs e) {
            MuestraClientesPeliculas();
            EscondePanelesBusquedas();

            ServicioDeVideoclub.Pelicula[] peliculas = await vid.DevuelvePeliculasSinAlquilarAsync();

            DGVPelis.DataSource = peliculas;
        }

        private async void BtMostrarClientes_Click(object sender, EventArgs e) {
            MuestraClientesPeliculas();
            EscondePanelesBusquedas();

            ServicioDeVideoclub.Cliente[] clientes = await vid.DevuelveClientesAsync();

            DGVClientes.DataSource = clientes;
        }

        private void BtBuscarCliente_Click(object sender, EventArgs e) {
            ControladorPaneles.ActivarPanelDesactivarResto(P2_3_BuscarClienteNombre, P2_Izquierda.Controls);
        }

        private async void BtEnviarClientePorNombre_Click(object sender, EventArgs e) {
            string nombre = TxNombreClienteBuscar.Text;

            ServicioDeVideoclub.Cliente[] resultado = await vid.DevuelveClientesPorNombreAsync(nombre);

            DGVClientes.DataSource = resultado;

            TxNombreClienteBuscar.Text = "";
        }

        private void BtBuscarPelicula_Click(object sender, EventArgs e) {
            ControladorPaneles.ActivarPanelDesactivarResto(P2_2_BuscarPeliculaNombre, P2_Izquierda.Controls);
        }

        private async void BtEnviarPeliculaPorNombre_Click(object sender, EventArgs e) {
            string titulo = TxNombrePeliculaBuscar.Text;

            ServicioDeVideoclub.Pelicula[] resultado = await vid.DevuelvePeliculasPorNombreAsync(titulo);

            DGVPelis.DataSource = resultado;

            TxNombrePeliculaBuscar.Text = "";
        }

        private void BtMostrarAlquileresCliente_Click(object sender, EventArgs e) {
            MuestraAlquileres();
            ControladorPaneles.ActivarPanelDesactivarResto(P2_1_BuscarAlquiler, P2_Izquierda.Controls);

        }

        private async void BtEnviarAlquilerPorNombre_Click(object sender, EventArgs e) {
            string nombre = TxNombreClienteAlquilerBuscar.Text;

            ServicioDeVideoclub.Alquiler[] resultado = await vid.DevuelveAlquilerPorNombreAsync(nombre);

            DGVAlquileres.DataSource = resultado;

            TxNombreClienteAlquilerBuscar.Text = "";
        }

        private async void BtAlquilar_Click(object sender, EventArgs e) {
            if (DGVAlquileres == null || DGVPelis == null) {
                MessageBox.Show("Debes seleccionar primero película y clientes");
            } else {
                ServicioDeVideoclub.Cliente clienteAlquilar = (ServicioDeVideoclub.Cliente)DGVClientes.SelectedRows[0].DataBoundItem;
                ServicioDeVideoclub.Pelicula peliculaAlquilar = (ServicioDeVideoclub.Pelicula)DGVPelis.SelectedRows[0].DataBoundItem;

                DateTime fecha = DateTFechaAlquilar.Value;
                string texto = await vid.AlquilaPeliculaAsync(clienteAlquilar, peliculaAlquilar, fecha) ?
                    "Se ha registrado el alquiler con éxito" : "No se ha podido registrar el alquiler";

                MessageBox.Show(texto);

                DGVPelis.DataSource = await vid.DevuelvePeliculasSinAlquilarAsync();
            }
        }

        private async void BtDevolver_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Alquiler alquilerDevolver = (ServicioDeVideoclub.Alquiler)DGVAlquileres.SelectedRows[0].DataBoundItem;

            string texto = await vid.FinalizarAlquilerPeliculaAsync(alquilerDevolver) ?
                "Se ha devuelto la película con éxito" : "No se ha podido devolver la película";

            MessageBox.Show(texto);

        }

        private void BtVolver_Click(object sender, EventArgs e) {
            formularioPrincipal.Show();
            this.Close();
        }

    }
}
