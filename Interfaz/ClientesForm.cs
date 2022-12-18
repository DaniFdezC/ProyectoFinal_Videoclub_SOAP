using Interfaz.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class ClientesForm : Form {
        ServicioDeVideoclub.VideoclubServicioClient vid;
        Form formularioPrincipal;
        public ClientesForm(ServicioDeVideoclub.VideoclubServicioClient vid, Form formularioPrincipal) {
            InitializeComponent();
            this.vid = vid;
            this.formularioPrincipal = formularioPrincipal;
        }

        private async void BtMostrarClientes_Click(object sender, EventArgs e) {
            ActivarPanelesMostrarClientes();

            ServicioDeVideoclub.Cliente[] clientes = await vid.DevuelveClientesAsync();

            DGVClientes.DataSource = clientes;
        }

        private void ActivarPanelesMostrarClientes() {
            ControladorPaneles.ActivarDesactivar(PanelTablasClientes, PnAnadirCliente);
            ControladorPaneles.DesactivarPaneles(PanelBuscarIzda, PanelEliminarIzda);
        }

        private void BtAnadirCliente_Click(object sender, EventArgs e) {
            ActivarPanelAnadirPelicula();
        }

        private void ActivarPanelAnadirPelicula() {
            ControladorPaneles.ActivarDesactivar(PnAnadirCliente, PanelTablasClientes);
            ControladorPaneles.DesactivarPaneles(PanelEliminarIzda, PanelBuscarIzda);
        }

        private async void BtEnviarCliente_Click(object sender, EventArgs e) {
            string nombre = TxNombre.Text;
            string apellidos = TxApellidos.Text;
            string direccion = TxDireccion.Text;
            string dni = TxDNI.Text;

            string texto = await vid.AnadeClienteAsync(nombre, apellidos, direccion, dni) ?
                "Se ha creado el cliente con éxito" : "No se ha podido crear el cliente";

            MessageBox.Show(texto);

            ReseteaTextBoxAnadir();
        }

        private void ReseteaTextBoxAnadir() {
            TxNombre.Text = "";
            TxApellidos.Text = "";
            TxDireccion.Text = "";
            TxDNI.Text = "";
        }

        private void BtEliminaCliente_Click(object sender, EventArgs e) {
            ActivarPanelesEliminarClientes();
        }

        private void ActivarPanelesEliminarClientes() {
            ControladorPaneles.ActivarDesactivar(PanelTablasClientes, PnAnadirCliente);
            ControladorPaneles.ActivarDesactivar(PanelEliminarIzda, PanelBuscarIzda);
        }

        private void BtBuscarCliente_Click(object sender, EventArgs e) {
            ActivarPanelesBuscarClientes();
        }

        private void ActivarPanelesBuscarClientes() {
            ControladorPaneles.ActivarDesactivar(PanelTablasClientes, PnAnadirCliente);
            ControladorPaneles.ActivarDesactivar(PanelBuscarIzda, PanelEliminarIzda);
        }

        private void BtBuscarPorNombre_Click(object sender, EventArgs e) {
            TxNombreClienteBuscar.Text = "";

            ControladorPaneles.ActivarPanel(PanelPorNombre);

        }

        private async void BtEnviarPorNombre_Click(object sender, EventArgs e) {
            string nombre = TxNombreClienteBuscar.Text;
            ServicioDeVideoclub.Cliente[] resultado = await vid.DevuelveClientesPorNombreAsync(nombre);

            ModificaTablaAMostrar(resultado);
        }

        private void ModificaTablaAMostrar(ServicioDeVideoclub.Cliente[] clientesMostrar) {
            if (clientesMostrar.Length == 0)
                MessageBox.Show("No hay clientes que mostrar");
            else
                DGVClientes.DataSource = clientesMostrar;
        }

        private async void BtEnviarEliminar_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Cliente clienteAEliminar = (ServicioDeVideoclub.Cliente)DGVClientes.SelectedRows[0].DataBoundItem;
            bool eliminado = await vid.EliminarClienteAsync(clienteAEliminar);

            string mensaje;
            if(eliminado) 
                mensaje = $"El cliente {clienteAEliminar.Nombre} {clienteAEliminar.Apellido} ha sido eliminado con exito";
            else
                mensaje = "No se ha podido eliminar el cliente";

            MessageBox.Show(mensaje);

            DGVClientes.DataSource = await vid.DevuelveClientesAsync();
        }

        private void BtVolver_Click(object sender, EventArgs e) {
            formularioPrincipal.Show();
            this.Close();
        }
    }
}
