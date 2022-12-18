using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioVideoClub {
    public static class MapeadorClases {

        public static Negocio.PeliculaNegocio[] ConversorPeliculasANegocio(ServicioVideoClub.Pelicula[] peliculasSinMapear) {
            List<PeliculaNegocio> peliculasMapeadas = new List<PeliculaNegocio>();

            foreach (Pelicula peli in peliculasSinMapear) {
                peliculasMapeadas.Add(ConversorPeliculaANegocio(peli));
            }

            return peliculasMapeadas.ToArray();
        }
        public static ServicioVideoClub.Pelicula[] ConversorPeliculasAServidor(Negocio.PeliculaNegocio[] peliculasSinMapear) {
            List<Pelicula> peliculasMapeadas = new List<Pelicula>();

            foreach (PeliculaNegocio peli in peliculasSinMapear) {
                peliculasMapeadas.Add(ConversorPeliculaAServidor(peli));
            }

            return peliculasMapeadas.ToArray();
        }


        public static Negocio.ClienteNegocio[] ConversorClientesANegocio(ServicioVideoClub.Cliente[] clientesSinMapear) {
            List<ClienteNegocio> clientesMapeados = new List<ClienteNegocio>();

            foreach (Cliente cliente in clientesSinMapear) {
                clientesMapeados.Add(ConversorClienteANegocio(cliente));
            }

            return clientesMapeados.ToArray();
        }
        public static ServicioVideoClub.Cliente[] ConversorClientesAServidor(Negocio.ClienteNegocio[] clientesSinMapear) {
            List<Cliente> clientesMapeados = new List<Cliente>();

            foreach (ClienteNegocio cliente in clientesSinMapear) {
                clientesMapeados.Add(ConversorClienteAServidor(cliente));
            }

            return clientesMapeados.ToArray();
        }

        public static Negocio.AlquilerNegocio[] ConversorAlquileresANegocio(ServicioVideoClub.Alquiler[] alquileresSinMapear) {
            List<AlquilerNegocio> alquileresMapeados = new List<AlquilerNegocio>();

            foreach (Alquiler alquiler in alquileresSinMapear) {
                alquileresMapeados.Add(ConversorAlquilerANegocio(alquiler));
            }

            return alquileresMapeados.ToArray();
        }
        public static ServicioVideoClub.Alquiler[] ConversorAlquileresAServidor(Negocio.AlquilerNegocio[] alquileresSinMapear) {
            List<Alquiler> alquileresMapeados = new List<Alquiler>();

            foreach (AlquilerNegocio alquiler in alquileresSinMapear) {
                alquileresMapeados.Add(ConversorAlquilerAServidor(alquiler));
            }

            return alquileresMapeados.ToArray();
        }


        public static Negocio.ClienteNegocio ConversorClienteANegocio(ServicioVideoClub.Cliente cl) {
            return new Negocio.ClienteNegocio() {
                Id = cl.Id,
                Nombre = cl.Nombre,
                Apellido = cl.Apellido,
                Direccion = cl.Direccion,
                Dni = cl.Dni
            };
        }
        public static ServicioVideoClub.Cliente ConversorClienteAServidor(Negocio.ClienteNegocio cl) {
            return new ServicioVideoClub.Cliente() {
                Id = cl.Id,
                Nombre = cl.Nombre,
                Apellido = cl.Apellido,
                Direccion = cl.Direccion,
                Dni = cl.Dni
            };
        }


        public static Negocio.PeliculaNegocio ConversorPeliculaANegocio(ServicioVideoClub.Pelicula peli) {
            return new Negocio.PeliculaNegocio() {
                Id = peli.Id,
                Titulo = peli.Titulo,
                Genero = peli.Genero,
                FechaInsercion = peli.FechaInsercion,
                Alquilada = peli.Alquilada
            };
        }
        public static ServicioVideoClub.Pelicula ConversorPeliculaAServidor(Negocio.PeliculaNegocio peli) {
            return new ServicioVideoClub.Pelicula() {
                Id = peli.Id,
                Titulo = peli.Titulo,
                Genero = peli.Genero,
                FechaInsercion = peli.FechaInsercion,
                Alquilada = peli.Alquilada
            };
        }


        public static Negocio.AlquilerNegocio ConversorAlquilerANegocio(ServicioVideoClub.Alquiler alquiler) {
            return new Negocio.AlquilerNegocio() {
                Id = alquiler.Id,
                NombreCliente = alquiler.NombreCliente,
                TituloPelicula = alquiler.TituloPelicula,
                FechaAlquiler = alquiler.FechaAlquiler,
                Devuelto = alquiler.Devuelto
            };
        }
        public static ServicioVideoClub.Alquiler ConversorAlquilerAServidor(Negocio.AlquilerNegocio alquiler) {
            return new ServicioVideoClub.Alquiler() {
                Id = alquiler.Id,
                NombreCliente = alquiler.NombreCliente,
                TituloPelicula = alquiler.TituloPelicula,
                FechaAlquiler = alquiler.FechaAlquiler,
                Devuelto = alquiler.Devuelto
            };
        }

    }
}