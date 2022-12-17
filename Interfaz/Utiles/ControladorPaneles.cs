using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Utiles {
    internal class ControladorPaneles {

        internal static void ActivarPanelBusqueda(Panel panelActivar, Control.ControlCollection controls) {
            foreach (Control control in controls) {
                if (control == panelActivar)
                    control.Visible = true;
                else if (control is Panel)
                    control.Visible = false;
            }
        }

        internal static void DesactivarPanelBusqueda(Control.ControlCollection controls) {
            ActivarPanelBusqueda(null, controls);
        }
    }
}
