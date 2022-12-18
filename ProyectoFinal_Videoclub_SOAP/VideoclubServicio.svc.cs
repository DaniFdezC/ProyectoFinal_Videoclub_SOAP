using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVideoClub {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VideoclubServicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VideoclubServicio.svc or VideoclubServicio.svc.cs at the Solution Explorer and start debugging.
    public class VideoclubServicio : IVideoclubServicio {
        static Videoclub videoclub = new Videoclub();

        public Task<bool> AnadeCliente(string nombre, string apellido, string direccion, string dni) {
            return videoclub.AnadeCliente(nombre, apellido, direccion, dni);
        }
        public Task<bool> AnadePelicula(string titulo, string genero, DateTime fecha) {
            return videoclub.AnadePelicula(titulo, genero, fecha);
        }


        public Task<bool> AlquilaPelicula(Cliente cliente, Pelicula pelicula, DateTime fecha) {
            ClienteNegocio clienteMapeado = MapeadorClases.ConversorClienteANegocio(cliente);
            PeliculaNegocio peliculaMapeada = MapeadorClases.ConversorPeliculaANegocio(pelicula);

            return videoclub.AlquilarPelicula(clienteMapeado, peliculaMapeada, fecha);
        }


        public Task<bool> EliminarCliente(Cliente clienteAEliminar) {
            ClienteNegocio clienteMapeado = MapeadorClases.ConversorClienteANegocio(clienteAEliminar);
            return videoclub.EliminarCliente(clienteMapeado);
        }
        public Task<bool> EliminarPelicula(Pelicula peliculaAEliminar) {
            PeliculaNegocio peliculaMapeada = MapeadorClases.ConversorPeliculaANegocio(peliculaAEliminar);
            return videoclub.EliminarPelicula(peliculaMapeada);
        }


        public Cliente[] DevuelveClientes() {
            ClienteNegocio[] clientesSinMapear = videoclub.DevuelveClientes();
            return MapeadorClases.ConversorClientesAServidor(clientesSinMapear);
        }
        public Pelicula[] DevuelvePeliculas() {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculas();

            return MapeadorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }


        public Pelicula[] DevuelvePeliculasPorDias(int dias) {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorDias(dias);

            return MapeadorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }
        public Pelicula[] DevuelvePeliculasPorGenero(string genero) {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorGenero(genero);

            return MapeadorClases.ConversorPeliculasAServidor(peliculasSinMapear);

        }
        public Pelicula[] DevuelvePeliculasPorNombre(string nombre) {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorNombre(nombre);

            return MapeadorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }


        public Cliente[] DevuelveClientesPorNombre(string nombre) {
            ClienteNegocio[] clientesSinMapear = videoclub.DevuelveClientesPorNombre(nombre);

            return MapeadorClases.ConversorClientesAServidor(clientesSinMapear);
        }

        public Pelicula[] DevuelvePeliculasSinAlquilar() {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasSinAlquilar();

            return MapeadorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }
        public Task<bool> FinalizarAlquilerPelicula(Alquiler alquiler) {
            AlquilerNegocio alquilerMapeado = MapeadorClases.ConversorAlquilerANegocio(alquiler);

            return videoclub.FinalizarAlquilerPelicula(alquilerMapeado);
        }


        public Alquiler[] DevuelveAlquilerPorNombre(string nombre) {
            AlquilerNegocio[] alquileresSinMapear = videoclub.DevuelveAlquilerPorNombre(nombre);

            return MapeadorClases.ConversorAlquileresAServidor(alquileresSinMapear);
        }

        public string[] DevuelveTiposPeliculas() {
            return videoclub.TiposDePeliculas();
        }

        public void IniciarPrimeraConexion() {
            videoclub.IniciarPrimeraConexion();
        }

    }
}
