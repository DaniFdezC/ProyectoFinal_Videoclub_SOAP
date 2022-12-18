using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVideoClub {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVideoclubServicio" in both code and config file together.
    [ServiceContract]
    public interface IVideoclubServicio {

        [OperationContract]
        Task<bool> AnadeCliente(string nombre, string apellido, string direccion, string dni);

        [OperationContract]
        Task<bool> AnadePelicula(string nombre, string genero, DateTime fecha);

        [OperationContract]
        Task<bool> AlquilaPelicula(Cliente cliente, Pelicula pelicula, DateTime fecha);

        [OperationContract]
        Task<bool> EliminarCliente(Cliente cliente);

        [OperationContract]
        Task<bool> EliminarPelicula(Pelicula pelicula);

        [OperationContract]
        void IniciarPrimeraConexion();

        [OperationContract]
        Cliente[] DevuelveClientes();

        [OperationContract]
        Pelicula[] DevuelvePeliculas();


        [OperationContract]
        Pelicula[] DevuelvePeliculasPorDias(int dias);

        [OperationContract]
        Pelicula[] DevuelvePeliculasPorGenero(string genero);

        [OperationContract]
        Pelicula[] DevuelvePeliculasPorNombre(string nombre);

        [OperationContract]
        Cliente[] DevuelveClientesPorNombre(string nombre);

        [OperationContract]
        Pelicula[] DevuelvePeliculasSinAlquilar();

        [OperationContract]
        Task<bool> FinalizarAlquilerPelicula(Alquiler alquiler);

        [OperationContract]
        Alquiler[] DevuelveAlquilerPorNombre(string nombre);

        [OperationContract]
        string[] DevuelveTiposPeliculas();
    }
}
