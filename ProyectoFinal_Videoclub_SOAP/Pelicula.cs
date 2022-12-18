using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioVideoClub {
    [DataContract]
    public class Pelicula {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public DateTime FechaInsercion { get; set; }
        [DataMember]
        public string Genero { get; set; }
        [DataMember]
        public bool Alquilada { get; set; }
        public Pelicula() {

        }
        public Pelicula(int id, string titulo, DateTime fechaInsercion, string genero, bool alquilada) {
            this.Id = id;
            this.Titulo = titulo;
            this.FechaInsercion = fechaInsercion;
            this.Genero = genero;
            Alquilada = alquilada;
        }

        public override string ToString() {
            return $"Pelicula {Id}, {Titulo}, con fecha {FechaInsercion} y genero {Genero}";
        }
    }
}