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

        private void BtClientes_Click(object sender, EventArgs e) {
            ClientesForm frm = new ClientesForm(vid);
            frm.Show();
        }

        private void BtPeliculas_Click(object sender, EventArgs e) {
            PeliculasForm frm = new PeliculasForm(vid);
            frm.Show();
        }

    }
}
