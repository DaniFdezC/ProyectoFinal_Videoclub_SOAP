using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class PrincipalForm : Form {
        ServicioDeVideoclub.VideoclubServicioClient vid = new ServicioDeVideoclub.VideoclubServicioClient();
        public PrincipalForm() {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        // Peliculas
        private void BtPeliculas_Click(object sender, EventArgs e) {
            PeliculasForm frm = new PeliculasForm(vid, this);
            frm.Show();
            this.Hide();
        }

        // Alquilar
        private void BtAlquilar_Click(object sender, EventArgs e) {
            AlquilerForm frm = new AlquilerForm(vid, this);
            frm.Show();
            this.Hide();
        }

        // Clientes
        private void BtClientes_Click(object sender, EventArgs e) {
            ClientesForm frm = new ClientesForm(vid, this);
            frm.Show();
            this.Hide();
        }

        
        // Primera carga para no ralentizar el formulario más adelante
        private void PrincipalForm_Load(object sender, EventArgs e) {
            vid.IniciarPrimeraConexion();
        }

        // Confirmación al cerrar
        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("¿Estás seguro que quieres cerrar?", "Salir de la app", MessageBoxButtons.YesNo) == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}
