using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio {
    public class Cliente {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }

        public Cliente() {

        }
        public Cliente(int id, string nombre, string apellido, string direccion, string dni) {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Dni = dni;
        }

        public override string ToString() {
            return $"Persona {Id}, {Nombre}, con apellidos {Apellido}, direccion {Direccion} y DNI {Dni}";
        }
    }
}
