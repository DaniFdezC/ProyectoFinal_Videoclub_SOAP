using MySqlConnector;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio {
    public class Videoclub {

        MySqlConnection cnn = null;

        public Cliente[] DevuelveClientes() {
            IniciarConexion();
            List<Cliente> datos = new List<Cliente>();

            string query = "SELECT * FROM clientes";

            MySqlCommand mycom = new MySqlCommand(query, cnn);
            MySqlDataReader myreader = mycom.ExecuteReader();


            while (myreader.Read()) {
                Cliente client = new Cliente() {
                    Id = Convert.ToInt32(myreader["Id"]),
                    Nombre = myreader["Nombre"].ToString(),
                    Apellido = myreader["Apellido"].ToString(),
                    Direccion = myreader["Direccion"].ToString(),
                    Dni = myreader["Dni"].ToString()
                };
                datos.Add(client);
            }
            CerrarConexion();
            return datos.ToArray();
        }

        public List<Pelicula> DevuelvePeliculas() {
            IniciarConexion();
            List<Pelicula> datos = new List<Pelicula>();

            string query = "SELECT * FROM peliculas";

            MySqlCommand mycom = new MySqlCommand(query, cnn);
            MySqlDataReader myreader = mycom.ExecuteReader();


            while (myreader.Read()) {
                Pelicula peli = new Pelicula() {
                    Id = Convert.ToInt32(myreader["Id"]),
                    Nombre = myreader["Nombre"].ToString(),
                    Genero = myreader["Genero"].ToString(),
                    FechaInsercion = (DateTime)myreader["FechaAdicion"]
                };

                datos.Add(peli);
            }
            CerrarConexion();
            return datos;
        }

        public String[] TiposDePeliculas() {
            return new String[] {"Comedia", "Terror", "Drama", "Thriller", "Accion", "SciFi", "Romantica"};
        }

        public bool AnadePelicula(string nombre, string genero, DateTime fecha) {
            IniciarConexion();

            string fechaFormateada = fecha.ToString("yyyy-MM-dd HH:mm:ss");

            string query = $"INSERT INTO `peliculas` (`id`, `nombre`, `genero`, `fechaAdicion`) VALUES (NULL, \'{nombre}\', \'{genero}\', \'{fechaFormateada}\')";

            MySqlCommand mycom = new MySqlCommand(query, cnn);
            MySqlDataReader myread = mycom.ExecuteReader();

            CerrarConexion();

            return true;
        }

        public bool AnadeCliente(string nombre, string apellido, string direccion, string dni) {
            IniciarConexion();


            string query = $"INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `direccion`, `dni`) VALUES (NULL, \'{nombre}\', \'{apellido}\', \'{direccion}\', '{dni}')";

            MySqlCommand mycom = new MySqlCommand(query, cnn);
            MySqlDataReader myread = mycom.ExecuteReader();

            CerrarConexion();

            return true;
        }

        public void IniciarConexion() {
            string data = "server=localhost;database=videoclub;uid=root;pwd=\"\";Convert Zero Datetime=True";
            cnn = new MySqlConnection(data);
            cnn.Open();
        }

        public void CerrarConexion() {
            cnn.Close();
        }

    }
}
