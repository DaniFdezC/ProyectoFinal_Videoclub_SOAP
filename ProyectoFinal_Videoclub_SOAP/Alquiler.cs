using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioVideoClub {
    [DataContract]
    public class Alquiler {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreCliente { get; set; }
        [DataMember]
        public string TituloPelicula { get; set; }
        [DataMember]
        public DateTime FechaAlquiler { get; set; }
        [DataMember]
        public bool Devuelto { get; set; }

        public Alquiler() {

        }

        public Alquiler(int id, string nombreCliente, string tituloPelicula, DateTime fechaAlquiler, bool devuelto) {
            Id = id;
            NombreCliente = nombreCliente;
            TituloPelicula = tituloPelicula;
            FechaAlquiler = fechaAlquiler;
            Devuelto = devuelto;
        }
    }
}