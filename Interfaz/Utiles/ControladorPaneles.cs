using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Utiles {
    internal class ControladorPaneles {

        internal static void ActivarPanelDesactivarResto(Panel panelActivar, Control.ControlCollection controls) {
            foreach (Control control in controls) {

                if (control == panelActivar)
                    ActivarPanel(control);

                else if (control is Panel)
                    DesactivarPanel(control);
            }
        }

        internal static void DesactivarTodosPaneles(Control.ControlCollection controls) {
            ActivarPanelDesactivarResto(null, controls);
        }

        internal static void ActivarDesactivar(Control panelActivar, Control panelDesactivar) {
            panelActivar.Visible = true;
            panelDesactivar.Visible = false;
        }
        internal static void ActivarPanel(Control panel1) {
            panel1.Visible = true;
        }

        internal static void DesactivarPanel(Control panel1) {
            panel1.Visible = false;
        }

        internal static void DesactivarPaneles(Control panel1, Control panel2) {
            DesactivarPanel(panel1);
            DesactivarPanel(panel2);    
        }
        internal static void DesactivarPaneles(Control panel1, Control panel2, Control panel3) {
            DesactivarPanel(panel1);
            DesactivarPanel(panel2);
            DesactivarPanel(panel3);
        }
    }
}
