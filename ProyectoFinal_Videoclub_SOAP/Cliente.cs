using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace ServicioVideoClub {
    [DataContract]
    public class Cliente {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
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
            return $"{Nombre} {Apellido}, direccion {Direccion}, DNI {Dni}";
        }
    }
}