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
        void EliminarCliente(Cliente cliente);

        [OperationContract]
        void EliminarPelicula(Pelicula pelicula);

        [OperationContract]
        Cliente[] DevuelveClientes();

        [OperationContract]
        Task<bool> AnadePelicula(string nombre, string genero, DateTime fecha);

        [OperationContract]
        Pelicula[] DevuelvePeliculas();

        [OperationContract]
        Pelicula[] DevuelvePeliculasNovedades();

        [OperationContract]
        Pelicula[] DevuelvePeliculasPorGenero(string genero);
    }
}
