using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio {
    public class Pelicula {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInsercion { get; set; }
        public string Genero { get; set; }
        public Pelicula() {

        }
        public Pelicula(int id, string nombre, DateTime fechaInsercion, string genero) {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaInsercion = fechaInsercion;
            this.Genero = genero;
        }

        public override string ToString() {
            return $"Pelicula {Id}, {Nombre}, con fecha {FechaInsercion} y genero {Genero}";
        }
    }
}
