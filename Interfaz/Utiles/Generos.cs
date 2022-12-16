using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio {
    public static class Generos {
        public enum Tipos {
            Comedia,
            Terror,
            Drama,
            Thriller,
            Accion,
            SciFi,
            Aventura,
            Romantica
        }

        public static string[] DevuelveGeneros() {
            string[] generos = new string[] { "Comedia", "Terror", "Drama", "Thriller", "Accion", "SciFi", "Aventura", "Romántica" };
            return generos;
        }
    }
}
