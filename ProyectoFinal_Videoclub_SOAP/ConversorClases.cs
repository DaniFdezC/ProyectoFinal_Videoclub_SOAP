using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioVideoClub {
    public static class ConversorClases {

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
                FechaInsercion = peli.FechaInsercion
            };
        }

        public static ServicioVideoClub.Pelicula ConversorPeliculaAServidor(Negocio.PeliculaNegocio peli) {
            return new ServicioVideoClub.Pelicula() {
                Id = peli.Id,
                Titulo = peli.Titulo,
                Genero = peli.Genero,
                FechaInsercion = peli.FechaInsercion
            };
        }

    }
}