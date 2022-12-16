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
        public ClientesForm(ServicioDeVideoclub.VideoclubServicioClient vid) {
            InitializeComponent();
            MuestraMostrar();
            this.vid = vid;
        }

        private void BtMostrarClientes_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Cliente[] clientes = vid.DevuelveClientes();

            DGVClientes.DataSource = clientes;

            MuestraMostrar();
        }

        private void BtAnadirCliente_Click(object sender, EventArgs e) {
            MuestraAnadir();
        }
        private async void BtEnviar_Click(object sender, EventArgs e) {
            string nombre = TxNombre.Text;
            string apellido = TxApellido.Text;
            string direccion = TxDireccion.Text;
            string dni = TxDni.Text;

            string texto = await vid.AnadeClienteAsync(nombre, apellido, direccion, dni) ?
                "Se ha creado el cliente con exito" : "No se ha podido crear el cliente";

            MessageBox.Show(texto);

            ReseteaTexto();
        }


        private void BtEliminaCliente_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Cliente[] clientes = vid.DevuelveClientes();

            DGVElimCl.DataSource = clientes;

            MuestraEliminar();
        }

        private void BtElim_Click(object sender, EventArgs e) {
            ServicioDeVideoclub.Cliente clienteAEliminar = (ServicioDeVideoclub.Cliente)DGVElimCl.SelectedRows[0].DataBoundItem;
            MessageBox.Show(clienteAEliminar.Nombre + " " + clienteAEliminar.Id);
            vid.EliminarClienteAsync(clienteAEliminar);
            MessageBox.Show($"El cliente {clienteAEliminar.Nombre} {clienteAEliminar.Apellido} ha sido eliminado con exito");
            DGVElimCl.DataSource = vid.DevuelveClientes();
        }

        private void ReseteaTexto() {
            TxNombre.Text = "";
            TxApellido.Text = "";
            TxDireccion.Text = "";
            TxDni.Text = "";
        }

        //
        private void MuestraPanel(Panel panelAMostrar) {
            foreach (Panel panel in this.Controls.OfType<Panel>()) {

                if (panel == panelAMostrar)
                    panel.Visible = true;

                else
                    panel.Visible = false;

            }
        }

        private void MuestraMostrar() {
            PnMostrar.Visible = true;
            PnAnadir.Visible = false;
            PnEliminar.Visible = false;
        }

        private void MuestraAnadir() {
            PnMostrar.Visible = false;
            PnAnadir.Visible = true;
            PnEliminar.Visible = false;
        }

        private void MuestraEliminar() {
            PnMostrar.Visible = false;
            PnAnadir.Visible = false;
            PnEliminar.Visible = true;
        }

    }
}
