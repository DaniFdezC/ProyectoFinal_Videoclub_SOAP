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

        public Task<bool> EliminarCliente(Cliente clienteAEliminar) {
            ClienteNegocio clienteMapeado = ConversorClases.ConversorClienteANegocio(clienteAEliminar);
            return videoclub.EliminarCliente(clienteMapeado);
        }
        public Task<bool> EliminarPelicula(Pelicula peliculaAEliminar) {
            PeliculaNegocio peliculaMapeada = ConversorClases.ConversorPeliculaANegocio(peliculaAEliminar);
            return videoclub.EliminarPelicula(peliculaMapeada);
        }

        public Cliente[] DevuelveClientes() {
            ClienteNegocio[] clientesSinMapear = videoclub.DevuelveClientes();
            return ConversorClases.ConversorClientesAServidor(clientesSinMapear);
        }
        public Pelicula[] DevuelvePeliculas() {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculas();

            return ConversorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }

        public Pelicula[] DevuelvePeliculasPorDias(int dias) {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorDias(dias);

            return ConversorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }
        public Pelicula[] DevuelvePeliculasPorGenero(string genero) {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorGenero(genero);

            return ConversorClases.ConversorPeliculasAServidor(peliculasSinMapear);

        }
        public Pelicula[] DevuelvePeliculasPorNombre(string nombre) {
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorNombre(nombre);

            return ConversorClases.ConversorPeliculasAServidor(peliculasSinMapear);
        }

        public string[] DevuelveTiposPeliculas() {
            return videoclub.TiposDePeliculas();
        }
        


    }
}
