using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.Utiles {
    internal static class ConvertidorATexto {
        internal static string[] ConvertirClientesAString(ServicioDeVideoclub.Cliente[] clientes) {
            List<string> list = new List<string>();
            foreach (var cliente in clientes) {
                list.Add($" {cliente.Nombre} {cliente.Direccion}, direccion {cliente.Direccion}, dni {cliente.Dni}");
            }

            return list.ToArray();
        }
    }
}
