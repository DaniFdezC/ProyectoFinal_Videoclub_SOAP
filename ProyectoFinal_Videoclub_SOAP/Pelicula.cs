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
        public Pelicula() {

        }
        public Pelicula(int id, string titulo, DateTime fechaInsercion, string genero) {
            this.Id = id;
            this.Titulo = titulo;
            this.FechaInsercion = fechaInsercion;
            this.Genero = genero;
        }

        public override string ToString() {
            return $"Pelicula {Id}, {Titulo}, con fecha {FechaInsercion} y genero {Genero}";
        }
    }
}