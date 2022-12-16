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

        public void EliminarCliente(Cliente clienteAEliminar) {
            ClienteNegocio clienteMapeado = ConversorClases.ConversorClienteANegocio(clienteAEliminar);
            videoclub.EliminarCliente(clienteMapeado);
        }

        public void EliminarPelicula(Pelicula peliculaAEliminar) {
            PeliculaNegocio peliculaMapeada = ConversorClases.ConversorPeliculaANegocio(peliculaAEliminar);
            videoclub.EliminarPelicula(peliculaMapeada);
        }
        public Cliente[] DevuelveClientes() {
            List<Cliente> clientesMapeados = new List<Cliente>();
            ClienteNegocio[] clientesSinMapear = videoclub.DevuelveClientes();

            foreach(ClienteNegocio clNegocio in clientesSinMapear) {
                clientesMapeados.Add(ConversorClases.ConversorClienteAServidor(clNegocio));
            }

            return clientesMapeados.ToArray();
        }

        public Pelicula[] DevuelvePeliculas() {
            List<Pelicula> peliculasMapeadas = new List<Pelicula>();
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculas();

            foreach (PeliculaNegocio peliNegocio in peliculasSinMapear) {
                peliculasMapeadas.Add(ConversorClases.ConversorPeliculaAServidor(peliNegocio));
            }

            return peliculasMapeadas.ToArray();
        }

        public Pelicula[] DevuelvePeliculasNovedades() {
            List<Pelicula> peliculasMapeadas = new List<Pelicula>();
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasNovedades();

            foreach (PeliculaNegocio peliNegocio in peliculasSinMapear) {
                peliculasMapeadas.Add(ConversorClases.ConversorPeliculaAServidor(peliNegocio));
            }

            return peliculasMapeadas.ToArray();
        }

        public Pelicula[] DevuelvePeliculasPorGenero(string genero) {
            List<Pelicula> peliculasMapeadas = new List<Pelicula>();
            PeliculaNegocio[] peliculasSinMapear = videoclub.DevuelvePeliculasPorGenero(genero);

            foreach (PeliculaNegocio peliNegocio in peliculasSinMapear) {
                peliculasMapeadas.Add(ConversorClases.ConversorPeliculaAServidor(peliNegocio));
            }

            return peliculasMapeadas.ToArray();
        }


        public Task<bool> AnadePelicula(string titulo, string genero, DateTime fecha) {
            return videoclub.AnadePelicula(titulo, genero, fecha);
        }


    }
}
